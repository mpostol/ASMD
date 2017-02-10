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
using Opc.Ua.Adi;
using Opc.Ua.Di;
using Opc.Ua;

namespace FTNIR
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
        /// The identifier for the ExecutionCycleSubcodeEnumeration DataType.
        /// </summary>
        public const uint ExecutionCycleSubcodeEnumeration = 459;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_PowerOn Method.
        /// </summary>
        public const uint FTNIRSimulatorDeviceType_MethodSet_PowerOn = 251;

        /// <summary>
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_PowerOff Method.
        /// </summary>
        public const uint FTNIRSimulatorDeviceType_MethodSet_PowerOff = 252;

        /// <summary>
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_ClearAllChannels Method.
        /// </summary>
        public const uint FTNIRSimulatorDeviceType_MethodSet_ClearAllChannels = 253;
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
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet Object.
        /// </summary>
        public const uint FTNIRSimulatorDeviceType_MethodSet = 4;

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet Object.
        /// </summary>
        public const uint IRSourceType_ParameterSet = 255;

        /// <summary>
        /// The identifier for the IRSourceType_Configuration Object.
        /// </summary>
        public const uint IRSourceType_Configuration = 277;

        /// <summary>
        /// The identifier for the IRSourceType_Status Object.
        /// </summary>
        public const uint IRSourceType_Status = 279;

        /// <summary>
        /// The identifier for the IRSourceType_FactorySettings Object.
        /// </summary>
        public const uint IRSourceType_FactorySettings = 281;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet Object.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet = 301;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_Configuration Object.
        /// </summary>
        public const uint FTNIRDetectorType_Configuration = 323;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_Status Object.
        /// </summary>
        public const uint FTNIRDetectorType_Status = 325;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_FactorySettings Object.
        /// </summary>
        public const uint FTNIRDetectorType_FactorySettings = 327;

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet Object.
        /// </summary>
        public const uint LiquidCellType_ParameterSet = 347;

        /// <summary>
        /// The identifier for the LiquidCellType_Status Object.
        /// </summary>
        public const uint LiquidCellType_Status = 371;

        /// <summary>
        /// The identifier for the LiquidCellType_FactorySettings Object.
        /// </summary>
        public const uint LiquidCellType_FactorySettings = 373;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet Object.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet = 390;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_Configuration Object.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_Configuration = 412;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_Status Object.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_Status = 414;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_FactorySettings Object.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_FactorySettings = 416;
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
        /// The identifier for the FTNIRSimulatorDeviceType ObjectType.
        /// </summary>
        public const uint FTNIRSimulatorDeviceType = 1;

        /// <summary>
        /// The identifier for the IRSourceType ObjectType.
        /// </summary>
        public const uint IRSourceType = 254;

        /// <summary>
        /// The identifier for the FTNIRDetectorType ObjectType.
        /// </summary>
        public const uint FTNIRDetectorType = 300;

        /// <summary>
        /// The identifier for the LiquidCellType ObjectType.
        /// </summary>
        public const uint LiquidCellType = 346;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType ObjectType.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType = 389;
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
        /// The identifier for the IRSourceType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint IRSourceType_ParameterSet_Manufacturer = 285;

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_Model Variable.
        /// </summary>
        public const uint IRSourceType_ParameterSet_Model = 288;

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint IRSourceType_ParameterSet_SerialNumber = 291;

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint IRSourceType_ParameterSet_IsEnabled = 294;

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint IRSourceType_ParameterSet_ActualTemperature = 297;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet_Manufacturer = 331;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet_Model = 334;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet_SerialNumber = 337;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Gain Variable.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet_Gain = 340;

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_IsSaturated Variable.
        /// </summary>
        public const uint FTNIRDetectorType_ParameterSet_IsSaturated = 343;

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint LiquidCellType_ParameterSet_Manufacturer = 377;

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_Model Variable.
        /// </summary>
        public const uint LiquidCellType_ParameterSet_Model = 380;

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint LiquidCellType_ParameterSet_SerialNumber = 383;

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint LiquidCellType_ParameterSet_ActualTemperature = 386;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet_Manufacturer = 420;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_Model Variable.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet_Model = 423;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet_SerialNumber = 426;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_RequestedTemperature Variable.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet_RequestedTemperature = 429;

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint ControllableHeatedLiquidCellType_ParameterSet_ActualTemperature = 432;

        /// <summary>
        /// The identifier for the Concentration_QualityIndex Variable.
        /// </summary>
        public const uint Concentration_QualityIndex = 441;

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_FirstX Variable.
        /// </summary>
        public const uint SimplePeakHeightModelType_FirstX = 450;

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_LastX Variable.
        /// </summary>
        public const uint SimplePeakHeightModelType_LastX = 453;

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_PeakHeight Variable.
        /// </summary>
        public const uint SimplePeakHeightModelType_PeakHeight = 456;

        /// <summary>
        /// The identifier for the ExecutionCycleSubcodeEnumeration_EnumStrings Variable.
        /// </summary>
        public const uint ExecutionCycleSubcodeEnumeration_EnumStrings = 460;

        /// <summary>
        /// The identifier for the OpcFtnir_XmlSchema Variable.
        /// </summary>
        public const uint OpcFtnir_XmlSchema = 461;

        /// <summary>
        /// The identifier for the OpcFtnir_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcFtnir_XmlSchema_NamespaceUri = 463;

        /// <summary>
        /// The identifier for the OpcFtnir_BinarySchema Variable.
        /// </summary>
        public const uint OpcFtnir_BinarySchema = 464;

        /// <summary>
        /// The identifier for the OpcFtnir_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcFtnir_BinarySchema_NamespaceUri = 466;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the Concentration VariableType.
        /// </summary>
        public const uint Concentration = 435;

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType VariableType.
        /// </summary>
        public const uint SimplePeakHeightModelType = 444;
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
        /// The identifier for the ExecutionCycleSubcodeEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionCycleSubcodeEnumeration = new ExpandedNodeId(FTNIR.DataTypes.ExecutionCycleSubcodeEnumeration, FTNIR.Namespaces.OpcFtnir);
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
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_PowerOn Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRSimulatorDeviceType_MethodSet_PowerOn = new ExpandedNodeId(FTNIR.Methods.FTNIRSimulatorDeviceType_MethodSet_PowerOn, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_PowerOff Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRSimulatorDeviceType_MethodSet_PowerOff = new ExpandedNodeId(FTNIR.Methods.FTNIRSimulatorDeviceType_MethodSet_PowerOff, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet_ClearAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRSimulatorDeviceType_MethodSet_ClearAllChannels = new ExpandedNodeId(FTNIR.Methods.FTNIRSimulatorDeviceType_MethodSet_ClearAllChannels, FTNIR.Namespaces.OpcFtnir);
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
        /// The identifier for the FTNIRSimulatorDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRSimulatorDeviceType_MethodSet = new ExpandedNodeId(FTNIR.Objects.FTNIRSimulatorDeviceType_MethodSet, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet = new ExpandedNodeId(FTNIR.Objects.IRSourceType_ParameterSet, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_Configuration = new ExpandedNodeId(FTNIR.Objects.IRSourceType_Configuration, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_Status = new ExpandedNodeId(FTNIR.Objects.IRSourceType_Status, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_FactorySettings = new ExpandedNodeId(FTNIR.Objects.IRSourceType_FactorySettings, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet = new ExpandedNodeId(FTNIR.Objects.FTNIRDetectorType_ParameterSet, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_Configuration = new ExpandedNodeId(FTNIR.Objects.FTNIRDetectorType_Configuration, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_Status = new ExpandedNodeId(FTNIR.Objects.FTNIRDetectorType_Status, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_FactorySettings = new ExpandedNodeId(FTNIR.Objects.FTNIRDetectorType_FactorySettings, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_ParameterSet = new ExpandedNodeId(FTNIR.Objects.LiquidCellType_ParameterSet, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_Status = new ExpandedNodeId(FTNIR.Objects.LiquidCellType_Status, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_FactorySettings = new ExpandedNodeId(FTNIR.Objects.LiquidCellType_FactorySettings, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet = new ExpandedNodeId(FTNIR.Objects.ControllableHeatedLiquidCellType_ParameterSet, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_Configuration = new ExpandedNodeId(FTNIR.Objects.ControllableHeatedLiquidCellType_Configuration, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_Status = new ExpandedNodeId(FTNIR.Objects.ControllableHeatedLiquidCellType_Status, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_FactorySettings = new ExpandedNodeId(FTNIR.Objects.ControllableHeatedLiquidCellType_FactorySettings, FTNIR.Namespaces.OpcFtnir);
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
        /// The identifier for the FTNIRSimulatorDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRSimulatorDeviceType = new ExpandedNodeId(FTNIR.ObjectTypes.FTNIRSimulatorDeviceType, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType = new ExpandedNodeId(FTNIR.ObjectTypes.IRSourceType, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType = new ExpandedNodeId(FTNIR.ObjectTypes.FTNIRDetectorType, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType = new ExpandedNodeId(FTNIR.ObjectTypes.LiquidCellType, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType = new ExpandedNodeId(FTNIR.ObjectTypes.ControllableHeatedLiquidCellType, FTNIR.Namespaces.OpcFtnir);
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
        /// The identifier for the IRSourceType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIR.Variables.IRSourceType_ParameterSet_Manufacturer, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet_Model = new ExpandedNodeId(FTNIR.Variables.IRSourceType_ParameterSet_Model, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIR.Variables.IRSourceType_ParameterSet_SerialNumber, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIR.Variables.IRSourceType_ParameterSet_IsEnabled, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the IRSourceType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId IRSourceType_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIR.Variables.IRSourceType_ParameterSet_ActualTemperature, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIR.Variables.FTNIRDetectorType_ParameterSet_Manufacturer, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet_Model = new ExpandedNodeId(FTNIR.Variables.FTNIRDetectorType_ParameterSet_Model, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIR.Variables.FTNIRDetectorType_ParameterSet_SerialNumber, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_Gain Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet_Gain = new ExpandedNodeId(FTNIR.Variables.FTNIRDetectorType_ParameterSet_Gain, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the FTNIRDetectorType_ParameterSet_IsSaturated Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIRDetectorType_ParameterSet_IsSaturated = new ExpandedNodeId(FTNIR.Variables.FTNIRDetectorType_ParameterSet_IsSaturated, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIR.Variables.LiquidCellType_ParameterSet_Manufacturer, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_ParameterSet_Model = new ExpandedNodeId(FTNIR.Variables.LiquidCellType_ParameterSet_Model, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIR.Variables.LiquidCellType_ParameterSet_SerialNumber, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the LiquidCellType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId LiquidCellType_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIR.Variables.LiquidCellType_ParameterSet_ActualTemperature, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIR.Variables.ControllableHeatedLiquidCellType_ParameterSet_Manufacturer, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet_Model = new ExpandedNodeId(FTNIR.Variables.ControllableHeatedLiquidCellType_ParameterSet_Model, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIR.Variables.ControllableHeatedLiquidCellType_ParameterSet_SerialNumber, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_RequestedTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet_RequestedTemperature = new ExpandedNodeId(FTNIR.Variables.ControllableHeatedLiquidCellType_ParameterSet_RequestedTemperature, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ControllableHeatedLiquidCellType_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllableHeatedLiquidCellType_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIR.Variables.ControllableHeatedLiquidCellType_ParameterSet_ActualTemperature, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the Concentration_QualityIndex Variable.
        /// </summary>
        public static readonly ExpandedNodeId Concentration_QualityIndex = new ExpandedNodeId(FTNIR.Variables.Concentration_QualityIndex, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_FirstX Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimplePeakHeightModelType_FirstX = new ExpandedNodeId(FTNIR.Variables.SimplePeakHeightModelType_FirstX, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_LastX Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimplePeakHeightModelType_LastX = new ExpandedNodeId(FTNIR.Variables.SimplePeakHeightModelType_LastX, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType_PeakHeight Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimplePeakHeightModelType_PeakHeight = new ExpandedNodeId(FTNIR.Variables.SimplePeakHeightModelType_PeakHeight, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the ExecutionCycleSubcodeEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionCycleSubcodeEnumeration_EnumStrings = new ExpandedNodeId(FTNIR.Variables.ExecutionCycleSubcodeEnumeration_EnumStrings, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the OpcFtnir_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcFtnir_XmlSchema = new ExpandedNodeId(FTNIR.Variables.OpcFtnir_XmlSchema, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the OpcFtnir_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcFtnir_XmlSchema_NamespaceUri = new ExpandedNodeId(FTNIR.Variables.OpcFtnir_XmlSchema_NamespaceUri, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the OpcFtnir_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcFtnir_BinarySchema = new ExpandedNodeId(FTNIR.Variables.OpcFtnir_BinarySchema, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the OpcFtnir_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcFtnir_BinarySchema_NamespaceUri = new ExpandedNodeId(FTNIR.Variables.OpcFtnir_BinarySchema_NamespaceUri, FTNIR.Namespaces.OpcFtnir);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the Concentration VariableType.
        /// </summary>
        public static readonly ExpandedNodeId Concentration = new ExpandedNodeId(FTNIR.VariableTypes.Concentration, FTNIR.Namespaces.OpcFtnir);

        /// <summary>
        /// The identifier for the SimplePeakHeightModelType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId SimplePeakHeightModelType = new ExpandedNodeId(FTNIR.VariableTypes.SimplePeakHeightModelType, FTNIR.Namespaces.OpcFtnir);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Concentration component.
        /// </summary>
        public const string Concentration = "Concentration";

        /// <summary>
        /// The BrowseName for the ControllableHeatedLiquidCellType component.
        /// </summary>
        public const string ControllableHeatedLiquidCellType = "ControllableHeatedLiquidCellType";

        /// <summary>
        /// The BrowseName for the ExecutionCycleSubcodeEnumeration component.
        /// </summary>
        public const string ExecutionCycleSubcodeEnumeration = "ExecutionCycleSubcodeEnumeration";

        /// <summary>
        /// The BrowseName for the FirstX component.
        /// </summary>
        public const string FirstX = "FirstX";

        /// <summary>
        /// The BrowseName for the FTNIRDetectorType component.
        /// </summary>
        public const string FTNIRDetectorType = "FTNIRDetectorType";

        /// <summary>
        /// The BrowseName for the FTNIRSimulatorDeviceType component.
        /// </summary>
        public const string FTNIRSimulatorDeviceType = "FTNIRSimulatorDeviceType";

        /// <summary>
        /// The BrowseName for the IRSourceType component.
        /// </summary>
        public const string IRSourceType = "IRSourceType";

        /// <summary>
        /// The BrowseName for the LastX component.
        /// </summary>
        public const string LastX = "LastX";

        /// <summary>
        /// The BrowseName for the LiquidCellType component.
        /// </summary>
        public const string LiquidCellType = "LiquidCellType";

        /// <summary>
        /// The BrowseName for the OpcFtnir_BinarySchema component.
        /// </summary>
        public const string OpcFtnir_BinarySchema = "FTNIR";

        /// <summary>
        /// The BrowseName for the OpcFtnir_XmlSchema component.
        /// </summary>
        public const string OpcFtnir_XmlSchema = "FTNIR";

        /// <summary>
        /// The BrowseName for the PeakHeight component.
        /// </summary>
        public const string PeakHeight = "PeakHeight";

        /// <summary>
        /// The BrowseName for the QualityIndex component.
        /// </summary>
        public const string QualityIndex = "QualityIndex";

        /// <summary>
        /// The BrowseName for the SimplePeakHeightModelType component.
        /// </summary>
        public const string SimplePeakHeightModelType = "SimplePeakHeightModelType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcFtnir namespace (.NET code namespace is 'FTNIR').
        /// </summary>
        public const string OpcFtnir = "http://opcfoundation.org/UA/FTNIR/";

        /// <summary>
        /// The URI for the OpcFtnirXsd namespace (.NET code namespace is 'FTNIR').
        /// </summary>
        public const string OpcFtnirXsd = "http://opcfoundation.org/UA/FTNIR/Types.xsd";

        /// <summary>
        /// The URI for the OpcAdi namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcAdi = "http://opcfoundation.org/UA/ADI/";

        /// <summary>
        /// The URI for the OpcAdiXsd namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcAdiXsd = "http://opcfoundation.org/UA/ADI/Types.xsd";

        /// <summary>
        /// The URI for the OpcDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion

    #region FTNIRSimulatorDeviceState Class
    #if (!OPCUA_EXCLUDE_FTNIRSimulatorDeviceState)
    /// <summary>
    /// Stores an instance of the FTNIRSimulatorDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FTNIRSimulatorDeviceState : SpectrometerDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FTNIRSimulatorDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.ObjectTypes.FTNIRSimulatorDeviceType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////hGCA" +
           "AAEAAAABACAAAABGVE5JUlNpbXVsYXRvckRldmljZVR5cGVJbnN0YW5jZQEBAQABAQEAAf////8OAAAA" +
           "JGCACgEAAAADAAkAAABNZXRob2RTZXQBAQQAAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6" +
           "BAAAAP////8NAAAABGGCCgQAAAACABAAAABHZXRDb25maWd1cmF0aW9uAQFBAAAvAQJZC0EAAAABAf//" +
           "//8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUIAAC4AREIAAACWAQAAAAEAKgEBGQAA" +
           "AAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAIAEAAAAFNl" +
           "dENvbmZpZ3VyYXRpb24BAUMAAC8BAlsLQwAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFEAAAuAEREAAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUUAAC4AREUAAACWAQAA" +
           "AAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAIAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAUYAAC8BAl4LRgAAAAEB/////wEAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBRwAALgBERwAAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZp" +
           "Z0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAgAXAAAAQ29tcGFy" +
           "ZUNvbmZpZ0RhdGFEaWdlc3QBAUgAAC8BAmALSAAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQFJAAAuAERJAAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUoAAC4A" +
           "REoAAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAAAAABACgBAQAAAAEB/////wAAAAAk" +
           "YYIKBAAAAAIAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAUsAAwAAAAA8AAAAUmVzZXQgYWxsIEFuYWx5c2Vy" +
           "Q2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAmMLSwAAAAEB/////wAA" +
           "AAAkYYIKBAAAAAIAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAUwAAwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5" +
           "c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAmQLTAAAAAEB////" +
           "/wAAAAAkYYIKBAAAAAIADwAAAFN0b3BBbGxDaGFubmVscwEBTQADAAAAADsAAABTdG9wIGFsbCBBbmFs" +
           "eXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQJlC00AAAABAf//" +
           "//8AAAAAJGGCCgQAAAACABAAAABBYm9ydEFsbENoYW5uZWxzAQFOAAMAAAAAPAAAAEFib3J0IGFsbCBB" +
           "bmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQJmC04AAAAB" +
           "Af////8AAAAAJGGCCgQAAAACAA0AAABHb3RvT3BlcmF0aW5nAQFPAAMAAAAAjQAAAEFuYWx5c2VyRGV2" +
           "aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlz" +
           "ZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0" +
           "aW5nIHN0YXRlLgAvAQJnC08AAAABAf////8AAAAAJGGCCgQAAAACAA8AAABHb3RvTWFpbnRlbmFuY2UB" +
           "AVAAAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ug" +
           "c3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVNb2RlIHN0YXRlLgAvAQJo" +
           "C1AAAAABAf////8AAAAAJGGCCgQAAAABAAcAAABQb3dlck9uAQH7AAMAAAAAJAAAAFNpbXVsYXRlIGFu" +
           "YWx5c2VyIHBvd2VyIG9uIHNlcXVlbmNlLgAvAQH7APsAAAABAf////8AAAAAJGGCCgQAAAABAAgAAABQ" +
           "b3dlck9mZgEB/AADAAAAACUAAABTaW11bGF0ZSBhbmFseXNlciBwb3dlciBvZmYgc2VxdWVuY2UuAC8B" +
           "AfwA/AAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAENsZWFyQWxsQ2hhbm5lbHMBAf0AAwAAAAAbAAAA" +
           "Q2FsbCBDbGVhciBvbiBhbGwgY2hhbm5lbHMuAC8BAf0A/QAAAAEB/////wAAAAAkYIAKAQAAAAMADgAA" +
           "AElkZW50aWZpY2F0aW9uAQEIAAMAAAAARgAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3Ig" +
           "aWRlbnRpZmljYXRpb24gb2YgdGhpcyBUb3BvbG9neUVsZW1lbnQALwED4S8IAAAAAwAAAAAjAAED7i8A" +
           "IwABA+8vACMAAQPsLwAAAAA1YIkKAgAAAAMADAAAAFNlcmlhbE51bWJlcgEBGAADAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQYAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAwAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQEZAAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAEQZAAAAAAb/////AQH/////AAAAADVgiQoCAAAAAwAMAAAATWFudWZhY3R1cmVyAQEaAAMA" +
           "AAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAEQaAAAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAwAFAAAATW9kZWwBARsAAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0" +
           "dXJlZCB0aGUgZGV2aWNlAC4ARBsAAAAAFf////8BAf////8AAAAANWCJCgIAAAADAAwAAABEZXZpY2VN" +
           "YW51YWwBARwAAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARBwAAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAADAA4AAABEZXZpY2VSZXZpc2lvbgEBHQADAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEHQAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAMAEAAAAFNvZnR3YXJlUmV2aXNpb24BAR4AAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEHgAAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAMAEAAAAEhhcmR3YXJlUmV2aXNpb24BAR8AAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEHwAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAIADQAAAENv" +
           "bmZpZ3VyYXRpb24BAWgAAC8BA+EvaAAAAAEAAAAAIwABAVQAAAAAAARggAoBAAAAAgAGAAAAU3RhdHVz" +
           "AQFqAAAvAQPhL2oAAAABAAAAACMAAQFRAAAAAAAEYIAKAQAAAAIADwAAAEZhY3RvcnlTZXR0aW5ncwEB" +
           "bAAALwED4S9sAAAA/////wAAAAAEYIAKAQAAAAIAFAAAAEFuYWx5c2VyU3RhdGVNYWNoaW5lAQFuAAAv" +
           "AQJjBG4AAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQFvAAAvAQDICm8AAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBcAAALgBEcAAAAAAR/////wEB/////wAAAAA=";
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

    #region IRSourceState Class
    #if (!OPCUA_EXCLUDE_IRSourceState)
    /// <summary>
    /// Stores an instance of the IRSourceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IRSourceState : SourceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IRSourceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.ObjectTypes.IRSourceType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////BGCA" +
           "AAEAAAABABQAAABJUlNvdXJjZVR5cGVJbnN0YW5jZQEB/gABAf4A/////wYAAAAkYIAKAQAAAAMADAAA" +
           "AFBhcmFtZXRlclNldAEB/wADAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADr/AAAA////" +
           "/wUAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgEBHQEALwEAPQkdAQAAABX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAFAAAATW9kZWwBASABAC8BAD0JIAEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DAAAAFNlcmlhbE51bWJlcgEBIwEALwEAPQkjAQAAAAz/////AQH/////AAAAABVwiQoCAAAAAQAJAAAA" +
           "SXNFbmFibGVkAQEmAQAvAQA9CSYBAAAAAf////8BAQAAAAAAQI9A/////wAAAAAVcIkKAgAAAAEAEQAA" +
           "AEFjdHVhbFRlbXBlcmF0dXJlAQEpAQAvAQA9CSkBAAAACv////8BAQAAAAAAQI9A/////wAAAAAEYIAK" +
           "AQAAAAIADQAAAENvbmZpZ3VyYXRpb24BARUBAC8BA+EvFQEAAAEAAAAAIwABASYBAAAAAARggAoBAAAA" +
           "AgAGAAAAU3RhdHVzAQEXAQAvAQPhLxcBAAABAAAAACMAAQEpAQAAAAAEYIAKAQAAAAIADwAAAEZhY3Rv" +
           "cnlTZXR0aW5ncwEBGQEALwED4S8ZAQAAAwAAAAAjAAEBHQEAIwABASABACMAAQEjAQAAAAA1YIkKAgAA" +
           "AAIADgAAAElzSG90U3dhcHBhYmxlAQEbAQMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2Fu" +
           "IGJlIGluc2VydGVkIGluIHRoZSBhY2Nlc3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARBsB" +
           "AAAAAf////8BAf////8AAAAANWCJCgIAAAACAAcAAABJc1JlYWR5AQEcAQMAAAAAJwAAAFRydWUgaWYg" +
           "dGhpcyBhY2Nlc3NvcnkgaXMgcmVhZHkgZm9yIHVzZQAuAEQcAQAAAAH/////AQH/////AAAAAA==";
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

    #region FTNIRDetectorState Class
    #if (!OPCUA_EXCLUDE_FTNIRDetectorState)
    /// <summary>
    /// Stores an instance of the FTNIRDetectorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FTNIRDetectorState : DetectorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FTNIRDetectorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.ObjectTypes.FTNIRDetectorType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////BGCA" +
           "AAEAAAABABkAAABGVE5JUkRldGVjdG9yVHlwZUluc3RhbmNlAQEsAQEBLAH/////BgAAACRggAoBAAAA" +
           "AwAMAAAAUGFyYW1ldGVyU2V0AQEtAQMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOi0B" +
           "AAD/////BQAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQFLAQAvAQA9CUsBAAAAFf////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAEBTgEALwEAPQlOAQAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAMAAAAU2VyaWFsTnVtYmVyAQFRAQAvAQA9CVEBAAAADP////8BAf////8AAAAAFXCJCgIAAAAB" +
           "AAQAAABHYWluAQFUAQAvAQA9CVQBAAAAB/////8BAQAAAAAAQI9A/////wAAAAAVcIkKAgAAAAEACwAA" +
           "AElzU2F0dXJhdGVkAQFXAQAvAQA9CVcBAAAAAf////8BAQAAAAAAQI9A/////wAAAAAEYIAKAQAAAAIA" +
           "DQAAAENvbmZpZ3VyYXRpb24BAUMBAC8BA+EvQwEAAAEAAAAAIwABAVQBAAAAAARggAoBAAAAAgAGAAAA" +
           "U3RhdHVzAQFFAQAvAQPhL0UBAAABAAAAACMAAQFXAQAAAAAEYIAKAQAAAAIADwAAAEZhY3RvcnlTZXR0" +
           "aW5ncwEBRwEALwED4S9HAQAAAwAAAAAjAAEBSwEAIwABAU4BACMAAQFRAQAAAAA1YIkKAgAAAAIADgAA" +
           "AElzSG90U3dhcHBhYmxlAQFJAQMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGlu" +
           "c2VydGVkIGluIHRoZSBhY2Nlc3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4AREkBAAAAAf//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAcAAABJc1JlYWR5AQFKAQMAAAAAJwAAAFRydWUgaWYgdGhpcyBh" +
           "Y2Nlc3NvcnkgaXMgcmVhZHkgZm9yIHVzZQAuAERKAQAAAAH/////AQH/////AAAAAA==";
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

    #region LiquidCellState Class
    #if (!OPCUA_EXCLUDE_LiquidCellState)
    /// <summary>
    /// Stores an instance of the LiquidCellType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LiquidCellState : SmartSamplingSystemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LiquidCellState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.ObjectTypes.LiquidCellType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////BGCA" +
           "AAEAAAABABYAAABMaXF1aWRDZWxsVHlwZUluc3RhbmNlAQFaAQEBWgH/////BgAAACRggAoBAAAAAwAM" +
           "AAAAUGFyYW1ldGVyU2V0AQFbAQMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOlsBAAD/" +
           "////BAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQF5AQAvAQA9CXkBAAAAFf////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAUAAABNb2RlbAEBfAEALwEAPQl8AQAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAMAAAAU2VyaWFsTnVtYmVyAQF/AQAvAQA9CX8BAAAADP////8BAf////8AAAAAFXCJCgIAAAABABEA" +
           "AABBY3R1YWxUZW1wZXJhdHVyZQEBggEALwEAPQmCAQAAAAr/////AQEAAAAAAECPQP////8AAAAABGCA" +
           "CgEAAAACAA0AAABDb25maWd1cmF0aW9uAQFxAQAvAQPhL3EBAAD/////AAAAAARggAoBAAAAAgAGAAAA" +
           "U3RhdHVzAQFzAQAvAQPhL3MBAAABAAAAACMAAQGCAQAAAAAEYIAKAQAAAAIADwAAAEZhY3RvcnlTZXR0" +
           "aW5ncwEBdQEALwED4S91AQAAAwAAAAAjAAEBeQEAIwABAXwBACMAAQF/AQAAAAA1YIkKAgAAAAIADgAA" +
           "AElzSG90U3dhcHBhYmxlAQF3AQMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGlu" +
           "c2VydGVkIGluIHRoZSBhY2Nlc3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARHcBAAAAAf//" +
           "//8BAf////8AAAAANWCJCgIAAAACAAcAAABJc1JlYWR5AQF4AQMAAAAAJwAAAFRydWUgaWYgdGhpcyBh" +
           "Y2Nlc3NvcnkgaXMgcmVhZHkgZm9yIHVzZQAuAER4AQAAAAH/////AQH/////AAAAAA==";
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

    #region ControllableHeatedLiquidCellState Class
    #if (!OPCUA_EXCLUDE_ControllableHeatedLiquidCellState)
    /// <summary>
    /// Stores an instance of the ControllableHeatedLiquidCellType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllableHeatedLiquidCellState : SmartSamplingSystemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ControllableHeatedLiquidCellState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.ObjectTypes.ControllableHeatedLiquidCellType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////BGCA" +
           "AAEAAAABACgAAABDb250cm9sbGFibGVIZWF0ZWRMaXF1aWRDZWxsVHlwZUluc3RhbmNlAQGFAQEBhQH/" +
           "////BgAAACRggAoBAAAAAwAMAAAAUGFyYW1ldGVyU2V0AQGGAQMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQ" +
           "YXJhbWV0ZXJzAC8AOoYBAAD/////BQAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQGkAQAvAQA9" +
           "CaQBAAAAFf////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAEBpwEALwEAPQmnAQAAABX/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQGqAQAvAQA9CaoBAAAADP////8BAf//" +
           "//8AAAAAFXCJCgIAAAABABQAAABSZXF1ZXN0ZWRUZW1wZXJhdHVyZQEBrQEALwEAPQmtAQAAAAr/////" +
           "AQEAAAAAAECPQP////8AAAAAFXCJCgIAAAABABEAAABBY3R1YWxUZW1wZXJhdHVyZQEBsAEALwEAPQmw" +
           "AQAAAAr/////AQEAAAAAAECPQP////8AAAAABGCACgEAAAACAA0AAABDb25maWd1cmF0aW9uAQGcAQAv" +
           "AQPhL5wBAAABAAAAACMAAQGtAQAAAAAEYIAKAQAAAAIABgAAAFN0YXR1cwEBngEALwED4S+eAQAAAQAA" +
           "AAAjAAEBsAEAAAAABGCACgEAAAACAA8AAABGYWN0b3J5U2V0dGluZ3MBAaABAC8BA+EvoAEAAAMAAAAA" +
           "IwABAaQBACMAAQGnAQAjAAEBqgEAAAAANWCJCgIAAAACAA4AAABJc0hvdFN3YXBwYWJsZQEBogEDAAAA" +
           "AFAAAABUcnVlIGlmIHRoaXMgYWNjZXNzb3J5IGNhbiBiZSBpbnNlcnRlZCBpbiB0aGUgYWNjZXNzb3J5" +
           "IHNsb3Qgd2hpbGUgaXQgaXMgcG93ZXJlZAAuAESiAQAAAAH/////AQH/////AAAAADVgiQoCAAAAAgAH" +
           "AAAASXNSZWFkeQEBowEDAAAAACcAAABUcnVlIGlmIHRoaXMgYWNjZXNzb3J5IGlzIHJlYWR5IGZvciB1" +
           "c2UALgBEowEAAAAB/////wEB/////wAAAAA=";
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

    #region ConcentrationState Class
    #if (!OPCUA_EXCLUDE_ConcentrationState)
    /// <summary>
    /// Stores an instance of the Concentration VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationState : EngineeringValueState<float>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConcentrationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.VariableTypes.Concentration, FTNIR.Namespaces.OpcFtnir, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Float, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////FXCB" +
           "AAIAAAABABUAAABDb25jZW50cmF0aW9uSW5zdGFuY2UBAbMBAQGzAQAKAQEAAAAAAECPQP////8BAAAA" +
           "FXCJCgIAAAABAAwAAABRdWFsaXR5SW5kZXgBAbkBAC8BAD0JuQEAAAAK/////wEBAAAAAABAj0D/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the QualityIndex Variable.
        /// </summary>
        public DataItemState<float> QualityIndex
        {
            get
            {
                return m_qualityIndex;
            }

            set
            {
                if (!Object.ReferenceEquals(m_qualityIndex, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_qualityIndex = value;
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
            if (m_qualityIndex != null)
            {
                children.Add(m_qualityIndex);
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
                case FTNIR.BrowseNames.QualityIndex:
                {
                    if (createOrReplace)
                    {
                        if (QualityIndex == null)
                        {
                            if (replacement == null)
                            {
                                QualityIndex = new DataItemState<float>(this);
                            }
                            else
                            {
                                QualityIndex = (DataItemState<float>)replacement;
                            }
                        }
                    }

                    instance = QualityIndex;
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
        private DataItemState<float> m_qualityIndex;
        #endregion
    }
    #endif
    #endregion

    #region SimplePeakHeightModelState Class
    #if (!OPCUA_EXCLUDE_SimplePeakHeightModelState)
    /// <summary>
    /// Stores an instance of the SimplePeakHeightModelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SimplePeakHeightModelState : ChemometricModelState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SimplePeakHeightModelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FTNIR.VariableTypes.SimplePeakHeightModelType, FTNIR.Namespaces.OpcFtnir, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.ByteString, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
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
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlROSVIvIAAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9BREkvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////FWCJ" +
           "AAIAAAABACEAAABTaW1wbGVQZWFrSGVpZ2h0TW9kZWxUeXBlSW5zdGFuY2UBAbwBAQG8AQAP/////wEB" +
           "AQAAAAECKgsAAQHIAQYAAAAVYIkKAgAAAAIABAAAAE5hbWUBAb0BAC4ARL0BAAAAFf////8BAf////8A" +
           "AAAAFWCJCgIAAAACAAwAAABDcmVhdGlvbkRhdGUBAb4BAC4ARL4BAAAADf////8BAf////8AAAAAFWCJ" +
           "CgIAAAACABAAAABNb2RlbERlc2NyaXB0aW9uAQG/AQAuAES/AQAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAGAAAARmlyc3RYAQHCAQMAAAAAJwAAAEZyZXF1ZW5jeSBvZiB0aGUgc3RhcnRpbmcgcG9pbnQg" +
           "aW4gY20tMQAvAQA9CcIBAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAUAAABMYXN0WAEBxQEDAAAA" +
           "ACMAAABGcmVxdWVuY3kgb2YgdGhlIGxhc3QgcG9pbnQgaW4gY20tMQAvAQA9CcUBAAAAC/////8BAf//" +
           "//8AAAAANXCJCgIAAAABAAoAAABQZWFrSGVpZ2h0AQHIAQMAAAAAGAAAAFBlYWsgaGVpZ2h0IG91dHB1" +
           "dCB2YWx1ZQAvAQA9CcgBAAAACv////8BAQAAAAAAQI9AAQAAAAECKgsBAQG8AQAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Frequency of the starting point in cm-1
        /// </summary>
        public DataItemState<double> FirstX
        {
            get
            {
                return m_firstX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firstX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firstX = value;
            }
        }

        /// <summary>
        /// Frequency of the last point in cm-1
        /// </summary>
        public DataItemState<double> LastX
        {
            get
            {
                return m_lastX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastX = value;
            }
        }

        /// <summary>
        /// Peak height output value
        /// </summary>
        public DataItemState<float> PeakHeight
        {
            get
            {
                return m_peakHeight;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peakHeight, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peakHeight = value;
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
            if (m_firstX != null)
            {
                children.Add(m_firstX);
            }

            if (m_lastX != null)
            {
                children.Add(m_lastX);
            }

            if (m_peakHeight != null)
            {
                children.Add(m_peakHeight);
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
                case FTNIR.BrowseNames.FirstX:
                {
                    if (createOrReplace)
                    {
                        if (FirstX == null)
                        {
                            if (replacement == null)
                            {
                                FirstX = new DataItemState<double>(this);
                            }
                            else
                            {
                                FirstX = (DataItemState<double>)replacement;
                            }
                        }
                    }

                    instance = FirstX;
                    break;
                }

                case FTNIR.BrowseNames.LastX:
                {
                    if (createOrReplace)
                    {
                        if (LastX == null)
                        {
                            if (replacement == null)
                            {
                                LastX = new DataItemState<double>(this);
                            }
                            else
                            {
                                LastX = (DataItemState<double>)replacement;
                            }
                        }
                    }

                    instance = LastX;
                    break;
                }

                case FTNIR.BrowseNames.PeakHeight:
                {
                    if (createOrReplace)
                    {
                        if (PeakHeight == null)
                        {
                            if (replacement == null)
                            {
                                PeakHeight = new DataItemState<float>(this);
                            }
                            else
                            {
                                PeakHeight = (DataItemState<float>)replacement;
                            }
                        }
                    }

                    instance = PeakHeight;
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
        private DataItemState<double> m_firstX;
        private DataItemState<double> m_lastX;
        private DataItemState<float> m_peakHeight;
        #endregion
    }
    #endif
    #endregion

    #region ExecutionCycleSubcodeEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_ExecutionCycleSubcodeEnumeration)
    /// <summary>
    /// A description for the ExecutionCycleSubcodeEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = FTNIR.Namespaces.OpcFtnirXsd)]
    public enum ExecutionCycleSubcodeEnumeration
    {
        /// <summary>
        /// A description for the Normal field.
        /// </summary>
        [EnumMember(Value = "Normal_0")]
        Normal = 0,
    }
    #endif
    #endregion
}