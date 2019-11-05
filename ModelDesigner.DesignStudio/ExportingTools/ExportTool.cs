//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.ImportExport.ExportingStructures;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.ExportingTools
{
  internal class ExportTool
  {

    #region internal
    internal enum TypeOfTheDocument
    {
      Maml,
      Docx
    }
    internal static void ExportToDocument(IModelNodeAdvance imna, TypeOfTheDocument typeOfTheDocument)
    {
      if (!CheckIfExportIsPossibleAndPrepareListOfTerms(imna, out List<TermWithDefinitionStructure> listOfAllTerms))
        return;
      IASMDExporter exporter = null;
      switch (typeOfTheDocument)
      {
        case TypeOfTheDocument.Maml:
          exporter = new MamlCreator();
          break;
        case TypeOfTheDocument.Docx:
          exporter = new DocxCreator();
          break;
      }
      string FileName = string.Empty;
      FileName = SelectFileCreateDocumentAndSave(listOfAllTerms, exporter, FileName);
    }
    #endregion

    #region private

    #region ConstantStrings
    #region Headers
    private const string referenceString = "Reference";
    private const string nodeClassString = "NodeClass";
    private const string symbolicNameString = "SymbolicName";
    private const string dataTypeString = "DataType";
    private const string typeDefinitionString = "TypeDefinition";
    private const string modellingRuleString = "ModellingRule";
    private const string childrenString = "Children";
    private const string targetBrowseNameString = "TargetId";
    private const string minCardString = "MinCardinality";
    private const string maxCardString = "MaxCardinality";
    private const string variableTypeString = "VariableType";
    private const string identifierString = "Identifier";
    private const string nameString = "Name";
    private const string descriptionString = "Description";
    private const string fieldsString = "Fields";
    private const string valueRankString = "ValueRank";
    private const string browseNameString = "BrowseName";
    private const string referenceTypeString = "ReferenceType";
    private const string targetIdString = "TargetId";
    private const string isInverseString = "IsInverse";
    #endregion Headers
    #region Others
    private const string inputArgumentsString = "Input arguments";
    private const string outputArgumentsString = "Output arguments";
    private const string methodString = "Method";
    private const string mandatoryRuleString = "Mandatory";
    private const string hasComponentString = "HasComponent";
    private const string hasPropertyString = "HasProperty";
    #endregion Others
    #endregion ConstantStrings
    private static bool CheckIfExportIsPossibleAndPrepareListOfTerms(IModelNodeAdvance imna, out List<TermWithDefinitionStructure> listOfAllTerms)
    {
      if (ExportConstrain.IsLicensed)
      {
        #region ModelDesignerProLicense.License.Licensed == true
        if (imna == null)
        {
          MessageBox.Show(Resources.ExportTool_NoNodeIsSelected, Resources.ExportTool_Window_Name, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
          listOfAllTerms = null;
          return false;
        }
        listOfAllTerms = new List<TermWithDefinitionStructure>();
        if (imna.NodeType == NodeTypeEnum.ProjectNode)
        {
          foreach (IModelNodeAdvance imnaInDictionary in ((imna.GetFolders()).Values))
          {
            if (imnaInDictionary.NodeType == NodeTypeEnum.ModelNode)
            {
              List<TermWithDefinitionStructure> temp_listOfAllTerms = new List<TermWithDefinitionStructure>();
              if (CheckIfExportIsPossibleAndPrepareListOfTerms(imnaInDictionary, out temp_listOfAllTerms))
                listOfAllTerms.AddRange(temp_listOfAllTerms);
            }
          }
        }
        else
        {
          #region imna.NodeType != NodeTypeEnum.ProjectNode
          TermWithDefinitionStructure term = null;
          if (imna.NodeType == NodeTypeEnum.ModelNode)
          {
            foreach (KeyValuePair<FolderType, IEnumerable<IModelNodeAdvance>> item in imna.GetFolders())
            {
              foreach (IModelNodeAdvance imnaInProject in item.Value)
              {
                term = CreateTermWithDefinition(imnaInProject);
                if (term != null)
                  listOfAllTerms.Add(term);
              }
            }
          }
          else
          {
            term = CreateTermWithDefinition(imna);
            if (term != null)
            {
              listOfAllTerms.Add(term);
              foreach (FolderType folderType in FolderType.GetValues(typeof(FolderType)))
              {
                if (GetFolder(imna, folderType) != null)
                {
                  foreach (IModelNodeAdvance imnaInFolder in GetFolder(imna, folderType))
                  {
                    term = CreateTermWithDefinition(imnaInFolder);
                    if (term != null)
                      listOfAllTerms.Add(term);
                  }
                }
              }
            }
            else
            {
              MessageBox.Show(Resources.ExportTool_cannot_expot_wrong_node, Resources.ExportTool_Window_Name, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
              return false;
            }
          }
          #endregion imna.NodeType != NodeTypeEnum.ProjectNode
        }
        #endregion ModelDesignerProLicense.License.Licensed == true
      }
      else
      {
        MessageBox.Show(Resources.ModelDesignerProLicenseWarning);
        listOfAllTerms = null;
        return false;
      }
      return true;
    }
    private static string SelectFileCreateDocumentAndSave(List<TermWithDefinitionStructure> listOfAllTerms, IASMDExporter exporter, string FileName)
    {
      using (SaveFileDialog sfd = new SaveFileDialog())
      {
        sfd.DefaultExt = exporter.FileDefaultExt;
        sfd.AddExtension = true;
        sfd.Filter = exporter.FileFilter;
        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          FileName = sfd.FileName;
          bool result = exporter.CreateDocument(FileName, listOfAllTerms, out string resultmessage);
          if (result)
          {
            if (MessageBox.Show(resultmessage, "Success!", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
              try
              {
                Process.Start(FileName);
              }
              catch (Win32Exception)
              {
                MessageBox.Show(Resources.ExportTool_NoDefualtApplication, "Cannot open the file", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
              }
          }
          else
            MessageBox.Show(resultmessage, "Fail!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
      }
      return FileName;
    }
    /// <summary>
    /// Exports to document.
    /// </summary>
    /// <param name="tn">The tree node</param>
    /// <param name="typeOfTheDocument">The type of the document.</param>

    #region creatorsOfTermWithDefinition
    /// <summary>
    /// Gets the folder.
    /// </summary>
    /// <param name="imna">The IModelNodeAdvance.</param>
    /// <param name="type">The folder type.</param>
    /// <returns></returns>
    private static IEnumerable<IModelNodeAdvance> GetFolder(IModelNodeAdvance imna, FolderType type)
    {
      if (imna == null)
        return null;
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> folders = imna.GetFolders();
      if (folders == null)
        return null;
      if (folders.ContainsKey(type))
        return folders[type];
      return null;
    }

    /// <summary>
    /// Creates the term with definition.
    /// </summary>
    /// <param name="iModelNode">The IModelNode.</param>
    /// <returns>Term with definition structure</returns>
    private static TermWithDefinitionStructure CreateTermWithDefinition(IModelNode imn)
    {
      if (imn != null)
      {
        if (imn.NodeClass == NodeClassesEnum.Method)
          return CreateTermWithDefinitionFromMethodDesign(imn);
        else if (imn.NodeClass == NodeClassesEnum.DataType)
          return CreateTermWithDefinitionFromDataTypeDesign(imn);
        else if (imn.NodeClass == NodeClassesEnum.VariableType)
          return CreateTermWithDefinitionFromVariableType(imn);
        else if (imn.NodeClass == NodeClassesEnum.None)
          return null;
        else
          return CreateTermWithDefinitionFromObjectOrObjectTypeOrReferenceTypeOrVariableOrView(imn);
      }
      return null;
    }

    /// <summary>
    /// Creates the term with definition from object or object type or reference type or variable or view.
    /// </summary>
    /// <param name="wrappedTreeNode">The wrapped tree node.</param>
    /// <returns></returns>
    private static TermWithDefinitionStructure CreateTermWithDefinitionFromObjectOrObjectTypeOrReferenceTypeOrVariableOrView(IModelNode iModelNode)
    {
      List<TableStructure> listOfAllTables = new List<TableStructure>();
      List<string> headerRowOfChildrenTable = new List<string>
      {
        referenceString,
        nodeClassString,
        symbolicNameString,
        dataTypeString,
        typeDefinitionString,
        modellingRuleString
      };
      TableStructure childrenTable = new TableStructure(childrenString, headerRowOfChildrenTable);
      GetInformationAboutChildren((IModelNodeAdvance)iModelNode, childrenTable);
      if (childrenTable.TableRows.Count > 0)
        listOfAllTables.Add(childrenTable);
      List<string> headerRowOfReferencesTable = new List<string>
      {
        referenceTypeString,
        targetIdString,
        isInverseString
      };
      TableStructure referencesTable = new TableStructure(referenceString, headerRowOfReferencesTable);
      GetInformationAboutReferences((IModelNodeAdvance)iModelNode, referencesTable);
      if (referencesTable.TableRows.Count > 0)
        listOfAllTables.Add(referencesTable);
      string tableName = iModelNode.Name + " (" + iModelNode.NodeClass.ToString() + ")";
      if (tableName == null)
        tableName = string.Empty;
      if (listOfAllTables.Count > 0)
        return new TermWithDefinitionStructure(listOfAllTables, tableName, CheckIfTheNodeIsAbstract(iModelNode));
      else
        return null;
    }

    /// <summary>
    /// Creates the type of the maml from variable.
    /// </summary>
    /// <param name="wrappedTreeNode">The wrapped tree node.</param>
    /// <returns>Term with definition structure</returns>
    private static TermWithDefinitionStructure CreateTermWithDefinitionFromVariableType(IModelNode iModelNode)
    {
      List<TableStructure> listOfAllTables = new List<TableStructure>();
      List<string> variableTypeHeaderRow = new List<string>
      {
        referenceString,
        minCardString,
        maxCardString,
        nodeClassString,
        symbolicNameString,
        dataTypeString,
        typeDefinitionString,
        modellingRuleString
      };
      TableStructure variableTypeChildrenTable = new TableStructure(childrenString, variableTypeHeaderRow);
      GetInformationAboutChildren((IModelNodeAdvance)iModelNode, variableTypeChildrenTable);
      if (variableTypeChildrenTable.TableRows.Count > 0)
        listOfAllTables.Add(variableTypeChildrenTable);
      List<string> variableTypeReferencesHeaderRow = new List<string>
      {
        referenceTypeString,
        targetIdString,
        isInverseString
      };
      TableStructure variableTypeReferencesTable = new TableStructure(referenceString, variableTypeReferencesHeaderRow);
      GetInformationAboutReferences((IModelNodeAdvance)iModelNode, variableTypeReferencesTable);
      if (variableTypeReferencesTable.TableRows.Count > 0)
        listOfAllTables.Add(variableTypeReferencesTable);
      string tableName = iModelNode.Name + " (" + variableTypeString + ")";
      if (listOfAllTables.Count > 0)
        return new TermWithDefinitionStructure(listOfAllTables, tableName, CheckIfTheNodeIsAbstract(iModelNode));
      else
        return null;
    }

    /// <summary>
    /// Creates the maml from data type design.
    /// </summary>
    /// <param name="wrappedTreeNode">The wrapped tree node.</param>
    /// <returns>Term with definition structure</returns>
    private static TermWithDefinitionStructure CreateTermWithDefinitionFromDataTypeDesign(IModelNode iModelNode)
    {
      List<TableStructure> listOfAllTables = new List<TableStructure>();
      List<string> dataTypeHeaderRow = new List<string>
      {
        identifierString,
        nameString,
        dataTypeString,
        descriptionString
      };
      TableStructure dataTypeFieldsTable = new TableStructure(fieldsString, dataTypeHeaderRow);
      GetInformationAboutDataTypeDesignParameters((IModelNodeAdvance)iModelNode, dataTypeFieldsTable);
      if (dataTypeFieldsTable.TableRows.Count > 0)
        listOfAllTables.Add(dataTypeFieldsTable);
      string tableName = iModelNode.Name + " (" + dataTypeString + ")";
      if (listOfAllTables.Count > 0)
        return new TermWithDefinitionStructure(listOfAllTables, tableName, CheckIfTheNodeIsAbstract(iModelNode));
      else
        return null;
    }

    /// <summary>
    /// Creates the maml from method design.
    /// </summary>
    /// <param name="wrappedTreeNode">The wrapped tree node.</param>
    /// <returns>Term with definition structure</returns>
    private static TermWithDefinitionStructure CreateTermWithDefinitionFromMethodDesign(IModelNode iModelNode)
    {
      List<TableStructure> listOfAllTables = new List<TableStructure>();
      List<string> methodHeaderRow = new List<string>
      {
        nameString,
        dataTypeString,
        valueRankString,
        descriptionString
      };
      TableStructure inputArgumentsTable = new TableStructure(inputArgumentsString, methodHeaderRow);
      GetInformationAboutMethodDesignInputsOrOutputs((IModelNodeAdvance)iModelNode, inputArgumentsTable, FolderType.InputArguments);
      if (inputArgumentsTable.TableRows.Count > 0)
        listOfAllTables.Add(inputArgumentsTable);
      TableStructure outputArgumentsTable = new TableStructure(outputArgumentsString, methodHeaderRow);
      GetInformationAboutMethodDesignInputsOrOutputs((IModelNodeAdvance)iModelNode, outputArgumentsTable, FolderType.OutputArguments);
      if (outputArgumentsTable.TableRows.Count > 0)
        listOfAllTables.Add(outputArgumentsTable);
      string tableName = iModelNode.Name + " (" + methodString + ")";
      if (listOfAllTables.Count > 0)
        return new TermWithDefinitionStructure(listOfAllTables, tableName, CheckIfTheNodeIsAbstract(iModelNode));
      else
        return null;
    }
    #endregion

    #region InformationGetters
    /// <summary>
    /// Gets the information about references.
    /// </summary>
    /// <param name="iModelNodeAdvance">The i model node advance.</param>
    /// <param name="tbls">The TBLS.</param>
    private static void GetInformationAboutReferences(IModelNodeAdvance iModelNodeAdvance, TableStructure tbls)
    {
      IEnumerable<IModelNodeAdvance> rf = GetFolder(iModelNodeAdvance, FolderType.References);
      if (rf != null)
        foreach (IModelNodeAdvance referenceFromTheReferencesFolder in rf)
        {
          Dictionary<string, string> row = GetDocumentation(referenceFromTheReferencesFolder.Wrapper4PropertyGrid);
          tbls.AddRow(row);
        }
    }

    /// <summary>
    /// Gets the information about variable type children.
    /// </summary>
    /// <param name="iModelNodeAdvance">The i model node advance.</param>
    /// <param name="tbls">The TBLS.</param>
    private static void GetInformationAboutVariableTypeChildren(IModelNodeAdvance iModelNodeAdvance, TableStructure tbls)
    {
      List<List<string>> allTableRows = new List<List<string>>();
      foreach (IModelNodeAdvance imna in GetFolder(iModelNodeAdvance, FolderType.Children))
      {
        Dictionary<string, string> row = GetDocumentation(imna.Wrapper4PropertyGrid);
        row.Add(referenceString, hasPropertyString);
        row.Add(nodeClassString, imna.NodeClass.ToString());
        tbls.AddRow(row);
      }
    }

    /// <summary>
    /// Gets the information about data type design outputs.
    /// </summary>
    /// <param name="iModelNodeAdvance">The i model node advance.</param>
    /// <param name="tbls">The table structure.</param>
    private static void GetInformationAboutDataTypeDesignParameters(IModelNodeAdvance iModelNodeAdvance, TableStructure tbls)
    {
      foreach (IModelNodeAdvance argument in GetFolder(iModelNodeAdvance, FolderType.Fields))
      {
        Dictionary<string, string> row = GetDocumentation(argument.Wrapper4PropertyGrid);
        tbls.AddRow(row);
      }
    }

    /// <summary>
    /// Gets the information about method design inputs or outputs.
    /// </summary>
    /// <param name="iModelNodeAdvance">The i model node advance.</param>
    /// <param name="tbls">The TBLS.</param>
    private static void GetInformationAboutMethodDesignInputsOrOutputs(IModelNodeAdvance iModelNodeAdvance, TableStructure tbls, FolderType ft)
    {
      List<List<string>> allTableRows = new List<List<string>>();
      IEnumerable<IModelNodeAdvance> pf = null;
      pf = GetFolder(iModelNodeAdvance, ft);
      if (pf != null)
        foreach (IModelNodeAdvance argument in pf)
        {
          Dictionary<string, string> row = GetDocumentation(argument.Wrapper4PropertyGrid);
          tbls.AddRow(row);
        }
    }

    /// <summary>
    /// Gets the information about children.
    /// </summary>
    /// <param name="iModelNodeAdvance">The i model node advance.</param>
    /// <param name="tbls">The table structure.</param>
    private static void GetInformationAboutChildren(IModelNodeAdvance iModelNodeAdvance, TableStructure tbls)
    {
      List<List<string>> allTableRows = new List<List<string>>();
      IEnumerable<IModelNodeAdvance> folder = GetFolder(iModelNodeAdvance, FolderType.Children);
      if (folder != null)
        foreach (IModelNodeAdvance imna in folder)
        {
          Dictionary<string, string> row = GetDocumentation(imna.Wrapper4PropertyGrid);
          if (imna.NodeClass == NodeClassesEnum.Property)
            row.Add(referenceString, hasPropertyString);
          else
            row.Add(referenceString, hasComponentString);
          row.Add(nodeClassString, imna.NodeClass.ToString());
          tbls.AddRow(row);
        }
    }

    #endregion

    #region SupportingMethods
    /// <summary>
    /// Gets the documentation.
    /// </summary>
    /// <param name="o">The object</param>
    /// <returns></returns>
    private static Dictionary<string, string> GetDocumentation(object o)
    {
      Dictionary<string, string> listOfRowFields = new Dictionary<string, string>();
      foreach (System.Reflection.PropertyInfo el in o.GetType().GetProperties())
      {
        object[] attributes = (el.GetCustomAttributes(typeof(DocumentationAttribute), true));
        if (attributes.Length > 0)
        {
          string val = string.Empty;
          foreach (object at in attributes)
          {
            DocumentationAttribute dat = at as DocumentationAttribute;
            val = dat.ConverterToDocumentationString.ConvertToString(el.GetValue(o, null), dat.DefaultValue);
            listOfRowFields.Add(dat.Name, val);
          }
        }
      }
      return listOfRowFields;
    }

    /// <summary>
    /// Checks if the node is abstract.
    /// </summary>
    /// <param name="imn">The IModelNode.</param>
    /// <returns>True if the node is abstract</returns>
    private static string CheckIfTheNodeIsAbstract(IModelNode imn)
    {
      if (imn.NodeClass == NodeClassesEnum.ObjectType)
        return ((ObjectTypeDesign<Opc.Ua.ModelCompiler.ObjectTypeDesign>)imn.Wrapper4PropertyGrid).IsAbstract.ToString();
      else if (imn.NodeClass == NodeClassesEnum.ReferenceType)
      {
        if ((imn.Wrapper4PropertyGrid as CAS.UA.Model.Designer.Wrappers4ProperyGrid.Reference) != null)
          return string.Empty;
        return ((CAS.UA.Model.Designer.Wrappers4ProperyGrid.ReferenceTypeDesign)imn.Wrapper4PropertyGrid).IsAbstract.ToString();
      }
      else if (imn.NodeClass == NodeClassesEnum.VariableType)
        return ((CAS.UA.Model.Designer.Wrappers4ProperyGrid.VariableTypeDesign)imn.Wrapper4PropertyGrid).IsAbstract.ToString();
      else if (imn.NodeClass == NodeClassesEnum.DataType)
        return ((CAS.UA.Model.Designer.Wrappers4ProperyGrid.DataTypeDesign)imn.Wrapper4PropertyGrid).IsAbstract.ToString();
      else
        return string.Empty;
    }
    #endregion

    #endregion
  }
}
