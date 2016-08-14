//<summary>
//  Title   : Import model from OPC DA address space.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.Lib.OPC.AddressSpace;
using CAS.UA.Model.Designer.ImportExport.Properties;
using Opc.Ua;
using Opc.Ua.ModelCompiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using LocalizedText = Opc.Ua.ModelCompiler.LocalizedText;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Import model from OPC DA address space.
  /// </summary>
  public static class OPCDA
  {

    #region internal
    /// <summary>
    /// Creates the import menu items.
    /// </summary>
    /// <param name="items">The items.</param>
    /// <param name="handler">The handler.</param>
    public static void CreateImportMenuItems(ToolStripItemCollection items, EventHandler handler)
    {
      ToolStripMenuItem imi = CreateFromOPCDAMenuItem();
      imi.Click += handler;
      items.Add(imi);
    }
    /// <summary>
    /// Called when on import menu item click.
    /// </summary>
    /// <param name="targetNamespace">The target namespace.</param>
    /// <returns></returns>
    public static NodeDesign[] OnImportMenuItemClick(string targetNamespace)
    {
      using (DictionaryManagement dic = new DictionaryManagement())
      {
        if (!dic.Open())
          return null;
        if (dic.Dictionary.ServersTable.Count == 0)
          return null;
        List<NodeDesign> nodes = new List<NodeDesign>();
        ImportServer(dic.Dictionary.ServersTable[0], targetNamespace, new UniqueName(), nodes);
        return nodes.ToArray();
      }
    }
    #endregion

    #region private
    private static int m_Counter;
    private const string m_NameFormat = "Server{0}";
    private static string NewName { get { return String.Format(m_NameFormat, m_Counter++); } }
    private const string m_Separator = "\\";
    private class UniqueName : SortedList<string, object>
    {
      private int count = 0;
      internal string GetUniqueName(string src)
      {
        if (this.ContainsKey(src))
          src += (count++);
        this.Add(src, null);
        return src;
      }
    }
    /// <summary>
    /// Creates from opcda menu item.
    /// </summary>
    /// <returns></returns>
    private static ToolStripMenuItem CreateFromOPCDAMenuItem()
    {
      return new ToolStripMenuItem()
      {
        Name = Resources.CreateFromOPCDAMenuItemName,
        //Size = new System.Drawing.Size( 66, 20 ),
        Text = Resources.CreateFromOPCDAMenuItemText,
        ToolTipText = Resources.CreateFromOPCDAMenuItemToolTip
      };
    }
    private static ObjectDesign CreateFolder
      (XmlQualifiedName name, string description, string displayName)
    {
      return CreateFolder(name, description, displayName, GetFolderType());
    }
    private static ObjectDesign CreateFolder
      (XmlQualifiedName name, string description, string displayName, XmlQualifiedName typeDefinition)
    {
      return new ObjectDesign()
      {
        TypeDefinition = typeDefinition,
        DisplayName = CreateLocalizedText(displayName),
        SymbolicName = name,
        Description = CreateLocalizedText(description),
        Children = new ListOfChildren(),
      };
    }
    private static void ImportServer
      (AddressSpaceDataBase.ServersTableRow svr, string targetNamespace, UniqueName uniqueName, List<NodeDesign> nodes)
    {
      string name = NewName;
      XmlQualifiedName sftName = new XmlQualifiedName(NewName, targetNamespace);
      ObjectDesign sft = CreateFolder(sftName, svr.URLString, svr.URL.Path);
      sft.References = new Reference[] { new Reference()
        {
          IsInverse = true,
          ReferenceType = CreateXmlQualifiedName( Opc.Ua.BrowseNames.Organizes ),
          TargetId = CreateXmlQualifiedName( "ObjectsFolder" )
        }
      };
      nodes.Add(sft);
      List<InstanceDesign> cldrn = new List<InstanceDesign>();
      foreach (AddressSpaceDataBase.TagsTableRow item in svr.GetTagsTableRows())
        ImportTag(item, targetNamespace, uniqueName, sft.SymbolicName, nodes, cldrn);
      sft.Children = new ListOfChildren() { Items = cldrn.ToArray() };
    }
    private static void ImportTag
      (
        AddressSpaceDataBase.TagsTableRow parentItem,
        string targetNamespace,
        UniqueName uniqueName,
        XmlQualifiedName parentObject,
        List<NodeDesign> nodes,
        List<InstanceDesign> parentChildren
      )
    {
      Opc.Da.BrowseElement pbe = parentItem.GetBrowseElement();
      if (pbe.IsItem)
      {

        VariableDesign var = new VariableDesign()
        {
          SymbolicName = new XmlQualifiedName(uniqueName.GetUniqueName(pbe.Name), targetNamespace),
          DisplayName = new LocalizedText() { Value = pbe.Name },
          DataType = GetBaseDataType(),
          TypeDefinition = GetBaseDataVariableType(),
          Description = new LocalizedText() { Value = pbe.ItemName },
          AccessLevel = AccessLevel.ReadWrite,
          AccessLevelSpecified = true,
          ValueRank = ValueRank.Scalar,
          ValueRankSpecified = true,
          WriteAccess = 0
        };
        parentChildren.Add(var);
        SortedDictionary<int, Opc.Da.ItemProperty> prprts = new SortedDictionary<int, Opc.Da.ItemProperty>();
        foreach (Opc.Da.ItemProperty item in pbe.Properties)
          prprts.Add(item.ID.Code, item);
        if (prprts.ContainsKey(Opc.Da.Property.DATATYPE.Code))
          GetDATATYPE(var, prprts[Opc.Da.Property.DATATYPE.Code]);
        GetEUTYPE(var, prprts);
        if (prprts.ContainsKey(Opc.Da.Property.ACCESSRIGHTS.Code))
          GetACCESSRIGHTS(var, prprts[Opc.Da.Property.ACCESSRIGHTS.Code]);
      }
      else
      {
        ObjectDesign sf = CreateFolder(new XmlQualifiedName(uniqueName.GetUniqueName(pbe.Name), targetNamespace), pbe.ItemName, pbe.Name);
        nodes.Add(sf);
        List<InstanceDesign> myChildren = new List<InstanceDesign>();
        foreach (AddressSpaceDataBase.TagsTableRow item in parentItem.GetTagsTableRows())
          ImportTag(item, targetNamespace, uniqueName, sf.SymbolicName, nodes, myChildren);
        sf.Children = new ListOfChildren() { Items = myChildren.ToArray() };
        sf.References = new Reference[]
        { new Reference()
          {
            IsInverse = true,
            ReferenceType = CreateXmlQualifiedName( Opc.Ua.BrowseNames.Organizes ),
            TargetId = parentObject
          }
        };
      }
    }
    private static void GetACCESSRIGHTS(VariableDesign var, Opc.Da.ItemProperty itemProperty)
    {
      if ((itemProperty == null) || (itemProperty.Value == null))
        return;
      var.AccessLevelSpecified = true;
      switch (((Opc.Da.accessRights)itemProperty.Value))
      {
        case Opc.Da.accessRights.readWritable:
          var.AccessLevel = AccessLevel.ReadWrite;
          break;
        case Opc.Da.accessRights.readable:
          var.AccessLevel = AccessLevel.Read;
          break;
        case Opc.Da.accessRights.writable:
          var.AccessLevel = AccessLevel.Write;
          break;
        default:
          var.AccessLevelSpecified = false;
          break;
      }
    }
    private static void GetEUTYPE(VariableDesign var, SortedDictionary<int, Opc.Da.ItemProperty> prprts)
    {
      if (!prprts.ContainsKey(Opc.Da.Property.EUTYPE.Code))
        return;
      Opc.Da.ItemProperty eut = prprts[Opc.Da.Property.EUTYPE.Code];
      if (eut.Value == null)
        return;
      switch ((Opc.Da.euType)eut.Value)
      {
        case Opc.Da.euType.analog:
          {
            var.TypeDefinition = GetAnalogItemType();
            Opc.Da.ItemProperty higheu = null;
            Opc.Da.ItemProperty loweu = null;
            if (prprts.ContainsKey(Opc.Da.Property.HIGHEU.Code))
              higheu = prprts[Opc.Da.Property.HIGHEU.Code];
            if (prprts.ContainsKey(Opc.Da.Property.LOWEU.Code))
              loweu = prprts[Opc.Da.Property.LOWEU.Code];
            if (higheu != null && loweu != null)
            {
              PropertyDesign prop = new PropertyDesign()
              {
                SymbolicName = CreateXmlQualifiedName(BrowseNames.EURange),
                DataType = CreateXmlQualifiedName(BrowseNames.Range),
                DefaultValue = CAS.UA.Common.Types.Range.CreateRange(higheu, loweu).XmlElement,
                ValueRank = ValueRank.Scalar,
                AccessLevel = AccessLevel.Read
              };
              var.Children = new ListOfChildren()
              {
                Items = new InstanceDesign[] { prop }
              };
            }
            break;
          }
        case Opc.Da.euType.enumerated:
          var.TypeDefinition = GetMultiStateDiscreteType();
          break;
        case Opc.Da.euType.noEnum:
          var.TypeDefinition = GetTwoStateDiscreteType();
          break;
        default:
          break;
      }
    }

    private static void GetDATATYPE(VariableDesign var, Opc.Da.ItemProperty prprty)
    {
      if (prprty == null || prprty.Value == null)
        return;
      Type vt = (Type)prprty.Value;
      NodeId id = Opc.Ua.TypeInfo.GetDataTypeId(vt);
      if (id == null)
        return;
      Debug.Assert(id.IdType == IdType.Numeric);
      BuiltInType bit = TypeInfo.GetBuiltInType(id);
      switch (bit)
      {
        case BuiltInType.Boolean:
        case BuiltInType.Byte:
        case BuiltInType.ByteString:
        case BuiltInType.DataValue:
        case BuiltInType.DateTime:
        case BuiltInType.Double:
        case BuiltInType.Float:
        case BuiltInType.Int16:
        case BuiltInType.Int32:
        case BuiltInType.Int64:
        case BuiltInType.SByte:
        case BuiltInType.String:
        case BuiltInType.UInt16:
        case BuiltInType.UInt32:
        case BuiltInType.UInt64:
          {
            string sn = Enum.GetName(typeof(BuiltInType), TypeInfo.GetBuiltInType(id));
            var.DataType = CreateXmlQualifiedName(sn);
            break;
          }
        case BuiltInType.UInteger:
        case BuiltInType.Integer:
        case BuiltInType.LocalizedText:
        case BuiltInType.Enumeration:
        case BuiltInType.ExpandedNodeId:
        case BuiltInType.ExtensionObject:
        case BuiltInType.Guid:
        case BuiltInType.NodeId:
        case BuiltInType.Null:
        case BuiltInType.Number:
        case BuiltInType.QualifiedName:
        case BuiltInType.StatusCode:
        case BuiltInType.Variant:
        case BuiltInType.XmlElement:
        case BuiltInType.DiagnosticInfo:
        default:
          break;
      }
      if (vt.IsArray)
        var.ValueRank = ValueRank.OneOrMoreDimensions;
    }
    private static XmlQualifiedName CreateXmlQualifiedName(string name)
    {
      return new XmlQualifiedName(name, Namespaces.OpcUa);
    }
    private static LocalizedText CreateLocalizedText(string displayName)
    {
      return new LocalizedText() { Value = displayName };
    }
    //ObjectTypes
    private static XmlQualifiedName GetFolderType() { return CreateXmlQualifiedName(BrowseNames.FolderType); }
    //DataTypes
    private static XmlQualifiedName GetBaseDataType() { return CreateXmlQualifiedName(BrowseNames.BaseDataType); }
    //VariableType
    private static XmlQualifiedName GetBaseDataVariableType() { return CreateXmlQualifiedName(Opc.Ua.BrowseNames.BaseDataVariableType); }
    private static XmlQualifiedName GetDataItemType() { return CreateXmlQualifiedName(BrowseNames.DataItemType); }
    private static XmlQualifiedName GetAnalogItemType() { return CreateXmlQualifiedName(BrowseNames.AnalogItemType); }
    private static XmlQualifiedName GetMultiStateDiscreteType() { return CreateXmlQualifiedName(BrowseNames.MultiStateDiscreteType); }
    private static XmlQualifiedName GetTwoStateDiscreteType() { return CreateXmlQualifiedName(BrowseNames.TwoStateDiscreteType); }
    //Properties
    private static XmlQualifiedName GetPropertyType() { return CreateXmlQualifiedName(BrowseNames.PropertyType); }
    private static XmlQualifiedName GetEURange() { return CreateXmlQualifiedName(BrowseNames.EURange); }
    //Values
    //TODO Must be implemented.
    private static XmlElement CreateRange(Range range)
    {
      return EncodeableObject.EncodeXml(range, null);
    }
    #endregion

  }

}

