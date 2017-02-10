/* ========================================================================
 * Copyright (c) 2005-2011 The OPC Foundation, Inc. All rights reserved.
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
using Opc.Ua;
using Opc.Ua.Di;

namespace Opc.Ua.Plc
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the CtrlConfigurationType_MethodSet_Start Method.
        /// </summary>
        public const uint CtrlConfigurationType_MethodSet_Start = 55;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_MethodSet_Stop Method.
        /// </summary>
        public const uint CtrlConfigurationType_MethodSet_Stop = 56;

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet_Start Method.
        /// </summary>
        public const uint CtrlResourceType_MethodSet_Start = 117;

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet_Stop Method.
        /// </summary>
        public const uint CtrlResourceType_MethodSet_Stop = 118;
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
        /// The identifier for the CtrlConfigurationType_MethodSet Object.
        /// </summary>
        public const uint CtrlConfigurationType_MethodSet = 10;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Resources Object.
        /// </summary>
        public const uint CtrlConfigurationType_Resources = 57;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Resources_SupportedTypes Object.
        /// </summary>
        public const uint CtrlConfigurationType_Resources_SupportedTypes = 58;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_GlobalVars Object.
        /// </summary>
        public const uint CtrlConfigurationType_GlobalVars = 59;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_AccessVars Object.
        /// </summary>
        public const uint CtrlConfigurationType_AccessVars = 61;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_ConfigVars Object.
        /// </summary>
        public const uint CtrlConfigurationType_ConfigVars = 63;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Configuration Object.
        /// </summary>
        public const uint CtrlConfigurationType_Configuration = 65;

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Diagnostic Object.
        /// </summary>
        public const uint CtrlConfigurationType_Diagnostic = 67;

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet Object.
        /// </summary>
        public const uint CtrlResourceType_MethodSet = 72;

        /// <summary>
        /// The identifier for the CtrlResourceType_Tasks Object.
        /// </summary>
        public const uint CtrlResourceType_Tasks = 119;

        /// <summary>
        /// The identifier for the CtrlResourceType_Tasks_SupportedTypes Object.
        /// </summary>
        public const uint CtrlResourceType_Tasks_SupportedTypes = 120;

        /// <summary>
        /// The identifier for the CtrlResourceType_Programs Object.
        /// </summary>
        public const uint CtrlResourceType_Programs = 121;

        /// <summary>
        /// The identifier for the CtrlResourceType_Programs_SupportedTypes Object.
        /// </summary>
        public const uint CtrlResourceType_Programs_SupportedTypes = 122;

        /// <summary>
        /// The identifier for the CtrlResourceType_GlobalVars Object.
        /// </summary>
        public const uint CtrlResourceType_GlobalVars = 123;

        /// <summary>
        /// The identifier for the CtrlResourceType_Configuration Object.
        /// </summary>
        public const uint CtrlResourceType_Configuration = 125;

        /// <summary>
        /// The identifier for the CtrlResourceType_Diagnostic Object.
        /// </summary>
        public const uint CtrlResourceType_Diagnostic = 127;
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
        /// The identifier for the CtrlConfigurationType ObjectType.
        /// </summary>
        public const uint CtrlConfigurationType = 7;

        /// <summary>
        /// The identifier for the CtrlResourceType ObjectType.
        /// </summary>
        public const uint CtrlResourceType = 69;

        /// <summary>
        /// The identifier for the CtrlProgramOrganizationUnitType ObjectType.
        /// </summary>
        public const uint CtrlProgramOrganizationUnitType = 129;

        /// <summary>
        /// The identifier for the CtrlProgramType ObjectType.
        /// </summary>
        public const uint CtrlProgramType = 166;

        /// <summary>
        /// The identifier for the CtrlFunctionBlockType ObjectType.
        /// </summary>
        public const uint CtrlFunctionBlockType = 204;

        /// <summary>
        /// The identifier for the CtrlTaskType ObjectType.
        /// </summary>
        public const uint CtrlTaskType = 242;

        /// <summary>
        /// The identifier for the SFCType ObjectType.
        /// </summary>
        public const uint SFCType = 246;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <summary>
        /// The identifier for the HasInputVars ReferenceType.
        /// </summary>
        public const uint HasInputVars = 1;

        /// <summary>
        /// The identifier for the HasOutputVars ReferenceType.
        /// </summary>
        public const uint HasOutputVars = 2;

        /// <summary>
        /// The identifier for the HasInOutVars ReferenceType.
        /// </summary>
        public const uint HasInOutVars = 3;

        /// <summary>
        /// The identifier for the HasLocalVars ReferenceType.
        /// </summary>
        public const uint HasLocalVars = 4;

        /// <summary>
        /// The identifier for the HasExternalVars ReferenceType.
        /// </summary>
        public const uint HasExternalVars = 5;

        /// <summary>
        /// The identifier for the With ReferenceType.
        /// </summary>
        public const uint With = 6;
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
        /// The identifier for the CtrlProgramOrganizationUnitType_Body Variable.
        /// </summary>
        public const uint CtrlProgramOrganizationUnitType_Body = 165;

        /// <summary>
        /// The identifier for the CtrlProgramType_Program Variable.
        /// </summary>
        public const uint CtrlProgramType_Program = 203;

        /// <summary>
        /// The identifier for the CtrlFunctionBlockType_FunctionBlock Variable.
        /// </summary>
        public const uint CtrlFunctionBlockType_FunctionBlock = 241;

        /// <summary>
        /// The identifier for the CtrlTaskType_Priority Variable.
        /// </summary>
        public const uint CtrlTaskType_Priority = 243;

        /// <summary>
        /// The identifier for the CtrlTaskType_Interval Variable.
        /// </summary>
        public const uint CtrlTaskType_Interval = 244;

        /// <summary>
        /// The identifier for the CtrlTaskType_Single Variable.
        /// </summary>
        public const uint CtrlTaskType_Single = 245;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the CtrlConfigurationType_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_MethodSet_Start = new ExpandedNodeId(Opc.Ua.Plc.Methods.CtrlConfigurationType_MethodSet_Start, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_MethodSet_Stop = new ExpandedNodeId(Opc.Ua.Plc.Methods.CtrlConfigurationType_MethodSet_Stop, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_MethodSet_Start = new ExpandedNodeId(Opc.Ua.Plc.Methods.CtrlResourceType_MethodSet_Start, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_MethodSet_Stop = new ExpandedNodeId(Opc.Ua.Plc.Methods.CtrlResourceType_MethodSet_Stop, Opc.Ua.Plc.Namespaces.OpcUaPlc);
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
        /// The identifier for the CtrlConfigurationType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_MethodSet = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_MethodSet, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Resources Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_Resources = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_Resources, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Resources_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_Resources_SupportedTypes = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_Resources_SupportedTypes, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_GlobalVars Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_GlobalVars = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_GlobalVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_AccessVars Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_AccessVars = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_AccessVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_ConfigVars Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_ConfigVars = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_ConfigVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_Configuration = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_Configuration, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlConfigurationType_Diagnostic Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType_Diagnostic = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlConfigurationType_Diagnostic, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_MethodSet = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_MethodSet, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Tasks Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Tasks = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Tasks, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Tasks_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Tasks_SupportedTypes = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Tasks_SupportedTypes, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Programs Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Programs = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Programs, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Programs_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Programs_SupportedTypes = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Programs_SupportedTypes, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_GlobalVars Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_GlobalVars = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_GlobalVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Configuration = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Configuration, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType_Diagnostic Object.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType_Diagnostic = new ExpandedNodeId(Opc.Ua.Plc.Objects.CtrlResourceType_Diagnostic, Opc.Ua.Plc.Namespaces.OpcUaPlc);
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
        /// The identifier for the CtrlConfigurationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlConfigurationType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlConfigurationType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlResourceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlResourceType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlResourceType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlProgramOrganizationUnitType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlProgramOrganizationUnitType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlProgramOrganizationUnitType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlProgramType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlProgramType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlProgramType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlFunctionBlockType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlFunctionBlockType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlFunctionBlockType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlTaskType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CtrlTaskType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.CtrlTaskType, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the SFCType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SFCType = new ExpandedNodeId(Opc.Ua.Plc.ObjectTypes.SFCType, Opc.Ua.Plc.Namespaces.OpcUaPlc);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <summary>
        /// The identifier for the HasInputVars ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasInputVars = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.HasInputVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the HasOutputVars ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasOutputVars = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.HasOutputVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the HasInOutVars ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasInOutVars = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.HasInOutVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the HasLocalVars ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasLocalVars = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.HasLocalVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the HasExternalVars ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasExternalVars = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.HasExternalVars, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the With ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId With = new ExpandedNodeId(Opc.Ua.Plc.ReferenceTypes.With, Opc.Ua.Plc.Namespaces.OpcUaPlc);
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
        /// The identifier for the CtrlProgramOrganizationUnitType_Body Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlProgramOrganizationUnitType_Body = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlProgramOrganizationUnitType_Body, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlProgramType_Program Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlProgramType_Program = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlProgramType_Program, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlFunctionBlockType_FunctionBlock Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlFunctionBlockType_FunctionBlock = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlFunctionBlockType_FunctionBlock, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlTaskType_Priority Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlTaskType_Priority = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlTaskType_Priority, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlTaskType_Interval Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlTaskType_Interval = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlTaskType_Interval, Opc.Ua.Plc.Namespaces.OpcUaPlc);

        /// <summary>
        /// The identifier for the CtrlTaskType_Single Variable.
        /// </summary>
        public static readonly ExpandedNodeId CtrlTaskType_Single = new ExpandedNodeId(Opc.Ua.Plc.Variables.CtrlTaskType_Single, Opc.Ua.Plc.Namespaces.OpcUaPlc);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AccessVars component.
        /// </summary>
        public const string AccessVars = "AccessVars";

        /// <summary>
        /// The BrowseName for the Body component.
        /// </summary>
        public const string Body = "Body";

        /// <summary>
        /// The BrowseName for the Configuration component.
        /// </summary>
        public const string Configuration = "Configuration";

        /// <summary>
        /// The BrowseName for the ConfigVars component.
        /// </summary>
        public const string ConfigVars = "ConfigVars";

        /// <summary>
        /// The BrowseName for the CtrlConfigurationType component.
        /// </summary>
        public const string CtrlConfigurationType = "CtrlConfigurationType";

        /// <summary>
        /// The BrowseName for the CtrlFunctionBlockType component.
        /// </summary>
        public const string CtrlFunctionBlockType = "CtrlFunctionBlockType";

        /// <summary>
        /// The BrowseName for the CtrlProgramOrganizationUnitType component.
        /// </summary>
        public const string CtrlProgramOrganizationUnitType = "CtrlProgramOrganizationUnitType";

        /// <summary>
        /// The BrowseName for the CtrlProgramType component.
        /// </summary>
        public const string CtrlProgramType = "CtrlProgramType";

        /// <summary>
        /// The BrowseName for the CtrlResourceType component.
        /// </summary>
        public const string CtrlResourceType = "CtrlResourceType";

        /// <summary>
        /// The BrowseName for the CtrlTaskType component.
        /// </summary>
        public const string CtrlTaskType = "CtrlTaskType";

        /// <summary>
        /// The BrowseName for the Diagnostic component.
        /// </summary>
        public const string Diagnostic = "Diagnostic";

        /// <summary>
        /// The BrowseName for the FunctionBlock component.
        /// </summary>
        public const string FunctionBlock = "FunctionBlock";

        /// <summary>
        /// The BrowseName for the GlobalVars component.
        /// </summary>
        public const string GlobalVars = "GlobalVars";

        /// <summary>
        /// The BrowseName for the HasExternalVars component.
        /// </summary>
        public const string HasExternalVars = "HasExternalVars";

        /// <summary>
        /// The BrowseName for the HasInOutVars component.
        /// </summary>
        public const string HasInOutVars = "HasInOutVars";

        /// <summary>
        /// The BrowseName for the HasInputVars component.
        /// </summary>
        public const string HasInputVars = "HasInputVars";

        /// <summary>
        /// The BrowseName for the HasLocalVars component.
        /// </summary>
        public const string HasLocalVars = "HasLocalVars";

        /// <summary>
        /// The BrowseName for the HasOutputVars component.
        /// </summary>
        public const string HasOutputVars = "HasOutputVars";

        /// <summary>
        /// The BrowseName for the Interval component.
        /// </summary>
        public const string Interval = "Interval";

        /// <summary>
        /// The BrowseName for the MethodSet component.
        /// </summary>
        public const string MethodSet = "MethodSet";

        /// <summary>
        /// The BrowseName for the Priority component.
        /// </summary>
        public const string Priority = "Priority";

        /// <summary>
        /// The BrowseName for the Program component.
        /// </summary>
        public const string Program = "Program";

        /// <summary>
        /// The BrowseName for the Programs component.
        /// </summary>
        public const string Programs = "Programs";

        /// <summary>
        /// The BrowseName for the Resources component.
        /// </summary>
        public const string Resources = "Resources";

        /// <summary>
        /// The BrowseName for the SFCType component.
        /// </summary>
        public const string SFCType = "SFCType";

        /// <summary>
        /// The BrowseName for the Single component.
        /// </summary>
        public const string Single = "Single";

        /// <summary>
        /// The BrowseName for the Tasks component.
        /// </summary>
        public const string Tasks = "Tasks";

        /// <summary>
        /// The BrowseName for the With component.
        /// </summary>
        public const string With = "With";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaPlc namespace (.NET code namespace is 'Opc.Ua.Plc').
        /// </summary>
        public const string OpcUaPlc = "http://PLCopen.org/OpcUa/IEC61131-3/";

        /// <summary>
        /// The URI for the OpcUaPlcXsd namespace (.NET code namespace is 'Opc.Ua.Plc').
        /// </summary>
        public const string OpcUaPlcXsd = "http://PLCopen.org/OpcUa/IEC61131-3/Types.xsd";
    }
    #endregion

    #region CtrlConfigurationState Class
    #if (!OPCUA_EXCLUDE_CtrlConfigurationState)
    /// <summary>
    /// Stores an instance of the CtrlConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlConfigurationState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlConfigurationType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAHQAAAEN0cmxDb25maWd1cmF0aW9uVHlwZUlu" +
           "c3RhbmNlAQIHAAECBwD/////EQAAACRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQIIAAMAAAAAFwAA" +
           "AEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOggAAAD/////AAAAACRggAoBAAAAAgAJAAAATWV0aG9k" +
           "U2V0AQIKAAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOgoAAAD/////AgAAAARhggoEAAAA" +
           "AgAFAAAAU3RhcnQBAjcAAC8BAjcANwAAAAEB/////wAAAAAEYYIKBAAAAAIABAAAAFN0b3ABAjgAAC8B" +
           "AjgAOAAAAAEB/////wAAAAA1YIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgECJgADAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQmAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQInAAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAEQnAAAAAAb/////AQH/////AAAAADVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQIoAAMA" +
           "AAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQoAAAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAFAAAATW9kZWwBAikAAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0" +
           "dXJlZCB0aGUgZGV2aWNlAC4ARCkAAAAAFf////8BAf////8AAAAANWCJCgIAAAABAAwAAABEZXZpY2VN" +
           "YW51YWwBAioAAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARCoAAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABAA4AAABEZXZpY2VSZXZpc2lvbgECKwADAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEKwAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEAEAAAAFNvZnR3YXJlUmV2aXNpb24BAiwAAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBELAAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEAEAAAAEhhcmR3YXJlUmV2aXNpb24BAi0AAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBELQAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADAAAAERl" +
           "dmljZUhlYWx0aAECLgADAAAAADwAAABTdGF0dXMgb2YgYSBkZXZpY2UgYXMgZGVmaW5lZCBieSBOQU1V" +
           "UiBSZWNvbW1lbmRhdGlvbiBORTEwNy4ALgBELgAAAAEBAAH/////AQH/////AAAAAARggAoBAAAAAgAJ" +
           "AAAAUmVzb3VyY2VzAQI5AAAvAQH2ADkAAAD/////AQAAACRggAoBAAAAAQAOAAAAU3VwcG9ydGVkVHlw" +
           "ZXMBAjoAAwAAAAByAAAARm9sZGVyIG1haW50YWluaW5nIHRoZSBzZXQgb2YgKHN1Yi10eXBlcyBvZikg" +
           "QmFzZU9iamVjdFR5cGVzIHRoYXQgY2FuIGJlIGluc3RhbnRpYXRlZCBpbiB0aGUgQ29uZmlndXJhYmxl" +
           "Q29tcG9uZW50AC8APToAAAD/////AAAAAARggAoBAAAAAgAKAAAAR2xvYmFsVmFycwECOwAALwEB+QA7" +
           "AAAA/////wAAAAAEYIAKAQAAAAIACgAAAEFjY2Vzc1ZhcnMBAj0AAC8BAfkAPQAAAP////8AAAAABGCA" +
           "CgEAAAACAAoAAABDb25maWdWYXJzAQI/AAAvAQH5AD8AAAD/////AAAAAARggAoBAAAAAgANAAAAQ29u" +
           "ZmlndXJhdGlvbgECQQAALwEB+QBBAAAA/////wAAAAAEYIAKAQAAAAIACgAAAERpYWdub3N0aWMBAkMA" +
           "AC8BAfkAQwAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Resources Object.
        /// </summary>
        public ConfigurableObjectState Resources
        {
            get
            {
                return m_resources;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resources, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resources = value;
            }
        }

        /// <summary>
        /// A description for the GlobalVars Object.
        /// </summary>
        public FunctionalGroupState GlobalVars
        {
            get
            {
                return m_globalVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_globalVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_globalVars = value;
            }
        }

        /// <summary>
        /// A description for the AccessVars Object.
        /// </summary>
        public FunctionalGroupState AccessVars
        {
            get
            {
                return m_accessVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessVars = value;
            }
        }

        /// <summary>
        /// A description for the ConfigVars Object.
        /// </summary>
        public FunctionalGroupState ConfigVars
        {
            get
            {
                return m_configVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configVars = value;
            }
        }

        /// <summary>
        /// A description for the Configuration Object.
        /// </summary>
        public FunctionalGroupState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <summary>
        /// A description for the Diagnostic Object.
        /// </summary>
        public FunctionalGroupState Diagnostic
        {
            get
            {
                return m_diagnostic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_diagnostic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_diagnostic = value;
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
            if (m_resources != null)
            {
                children.Add(m_resources);
            }

            if (m_globalVars != null)
            {
                children.Add(m_globalVars);
            }

            if (m_accessVars != null)
            {
                children.Add(m_accessVars);
            }

            if (m_configVars != null)
            {
                children.Add(m_configVars);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_diagnostic != null)
            {
                children.Add(m_diagnostic);
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
                case Opc.Ua.Plc.BrowseNames.Resources:
                {
                    if (createOrReplace)
                    {
                        if (Resources == null)
                        {
                            if (replacement == null)
                            {
                                Resources = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Resources = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Resources;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.GlobalVars:
                {
                    if (createOrReplace)
                    {
                        if (GlobalVars == null)
                        {
                            if (replacement == null)
                            {
                                GlobalVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                GlobalVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = GlobalVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.AccessVars:
                {
                    if (createOrReplace)
                    {
                        if (AccessVars == null)
                        {
                            if (replacement == null)
                            {
                                AccessVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AccessVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AccessVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.ConfigVars:
                {
                    if (createOrReplace)
                    {
                        if (ConfigVars == null)
                        {
                            if (replacement == null)
                            {
                                ConfigVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                ConfigVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = ConfigVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Diagnostic:
                {
                    if (createOrReplace)
                    {
                        if (Diagnostic == null)
                        {
                            if (replacement == null)
                            {
                                Diagnostic = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Diagnostic = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Diagnostic;
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
        private ConfigurableObjectState m_resources;
        private FunctionalGroupState m_globalVars;
        private FunctionalGroupState m_accessVars;
        private FunctionalGroupState m_configVars;
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_diagnostic;
        #endregion
    }
    #endif
    #endregion

    #region CtrlResourceState Class
    #if (!OPCUA_EXCLUDE_CtrlResourceState)
    /// <summary>
    /// Stores an instance of the CtrlResourceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlResourceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlResourceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlResourceType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }

            if (GlobalVars != null)
            {
                GlobalVars.Initialize(context, GlobalVars_InitializationString);
            }

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (Diagnostic != null)
            {
                Diagnostic.Initialize(context, Diagnostic_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8kYIAKAQAAAAIACQAAAE1ldGhvZFNldAECSAADAAAAABQAAABG" +
           "bGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpIAAAA/////wIAAAAEYYIKBAAAAAIABQAAAFN0YXJ0AQJ1AAAv" +
           "AQJ1AHUAAAABAf////8AAAAABGGCCgQAAAACAAQAAABTdG9wAQJ2AAAvAQJ2AHYAAAABAf////8AAAAA";

        private const string GlobalVars_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIACgAAAEdsb2JhbFZhcnMBAnsAAC8BAfkAewAA" +
           "AP////8AAAAA";

        private const string Configuration_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIADQAAAENvbmZpZ3VyYXRpb24BAn0AAC8BAfkA" +
           "fQAAAP////8AAAAA";

        private const string Diagnostic_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAKAQAAAAIACgAAAERpYWdub3N0aWMBAn8AAC8BAfkAfwAA" +
           "AP////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAGAAAAEN0cmxSZXNvdXJjZVR5cGVJbnN0YW5j" +
           "ZQECRQABAkUA/////xAAAAAkYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAECRgADAAAAABcAAABGbGF0" +
           "IGxpc3Qgb2YgUGFyYW1ldGVycwAvADpGAAAA/////wAAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEC" +
           "SAADAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADpIAAAA/////wIAAAAEYYIKBAAAAAIABQAA" +
           "AFN0YXJ0AQJ1AAAvAQJ1AHUAAAABAf////8AAAAABGGCCgQAAAACAAQAAABTdG9wAQJ2AAAvAQJ2AHYA" +
           "AAABAf////8AAAAANWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAmQAAwAAAABNAAAASWRlbnRpZmll" +
           "ciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2Ug" +
           "aW5zdGFuY2UALgBEZAAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADwAAAFJldmlzaW9uQ291bnRl" +
           "cgECZQADAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBv" +
           "ZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQA" +
           "LgBEZQAAAAAG/////wEB/////wAAAAA1YIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgECZgADAAAAABgA" +
           "AABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEZgAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "BQAAAE1vZGVsAQJnAAMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQg" +
           "dGhlIGRldmljZQAuAERnAAAAABX/////AQH/////AAAAADVgiQoCAAAAAQAMAAAARGV2aWNlTWFudWFs" +
           "AQJoAAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8" +
           "IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAERoAAAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAOAAAARGV2aWNlUmV2aXNpb24BAmkAAwAAAAAkAAAAT3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARGkAAAAADP////8BAf////8AAAAANWCJCgIAAAABABAA" +
           "AABTb2Z0d2FyZVJldmlzaW9uAQJqAAMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2Fy" +
           "ZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARGoAAAAADP////8BAf////8AAAAANWCJCgIAAAABABAA" +
           "AABIYXJkd2FyZVJldmlzaW9uAQJrAAMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARGsAAAAADP////8BAf////8AAAAANWCJCgIAAAABAAwAAABEZXZpY2VI" +
           "ZWFsdGgBAmwAAwAAAAA8AAAAU3RhdHVzIG9mIGEgZGV2aWNlIGFzIGRlZmluZWQgYnkgTkFNVVIgUmVj" +
           "b21tZW5kYXRpb24gTkUxMDcuAC4ARGwAAAABAQAB/////wEB/////wAAAAAEYIAKAQAAAAIABQAAAFRh" +
           "c2tzAQJ3AAAvAQH2AHcAAAD/////AQAAACRggAoBAAAAAQAOAAAAU3VwcG9ydGVkVHlwZXMBAngAAwAA" +
           "AAByAAAARm9sZGVyIG1haW50YWluaW5nIHRoZSBzZXQgb2YgKHN1Yi10eXBlcyBvZikgQmFzZU9iamVj" +
           "dFR5cGVzIHRoYXQgY2FuIGJlIGluc3RhbnRpYXRlZCBpbiB0aGUgQ29uZmlndXJhYmxlQ29tcG9uZW50" +
           "AC8APXgAAAD/////AAAAAARggAoBAAAAAgAIAAAAUHJvZ3JhbXMBAnkAAC8BAfYAeQAAAP////8BAAAA" +
           "JGCACgEAAAABAA4AAABTdXBwb3J0ZWRUeXBlcwECegADAAAAAHIAAABGb2xkZXIgbWFpbnRhaW5pbmcg" +
           "dGhlIHNldCBvZiAoc3ViLXR5cGVzIG9mKSBCYXNlT2JqZWN0VHlwZXMgdGhhdCBjYW4gYmUgaW5zdGFu" +
           "dGlhdGVkIGluIHRoZSBDb25maWd1cmFibGVDb21wb25lbnQALwA9egAAAP////8AAAAABGCACgEAAAAC" +
           "AAoAAABHbG9iYWxWYXJzAQJ7AAAvAQH5AHsAAAD/////AAAAAARggAoBAAAAAgANAAAAQ29uZmlndXJh" +
           "dGlvbgECfQAALwEB+QB9AAAA/////wAAAAAEYIAKAQAAAAIACgAAAERpYWdub3N0aWMBAn8AAC8BAfkA" +
           "fwAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Tasks Object.
        /// </summary>
        public ConfigurableObjectState Tasks
        {
            get
            {
                return m_tasks;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tasks, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tasks = value;
            }
        }

        /// <summary>
        /// A description for the Programs Object.
        /// </summary>
        public ConfigurableObjectState Programs
        {
            get
            {
                return m_programs;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programs, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programs = value;
            }
        }

        /// <summary>
        /// A description for the GlobalVars Object.
        /// </summary>
        public FunctionalGroupState GlobalVars
        {
            get
            {
                return m_globalVars;
            }

            set
            {
                if (!Object.ReferenceEquals(m_globalVars, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_globalVars = value;
            }
        }

        /// <summary>
        /// A description for the Configuration Object.
        /// </summary>
        public FunctionalGroupState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <summary>
        /// A description for the Diagnostic Object.
        /// </summary>
        public FunctionalGroupState Diagnostic
        {
            get
            {
                return m_diagnostic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_diagnostic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_diagnostic = value;
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
            if (m_tasks != null)
            {
                children.Add(m_tasks);
            }

            if (m_programs != null)
            {
                children.Add(m_programs);
            }

            if (m_globalVars != null)
            {
                children.Add(m_globalVars);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_diagnostic != null)
            {
                children.Add(m_diagnostic);
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
                case Opc.Ua.Plc.BrowseNames.Tasks:
                {
                    if (createOrReplace)
                    {
                        if (Tasks == null)
                        {
                            if (replacement == null)
                            {
                                Tasks = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Tasks = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Tasks;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Programs:
                {
                    if (createOrReplace)
                    {
                        if (Programs == null)
                        {
                            if (replacement == null)
                            {
                                Programs = new ConfigurableObjectState(this);
                            }
                            else
                            {
                                Programs = (ConfigurableObjectState)replacement;
                            }
                        }
                    }

                    instance = Programs;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.GlobalVars:
                {
                    if (createOrReplace)
                    {
                        if (GlobalVars == null)
                        {
                            if (replacement == null)
                            {
                                GlobalVars = new FunctionalGroupState(this);
                            }
                            else
                            {
                                GlobalVars = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = GlobalVars;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Diagnostic:
                {
                    if (createOrReplace)
                    {
                        if (Diagnostic == null)
                        {
                            if (replacement == null)
                            {
                                Diagnostic = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Diagnostic = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Diagnostic;
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
        private ConfigurableObjectState m_tasks;
        private ConfigurableObjectState m_programs;
        private FunctionalGroupState m_globalVars;
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_diagnostic;
        #endregion
    }
    #endif
    #endregion

    #region CtrlProgramOrganizationUnitState Class
    #if (!OPCUA_EXCLUDE_CtrlProgramOrganizationUnitState)
    /// <summary>
    /// Stores an instance of the CtrlProgramOrganizationUnitType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlProgramOrganizationUnitState : BlockState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlProgramOrganizationUnitState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlProgramOrganizationUnitType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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

            if (Body != null)
            {
                Body.Initialize(context, Body_InitializationString);
            }
        }

        #region Initialization String
        private const string Body_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABAAAAEJvZHkBAqUAAC8AP6UAAAAAEP////8B" +
           "Af////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAJwAAAEN0cmxQcm9ncmFtT3JnYW5pemF0aW9u" +
           "VW5pdFR5cGVJbnN0YW5jZQECgQABAoEA/////wIAAAAkYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAEC" +
           "ggADAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADqCAAAA/////wAAAAAVYIkKAgAAAAIA" +
           "BAAAAEJvZHkBAqUAAC8AP6UAAAAAEP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Body Variable.
        /// </summary>
        public BaseDataVariableState<XmlElement> Body
        {
            get
            {
                return m_body;
            }

            set
            {
                if (!Object.ReferenceEquals(m_body, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_body = value;
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
            if (m_body != null)
            {
                children.Add(m_body);
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
                case Opc.Ua.Plc.BrowseNames.Body:
                {
                    if (createOrReplace)
                    {
                        if (Body == null)
                        {
                            if (replacement == null)
                            {
                                Body = new BaseDataVariableState<XmlElement>(this);
                            }
                            else
                            {
                                Body = (BaseDataVariableState<XmlElement>)replacement;
                            }
                        }
                    }

                    instance = Body;
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
        private BaseDataVariableState<XmlElement> m_body;
        #endregion
    }
    #endif
    #endregion

    #region CtrlProgramState Class
    #if (!OPCUA_EXCLUDE_CtrlProgramState)
    /// <summary>
    /// Stores an instance of the CtrlProgramType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlProgramState : CtrlProgramOrganizationUnitState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlProgramState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlProgramType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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

            if (Program != null)
            {
                Program.Initialize(context, Program_InitializationString);
            }
        }

        #region Initialization String
        private const string Program_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABwAAAFByb2dyYW0BAssAAC8AP8sAAAAAFv//" +
           "//8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAFwAAAEN0cmxQcm9ncmFtVHlwZUluc3RhbmNl" +
           "AQKmAAECpgD/////AgAAACRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQKnAAMAAAAAFwAAAEZsYXQg" +
           "bGlzdCBvZiBQYXJhbWV0ZXJzAC8AOqcAAAD/////AAAAABVgiQoCAAAAAgAHAAAAUHJvZ3JhbQECywAA" +
           "LwA/ywAAAAAW/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Program Variable.
        /// </summary>
        public BaseDataVariableState<ExtensionObject> Program
        {
            get
            {
                return m_program;
            }

            set
            {
                if (!Object.ReferenceEquals(m_program, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_program = value;
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
            if (m_program != null)
            {
                children.Add(m_program);
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
                case Opc.Ua.Plc.BrowseNames.Program:
                {
                    if (createOrReplace)
                    {
                        if (Program == null)
                        {
                            if (replacement == null)
                            {
                                Program = new BaseDataVariableState<ExtensionObject>(this);
                            }
                            else
                            {
                                Program = (BaseDataVariableState<ExtensionObject>)replacement;
                            }
                        }
                    }

                    instance = Program;
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
        private BaseDataVariableState<ExtensionObject> m_program;
        #endregion
    }
    #endif
    #endregion

    #region CtrlFunctionBlockState Class
    #if (!OPCUA_EXCLUDE_CtrlFunctionBlockState)
    /// <summary>
    /// Stores an instance of the CtrlFunctionBlockType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlFunctionBlockState : CtrlProgramOrganizationUnitState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlFunctionBlockState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlFunctionBlockType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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

            if (FunctionBlock != null)
            {
                FunctionBlock.Initialize(context, FunctionBlock_InitializationString);
            }
        }

        #region Initialization String
        private const string FunctionBlock_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIADQAAAEZ1bmN0aW9uQmxvY2sBAvEAAC8AP/EA" +
           "AAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAHQAAAEN0cmxGdW5jdGlvbkJsb2NrVHlwZUlu" +
           "c3RhbmNlAQLMAAECzAD/////AgAAACRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQLNAAMAAAAAFwAA" +
           "AEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOs0AAAD/////AAAAABVgiQoCAAAAAgANAAAARnVuY3Rp" +
           "b25CbG9jawEC8QAALwA/8QAAAAAY/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the FunctionBlock Variable.
        /// </summary>
        public BaseDataVariableState FunctionBlock
        {
            get
            {
                return m_functionBlock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionBlock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionBlock = value;
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
            if (m_functionBlock != null)
            {
                children.Add(m_functionBlock);
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
                case Opc.Ua.Plc.BrowseNames.FunctionBlock:
                {
                    if (createOrReplace)
                    {
                        if (FunctionBlock == null)
                        {
                            if (replacement == null)
                            {
                                FunctionBlock = new BaseDataVariableState(this);
                            }
                            else
                            {
                                FunctionBlock = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = FunctionBlock;
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
        private BaseDataVariableState m_functionBlock;
        #endregion
    }
    #endif
    #endregion

    #region CtrlTaskState Class
    #if (!OPCUA_EXCLUDE_CtrlTaskState)
    /// <summary>
    /// Stores an instance of the CtrlTaskType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlTaskState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CtrlTaskState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.CtrlTaskType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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

            if (Interval != null)
            {
                Interval.Initialize(context, Interval_InitializationString);
            }

            if (Single != null)
            {
                Single.Initialize(context, Single_InitializationString);
            }
        }

        #region Initialization String
        private const string Interval_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIACAAAAEludGVydmFsAQL0AAAuAET0AAAAAAz/" +
           "////AQH/////AAAAAA==";

        private const string Single_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8VYIkKAgAAAAIABgAAAFNpbmdsZQEC9QAALgBE9QAAAAAM////" +
           "/wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIAFAAAAEN0cmxUYXNrVHlwZUluc3RhbmNlAQLy" +
           "AAEC8gD/////AwAAABVgiQoCAAAAAgAIAAAAUHJpb3JpdHkBAvMAAC4ARPMAAAAAB/////8BAf////8A" +
           "AAAAFWCJCgIAAAACAAgAAABJbnRlcnZhbAEC9AAALgBE9AAAAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAIABgAAAFNpbmdsZQEC9QAALgBE9QAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Priority Property.
        /// </summary>
        public PropertyState<uint> Priority
        {
            get
            {
                return m_priority;
            }

            set
            {
                if (!Object.ReferenceEquals(m_priority, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_priority = value;
            }
        }

        /// <summary>
        /// A description for the Interval Property.
        /// </summary>
        public PropertyState<string> Interval
        {
            get
            {
                return m_interval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_interval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_interval = value;
            }
        }

        /// <summary>
        /// A description for the Single Property.
        /// </summary>
        public PropertyState<string> Single
        {
            get
            {
                return m_single;
            }

            set
            {
                if (!Object.ReferenceEquals(m_single, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_single = value;
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
            if (m_priority != null)
            {
                children.Add(m_priority);
            }

            if (m_interval != null)
            {
                children.Add(m_interval);
            }

            if (m_single != null)
            {
                children.Add(m_single);
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
                case Opc.Ua.Plc.BrowseNames.Priority:
                {
                    if (createOrReplace)
                    {
                        if (Priority == null)
                        {
                            if (replacement == null)
                            {
                                Priority = new PropertyState<uint>(this);
                            }
                            else
                            {
                                Priority = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = Priority;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Interval:
                {
                    if (createOrReplace)
                    {
                        if (Interval == null)
                        {
                            if (replacement == null)
                            {
                                Interval = new PropertyState<string>(this);
                            }
                            else
                            {
                                Interval = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Interval;
                    break;
                }

                case Opc.Ua.Plc.BrowseNames.Single:
                {
                    if (createOrReplace)
                    {
                        if (Single == null)
                        {
                            if (replacement == null)
                            {
                                Single = new PropertyState<string>(this);
                            }
                            else
                            {
                                Single = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Single;
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
        private PropertyState<uint> m_priority;
        private PropertyState<string> m_interval;
        private PropertyState<string> m_single;
        #endregion
    }
    #endif
    #endregion

    #region SFCState Class
    #if (!OPCUA_EXCLUDE_SFCState)
    /// <summary>
    /// Stores an instance of the SFCType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SFCState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SFCState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Plc.ObjectTypes.SFCType, Opc.Ua.Plc.Namespaces.OpcUaPlc, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvJAAAAGh0dHA6Ly9QTENvcGVuLm9y" +
           "Zy9PcGNVYS9JRUM2MTEzMS0zL/////8EYIAAAQAAAAIADwAAAFNGQ1R5cGVJbnN0YW5jZQEC9gABAvYA" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}