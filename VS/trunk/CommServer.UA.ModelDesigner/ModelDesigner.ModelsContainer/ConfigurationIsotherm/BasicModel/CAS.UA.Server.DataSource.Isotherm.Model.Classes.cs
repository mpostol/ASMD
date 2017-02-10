
/* ========================================================================
 * Copyright (c) 2005-2010 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;

namespace CAS.UA.Server.DataSource.Isotherm.Model
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the StructureExample DataType.
        /// </summary>
        public const uint StructureExample = 6;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the PLC Object.
        /// </summary>
        public const uint PLC = 2;

        /// <summary>
        /// The identifier for the StructureExample_Encoding_DefaultXml Object.
        /// </summary>
        public const uint StructureExample_Encoding_DefaultXml = 7;

        /// <summary>
        /// The identifier for the StructureExample_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint StructureExample_Encoding_DefaultBinary = 14;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the PLCType ObjectType.
        /// </summary>
        public const uint PLCType = 1;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the PLCType_ArrayVariableInstanceDeclaration Variable.
        /// </summary>
        public const uint PLCType_ArrayVariableInstanceDeclaration = 4;

        /// <summary>
        /// The identifier for the PLC_ArrayVariableInstanceDeclaration Variable.
        /// </summary>
        public const uint PLC_ArrayVariableInstanceDeclaration = 5;

        /// <summary>
        /// The identifier for the PLC_ArrayVariable Variable.
        /// </summary>
        public const uint PLC_ArrayVariable = 3;

        /// <summary>
        /// The identifier for the PLC_NameNotSet785 Variable.
        /// </summary>
        public const uint PLC_NameNotSet785 = 21;

        /// <summary>
        /// The identifier for the cas_XmlSchema Variable.
        /// </summary>
        public const uint cas_XmlSchema = 8;

        /// <summary>
        /// The identifier for the cas_XmlSchema_DataTypeVersion Variable.
        /// </summary>
        public const uint cas_XmlSchema_DataTypeVersion = 9;

        /// <summary>
        /// The identifier for the cas_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint cas_XmlSchema_NamespaceUri = 10;

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample Variable.
        /// </summary>
        public const uint cas_XmlSchema_StructureExample = 11;

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample_DataTypeVersion Variable.
        /// </summary>
        public const uint cas_XmlSchema_StructureExample_DataTypeVersion = 12;

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample_DictionaryFragment Variable.
        /// </summary>
        public const uint cas_XmlSchema_StructureExample_DictionaryFragment = 13;

        /// <summary>
        /// The identifier for the cas_BinarySchema Variable.
        /// </summary>
        public const uint cas_BinarySchema = 15;

        /// <summary>
        /// The identifier for the cas_BinarySchema_DataTypeVersion Variable.
        /// </summary>
        public const uint cas_BinarySchema_DataTypeVersion = 16;

        /// <summary>
        /// The identifier for the cas_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint cas_BinarySchema_NamespaceUri = 17;

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample Variable.
        /// </summary>
        public const uint cas_BinarySchema_StructureExample = 18;

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample_DataTypeVersion Variable.
        /// </summary>
        public const uint cas_BinarySchema_StructureExample_DataTypeVersion = 19;

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample_DictionaryFragment Variable.
        /// </summary>
        public const uint cas_BinarySchema_StructureExample_DictionaryFragment = 20;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the StructureExample DataType.
        /// </summary>
        public static readonly ExpandedNodeId StructureExample = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.DataTypes.StructureExample, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the PLC Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Objects.PLC, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the StructureExample_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId StructureExample_Encoding_DefaultXml = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Objects.StructureExample_Encoding_DefaultXml, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the StructureExample_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId StructureExample_Encoding_DefaultBinary = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Objects.StructureExample_Encoding_DefaultBinary, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the PLCType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PLCType = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.ObjectTypes.PLCType, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the PLCType_ArrayVariableInstanceDeclaration Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLCType_ArrayVariableInstanceDeclaration = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.PLCType_ArrayVariableInstanceDeclaration, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the PLC_ArrayVariableInstanceDeclaration Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC_ArrayVariableInstanceDeclaration = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.PLC_ArrayVariableInstanceDeclaration, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the PLC_ArrayVariable Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC_ArrayVariable = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.PLC_ArrayVariable, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the PLC_NameNotSet785 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC_NameNotSet785 = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.PLC_NameNotSet785, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_DataTypeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_DataTypeVersion = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema_DataTypeVersion, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_NamespaceUri = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema_NamespaceUri, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_StructureExample = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema_StructureExample, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample_DataTypeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_StructureExample_DataTypeVersion = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema_StructureExample_DataTypeVersion, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_StructureExample_DictionaryFragment Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_StructureExample_DictionaryFragment = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_XmlSchema_StructureExample_DictionaryFragment, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_DataTypeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_DataTypeVersion = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema_DataTypeVersion, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_NamespaceUri = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema_NamespaceUri, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_StructureExample = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema_StructureExample, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample_DataTypeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_StructureExample_DataTypeVersion = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema_StructureExample_DataTypeVersion, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_StructureExample_DictionaryFragment Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_StructureExample_DictionaryFragment = new ExpandedNodeId(CAS.UA.Server.DataSource.Isotherm.Model.Variables.cas_BinarySchema_StructureExample_DictionaryFragment, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ArrayVariable component.
        /// </summary>
        public const string ArrayVariable = "ArrayVariable";

        /// <summary>
        /// The BrowseName for the ArrayVariableInstanceDeclaration component.
        /// </summary>
        public const string ArrayVariableInstanceDeclaration = "ArrayVariableInstanceDeclaration";

        /// <summary>
        /// The BrowseName for the cas_BinarySchema component.
        /// </summary>
        public const string cas_BinarySchema = "CAS.UA.Server.DataSource.Isotherm.Model";

        /// <summary>
        /// The BrowseName for the cas_XmlSchema component.
        /// </summary>
        public const string cas_XmlSchema = "CAS.UA.Server.DataSource.Isotherm.Model";

        /// <summary>
        /// The BrowseName for the NameNotSet785 component.
        /// </summary>
        public const string NameNotSet785 = "NameNotSet785";

        /// <summary>
        /// The BrowseName for the PLC component.
        /// </summary>
        public const string PLC = "PLC";

        /// <summary>
        /// The BrowseName for the PLCType component.
        /// </summary>
        public const string PLCType = "PLCType";

        /// <summary>
        /// The BrowseName for the StructureExample component.
        /// </summary>
        public const string StructureExample = "StructureExample";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cas namespace (.NET code namespace is 'CAS.UA.Server.DataSource.Isotherm.Model').
        /// </summary>
        public const string cas = "http://cas.eu/UA/CommServer/";

        /// <summary>
        /// The URI for the ua namespace (.NET code namespace is '').
        /// </summary>
        public const string ua = "http://opcfoundation.org/UA/";

        /// <summary>
        /// Returns a namespace table with all of the URIs defined.
        /// </summary>
        /// <remarks>
        /// This table is was used to create any relative paths in the model design.
        /// </remarks>
        public static NamespaceTable GetNamespaceTable()
        {
            FieldInfo[] fields = typeof(Namespaces).GetFields(BindingFlags.Public | BindingFlags.Static);

            NamespaceTable namespaceTable = new NamespaceTable();

            foreach (FieldInfo field in fields)
            {
                string namespaceUri = (string)field.GetValue(typeof(Namespaces));

                if (namespaceTable.GetIndex(namespaceUri) == -1)
                {
                    namespaceTable.Append(namespaceUri);
                }
            }

            return namespaceTable;
        }
    }
    #endregion
    
    #region PLCState Class
    #if (!OPCUA_EXCLUDE_PLCState)
    /// <summary>
    /// Stores an instance of the PLCType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PLCState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PLCState(NodeState parent) : base(parent)
        {
        }
        
        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(CAS.UA.Server.DataSource.Isotherm.Model.ObjectTypes.PLCType, CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString = 
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAABAAAAAQAPAAAAUExDVHlw" +
           "ZUluc3RhbmNlAQEBAAEBAQD/////AQAAABVgiQoCAAAAAQAgAAAAQXJyYXlWYXJpYWJsZUluc3RhbmNl" +
           "RGVjbGFyYXRpb24BAQQAAC8APwQAAAABAQYAAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ArrayVariableInstanceDeclaration Variable.
        /// </summary>
        public BaseDataVariableState<StructureExample[]> ArrayVariableInstanceDeclaration
        {
            get
            { 
                return m_arrayVariableInstanceDeclaration;  
            }
            
            set
            {
                if (!Object.ReferenceEquals(m_arrayVariableInstanceDeclaration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_arrayVariableInstanceDeclaration = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_arrayVariableInstanceDeclaration != null)
            {
                children.Add(m_arrayVariableInstanceDeclaration);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case CAS.UA.Server.DataSource.Isotherm.Model.BrowseNames.ArrayVariableInstanceDeclaration:
                {
                    if (createOrReplace)
                    {
                        if (ArrayVariableInstanceDeclaration == null)
                        {
                            if (replacement == null)
                            {
                                ArrayVariableInstanceDeclaration = new BaseDataVariableState<StructureExample[]>(this);
                            }
                            else
                            {
                                ArrayVariableInstanceDeclaration = (BaseDataVariableState<StructureExample[]>)replacement;
                            }
                        }
                    }

                    instance = ArrayVariableInstanceDeclaration;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<StructureExample[]> m_arrayVariableInstanceDeclaration;
        #endregion
    }
    #endif
    #endregion

    #region StructureExample Class
    #if (!OPCUA_EXCLUDE_StructureExample)
    /// <summary>
    /// A description for the StructureExample DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas)]
    public partial class StructureExample : EncodeableObject
    {
    	#region Constructors
    	/// <summary>
    	/// The default constructor.
    	/// </summary>
    	public StructureExample()
    	{
    		Initialize();
    	}
        
    	/// <summary>
    	/// Called by the .NET framework during deserialization.
    	/// </summary>
        [OnDeserializing]
    	private void Initialize(StreamingContext context)
    	{
    		Initialize();
    	}

    	/// <summary>
    	/// Sets private members to default values.
    	/// </summary>
    	private void Initialize()
    	{
    		m_field1 = new Int32Collection();
    	}
    	#endregion

    	#region Public Properties
    	/// <summary>
    	/// A description for the Field1 field.
    	/// </summary>
    	[DataMember(Name = "Field1", Order = 1)]
    	public Int32Collection Field1
    	{
    		get 
    	    { 
    	        return m_field1;  
    	    }
    		
    	    set 
    	    { 
    	        m_field1 = value; 

    	        if (value == null)
    	        {
    	            m_field1 = new Int32Collection();
    	        }
    	    }
    	}
    	#endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.StructureExample; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.StructureExample_Encoding_DefaultBinary; }
        }
        
        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.StructureExample_Encoding_DefaultXml; }
        }
        
        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

            encoder.WriteInt32Array("Field1", Field1);

            encoder.PopNamespace();
        }
        
        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas);

            Field1 = decoder.ReadInt32Array("Field1");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }
            
            StructureExample value = encodeable as StructureExample;
            
            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_field1, value.m_field1)) return false;

            return true;
        }
        
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            StructureExample clone = (StructureExample)base.Clone();

            clone.m_field1 = (Int32Collection)Utils.Clone(this.m_field1);

            return clone;
        }
        #endregion
        
    	#region Private Fields
    	private Int32Collection m_field1;
    	#endregion
    }

    #region StructureExampleCollection Class
    /// <summary>
    /// A collection of StructureExample objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfStructureExample", Namespace = CAS.UA.Server.DataSource.Isotherm.Model.Namespaces.cas, ItemName = "StructureExample")]
    public partial class StructureExampleCollection : List<StructureExample>, ICloneable
    {
    	#region Constructors
    	/// <summary>
    	/// Initializes the collection with default values.
    	/// </summary>
    	public StructureExampleCollection() {}
    	
    	/// <summary>
    	/// Initializes the collection with an initial capacity.
    	/// </summary>
    	public StructureExampleCollection(int capacity) : base(capacity) {}
    	
    	/// <summary>
    	/// Initializes the collection with another collection.
    	/// </summary>
    	public StructureExampleCollection(IEnumerable<StructureExample> collection) : base(collection) {}
    	#endregion
                    
        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator StructureExampleCollection(StructureExample[] values)
        {
            if (values != null)
            {
                return new StructureExampleCollection(values);
            }

            return new StructureExampleCollection();
        }
        
        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator StructureExample[](StructureExampleCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            StructureExampleCollection clone = new StructureExampleCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((StructureExample)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion
}