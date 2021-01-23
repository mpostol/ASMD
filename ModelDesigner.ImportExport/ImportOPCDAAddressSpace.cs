//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.Lib.OPC.AddressSpace;
using CAS.UA.Model.Designer.ImportExport.Properties;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

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
    public static OpcUaModelCompiler.NodeDesign[] OnImportMenuItemClick(string targetNamespace)
    {
      using (DictionaryManagement dic = new DictionaryManagement())
      {
        if (!dic.Open())
          return null;
        if (dic.Dictionary.ServersTable.Count == 0)
          return null;
        List<OpcUaModelCompiler.NodeDesign> nodes = new List<OpcUaModelCompiler.NodeDesign>();
        ImportServer(dic.Dictionary.ServersTable[0], targetNamespace, new UniqueName(), nodes);
        return nodes.ToArray();
      }
    }

    #endregion internal

    #region private

    private static int m_Counter;
    private const string m_NameFormat = "Server{0}";
    private static string NewName => string.Format(m_NameFormat, m_Counter++);
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

    private static OpcUaModelCompiler.ObjectDesign CreateFolder(XmlQualifiedName name, string description, string displayName)
    {
      return CreateFolder(name, description, displayName, GetFolderType());
    }

    private static OpcUaModelCompiler.ObjectDesign CreateFolder(XmlQualifiedName name, string description, string displayName, XmlQualifiedName typeDefinition)
    {
      return new OpcUaModelCompiler.ObjectDesign()
      {
        TypeDefinition = typeDefinition,
        DisplayName = CreateLocalizedText(displayName),
        SymbolicName = name,
        Description = CreateLocalizedText(description),
        Children = new OpcUaModelCompiler.ListOfChildren(),
      };
    }

    private static void ImportServer
      (AddressSpaceDataBase.ServersTableRow svr, string targetNamespace, UniqueName uniqueName, List<OpcUaModelCompiler.NodeDesign> nodes)
    {
      string name = NewName;
      XmlQualifiedName sftName = new XmlQualifiedName(NewName, targetNamespace);
      OpcUaModelCompiler.ObjectDesign sft = CreateFolder(sftName, svr.URLString, svr.URL.Path);
      sft.References = new OpcUaModelCompiler.Reference[] { new OpcUaModelCompiler.Reference()
        {
          IsInverse = true,
          ReferenceType = CreateXmlQualifiedName( Opc.Ua.BrowseNames.Organizes ),
          TargetId = CreateXmlQualifiedName( "ObjectsFolder" )
        }
      };
      nodes.Add(sft);
      List<OpcUaModelCompiler.InstanceDesign> cldrn = new List<OpcUaModelCompiler.InstanceDesign>();
      foreach (AddressSpaceDataBase.TagsTableRow item in svr.GetTagsTableRows())
        ImportTag(item, targetNamespace, uniqueName, sft.SymbolicName, nodes, cldrn);
      sft.Children = new OpcUaModelCompiler.ListOfChildren() { Items = cldrn.ToArray() };
    }

    private static void ImportTag
      (
        AddressSpaceDataBase.TagsTableRow parentItem,
        string targetNamespace,
        UniqueName uniqueName,
        XmlQualifiedName parentObject,
        List<OpcUaModelCompiler.NodeDesign> nodes,
        List<OpcUaModelCompiler.InstanceDesign> parentChildren
      )
    {
      Opc.Da.BrowseElement pbe = parentItem.GetBrowseElement();
      if (pbe.IsItem)
      {
        OpcUaModelCompiler.VariableDesign var = new OpcUaModelCompiler.VariableDesign()
        {
          SymbolicName = new XmlQualifiedName(uniqueName.GetUniqueName(pbe.Name), targetNamespace),
          DisplayName = new OpcUaModelCompiler.LocalizedText() { Value = pbe.Name },
          DataType = GetBaseDataType(),
          TypeDefinition = GetBaseDataVariableType(),
          Description = new OpcUaModelCompiler.LocalizedText() { Value = pbe.ItemName },
          AccessLevel = OpcUaModelCompiler.AccessLevel.ReadWrite,
          AccessLevelSpecified = true,
          ValueRank = OpcUaModelCompiler.ValueRank.Scalar,
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
        OpcUaModelCompiler.ObjectDesign sf = CreateFolder(new XmlQualifiedName(uniqueName.GetUniqueName(pbe.Name), targetNamespace), pbe.ItemName, pbe.Name);
        nodes.Add(sf);
        List<OpcUaModelCompiler.InstanceDesign> myChildren = new List<OpcUaModelCompiler.InstanceDesign>();
        foreach (AddressSpaceDataBase.TagsTableRow item in parentItem.GetTagsTableRows())
          ImportTag(item, targetNamespace, uniqueName, sf.SymbolicName, nodes, myChildren);
        sf.Children = new OpcUaModelCompiler.ListOfChildren() { Items = myChildren.ToArray() };
        sf.References = new OpcUaModelCompiler.Reference[]
        { new OpcUaModelCompiler.Reference()
          {
            IsInverse = true,
            ReferenceType = CreateXmlQualifiedName( Opc.Ua.BrowseNames.Organizes ),
            TargetId = parentObject
          }
        };
      }
    }

    private static void GetACCESSRIGHTS(OpcUaModelCompiler.VariableDesign var, Opc.Da.ItemProperty itemProperty)
    {
      if ((itemProperty == null) || (itemProperty.Value == null))
        return;
      var.AccessLevelSpecified = true;
      switch (((Opc.Da.accessRights)itemProperty.Value))
      {
        case Opc.Da.accessRights.readWritable:
          var.AccessLevel = OpcUaModelCompiler.AccessLevel.ReadWrite;
          break;

        case Opc.Da.accessRights.readable:
          var.AccessLevel = OpcUaModelCompiler.AccessLevel.Read;
          break;

        case Opc.Da.accessRights.writable:
          var.AccessLevel = OpcUaModelCompiler.AccessLevel.Write;
          break;

        default:
          var.AccessLevelSpecified = false;
          break;
      }
    }

    private static void GetEUTYPE(OpcUaModelCompiler.VariableDesign var, SortedDictionary<int, Opc.Da.ItemProperty> prprts)
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
              OpcUaModelCompiler.PropertyDesign prop = new OpcUaModelCompiler.PropertyDesign()
              {
                SymbolicName = CreateXmlQualifiedName(BrowseNames.EURange),
                DataType = CreateXmlQualifiedName(BrowseNames.Range),
                DefaultValue = CAS.UA.Common.Types.Range.CreateRange(higheu, loweu).XmlElement,
                ValueRank = OpcUaModelCompiler.ValueRank.Scalar,
                AccessLevel = OpcUaModelCompiler.AccessLevel.Read
              };
              var.Children = new OpcUaModelCompiler.ListOfChildren()
              {
                Items = new OpcUaModelCompiler.InstanceDesign[] { prop }
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

    private static void GetDATATYPE(OpcUaModelCompiler.VariableDesign var, Opc.Da.ItemProperty prprty)
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
        var.ValueRank = OpcUaModelCompiler.ValueRank.OneOrMoreDimensions;
    }

    private static XmlQualifiedName CreateXmlQualifiedName(string name)
    {
      return new XmlQualifiedName(name, Namespaces.OpcUa);
    }

    private static OpcUaModelCompiler.LocalizedText CreateLocalizedText(string displayName)
    {
      return new OpcUaModelCompiler.LocalizedText() { Value = displayName };
    }

    //ObjectTypes
    private static XmlQualifiedName GetFolderType() { return CreateXmlQualifiedName(BrowseNames.FolderType); }

    //DataTypes
    private static XmlQualifiedName GetBaseDataType() { return CreateXmlQualifiedName(BrowseNames.BaseDataType); }

    //VariableType
    private static XmlQualifiedName GetBaseDataVariableType() { return CreateXmlQualifiedName(Opc.Ua.BrowseNames.BaseDataVariableType); }

    private static XmlQualifiedName GetDataItemType()
    {
      return CreateXmlQualifiedName(BrowseNames.DataItemType);
    }

    private static XmlQualifiedName GetAnalogItemType()
    {
      return CreateXmlQualifiedName(BrowseNames.AnalogItemType);
    }

    private static XmlQualifiedName GetMultiStateDiscreteType()
    {
      return CreateXmlQualifiedName(BrowseNames.MultiStateDiscreteType);
    }

    private static XmlQualifiedName GetTwoStateDiscreteType()
    {
      return CreateXmlQualifiedName(BrowseNames.TwoStateDiscreteType);
    }

    //Properties
    private static XmlQualifiedName GetPropertyType() { return CreateXmlQualifiedName(BrowseNames.PropertyType); }

    private static XmlQualifiedName GetEURange()
    {
      return CreateXmlQualifiedName(BrowseNames.EURange);
    }

    //Values
    //TODO Must be implemented.
    private static XmlElement CreateRange(Range range)
    {
      return EncodeableObject.EncodeXml(range, null);
    }

    #endregion private
  }
}