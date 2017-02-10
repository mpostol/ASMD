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

namespace Opc.Ua.Di
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
        /// The identifier for the DeviceHealthEnumeration DataType.
        /// </summary>
        public const uint DeviceHealthEnumeration = 6244;

        /// <summary>
        /// The identifier for the FetchResultDataType DataType.
        /// </summary>
        public const uint FetchResultDataType = 6522;

        /// <summary>
        /// The identifier for the FetchResultErrorDataType DataType.
        /// </summary>
        public const uint FetchResultErrorDataType = 6523;

        /// <summary>
        /// The identifier for the FetchResultDataDataType DataType.
        /// </summary>
        public const uint FetchResultDataDataType = 6524;

        /// <summary>
        /// The identifier for the ParameterResultDataType DataType.
        /// </summary>
        public const uint ParameterResultDataType = 6525;
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
        /// The identifier for the TopologyElementType_MethodSet_MethodIdentifier Method.
        /// </summary>
        public const uint TopologyElementType_MethodSet_MethodIdentifier = 6018;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock = 6166;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock = 6169;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock = 6171;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock = 6173;

        /// <summary>
        /// The identifier for the FunctionalGroupType_MethodIdentifier Method.
        /// </summary>
        public const uint FunctionalGroupType_MethodIdentifier = 6029;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_InitLock = 6299;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock = 6302;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock = 6304;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock = 6306;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock = 6605;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock = 6608;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock = 6610;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock = 6612;

        /// <summary>
        /// The identifier for the TransferToDeviceMethodType Method.
        /// </summary>
        public const uint TransferToDeviceMethodType = 6515;

        /// <summary>
        /// The identifier for the TransferFromDeviceMethodType Method.
        /// </summary>
        public const uint TransferFromDeviceMethodType = 6517;

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType Method.
        /// </summary>
        public const uint FetchTransferResultDataMethodType = 6519;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice Method.
        /// </summary>
        public const uint TransferServicesType_TransferToDevice = 6527;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice Method.
        /// </summary>
        public const uint TransferServicesType_TransferFromDevice = 6529;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData Method.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData = 6531;

        /// <summary>
        /// The identifier for the InitLockMethodType Method.
        /// </summary>
        public const uint InitLockMethodType = 6458;

        /// <summary>
        /// The identifier for the RenewLockMethodType Method.
        /// </summary>
        public const uint RenewLockMethodType = 6461;

        /// <summary>
        /// The identifier for the ExitLockMethodType Method.
        /// </summary>
        public const uint ExitLockMethodType = 6463;

        /// <summary>
        /// The identifier for the BreakLockMethodType Method.
        /// </summary>
        public const uint BreakLockMethodType = 6465;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock Method.
        /// </summary>
        public const uint LockingServicesType_InitLock = 6393;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock Method.
        /// </summary>
        public const uint LockingServicesType_RenewLock = 6396;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock Method.
        /// </summary>
        public const uint LockingServicesType_ExitLock = 6398;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock Method.
        /// </summary>
        public const uint LockingServicesType_BreakLock = 6400;
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
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public const uint DeviceSet = 5001;

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public const uint NetworkSet = 6078;

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public const uint DeviceTopology = 6094;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public const uint TopologyElementType_ParameterSet = 5002;

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public const uint TopologyElementType_MethodSet = 5003;

        /// <summary>
        /// The identifier for the TopologyElementType_GroupIdentifier Object.
        /// </summary>
        public const uint TopologyElementType_GroupIdentifier = 6567;

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public const uint TopologyElementType_Identification = 6014;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public const uint TopologyElementType_Lock = 6161;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage Object.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage = 6209;

        /// <summary>
        /// The identifier for the DeviceType_Documentation Object.
        /// </summary>
        public const uint DeviceType_Documentation = 6211;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport Object.
        /// </summary>
        public const uint DeviceType_ProtocolSupport = 6213;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet Object.
        /// </summary>
        public const uint DeviceType_ImageSet = 6215;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier Object.
        /// </summary>
        public const uint DeviceType_CPIdentifier = 6571;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint DeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_SupportedTypes Object.
        /// </summary>
        public const uint ConfigurableObjectType_SupportedTypes = 5004;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_ObjectIdentifier Object.
        /// </summary>
        public const uint ConfigurableObjectType_ObjectIdentifier = 6026;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier Object.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier = 6027;

        /// <summary>
        /// The identifier for the NetworkType_ProfileIdentifier Object.
        /// </summary>
        public const uint NetworkType_ProfileIdentifier = 6596;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier = 6248;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkAddress = 6292;

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public const uint NetworkType_Lock = 6294;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkAddress = 6354;

        /// <summary>
        /// The identifier for the ConnectionPointType_ProfileId Object.
        /// </summary>
        public const uint ConnectionPointType_ProfileId = 6499;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier = 6599;

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint FetchResultDataType_Encoding_DefaultXml = 6535;

        /// <summary>
        /// The identifier for the FetchResultErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint FetchResultErrorDataType_Encoding_DefaultXml = 6536;

        /// <summary>
        /// The identifier for the FetchResultDataDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint FetchResultDataDataType_Encoding_DefaultXml = 6537;

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ParameterResultDataType_Encoding_DefaultXml = 6538;

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint FetchResultDataType_Encoding_DefaultBinary = 6551;

        /// <summary>
        /// The identifier for the FetchResultErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint FetchResultErrorDataType_Encoding_DefaultBinary = 6552;

        /// <summary>
        /// The identifier for the FetchResultDataDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint FetchResultDataDataType_Encoding_DefaultBinary = 6553;

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ParameterResultDataType_Encoding_DefaultBinary = 6554;
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
        /// The identifier for the TopologyElementType ObjectType.
        /// </summary>
        public const uint TopologyElementType = 1001;

        /// <summary>
        /// The identifier for the DeviceType ObjectType.
        /// </summary>
        public const uint DeviceType = 1002;

        /// <summary>
        /// The identifier for the BlockType ObjectType.
        /// </summary>
        public const uint BlockType = 1003;

        /// <summary>
        /// The identifier for the ConfigurableObjectType ObjectType.
        /// </summary>
        public const uint ConfigurableObjectType = 1004;

        /// <summary>
        /// The identifier for the FunctionalGroupType ObjectType.
        /// </summary>
        public const uint FunctionalGroupType = 1005;

        /// <summary>
        /// The identifier for the ProtocolType ObjectType.
        /// </summary>
        public const uint ProtocolType = 1006;

        /// <summary>
        /// The identifier for the NetworkType ObjectType.
        /// </summary>
        public const uint NetworkType = 6247;

        /// <summary>
        /// The identifier for the ConnectionPointType ObjectType.
        /// </summary>
        public const uint ConnectionPointType = 6308;

        /// <summary>
        /// The identifier for the TransferServicesType ObjectType.
        /// </summary>
        public const uint TransferServicesType = 6526;

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public const uint LockingServicesType = 6388;
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
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public const uint ConnectsTo = 6030;

        /// <summary>
        /// The identifier for the ConnectsToParent ReferenceType.
        /// </summary>
        public const uint ConnectsToParent = 6467;

        /// <summary>
        /// The identifier for the IsOnline ReferenceType.
        /// </summary>
        public const uint IsOnline = 6031;
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
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public const uint DeviceTopology_OnlineAccess = 6095;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public const uint TopologyElementType_ParameterSet_ParameterIdentifier = 6017;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_Locked Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_Locked = 6468;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingClient Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingClient = 6163;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingUser Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingUser = 6164;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RemainingLockTime = 6165;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_InputArguments = 6167;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_OutputArguments = 6168;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock_OutputArguments = 6170;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock_OutputArguments = 6172;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock_OutputArguments = 6174;

        /// <summary>
        /// The identifier for the DeviceType_SerialNumber Variable.
        /// </summary>
        public const uint DeviceType_SerialNumber = 6001;

        /// <summary>
        /// The identifier for the DeviceType_RevisionCounter Variable.
        /// </summary>
        public const uint DeviceType_RevisionCounter = 6002;

        /// <summary>
        /// The identifier for the DeviceType_Manufacturer Variable.
        /// </summary>
        public const uint DeviceType_Manufacturer = 6003;

        /// <summary>
        /// The identifier for the DeviceType_Model Variable.
        /// </summary>
        public const uint DeviceType_Model = 6004;

        /// <summary>
        /// The identifier for the DeviceType_DeviceManual Variable.
        /// </summary>
        public const uint DeviceType_DeviceManual = 6005;

        /// <summary>
        /// The identifier for the DeviceType_DeviceRevision Variable.
        /// </summary>
        public const uint DeviceType_DeviceRevision = 6006;

        /// <summary>
        /// The identifier for the DeviceType_SoftwareRevision Variable.
        /// </summary>
        public const uint DeviceType_SoftwareRevision = 6007;

        /// <summary>
        /// The identifier for the DeviceType_HardwareRevision Variable.
        /// </summary>
        public const uint DeviceType_HardwareRevision = 6008;

        /// <summary>
        /// The identifier for the DeviceType_DeviceClass Variable.
        /// </summary>
        public const uint DeviceType_DeviceClass = 6470;

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealth Variable.
        /// </summary>
        public const uint DeviceType_DeviceHealth = 6208;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage_ImageIdentifier = 6210;

        /// <summary>
        /// The identifier for the DeviceType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public const uint DeviceType_Documentation_DocumentIdentifier = 6212;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ProtocolSupport_ProtocolSupportIdentifier = 6214;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ImageSet_ImageIdentifier = 6216;

        /// <summary>
        /// The identifier for the BlockType_RevisionCounter Variable.
        /// </summary>
        public const uint BlockType_RevisionCounter = 6009;

        /// <summary>
        /// The identifier for the BlockType_ActualMode Variable.
        /// </summary>
        public const uint BlockType_ActualMode = 6010;

        /// <summary>
        /// The identifier for the BlockType_PermittedMode Variable.
        /// </summary>
        public const uint BlockType_PermittedMode = 6011;

        /// <summary>
        /// The identifier for the BlockType_NormalMode Variable.
        /// </summary>
        public const uint BlockType_NormalMode = 6012;

        /// <summary>
        /// The identifier for the BlockType_TargetMode Variable.
        /// </summary>
        public const uint BlockType_TargetMode = 6013;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier_UIElement = 6242;

        /// <summary>
        /// The identifier for the FunctionalGroupType_ParameterIdentifier Variable.
        /// </summary>
        public const uint FunctionalGroupType_ParameterIdentifier = 6028;

        /// <summary>
        /// The identifier for the FunctionalGroupType_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_UIElement = 6243;

        /// <summary>
        /// The identifier for the DeviceHealthEnumeration_EnumStrings Variable.
        /// </summary>
        public const uint DeviceHealthEnumeration_EnumStrings = 6450;

        /// <summary>
        /// The identifier for the NetworkType_Lock_Locked Variable.
        /// </summary>
        public const uint NetworkType_Lock_Locked = 6497;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingClient = 6296;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingUser = 6297;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkType_Lock_RemainingLockTime = 6298;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_InputArguments = 6300;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_OutputArguments = 6301;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock_OutputArguments = 6303;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock_OutputArguments = 6305;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock_OutputArguments = 6307;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_Locked = 6601;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingClient = 6602;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingUser = 6603;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = 6604;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = 6606;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = 6607;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = 6609;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = 6611;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = 6613;

        /// <summary>
        /// The identifier for the TransferToDeviceMethodType_OutputArguments Variable.
        /// </summary>
        public const uint TransferToDeviceMethodType_OutputArguments = 6516;

        /// <summary>
        /// The identifier for the TransferFromDeviceMethodType_OutputArguments Variable.
        /// </summary>
        public const uint TransferFromDeviceMethodType_OutputArguments = 6518;

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType_InputArguments Variable.
        /// </summary>
        public const uint FetchTransferResultDataMethodType_InputArguments = 6520;

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType_OutputArguments Variable.
        /// </summary>
        public const uint FetchTransferResultDataMethodType_OutputArguments = 6521;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_TransferToDevice_OutputArguments = 6528;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_TransferFromDevice_OutputArguments = 6530;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData_InputArguments = 6532;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData_OutputArguments = 6533;

        /// <summary>
        /// The identifier for the MaxInactiveLockTime Variable.
        /// </summary>
        public const uint MaxInactiveLockTime = 6387;

        /// <summary>
        /// The identifier for the InitLockMethodType_InputArguments Variable.
        /// </summary>
        public const uint InitLockMethodType_InputArguments = 6459;

        /// <summary>
        /// The identifier for the InitLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint InitLockMethodType_OutputArguments = 6460;

        /// <summary>
        /// The identifier for the RenewLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint RenewLockMethodType_OutputArguments = 6462;

        /// <summary>
        /// The identifier for the ExitLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint ExitLockMethodType_OutputArguments = 6464;

        /// <summary>
        /// The identifier for the BreakLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint BreakLockMethodType_OutputArguments = 6466;

        /// <summary>
        /// The identifier for the LockingServicesType_Locked Variable.
        /// </summary>
        public const uint LockingServicesType_Locked = 6534;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingClient Variable.
        /// </summary>
        public const uint LockingServicesType_LockingClient = 6390;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingUser Variable.
        /// </summary>
        public const uint LockingServicesType_LockingUser = 6391;

        /// <summary>
        /// The identifier for the LockingServicesType_RemainingLockTime Variable.
        /// </summary>
        public const uint LockingServicesType_RemainingLockTime = 6392;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_InputArguments = 6394;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_OutputArguments = 6395;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_RenewLock_OutputArguments = 6397;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_ExitLock_OutputArguments = 6399;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_BreakLock_OutputArguments = 6401;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema = 6423;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_NamespaceUri = 6425;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_FetchResultDataType = 6539;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultErrorDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_FetchResultErrorDataType = 6542;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_FetchResultDataDataType = 6545;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_ParameterResultDataType = 6548;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema = 6435;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_NamespaceUri = 6437;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_FetchResultDataType = 6555;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultErrorDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_FetchResultErrorDataType = 6558;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_FetchResultDataDataType = 6561;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_ParameterResultDataType = 6564;
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
        /// The identifier for the UIElementType VariableType.
        /// </summary>
        public const uint UIElementType = 6246;
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
        /// The identifier for the DeviceHealthEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthEnumeration = new ExpandedNodeId(Opc.Ua.Di.DataTypes.DeviceHealthEnumeration, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultErrorDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.FetchResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.FetchResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the TopologyElementType_MethodSet_MethodIdentifier Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_MethodSet_MethodIdentifier = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_MethodSet_MethodIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_MethodIdentifier Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_MethodIdentifier = new ExpandedNodeId(Opc.Ua.Di.Methods.FunctionalGroupType_MethodIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferToDeviceMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferToDeviceMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferToDeviceMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferFromDeviceMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferFromDeviceMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferFromDeviceMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultDataMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.FetchTransferResultDataMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_TransferToDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_TransferFromDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_FetchTransferResultData, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InitLockMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId InitLockMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.InitLockMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the RenewLockMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId RenewLockMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.RenewLockMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ExitLockMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId ExitLockMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.ExitLockMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BreakLockMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId BreakLockMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.BreakLockMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceTopology, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_ParameterSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_MethodSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_MethodSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_GroupIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Identification = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Identification, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_DeviceTypeImage, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Documentation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Documentation = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_Documentation, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_ProtocolSupport, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ImageSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ImageSet = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_ImageSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_CPIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType_SupportedTypes = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfigurableObjectType_SupportedTypes, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType_ObjectIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType_ObjectIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfigurableObjectType_ObjectIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.FunctionalGroupType_GroupIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_ProfileIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_ProfileIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_ProfileIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_ProfileId Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_ProfileId = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_ProfileId, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultErrorDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultErrorDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResultDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultErrorDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultErrorDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResultDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the TopologyElementType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.TopologyElementType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.DeviceType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BlockType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.BlockType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ConfigurableObjectType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.FunctionalGroupType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ProtocolType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProtocolType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ProtocolType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.NetworkType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ConnectionPointType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.TransferServicesType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.LockingServicesType, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectsTo = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.ConnectsTo, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectsToParent ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectsToParent = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.ConnectsToParent, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IsOnline ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId IsOnline = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.IsOnline, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_OnlineAccess = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_OnlineAccess, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet_ParameterIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_ParameterSet_ParameterIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceClass = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceClass, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceHealth = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceHealth, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceTypeImage_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Documentation_DocumentIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Documentation_DocumentIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport_ProtocolSupportIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ProtocolSupport_ProtocolSupportIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ImageSet_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ImageSet_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_ActualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_ActualMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_ActualMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_PermittedMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_PermittedMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_PermittedMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_NormalMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_NormalMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_NormalMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_TargetMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_TargetMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_TargetMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier_UIElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier_UIElement = new ExpandedNodeId(Opc.Ua.Di.Variables.FunctionalGroupType_GroupIdentifier_UIElement, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_ParameterIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_ParameterIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.FunctionalGroupType_ParameterIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_UIElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_UIElement = new ExpandedNodeId(Opc.Ua.Di.Variables.FunctionalGroupType_UIElement, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthEnumeration_EnumStrings, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferToDeviceMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferToDeviceMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferToDeviceMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferFromDeviceMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferFromDeviceMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferFromDeviceMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultDataMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FetchTransferResultDataMethodType_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultDataMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultDataMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FetchTransferResultDataMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_TransferToDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_TransferFromDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_FetchTransferResultData_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_FetchTransferResultData_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaxInactiveLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaxInactiveLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.MaxInactiveLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InitLockMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId InitLockMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.InitLockMethodType_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InitLockMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId InitLockMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.InitLockMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the RenewLockMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RenewLockMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.RenewLockMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ExitLockMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExitLockMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ExitLockMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BreakLockMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BreakLockMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BreakLockMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_FetchResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_FetchResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_FetchResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_FetchResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_FetchResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_FetchResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_FetchResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_FetchResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the UIElementType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId UIElementType = new ExpandedNodeId(Opc.Ua.Di.VariableTypes.UIElementType, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ActualMode component.
        /// </summary>
        public const string ActualMode = "ActualMode";

        /// <summary>
        /// The BrowseName for the BlockType component.
        /// </summary>
        public const string BlockType = "BlockType";

        /// <summary>
        /// The BrowseName for the BreakLock component.
        /// </summary>
        public const string BreakLock = "BreakLock";

        /// <summary>
        /// The BrowseName for the BreakLockMethodType component.
        /// </summary>
        public const string BreakLockMethodType = "BreakLockMethodType";

        /// <summary>
        /// The BrowseName for the ConfigurableObjectType component.
        /// </summary>
        public const string ConfigurableObjectType = "ConfigurableObjectType";

        /// <summary>
        /// The BrowseName for the ConnectionPointType component.
        /// </summary>
        public const string ConnectionPointType = "ConnectionPointType";

        /// <summary>
        /// The BrowseName for the ConnectsTo component.
        /// </summary>
        public const string ConnectsTo = "ConnectsTo";

        /// <summary>
        /// The BrowseName for the ConnectsToParent component.
        /// </summary>
        public const string ConnectsToParent = "ConnectsToParent";

        /// <summary>
        /// The BrowseName for the CPIdentifier component.
        /// </summary>
        public const string CPIdentifier = "<CPIdentifier>";

        /// <summary>
        /// The BrowseName for the DeviceClass component.
        /// </summary>
        public const string DeviceClass = "DeviceClass";

        /// <summary>
        /// The BrowseName for the DeviceHealth component.
        /// </summary>
        public const string DeviceHealth = "DeviceHealth";

        /// <summary>
        /// The BrowseName for the DeviceHealthEnumeration component.
        /// </summary>
        public const string DeviceHealthEnumeration = "DeviceHealthEnumeration";

        /// <summary>
        /// The BrowseName for the DeviceManual component.
        /// </summary>
        public const string DeviceManual = "DeviceManual";

        /// <summary>
        /// The BrowseName for the DeviceRevision component.
        /// </summary>
        public const string DeviceRevision = "DeviceRevision";

        /// <summary>
        /// The BrowseName for the DeviceSet component.
        /// </summary>
        public const string DeviceSet = "DeviceSet";

        /// <summary>
        /// The BrowseName for the DeviceTopology component.
        /// </summary>
        public const string DeviceTopology = "DeviceTopology";

        /// <summary>
        /// The BrowseName for the DeviceType component.
        /// </summary>
        public const string DeviceType = "DeviceType";

        /// <summary>
        /// The BrowseName for the DeviceTypeImage component.
        /// </summary>
        public const string DeviceTypeImage = "DeviceTypeImage";

        /// <summary>
        /// The BrowseName for the Documentation component.
        /// </summary>
        public const string Documentation = "Documentation";

        /// <summary>
        /// The BrowseName for the ExitLock component.
        /// </summary>
        public const string ExitLock = "ExitLock";

        /// <summary>
        /// The BrowseName for the ExitLockMethodType component.
        /// </summary>
        public const string ExitLockMethodType = "ExitLockMethodType";

        /// <summary>
        /// The BrowseName for the FetchResultDataDataType component.
        /// </summary>
        public const string FetchResultDataDataType = "FetchResultDataDataType";

        /// <summary>
        /// The BrowseName for the FetchResultDataType component.
        /// </summary>
        public const string FetchResultDataType = "FetchResultDataType";

        /// <summary>
        /// The BrowseName for the FetchResultErrorDataType component.
        /// </summary>
        public const string FetchResultErrorDataType = "FetchResultErrorDataType";

        /// <summary>
        /// The BrowseName for the FetchTransferResultData component.
        /// </summary>
        public const string FetchTransferResultData = "FetchTransferResultData";

        /// <summary>
        /// The BrowseName for the FetchTransferResultDataMethodType component.
        /// </summary>
        public const string FetchTransferResultDataMethodType = "FetchTransferResultDataMethodType";

        /// <summary>
        /// The BrowseName for the FunctionalGroupType component.
        /// </summary>
        public const string FunctionalGroupType = "FunctionalGroupType";

        /// <summary>
        /// The BrowseName for the GroupIdentifier component.
        /// </summary>
        public const string GroupIdentifier = "<GroupIdentifier>";

        /// <summary>
        /// The BrowseName for the HardwareRevision component.
        /// </summary>
        public const string HardwareRevision = "HardwareRevision";

        /// <summary>
        /// The BrowseName for the Identification component.
        /// </summary>
        public const string Identification = "Identification";

        /// <summary>
        /// The BrowseName for the ImageSet component.
        /// </summary>
        public const string ImageSet = "ImageSet";

        /// <summary>
        /// The BrowseName for the InitLock component.
        /// </summary>
        public const string InitLock = "InitLock";

        /// <summary>
        /// The BrowseName for the InitLockMethodType component.
        /// </summary>
        public const string InitLockMethodType = "InitLockMethodType";

        /// <summary>
        /// The BrowseName for the IsOnline component.
        /// </summary>
        public const string IsOnline = "IsOnline";

        /// <summary>
        /// The BrowseName for the Lock component.
        /// </summary>
        public const string Lock = "Lock";

        /// <summary>
        /// The BrowseName for the Locked component.
        /// </summary>
        public const string Locked = "Locked";

        /// <summary>
        /// The BrowseName for the LockingClient component.
        /// </summary>
        public const string LockingClient = "LockingClient";

        /// <summary>
        /// The BrowseName for the LockingServicesType component.
        /// </summary>
        public const string LockingServicesType = "LockingServicesType";

        /// <summary>
        /// The BrowseName for the LockingUser component.
        /// </summary>
        public const string LockingUser = "LockingUser";

        /// <summary>
        /// The BrowseName for the Manufacturer component.
        /// </summary>
        public const string Manufacturer = "Manufacturer";

        /// <summary>
        /// The BrowseName for the MaxInactiveLockTime component.
        /// </summary>
        public const string MaxInactiveLockTime = "MaxInactiveLockTime";

        /// <summary>
        /// The BrowseName for the MethodIdentifier component.
        /// </summary>
        public const string MethodIdentifier = "<MethodIdentifier>";

        /// <summary>
        /// The BrowseName for the MethodSet component.
        /// </summary>
        public const string MethodSet = "MethodSet";

        /// <summary>
        /// The BrowseName for the Model component.
        /// </summary>
        public const string Model = "Model";

        /// <summary>
        /// The BrowseName for the NetworkAddress component.
        /// </summary>
        public const string NetworkAddress = "NetworkAddress";

        /// <summary>
        /// The BrowseName for the NetworkIdentifier component.
        /// </summary>
        public const string NetworkIdentifier = "<NetworkIdentifier>";

        /// <summary>
        /// The BrowseName for the NetworkSet component.
        /// </summary>
        public const string NetworkSet = "NetworkSet";

        /// <summary>
        /// The BrowseName for the NetworkType component.
        /// </summary>
        public const string NetworkType = "NetworkType";

        /// <summary>
        /// The BrowseName for the NormalMode component.
        /// </summary>
        public const string NormalMode = "NormalMode";

        /// <summary>
        /// The BrowseName for the ObjectIdentifier component.
        /// </summary>
        public const string ObjectIdentifier = "<ObjectIdentifier>";

        /// <summary>
        /// The BrowseName for the OnlineAccess component.
        /// </summary>
        public const string OnlineAccess = "OnlineAccess";

        /// <summary>
        /// The BrowseName for the OpcUaDi_BinarySchema component.
        /// </summary>
        public const string OpcUaDi_BinarySchema = "Opc.Ua.Di";

        /// <summary>
        /// The BrowseName for the OpcUaDi_XmlSchema component.
        /// </summary>
        public const string OpcUaDi_XmlSchema = "Opc.Ua.Di";

        /// <summary>
        /// The BrowseName for the ParameterIdentifier component.
        /// </summary>
        public const string ParameterIdentifier = "<ParameterIdentifier>";

        /// <summary>
        /// The BrowseName for the ParameterResultDataType component.
        /// </summary>
        public const string ParameterResultDataType = "ParameterResultDataType";

        /// <summary>
        /// The BrowseName for the ParameterSet component.
        /// </summary>
        public const string ParameterSet = "ParameterSet";

        /// <summary>
        /// The BrowseName for the PermittedMode component.
        /// </summary>
        public const string PermittedMode = "PermittedMode";

        /// <summary>
        /// The BrowseName for the ProfileId component.
        /// </summary>
        public const string ProfileId = "<ProfileId>";

        /// <summary>
        /// The BrowseName for the ProfileIdentifier component.
        /// </summary>
        public const string ProfileIdentifier = "<ProfileIdentifier>";

        /// <summary>
        /// The BrowseName for the ProtocolSupport component.
        /// </summary>
        public const string ProtocolSupport = "ProtocolSupport";

        /// <summary>
        /// The BrowseName for the ProtocolType component.
        /// </summary>
        public const string ProtocolType = "ProtocolType";

        /// <summary>
        /// The BrowseName for the RemainingLockTime component.
        /// </summary>
        public const string RemainingLockTime = "RemainingLockTime";

        /// <summary>
        /// The BrowseName for the RenewLock component.
        /// </summary>
        public const string RenewLock = "RenewLock";

        /// <summary>
        /// The BrowseName for the RenewLockMethodType component.
        /// </summary>
        public const string RenewLockMethodType = "RenewLockMethodType";

        /// <summary>
        /// The BrowseName for the RevisionCounter component.
        /// </summary>
        public const string RevisionCounter = "RevisionCounter";

        /// <summary>
        /// The BrowseName for the SerialNumber component.
        /// </summary>
        public const string SerialNumber = "SerialNumber";

        /// <summary>
        /// The BrowseName for the SoftwareRevision component.
        /// </summary>
        public const string SoftwareRevision = "SoftwareRevision";

        /// <summary>
        /// The BrowseName for the SupportedTypes component.
        /// </summary>
        public const string SupportedTypes = "SupportedTypes";

        /// <summary>
        /// The BrowseName for the TargetMode component.
        /// </summary>
        public const string TargetMode = "TargetMode";

        /// <summary>
        /// The BrowseName for the TopologyElementType component.
        /// </summary>
        public const string TopologyElementType = "TopologyElementType";

        /// <summary>
        /// The BrowseName for the TransferFromDevice component.
        /// </summary>
        public const string TransferFromDevice = "TransferFromDevice";

        /// <summary>
        /// The BrowseName for the TransferFromDeviceMethodType component.
        /// </summary>
        public const string TransferFromDeviceMethodType = "TransferFromDeviceMethodType";

        /// <summary>
        /// The BrowseName for the TransferServicesType component.
        /// </summary>
        public const string TransferServicesType = "TransferServicesType";

        /// <summary>
        /// The BrowseName for the TransferToDevice component.
        /// </summary>
        public const string TransferToDevice = "TransferToDevice";

        /// <summary>
        /// The BrowseName for the TransferToDeviceMethodType component.
        /// </summary>
        public const string TransferToDeviceMethodType = "TransferToDeviceMethodType";

        /// <summary>
        /// The BrowseName for the UIElement component.
        /// </summary>
        public const string UIElement = "UIElement";

        /// <summary>
        /// The BrowseName for the UIElementType component.
        /// </summary>
        public const string UIElementType = "UIElementType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

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

    #region TopologyElementState Class
    #if (!OPCUA_EXCLUDE_TopologyElementState)
    /// <summary>
    /// Stores an instance of the TopologyElementType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TopologyElementState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TopologyElementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.TopologyElementType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }

            if (Identification != null)
            {
                Identification.Initialize(context, Identification_InitializationString);
            }

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAMAAAAUGFy" +
           "YW1ldGVyU2V0AQGKEwMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOooTAAD/////AAAA" +
           "AA==";

        private const string MethodSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAJAAAATWV0" +
           "aG9kU2V0AQGLEwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOosTAAD/////AAAAAA==";

        private const string Identification_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24BAX4XAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVu" +
           "dGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQHtA34XAAD/////AAAAAA==";

        private const string Lock_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAEAAAATG9j" +
           "awEBERgDAAAAACIAAABVc2VkIHRvIGxvY2sgdGhlIHRvcG9sb2d5IGVsZW1lbnQuAC8BAfQYERgAAP//" +
           "//8IAAAAFWCJCgIAAAABAAYAAABMb2NrZWQBAUQZAC4AREQZAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAABAA0AAABMb2NraW5nQ2xpZW50AQETGAAuAEQTGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAATG9ja2luZ1VzZXIBARQYAC4ARBQYAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1h" +
           "aW5pbmdMb2NrVGltZQEBFRgALgBEFRgAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5p" +
           "dExvY2sBARYYAC8BAfkYFhgAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEX" +
           "GAAuAEQXGAAAlgEAAAABACoBAR0AAAAOAAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEYGAAuAEQYGAAAlgEAAAABACoB" +
           "AR0AAAAOAAAASW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQAJAAAAUmVuZXdMb2NrAQEZGAAvAQH8GBkYAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBARoYAC4ARBoYAACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAARXhpdExvY2sBARsYAC8BAf4YGxgAAAEB" +
           "/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBHBgALgBEHBgAAJYBAAAAAQAqAQEd" +
           "AAAADgAAAEV4aXRMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEA" +
           "CQAAAEJyZWFrTG9jawEBHRgALwEBABkdGAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQEeGAAuAEQeGAAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAAVG9w" +
           "b2xvZ3lFbGVtZW50VHlwZUluc3RhbmNlAQHpAwEB6QP/////BAAAACRggAoBAAAAAQAMAAAAUGFyYW1l" +
           "dGVyU2V0AQGKEwMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOooTAAD/////AAAAACRg" +
           "gAoBAAAAAQAJAAAATWV0aG9kU2V0AQGLEwMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOosT" +
           "AAD/////AAAAACRggAoBAAAAAQAOAAAASWRlbnRpZmljYXRpb24BAX4XAwAAAABGAAAAVXNlZCB0byBv" +
           "cmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVudGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVu" +
           "dAAvAQHtA34XAAD/////AAAAACRggAoBAAAAAQAEAAAATG9jawEBERgDAAAAACIAAABVc2VkIHRvIGxv" +
           "Y2sgdGhlIHRvcG9sb2d5IGVsZW1lbnQuAC8BAfQYERgAAP////8IAAAAFWCJCgIAAAABAAYAAABMb2Nr" +
           "ZWQBAUQZAC4AREQZAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAA0AAABMb2NraW5nQ2xpZW50AQET" +
           "GAAuAEQTGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAATG9ja2luZ1VzZXIBARQYAC4ARBQY" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1haW5pbmdMb2NrVGltZQEBFRgALgBEFRgA" +
           "AAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5pdExvY2sBARYYAC8BAfkYFhgAAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEXGAAuAEQXGAAAlgEAAAABACoBAR0AAAAO" +
           "AAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQEYGAAuAEQYGAAAlgEAAAABACoBAR0AAAAOAAAASW5pdExvY2tTdGF0dXMA" +
           "Bv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAAUmVuZXdMb2NrAQEZGAAvAQH8" +
           "GBkYAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARoYAC4ARBoYAACWAQAA" +
           "AAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARh" +
           "ggoEAAAAAQAIAAAARXhpdExvY2sBARsYAC8BAf4YGxgAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBHBgALgBEHBgAAJYBAAAAAQAqAQEdAAAADgAAAEV4aXRMb2NrU3RhdHVzAAb/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFrTG9jawEBHRgALwEBABkd" +
           "GAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEeGAAuAEQeGAAAlgEAAAAB" +
           "ACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Flat list of Parameters
        /// </summary>
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }

        /// <summary>
        /// Flat list of Methods
        /// </summary>
        public BaseObjectState MethodSet
        {
            get
            {
                return m_methodSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_methodSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_methodSet = value;
            }
        }

        /// <summary>
        /// Used to organize parameters for identification of this TopologyElement
        /// </summary>
        public FunctionalGroupState Identification
        {
            get
            {
                return m_identification;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identification = value;
            }
        }

        /// <summary>
        /// Used to lock the topology element.
        /// </summary>
        public LockingServicesState Lock
        {
            get
            {
                return m_lock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
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
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            if (m_methodSet != null)
            {
                children.Add(m_methodSet);
            }

            if (m_identification != null)
            {
                children.Add(m_identification);
            }

            if (m_lock != null)
            {
                children.Add(m_lock);
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
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.MethodSet:
                {
                    if (createOrReplace)
                    {
                        if (MethodSet == null)
                        {
                            if (replacement == null)
                            {
                                MethodSet = new BaseObjectState(this);
                            }
                            else
                            {
                                MethodSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = MethodSet;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Identification = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesState)replacement;
                            }
                        }
                    }

                    instance = Lock;
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
        private BaseObjectState m_parameterSet;
        private BaseObjectState m_methodSet;
        private FunctionalGroupState m_identification;
        private LockingServicesState m_lock;
        #endregion
    }
    #endif
    #endregion

    #region DeviceState Class
    #if (!OPCUA_EXCLUDE_DeviceState)
    /// <summary>
    /// Stores an instance of the DeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DeviceState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.DeviceType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (DeviceTypeImage != null)
            {
                DeviceTypeImage.Initialize(context, DeviceTypeImage_InitializationString);
            }

            if (Documentation != null)
            {
                Documentation.Initialize(context, Documentation_InitializationString);
            }

            if (ProtocolSupport != null)
            {
                ProtocolSupport.Initialize(context, ProtocolSupport_InitializationString);
            }

            if (ImageSet != null)
            {
                ImageSet.Initialize(context, ImageSet_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceClass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQALAAAARGV2" +
           "aWNlQ2xhc3MBAUYZAwAAAAA/AAAASW5kaWNhdGVzIGluIHdoaWNoIGRvbWFpbiBvciBmb3Igd2hhdCBw" +
           "dXJwb3NlIGEgZGV2aWNlIGlzIHVzZWQuAC4AREYZAAAADP////8BAf////8AAAAA";

        private const string DeviceHealth_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAMAAAARGV2" +
           "aWNlSGVhbHRoAQFAGAMAAAAAPAAAAFN0YXR1cyBvZiBhIGRldmljZSBhcyBkZWZpbmVkIGJ5IE5BTVVS" +
           "IFJlY29tbWVuZGF0aW9uIE5FMTA3LgAuAERAGAAAAQFkGP////8BAf////8AAAAA";

        private const string DeviceTypeImage_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAPAAAARGV2" +
           "aWNlVHlwZUltYWdlAQFBGAMAAAAAIQAAAE9yZ2FuaXplcyBwaWN0dXJlcyBvZiB0aGUgZGV2aWNlLgAv" +
           "AD1BGAAA/////wAAAAA=";

        private const string Documentation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQANAAAARG9j" +
           "dW1lbnRhdGlvbgEBQxgDAAAAACMAAABPcmdhbml6ZXMgZG9jdW1lbnRzIGZvciB0aGUgZGV2aWNlLgAv" +
           "AD1DGAAA/////wAAAAA=";

        private const string ProtocolSupport_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAPAAAAUHJv" +
           "dG9jb2xTdXBwb3J0AQFFGAMAAAAAJwAAAFByb3RvY29sLXNwZWNpZmljIGZpbGVzIGZvciB0aGUgZGV2" +
           "aWNlLgAvAD1FGAAA/////wAAAAA=";

        private const string ImageSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAIAAAASW1h" +
           "Z2VTZXQBAUcYAwAAAAAxAAAAT3JnYW5pemVzIGltYWdlcyB0aGF0IGFyZSB1c2VkIHdpdGhpbiBVSUVs" +
           "ZW1lbnRzLgAvAD1HGAAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAARGV2" +
           "aWNlVHlwZUluc3RhbmNlAQHqAwEB6gP/////DgAAADVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQFx" +
           "FwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51" +
           "ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARHEXAAAADP////8BAf////8AAAAANWCJCgIAAAAB" +
           "AA8AAABSZXZpc2lvbkNvdW50ZXIBAXIXAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRp" +
           "Y2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNl" +
           "IGhhcyBiZWVuIG1vZGlmaWVkAC4ARHIXAAAABv////8BAf////8AAAAANWCJCgIAAAABAAwAAABNYW51" +
           "ZmFjdHVyZXIBAXMXAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARHMXAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAABAAUAAABNb2RlbAEBdBcDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55" +
           "IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEdBcAAAAV/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEADAAAAERldmljZU1hbnVhbAEBdRcDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmls" +
           "ZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZp" +
           "Y2UALgBEdRcAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAERldmljZVJldmlzaW9uAQF2FwMA" +
           "AAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAER2FwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAQAAAAU29mdHdhcmVSZXZpc2lvbgEBdxcDAAAAADUAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAER3FwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAQAAAASGFyZHdhcmVSZXZpc2lvbgEBeBcDAAAAACwAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAER4FwAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQALAAAARGV2aWNlQ2xhc3MBAUYZAwAAAAA/AAAASW5kaWNhdGVzIGluIHdoaWNoIGRvbWFp" +
           "biBvciBmb3Igd2hhdCBwdXJwb3NlIGEgZGV2aWNlIGlzIHVzZWQuAC4AREYZAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABAAwAAABEZXZpY2VIZWFsdGgBAUAYAwAAAAA8AAAAU3RhdHVzIG9mIGEgZGV2aWNl" +
           "IGFzIGRlZmluZWQgYnkgTkFNVVIgUmVjb21tZW5kYXRpb24gTkUxMDcuAC4AREAYAAABAWQY/////wEB" +
           "/////wAAAAAkYIAKAQAAAAEADwAAAERldmljZVR5cGVJbWFnZQEBQRgDAAAAACEAAABPcmdhbml6ZXMg" +
           "cGljdHVyZXMgb2YgdGhlIGRldmljZS4ALwA9QRgAAP////8AAAAAJGCACgEAAAABAA0AAABEb2N1bWVu" +
           "dGF0aW9uAQFDGAMAAAAAIwAAAE9yZ2FuaXplcyBkb2N1bWVudHMgZm9yIHRoZSBkZXZpY2UuAC8APUMY" +
           "AAD/////AAAAACRggAoBAAAAAQAPAAAAUHJvdG9jb2xTdXBwb3J0AQFFGAMAAAAAJwAAAFByb3RvY29s" +
           "LXNwZWNpZmljIGZpbGVzIGZvciB0aGUgZGV2aWNlLgAvAD1FGAAA/////wAAAAAkYIAKAQAAAAEACAAA" +
           "AEltYWdlU2V0AQFHGAMAAAAAMQAAAE9yZ2FuaXplcyBpbWFnZXMgdGhhdCBhcmUgdXNlZCB3aXRoaW4g" +
           "VUlFbGVtZW50cy4ALwA9RxgAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Identifier that uniquely identifies, within a manufacturer, a device instance
        /// </summary>
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <summary>
        /// An incremental counter indicating the number of times the static data within the Device has been modified
        /// </summary>
        public PropertyState<int> RevisionCounter
        {
            get
            {
                return m_revisionCounter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        /// <summary>
        /// Model name of the device
        /// </summary>
        public PropertyState<LocalizedText> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <summary>
        /// Name of the company that manufactured the device
        /// </summary>
        public PropertyState<LocalizedText> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <summary>
        /// Address (pathname in the file system or a URL | Web address) of user manual for the device
        /// </summary>
        public PropertyState<string> DeviceManual
        {
            get
            {
                return m_deviceManual;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceManual, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceManual = value;
            }
        }

        /// <summary>
        /// Overall revision level of the device
        /// </summary>
        public PropertyState<string> DeviceRevision
        {
            get
            {
                return m_deviceRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceRevision = value;
            }
        }

        /// <summary>
        /// Revision level of the software/firmware of the device
        /// </summary>
        public PropertyState<string> SoftwareRevision
        {
            get
            {
                return m_softwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        /// <summary>
        /// Revision level of the hardware of the device
        /// </summary>
        public PropertyState<string> HardwareRevision
        {
            get
            {
                return m_hardwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hardwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hardwareRevision = value;
            }
        }

        /// <summary>
        /// Indicates in which domain or for what purpose a device is used.
        /// </summary>
        public PropertyState<string> DeviceClass
        {
            get
            {
                return m_deviceClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        /// <summary>
        /// Status of a device as defined by NAMUR Recommendation NE107.
        /// </summary>
        public PropertyState<DeviceHealthEnumeration> DeviceHealth
        {
            get
            {
                return m_deviceHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
            }
        }

        /// <summary>
        /// Organizes pictures of the device.
        /// </summary>
        public FolderState DeviceTypeImage
        {
            get
            {
                return m_deviceTypeImage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceTypeImage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceTypeImage = value;
            }
        }

        /// <summary>
        /// Organizes documents for the device.
        /// </summary>
        public FolderState Documentation
        {
            get
            {
                return m_documentation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_documentation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_documentation = value;
            }
        }

        /// <summary>
        /// Protocol-specific files for the device.
        /// </summary>
        public FolderState ProtocolSupport
        {
            get
            {
                return m_protocolSupport;
            }

            set
            {
                if (!Object.ReferenceEquals(m_protocolSupport, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolSupport = value;
            }
        }

        /// <summary>
        /// Organizes images that are used within UIElements.
        /// </summary>
        public FolderState ImageSet
        {
            get
            {
                return m_imageSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_imageSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_imageSet = value;
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
            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_deviceManual != null)
            {
                children.Add(m_deviceManual);
            }

            if (m_deviceRevision != null)
            {
                children.Add(m_deviceRevision);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_hardwareRevision != null)
            {
                children.Add(m_hardwareRevision);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
            }

            if (m_deviceTypeImage != null)
            {
                children.Add(m_deviceTypeImage);
            }

            if (m_documentation != null)
            {
                children.Add(m_documentation);
            }

            if (m_protocolSupport != null)
            {
                children.Add(m_protocolSupport);
            }

            if (m_imageSet != null)
            {
                children.Add(m_imageSet);
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
                case Opc.Ua.Di.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<int>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceManual:
                {
                    if (createOrReplace)
                    {
                        if (DeviceManual == null)
                        {
                            if (replacement == null)
                            {
                                DeviceManual = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceManual = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceManual;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceRevision:
                {
                    if (createOrReplace)
                    {
                        if (DeviceRevision == null)
                        {
                            if (replacement == null)
                            {
                                DeviceRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceRevision;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.HardwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (HardwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                HardwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                HardwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HardwareRevision;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new PropertyState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (PropertyState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.DeviceTypeImage:
                {
                    if (createOrReplace)
                    {
                        if (DeviceTypeImage == null)
                        {
                            if (replacement == null)
                            {
                                DeviceTypeImage = new FolderState(this);
                            }
                            else
                            {
                                DeviceTypeImage = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceTypeImage;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.Documentation:
                {
                    if (createOrReplace)
                    {
                        if (Documentation == null)
                        {
                            if (replacement == null)
                            {
                                Documentation = new FolderState(this);
                            }
                            else
                            {
                                Documentation = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Documentation;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ProtocolSupport:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolSupport == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolSupport = new FolderState(this);
                            }
                            else
                            {
                                ProtocolSupport = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ProtocolSupport;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ImageSet:
                {
                    if (createOrReplace)
                    {
                        if (ImageSet == null)
                        {
                            if (replacement == null)
                            {
                                ImageSet = new FolderState(this);
                            }
                            else
                            {
                                ImageSet = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ImageSet;
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
        private PropertyState<string> m_serialNumber;
        private PropertyState<int> m_revisionCounter;
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<LocalizedText> m_model;
        private PropertyState<string> m_deviceManual;
        private PropertyState<string> m_deviceRevision;
        private PropertyState<string> m_softwareRevision;
        private PropertyState<string> m_hardwareRevision;
        private PropertyState<string> m_deviceClass;
        private PropertyState<DeviceHealthEnumeration> m_deviceHealth;
        private FolderState m_deviceTypeImage;
        private FolderState m_documentation;
        private FolderState m_protocolSupport;
        private FolderState m_imageSet;
        #endregion
    }
    #endif
    #endregion

    #region BlockState Class
    #if (!OPCUA_EXCLUDE_BlockState)
    /// <summary>
    /// Stores an instance of the BlockType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlockState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BlockState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.BlockType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (ActualMode != null)
            {
                ActualMode.Initialize(context, ActualMode_InitializationString);
            }

            if (PermittedMode != null)
            {
                PermittedMode.Initialize(context, PermittedMode_InitializationString);
            }

            if (NormalMode != null)
            {
                NormalMode.Initialize(context, NormalMode_InitializationString);
            }

            if (TargetMode != null)
            {
                TargetMode.Initialize(context, TargetMode_InitializationString);
            }
        }

        #region Initialization String
        private const string RevisionCounter_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQF5FwMAAAAAZQAAAEluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUg" +
           "bnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIEJsb2NrIGhhcyBiZWVuIG1v" +
           "ZGlmaWVkAC4ARHkXAAAAB/////8BAf////8AAAAA";

        private const string ActualMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAAQWN0" +
           "dWFsTW9kZQEBehcDAAAAADYAAABDdXJyZW50IG1vZGUgb2Ygb3BlcmF0aW9uIHRoZSBCbG9jayBpcyBh" +
           "YmxlIHRvIGFjaGlldmUALgBEehcAAAAV/////wEB/////wAAAAA=";

        private const string PermittedMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQANAAAAUGVy" +
           "bWl0dGVkTW9kZQEBexcDAAAAAFMAAABNb2RlcyBvZiBvcGVyYXRpb24gdGhhdCBhcmUgYWxsb3dlZCBm" +
           "b3IgdGhlIEJsb2NrIGJhc2VkIG9uIGFwcGxpY2F0aW9uIHJlcXVpcmVtZW50cwAuAER7FwAAABUBAAAA" +
           "AQH/////AAAAAA==";

        private const string NormalMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAATm9y" +
           "bWFsTW9kZQEBfBcDAAAAAEIAAABNb2RlIHRoZSBCbG9jayBzaG91bGQgYmUgc2V0IHRvIGR1cmluZyBu" +
           "b3JtYWwgb3BlcmF0aW5nIGNvbmRpdGlvbnMALgBEfBcAAAAVAQAAAAEB/////wAAAAA=";

        private const string TargetMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAAVGFy" +
           "Z2V0TW9kZQEBfRcDAAAAAC8AAABNb2RlIG9mIG9wZXJhdGlvbiB0aGF0IGlzIGRlc2lyZWQgZm9yIHRo" +
           "ZSBCbG9jawAuAER9FwAAABUBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQARAAAAQmxv" +
           "Y2tUeXBlSW5zdGFuY2UBAesDAQHrA/////8FAAAANWCJCgIAAAABAA8AAABSZXZpc2lvbkNvdW50ZXIB" +
           "AXkXAwAAAABlAAAASW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGlt" +
           "ZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgQmxvY2sgaGFzIGJlZW4gbW9kaWZpZWQALgBEeRcA" +
           "AAAH/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAEFjdHVhbE1vZGUBAXoXAwAAAAA2AAAAQ3VycmVu" +
           "dCBtb2RlIG9mIG9wZXJhdGlvbiB0aGUgQmxvY2sgaXMgYWJsZSB0byBhY2hpZXZlAC4ARHoXAAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAABAA0AAABQZXJtaXR0ZWRNb2RlAQF7FwMAAAAAUwAAAE1vZGVzIG9m" +
           "IG9wZXJhdGlvbiB0aGF0IGFyZSBhbGxvd2VkIGZvciB0aGUgQmxvY2sgYmFzZWQgb24gYXBwbGljYXRp" +
           "b24gcmVxdWlyZW1lbnRzAC4ARHsXAAAAFQEAAAABAf////8AAAAANWCJCgIAAAABAAoAAABOb3JtYWxN" +
           "b2RlAQF8FwMAAAAAQgAAAE1vZGUgdGhlIEJsb2NrIHNob3VsZCBiZSBzZXQgdG8gZHVyaW5nIG5vcm1h" +
           "bCBvcGVyYXRpbmcgY29uZGl0aW9ucwAuAER8FwAAABUBAAAAAQH/////AAAAADVgiQoCAAAAAQAKAAAA" +
           "VGFyZ2V0TW9kZQEBfRcDAAAAAC8AAABNb2RlIG9mIG9wZXJhdGlvbiB0aGF0IGlzIGRlc2lyZWQgZm9y" +
           "IHRoZSBCbG9jawAuAER9FwAAABUBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Incremental counter indicating the number of times the static data within the Block has been modified
        /// </summary>
        public PropertyState<uint> RevisionCounter
        {
            get
            {
                return m_revisionCounter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        /// <summary>
        /// Current mode of operation the Block is able to achieve
        /// </summary>
        public PropertyState<LocalizedText> ActualMode
        {
            get
            {
                return m_actualMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actualMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actualMode = value;
            }
        }

        /// <summary>
        /// Modes of operation that are allowed for the Block based on application requirements
        /// </summary>
        public PropertyState<LocalizedText[]> PermittedMode
        {
            get
            {
                return m_permittedMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_permittedMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_permittedMode = value;
            }
        }

        /// <summary>
        /// Mode the Block should be set to during normal operating conditions
        /// </summary>
        public PropertyState<LocalizedText[]> NormalMode
        {
            get
            {
                return m_normalMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_normalMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_normalMode = value;
            }
        }

        /// <summary>
        /// Mode of operation that is desired for the Block
        /// </summary>
        public PropertyState<LocalizedText[]> TargetMode
        {
            get
            {
                return m_targetMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_targetMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetMode = value;
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
            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_actualMode != null)
            {
                children.Add(m_actualMode);
            }

            if (m_permittedMode != null)
            {
                children.Add(m_permittedMode);
            }

            if (m_normalMode != null)
            {
                children.Add(m_normalMode);
            }

            if (m_targetMode != null)
            {
                children.Add(m_targetMode);
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
                case Opc.Ua.Di.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<uint>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ActualMode:
                {
                    if (createOrReplace)
                    {
                        if (ActualMode == null)
                        {
                            if (replacement == null)
                            {
                                ActualMode = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ActualMode = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ActualMode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.PermittedMode:
                {
                    if (createOrReplace)
                    {
                        if (PermittedMode == null)
                        {
                            if (replacement == null)
                            {
                                PermittedMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                PermittedMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = PermittedMode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.NormalMode:
                {
                    if (createOrReplace)
                    {
                        if (NormalMode == null)
                        {
                            if (replacement == null)
                            {
                                NormalMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                NormalMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = NormalMode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.TargetMode:
                {
                    if (createOrReplace)
                    {
                        if (TargetMode == null)
                        {
                            if (replacement == null)
                            {
                                TargetMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                TargetMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = TargetMode;
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
        private PropertyState<uint> m_revisionCounter;
        private PropertyState<LocalizedText> m_actualMode;
        private PropertyState<LocalizedText[]> m_permittedMode;
        private PropertyState<LocalizedText[]> m_normalMode;
        private PropertyState<LocalizedText[]> m_targetMode;
        #endregion
    }
    #endif
    #endregion

    #region ConfigurableObjectState Class
    #if (!OPCUA_EXCLUDE_ConfigurableObjectState)
    /// <summary>
    /// Stores an instance of the ConfigurableObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConfigurableObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConfigurableObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.ConfigurableObjectType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAeAAAAQ29u" +
           "ZmlndXJhYmxlT2JqZWN0VHlwZUluc3RhbmNlAQHsAwEB7AP/////AQAAACRggAoBAAAAAQAOAAAAU3Vw" +
           "cG9ydGVkVHlwZXMBAYwTAwAAAAByAAAARm9sZGVyIG1haW50YWluaW5nIHRoZSBzZXQgb2YgKHN1Yi10" +
           "eXBlcyBvZikgQmFzZU9iamVjdFR5cGVzIHRoYXQgY2FuIGJlIGluc3RhbnRpYXRlZCBpbiB0aGUgQ29u" +
           "ZmlndXJhYmxlQ29tcG9uZW50AC8APYwTAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Folder maintaining the set of (sub-types of) BaseObjectTypes that can be instantiated in the ConfigurableComponent
        /// </summary>
        public FolderState SupportedTypes
        {
            get
            {
                return m_supportedTypes;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedTypes, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedTypes = value;
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
            if (m_supportedTypes != null)
            {
                children.Add(m_supportedTypes);
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
                case Opc.Ua.Di.BrowseNames.SupportedTypes:
                {
                    if (createOrReplace)
                    {
                        if (SupportedTypes == null)
                        {
                            if (replacement == null)
                            {
                                SupportedTypes = new FolderState(this);
                            }
                            else
                            {
                                SupportedTypes = (FolderState)replacement;
                            }
                        }
                    }

                    instance = SupportedTypes;
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
        private FolderState m_supportedTypes;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalGroupState Class
    #if (!OPCUA_EXCLUDE_FunctionalGroupState)
    /// <summary>
    /// Stores an instance of the FunctionalGroupType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalGroupState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FunctionalGroupState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.FunctionalGroupType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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

            if (UIElement != null)
            {
                UIElement.Initialize(context, UIElement_InitializationString);
            }
        }

        #region Initialization String
        private const string UIElement_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAJAAAAVUlF" +
           "bGVtZW50AQFjGAMAAAAAMAAAAEEgdXNlciBpbnRlcmZhY2UgZWxlbWVudCBhc3NpZ25lZCB0byB0aGlz" +
           "IGdyb3VwLgAvAQFmGGMYAAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAARnVu" +
           "Y3Rpb25hbEdyb3VwVHlwZUluc3RhbmNlAQHtAwEB7QP/////AQAAADVgiQoCAAAAAQAJAAAAVUlFbGVt" +
           "ZW50AQFjGAMAAAAAMAAAAEEgdXNlciBpbnRlcmZhY2UgZWxlbWVudCBhc3NpZ25lZCB0byB0aGlzIGdy" +
           "b3VwLgAvAQFmGGMYAAAAGP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A user interface element assigned to this group.
        /// </summary>
        public UIElementState UIElement
        {
            get
            {
                return m_uIElement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uIElement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uIElement = value;
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
            if (m_uIElement != null)
            {
                children.Add(m_uIElement);
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
                case Opc.Ua.Di.BrowseNames.UIElement:
                {
                    if (createOrReplace)
                    {
                        if (UIElement == null)
                        {
                            if (replacement == null)
                            {
                                UIElement = new UIElementState(this);
                            }
                            else
                            {
                                UIElement = (UIElementState)replacement;
                            }
                        }
                    }

                    instance = UIElement;
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
        private UIElementState m_uIElement;
        #endregion
    }
    #endif
    #endregion

    #region ProtocolState Class
    #if (!OPCUA_EXCLUDE_ProtocolState)
    /// <summary>
    /// Stores an instance of the ProtocolType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProtocolState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProtocolState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.ProtocolType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAUAAAAUHJv" +
           "dG9jb2xUeXBlSW5zdGFuY2UBAe4DAQHuA/////8AAAAA";
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

    #region DeviceHealthEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_DeviceHealthEnumeration)
    /// <summary>
    /// A description for the DeviceHealthEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public enum DeviceHealthEnumeration
    {
        /// <summary>
        /// This device functions normally.
        /// </summary>
        [EnumMember(Value = "NORMAL_0")]
        NORMAL = 0,

        /// <summary>
        /// Malfunction of the device or any of its peripherals.
        /// </summary>
        [EnumMember(Value = "FAILURE_1")]
        FAILURE = 1,

        /// <summary>
        /// Functional checks are currently performed.
        /// </summary>
        [EnumMember(Value = "CHECK_FUNCTION_2")]
        CHECK_FUNCTION = 2,

        /// <summary>
        /// The device is currently working outside of its specified range or that internal diagnoses indicate deviations from measured or set values.
        /// </summary>
        [EnumMember(Value = "OFF_SPEC_3")]
        OFF_SPEC = 3,

        /// <summary>
        /// This element is working, but a maintenance operation is required.
        /// </summary>
        [EnumMember(Value = "MAINTENANCE_REQUIRED_4")]
        MAINTENANCE_REQUIRED = 4,
    }

    #region DeviceHealthEnumerationCollection Class
    /// <summary>
    /// A collection of DeviceHealthEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDeviceHealthEnumeration", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "DeviceHealthEnumeration")]
    public partial class DeviceHealthEnumerationCollection : List<DeviceHealthEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DeviceHealthEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DeviceHealthEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DeviceHealthEnumerationCollection(IEnumerable<DeviceHealthEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DeviceHealthEnumerationCollection(DeviceHealthEnumeration[] values)
        {
            if (values != null)
            {
                return new DeviceHealthEnumerationCollection(values);
            }

            return new DeviceHealthEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DeviceHealthEnumeration[](DeviceHealthEnumerationCollection values)
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
            DeviceHealthEnumerationCollection clone = new DeviceHealthEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeviceHealthEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region UIElementState Class
    #if (!OPCUA_EXCLUDE_UIElementState)
    /// <summary>
    /// Stores an instance of the UIElementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UIElementState : BaseVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public UIElementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.VariableTypes.UIElementType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQACAAAAAQAVAAAAVUlF" +
           "bGVtZW50VHlwZUluc3RhbmNlAQFmGAEBZhgAGP////8BAf////8AAAAA";
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

    #region UIElementState<T> Class
    /// <summary>
    /// A typed version of the UIElementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class UIElementState<T> : UIElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public UIElementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region NetworkState Class
    #if (!OPCUA_EXCLUDE_NetworkState)
    /// <summary>
    /// Stores an instance of the NetworkType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NetworkState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public NetworkState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.NetworkType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }
        }

        #region Initialization String
        private const string Lock_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAEAAAATG9j" +
           "awEBlhgDAAAAABkAAABVc2VkIHRvIGxvY2sgdGhlIE5ldHdvcmsuAC8BAfQYlhgAAP////8IAAAAFWCJ" +
           "CgIAAAABAAYAAABMb2NrZWQBAWEZAC4ARGEZAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAA0AAABM" +
           "b2NraW5nQ2xpZW50AQGYGAAuAESYGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAATG9ja2lu" +
           "Z1VzZXIBAZkYAC4ARJkYAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1haW5pbmdMb2Nr" +
           "VGltZQEBmhgALgBEmhgAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5pdExvY2sBAZsY" +
           "AC8BAfkYmxgAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGcGAAuAEScGAAA" +
           "lgEAAAABACoBAR0AAAAOAAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "ABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGdGAAuAESdGAAAlgEAAAABACoBAR0AAAAOAAAA" +
           "SW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAAUmVu" +
           "ZXdMb2NrAQGeGAAvAQH8GJ4YAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AZ8YAC4ARJ8YAACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQAIAAAARXhpdExvY2sBAaAYAC8BAf4YoBgAAAEB/////wEAAAAV" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBoRgALgBEoRgAAJYBAAAAAQAqAQEdAAAADgAAAEV4" +
           "aXRMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFr" +
           "TG9jawEBohgALwEBABmiGAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGj" +
           "GAAuAESjGAAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQATAAAATmV0" +
           "d29ya1R5cGVJbnN0YW5jZQEBZxgBAWcY/////wEAAAAkYIAKAQAAAAEABAAAAExvY2sBAZYYAwAAAAAZ" +
           "AAAAVXNlZCB0byBsb2NrIHRoZSBOZXR3b3JrLgAvAQH0GJYYAAD/////CAAAABVgiQoCAAAAAQAGAAAA" +
           "TG9ja2VkAQFhGQAuAERhGQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQANAAAATG9ja2luZ0NsaWVu" +
           "dAEBmBgALgBEmBgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExvY2tpbmdVc2VyAQGZGAAu" +
           "AESZGAAAAAH/////AQH/////AAAAABVgiQoCAAAAAQARAAAAUmVtYWluaW5nTG9ja1RpbWUBAZoYAC4A" +
           "RJoYAAABACIB/////wEB/////wAAAAAEYYIKBAAAAAEACAAAAEluaXRMb2NrAQGbGAAvAQH5GJsYAAAB" +
           "Af////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnBgALgBEnBgAAJYBAAAAAQAqAQEd" +
           "AAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBnRgALgBEnRgAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3Rh" +
           "dHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAFJlbmV3TG9jawEBnhgA" +
           "LwEB/BieGAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGfGAAuAESfGAAA" +
           "lgEAAAABACoBAR4AAAAPAAAAUmVuZXdMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQGgGAAvAQH+GKAYAAABAf////8BAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAaEYAC4ARKEYAACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1" +
           "cwAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABCcmVha0xvY2sBAaIYAC8B" +
           "AQAZohgAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBoxgALgBEoxgAAJYB" +
           "AAAAAQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Used to lock the Network.
        /// </summary>
        public LockingServicesState Lock
        {
            get
            {
                return m_lock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
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
            if (m_lock != null)
            {
                children.Add(m_lock);
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
                case Opc.Ua.Di.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesState)replacement;
                            }
                        }
                    }

                    instance = Lock;
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
        private LockingServicesState m_lock;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPointState Class
    #if (!OPCUA_EXCLUDE_ConnectionPointState)
    /// <summary>
    /// Stores an instance of the ConnectionPointType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionPointState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConnectionPointState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.ConnectionPointType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAAQ29u" +
           "bmVjdGlvblBvaW50VHlwZUluc3RhbmNlAQGkGAEBpBj/////AQAAACRggAoBAAAAAQAOAAAATmV0d29y" +
           "a0FkZHJlc3MBAdIYAwAAAAAqAAAAVGhlIGFkZHJlc3Mgb2YgdGhlIGRldmljZSBvbiB0aGlzIG5ldHdv" +
           "cmsuAC8BAe0D0hgAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// The address of the device on this network.
        /// </summary>
        public FunctionalGroupState NetworkAddress
        {
            get
            {
                return m_networkAddress;
            }

            set
            {
                if (!Object.ReferenceEquals(m_networkAddress, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_networkAddress = value;
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
            if (m_networkAddress != null)
            {
                children.Add(m_networkAddress);
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
                case Opc.Ua.Di.BrowseNames.NetworkAddress:
                {
                    if (createOrReplace)
                    {
                        if (NetworkAddress == null)
                        {
                            if (replacement == null)
                            {
                                NetworkAddress = new FunctionalGroupState(this);
                            }
                            else
                            {
                                NetworkAddress = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = NetworkAddress;
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
        private FunctionalGroupState m_networkAddress;
        #endregion
    }
    #endif
    #endregion

    #region TransferToDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_TransferToDeviceMethodState)
    /// <summary>
    /// Stores an instance of the TransferToDeviceMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferToDeviceMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferToDeviceMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferToDeviceMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAaAAAAVHJh" +
           "bnNmZXJUb0RldmljZU1ldGhvZFR5cGUBAXMZAC8BAXMZcxkAAAEB/////wEAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBdBkALgBEdBkAAJYCAAAAAQAqAQEZAAAACgAAAFRyYW5zZmVySUQABv//" +
           "//8AAAAAAAEAKgEBIQAAABIAAABJbml0VHJhbnNmZXJTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferToDeviceMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int transferID = (int)outputArguments[0];
            int initTransferStatus = (int)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref transferID,
                    ref initTransferStatus);
            }

            outputArguments[0] = transferID;
            outputArguments[1] = initTransferStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferToDeviceMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int transferID,
        ref int initTransferStatus);
    #endif
    #endregion

    #region TransferFromDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_TransferFromDeviceMethodState)
    /// <summary>
    /// Stores an instance of the TransferFromDeviceMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferFromDeviceMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferFromDeviceMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferFromDeviceMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAcAAAAVHJh" +
           "bnNmZXJGcm9tRGV2aWNlTWV0aG9kVHlwZQEBdRkALwEBdRl1GQAAAQH/////AQAAABVgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQF2GQAuAER2GQAAlgIAAAABACoBARkAAAAKAAAAVHJhbnNmZXJJRAAG" +
           "/////wAAAAAAAQAqAQEhAAAAEgAAAEluaXRUcmFuc2ZlclN0YXR1cwAG/////wAAAAAAAQAoAQEAAAAB" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferFromDeviceMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int transferID = (int)outputArguments[0];
            int initTransferStatus = (int)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref transferID,
                    ref initTransferStatus);
            }

            outputArguments[0] = transferID;
            outputArguments[1] = initTransferStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferFromDeviceMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int transferID,
        ref int initTransferStatus);
    #endif
    #endregion

    #region FetchTransferResultDataMethodState Class
    #if (!OPCUA_EXCLUDE_FetchTransferResultDataMethodState)
    /// <summary>
    /// Stores an instance of the FetchTransferResultDataMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FetchTransferResultDataMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FetchTransferResultDataMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new FetchTransferResultDataMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAhAAAARmV0" +
           "Y2hUcmFuc2ZlclJlc3VsdERhdGFNZXRob2RUeXBlAQF3GQAvAQF3GXcZAAABAf////8CAAAAFWCpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBeBkALgBEeBkAAJYEAAAAAQAqAQEZAAAACgAAAFRyYW5zZmVy" +
           "SUQABv////8AAAAAAAEAKgEBHQAAAA4AAABTZXF1ZW5jZU51bWJlcgAG/////wAAAAAAAQAqAQEqAAAA" +
           "GwAAAE1heFBhcmFtZXRlclJlc3VsdHNUb1JldHVybgAG/////wAAAAAAAQAqAQEeAAAADwAAAE9taXRH" +
           "b29kUmVzdWx0cwAB/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAXkZAC4ARHkZAACWAQAAAAEAKgEBHAAAAAsAAABGZXRjaFJlc3VsdAEBehn/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public FetchTransferResultDataMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int transferID = (int)inputArguments[0];
            int sequenceNumber = (int)inputArguments[1];
            int maxParameterResultsToReturn = (int)inputArguments[2];
            bool omitGoodResults = (bool)inputArguments[3];

            FetchResultDataType fetchResult = (FetchResultDataType)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    transferID,
                    sequenceNumber,
                    maxParameterResultsToReturn,
                    omitGoodResults,
                    ref fetchResult);
            }

            outputArguments[0] = fetchResult;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult FetchTransferResultDataMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        int transferID,
        int sequenceNumber,
        int maxParameterResultsToReturn,
        bool omitGoodResults,
        ref FetchResultDataType fetchResult);
    #endif
    #endregion

    #region FetchResultDataType Class
    #if (!OPCUA_EXCLUDE_FetchResultDataType)
    /// <summary>
    /// A description for the FetchResultDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class FetchResultDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public FetchResultDataType()
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
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.FetchResultDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.FetchResultDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.FetchResultDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            FetchResultDataType value = encodeable as FetchResultDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            FetchResultDataType clone = (FetchResultDataType)this.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region FetchResultDataTypeCollection Class
    /// <summary>
    /// A collection of FetchResultDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFetchResultDataType", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "FetchResultDataType")]
    public partial class FetchResultDataTypeCollection : List<FetchResultDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public FetchResultDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public FetchResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public FetchResultDataTypeCollection(IEnumerable<FetchResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator FetchResultDataTypeCollection(FetchResultDataType[] values)
        {
            if (values != null)
            {
                return new FetchResultDataTypeCollection(values);
            }

            return new FetchResultDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator FetchResultDataType[](FetchResultDataTypeCollection values)
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
            FetchResultDataTypeCollection clone = new FetchResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FetchResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FetchResultErrorDataType Class
    #if (!OPCUA_EXCLUDE_FetchResultErrorDataType)
    /// <summary>
    /// A description for the FetchResultErrorDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class FetchResultErrorDataType : FetchResultDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public FetchResultErrorDataType()
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
            m_status = (int)0;
            m_diagnostics = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Status field.
        /// </summary>
        [DataMember(Name = "Status", IsRequired = false, Order = 1)]
        public int Status
        {
            get { return m_status;  }
            set { m_status = value; }
        }

        /// <summary>
        /// A description for the Diagnostics field.
        /// </summary>
        [DataMember(Name = "Diagnostics", IsRequired = false, Order = 2)]
        public DiagnosticInfo Diagnostics
        {
            get { return m_diagnostics;  }
            set { m_diagnostics = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.FetchResultErrorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.FetchResultErrorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.FetchResultErrorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteInt32("Status", Status);
            encoder.WriteDiagnosticInfo("Diagnostics", Diagnostics);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            Status = decoder.ReadInt32("Status");
            Diagnostics = decoder.ReadDiagnosticInfo("Diagnostics");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            FetchResultErrorDataType value = encodeable as FetchResultErrorDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_status, value.m_status)) return false;
            if (!Utils.IsEqual(m_diagnostics, value.m_diagnostics)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            FetchResultErrorDataType clone = (FetchResultErrorDataType)base.Clone();

            clone.m_status = (int)Utils.Clone(this.m_status);
            clone.m_diagnostics = (DiagnosticInfo)Utils.Clone(this.m_diagnostics);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_status;
        private DiagnosticInfo m_diagnostics;
        #endregion
    }

    #region FetchResultErrorDataTypeCollection Class
    /// <summary>
    /// A collection of FetchResultErrorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFetchResultErrorDataType", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "FetchResultErrorDataType")]
    public partial class FetchResultErrorDataTypeCollection : List<FetchResultErrorDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public FetchResultErrorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public FetchResultErrorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public FetchResultErrorDataTypeCollection(IEnumerable<FetchResultErrorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator FetchResultErrorDataTypeCollection(FetchResultErrorDataType[] values)
        {
            if (values != null)
            {
                return new FetchResultErrorDataTypeCollection(values);
            }

            return new FetchResultErrorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator FetchResultErrorDataType[](FetchResultErrorDataTypeCollection values)
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
            FetchResultErrorDataTypeCollection clone = new FetchResultErrorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FetchResultErrorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FetchResultDataDataType Class
    #if (!OPCUA_EXCLUDE_FetchResultDataDataType)
    /// <summary>
    /// A description for the FetchResultDataDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class FetchResultDataDataType : FetchResultDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public FetchResultDataDataType()
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
            m_sequenceNumber = (int)0;
            m_endOfResults = true;
            m_parameterDefs = new ParameterResultDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SequenceNumber field.
        /// </summary>
        [DataMember(Name = "SequenceNumber", IsRequired = false, Order = 1)]
        public int SequenceNumber
        {
            get { return m_sequenceNumber;  }
            set { m_sequenceNumber = value; }
        }

        /// <summary>
        /// A description for the EndOfResults field.
        /// </summary>
        [DataMember(Name = "EndOfResults", IsRequired = false, Order = 2)]
        public bool EndOfResults
        {
            get { return m_endOfResults;  }
            set { m_endOfResults = value; }
        }

        /// <summary>
        /// A description for the ParameterDefs field.
        /// </summary>
        [DataMember(Name = "ParameterDefs", IsRequired = false, Order = 3)]
        public ParameterResultDataTypeCollection ParameterDefs
        {
            get
            {
                return m_parameterDefs;
            }

            set
            {
                m_parameterDefs = value;

                if (value == null)
                {
                    m_parameterDefs = new ParameterResultDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.FetchResultDataDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.FetchResultDataDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.FetchResultDataDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteInt32("SequenceNumber", SequenceNumber);
            encoder.WriteBoolean("EndOfResults", EndOfResults);
            encoder.WriteEncodeableArray("ParameterDefs", ParameterDefs.ToArray(), typeof(ParameterResultDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            SequenceNumber = decoder.ReadInt32("SequenceNumber");
            EndOfResults = decoder.ReadBoolean("EndOfResults");
            ParameterDefs = (ParameterResultDataTypeCollection)decoder.ReadEncodeableArray("ParameterDefs", typeof(ParameterResultDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            FetchResultDataDataType value = encodeable as FetchResultDataDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sequenceNumber, value.m_sequenceNumber)) return false;
            if (!Utils.IsEqual(m_endOfResults, value.m_endOfResults)) return false;
            if (!Utils.IsEqual(m_parameterDefs, value.m_parameterDefs)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            FetchResultDataDataType clone = (FetchResultDataDataType)base.Clone();

            clone.m_sequenceNumber = (int)Utils.Clone(this.m_sequenceNumber);
            clone.m_endOfResults = (bool)Utils.Clone(this.m_endOfResults);
            clone.m_parameterDefs = (ParameterResultDataTypeCollection)Utils.Clone(this.m_parameterDefs);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_sequenceNumber;
        private bool m_endOfResults;
        private ParameterResultDataTypeCollection m_parameterDefs;
        #endregion
    }

    #region FetchResultDataDataTypeCollection Class
    /// <summary>
    /// A collection of FetchResultDataDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFetchResultDataDataType", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "FetchResultDataDataType")]
    public partial class FetchResultDataDataTypeCollection : List<FetchResultDataDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public FetchResultDataDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public FetchResultDataDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public FetchResultDataDataTypeCollection(IEnumerable<FetchResultDataDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator FetchResultDataDataTypeCollection(FetchResultDataDataType[] values)
        {
            if (values != null)
            {
                return new FetchResultDataDataTypeCollection(values);
            }

            return new FetchResultDataDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator FetchResultDataDataType[](FetchResultDataDataTypeCollection values)
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
            FetchResultDataDataTypeCollection clone = new FetchResultDataDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FetchResultDataDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ParameterResultDataType Class
    #if (!OPCUA_EXCLUDE_ParameterResultDataType)
    /// <summary>
    /// A description for the ParameterResultDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class ParameterResultDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ParameterResultDataType()
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
            m_nodePath = new QualifiedNameCollection();
            m_statusCode = StatusCodes.Good;
            m_diagnostics = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the NodePath field.
        /// </summary>
        [DataMember(Name = "NodePath", IsRequired = false, Order = 1)]
        public QualifiedNameCollection NodePath
        {
            get
            {
                return m_nodePath;
            }

            set
            {
                m_nodePath = value;

                if (value == null)
                {
                    m_nodePath = new QualifiedNameCollection();
                }
            }
        }

        /// <summary>
        /// A description for the StatusCode field.
        /// </summary>
        [DataMember(Name = "StatusCode", IsRequired = false, Order = 2)]
        public StatusCode StatusCode
        {
            get { return m_statusCode;  }
            set { m_statusCode = value; }
        }

        /// <summary>
        /// A description for the Diagnostics field.
        /// </summary>
        [DataMember(Name = "Diagnostics", IsRequired = false, Order = 3)]
        public DiagnosticInfo Diagnostics
        {
            get { return m_diagnostics;  }
            set { m_diagnostics = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ParameterResultDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ParameterResultDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ParameterResultDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteQualifiedNameArray("NodePath", NodePath);
            encoder.WriteStatusCode("StatusCode", StatusCode);
            encoder.WriteDiagnosticInfo("Diagnostics", Diagnostics);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            NodePath = decoder.ReadQualifiedNameArray("NodePath");
            StatusCode = decoder.ReadStatusCode("StatusCode");
            Diagnostics = decoder.ReadDiagnosticInfo("Diagnostics");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ParameterResultDataType value = encodeable as ParameterResultDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_nodePath, value.m_nodePath)) return false;
            if (!Utils.IsEqual(m_statusCode, value.m_statusCode)) return false;
            if (!Utils.IsEqual(m_diagnostics, value.m_diagnostics)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            ParameterResultDataType clone = (ParameterResultDataType)this.MemberwiseClone();

            clone.m_nodePath = (QualifiedNameCollection)Utils.Clone(this.m_nodePath);
            clone.m_statusCode = (StatusCode)Utils.Clone(this.m_statusCode);
            clone.m_diagnostics = (DiagnosticInfo)Utils.Clone(this.m_diagnostics);

            return clone;
        }
        #endregion

        #region Private Fields
        private QualifiedNameCollection m_nodePath;
        private StatusCode m_statusCode;
        private DiagnosticInfo m_diagnostics;
        #endregion
    }

    #region ParameterResultDataTypeCollection Class
    /// <summary>
    /// A collection of ParameterResultDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfParameterResultDataType", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "ParameterResultDataType")]
    public partial class ParameterResultDataTypeCollection : List<ParameterResultDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ParameterResultDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ParameterResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ParameterResultDataTypeCollection(IEnumerable<ParameterResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ParameterResultDataTypeCollection(ParameterResultDataType[] values)
        {
            if (values != null)
            {
                return new ParameterResultDataTypeCollection(values);
            }

            return new ParameterResultDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ParameterResultDataType[](ParameterResultDataTypeCollection values)
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
            ParameterResultDataTypeCollection clone = new ParameterResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ParameterResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TransferServicesState Class
    #if (!OPCUA_EXCLUDE_TransferServicesState)
    /// <summary>
    /// Stores an instance of the TransferServicesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferServicesState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferServicesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.TransferServicesType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAcAAAAVHJh" +
           "bnNmZXJTZXJ2aWNlc1R5cGVJbnN0YW5jZQEBfhkBAX4Z/////wMAAAAEYYIKBAAAAAEAEAAAAFRyYW5z" +
           "ZmVyVG9EZXZpY2UBAX8ZAC8BAX8ZfxkAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBgBkALgBEgBkAAJYCAAAAAQAqAQEZAAAACgAAAFRyYW5zZmVySUQABv////8AAAAAAAEAKgEB" +
           "IQAAABIAAABJbml0VHJhbnNmZXJTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQASAAAAVHJhbnNmZXJGcm9tRGV2aWNlAQGBGQAvAQGBGYEZAAABAf////8BAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAYIZAC4ARIIZAACWAgAAAAEAKgEBGQAAAAoAAABUcmFuc2ZlcklE" +
           "AAb/////AAAAAAABACoBASEAAAASAAAASW5pdFRyYW5zZmVyU3RhdHVzAAb/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEAFwAAAEZldGNoVHJhbnNmZXJSZXN1bHREYXRhAQGDGQAvAQGDGYMZ" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBhBkALgBEhBkAAJYEAAAAAQAq" +
           "AQEZAAAACgAAAFRyYW5zZmVySUQABv////8AAAAAAAEAKgEBHQAAAA4AAABTZXF1ZW5jZU51bWJlcgAG" +
           "/////wAAAAAAAQAqAQEqAAAAGwAAAE1heFBhcmFtZXRlclJlc3VsdHNUb1JldHVybgAG/////wAAAAAA" +
           "AQAqAQEeAAAADwAAAE9taXRHb29kUmVzdWx0cwAB/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYUZAC4ARIUZAACWAQAAAAEAKgEBHAAAAAsAAABGZXRj" +
           "aFJlc3VsdAEBehn/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the TransferFromDeviceMethodType Method.
        /// </summary>
        public TransferFromDeviceMethodState TransferToDevice
        {
            get
            {
                return m_transferToDeviceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transferToDeviceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferToDeviceMethod = value;
            }
        }

        /// <summary>
        /// A description for the TransferFromDeviceMethodType Method.
        /// </summary>
        public TransferFromDeviceMethodState TransferFromDevice
        {
            get
            {
                return m_transferFromDeviceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transferFromDeviceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferFromDeviceMethod = value;
            }
        }

        /// <summary>
        /// A description for the FetchTransferResultDataMethodType Method.
        /// </summary>
        public FetchTransferResultDataMethodState FetchTransferResultData
        {
            get
            {
                return m_fetchTransferResultDataMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fetchTransferResultDataMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fetchTransferResultDataMethod = value;
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
            if (m_transferToDeviceMethod != null)
            {
                children.Add(m_transferToDeviceMethod);
            }

            if (m_transferFromDeviceMethod != null)
            {
                children.Add(m_transferFromDeviceMethod);
            }

            if (m_fetchTransferResultDataMethod != null)
            {
                children.Add(m_fetchTransferResultDataMethod);
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
                case Opc.Ua.Di.BrowseNames.TransferToDevice:
                {
                    if (createOrReplace)
                    {
                        if (TransferToDevice == null)
                        {
                            if (replacement == null)
                            {
                                TransferToDevice = new TransferFromDeviceMethodState(this);
                            }
                            else
                            {
                                TransferToDevice = (TransferFromDeviceMethodState)replacement;
                            }
                        }
                    }

                    instance = TransferToDevice;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.TransferFromDevice:
                {
                    if (createOrReplace)
                    {
                        if (TransferFromDevice == null)
                        {
                            if (replacement == null)
                            {
                                TransferFromDevice = new TransferFromDeviceMethodState(this);
                            }
                            else
                            {
                                TransferFromDevice = (TransferFromDeviceMethodState)replacement;
                            }
                        }
                    }

                    instance = TransferFromDevice;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.FetchTransferResultData:
                {
                    if (createOrReplace)
                    {
                        if (FetchTransferResultData == null)
                        {
                            if (replacement == null)
                            {
                                FetchTransferResultData = new FetchTransferResultDataMethodState(this);
                            }
                            else
                            {
                                FetchTransferResultData = (FetchTransferResultDataMethodState)replacement;
                            }
                        }
                    }

                    instance = FetchTransferResultData;
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
        private TransferFromDeviceMethodState m_transferToDeviceMethod;
        private TransferFromDeviceMethodState m_transferFromDeviceMethod;
        private FetchTransferResultDataMethodState m_fetchTransferResultDataMethod;
        #endregion
    }
    #endif
    #endregion

    #region InitLockMethodState Class
    #if (!OPCUA_EXCLUDE_InitLockMethodState)
    /// <summary>
    /// Stores an instance of the InitLockMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InitLockMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InitLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new InitLockMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQASAAAASW5p" +
           "dExvY2tNZXRob2RUeXBlAQE6GQAvAQE6GToZAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBOxkALgBEOxkAAJYBAAAAAQAqAQEdAAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPBkALgBEPBkA" +
           "AJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public InitLockMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string currentContext = (string)inputArguments[0];

            int initLockStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    currentContext,
                    ref initLockStatus);
            }

            outputArguments[0] = initLockStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult InitLockMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string currentContext,
        ref int initLockStatus);
    #endif
    #endregion

    #region RenewLockMethodState Class
    #if (!OPCUA_EXCLUDE_RenewLockMethodState)
    /// <summary>
    /// Stores an instance of the RenewLockMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RenewLockMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RenewLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new RenewLockMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQATAAAAUmVu" +
           "ZXdMb2NrTWV0aG9kVHlwZQEBPRkALwEBPRk9GQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQE+GQAuAEQ+GQAAlgEAAAABACoBAR4AAAAPAAAAUmVuZXdMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public RenewLockMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int renewLockStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref renewLockStatus);
            }

            outputArguments[0] = renewLockStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult RenewLockMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int renewLockStatus);
    #endif
    #endregion

    #region ExitLockMethodState Class
    #if (!OPCUA_EXCLUDE_ExitLockMethodState)
    /// <summary>
    /// Stores an instance of the ExitLockMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExitLockMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ExitLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ExitLockMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQASAAAARXhp" +
           "dExvY2tNZXRob2RUeXBlAQE/GQAvAQE/GT8ZAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAUAZAC4AREAZAACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ExitLockMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int exitLockStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref exitLockStatus);
            }

            outputArguments[0] = exitLockStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ExitLockMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int exitLockStatus);
    #endif
    #endregion

    #region BreakLockMethodState Class
    #if (!OPCUA_EXCLUDE_BreakLockMethodState)
    /// <summary>
    /// Stores an instance of the BreakLockMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BreakLockMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BreakLockMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new BreakLockMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQATAAAAQnJl" +
           "YWtMb2NrTWV0aG9kVHlwZQEBQRkALwEBQRlBGQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFCGQAuAERCGQAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public BreakLockMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            int breakLockStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref breakLockStatus);
            }

            outputArguments[0] = breakLockStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult BreakLockMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int breakLockStatus);
    #endif
    #endregion

    #region LockingServicesState Class
    #if (!OPCUA_EXCLUDE_LockingServicesState)
    /// <summary>
    /// Stores an instance of the LockingServicesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LockingServicesState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LockingServicesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.LockingServicesType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAATG9j" +
           "a2luZ1NlcnZpY2VzVHlwZUluc3RhbmNlAQH0GAEB9Bj/////CAAAABVgiQoCAAAAAQAGAAAATG9ja2Vk" +
           "AQGGGQAuAESGGQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQANAAAATG9ja2luZ0NsaWVudAEB9hgA" +
           "LgBE9hgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExvY2tpbmdVc2VyAQH3GAAuAET3GAAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAQARAAAAUmVtYWluaW5nTG9ja1RpbWUBAfgYAC4ARPgYAAAB" +
           "ACIB/////wEB/////wAAAAAEYYIKBAAAAAEACAAAAEluaXRMb2NrAQH5GAAvAQH5GPkYAAABAf////8C" +
           "AAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB+hgALgBE+hgAAJYBAAAAAQAqAQEdAAAADgAA" +
           "AEN1cnJlbnRDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEB+xgALgBE+xgAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3RhdHVzAAb/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAFJlbmV3TG9jawEB/BgALwEB/Bj8" +
           "GAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQH9GAAuAET9GAAAlgEAAAAB" +
           "ACoBAR4AAAAPAAAAUmVuZXdMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACAAAAEV4aXRMb2NrAQH+GAAvAQH+GP4YAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAf8YAC4ARP8YAACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABCcmVha0xvY2sBAQAZAC8BAQAZABkA" +
           "AAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBARkALgBEARkAAJYBAAAAAQAq" +
           "AQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Locked Property.
        /// </summary>
        public PropertyState<bool> Locked
        {
            get
            {
                return m_locked;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locked, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locked = value;
            }
        }

        /// <summary>
        /// A description for the LockingClient Property.
        /// </summary>
        public PropertyState<string> LockingClient
        {
            get
            {
                return m_lockingClient;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lockingClient, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockingClient = value;
            }
        }

        /// <summary>
        /// A description for the LockingUser Property.
        /// </summary>
        public PropertyState<bool> LockingUser
        {
            get
            {
                return m_lockingUser;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lockingUser, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockingUser = value;
            }
        }

        /// <summary>
        /// A description for the RemainingLockTime Property.
        /// </summary>
        public PropertyState<double> RemainingLockTime
        {
            get
            {
                return m_remainingLockTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_remainingLockTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_remainingLockTime = value;
            }
        }

        /// <summary>
        /// A description for the InitLockMethodType Method.
        /// </summary>
        public InitLockMethodState InitLock
        {
            get
            {
                return m_initLockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_initLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initLockMethod = value;
            }
        }

        /// <summary>
        /// A description for the RenewLockMethodType Method.
        /// </summary>
        public RenewLockMethodState RenewLock
        {
            get
            {
                return m_renewLockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_renewLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_renewLockMethod = value;
            }
        }

        /// <summary>
        /// A description for the ExitLockMethodType Method.
        /// </summary>
        public ExitLockMethodState ExitLock
        {
            get
            {
                return m_exitLockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_exitLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_exitLockMethod = value;
            }
        }

        /// <summary>
        /// A description for the BreakLockMethodType Method.
        /// </summary>
        public BreakLockMethodState BreakLock
        {
            get
            {
                return m_breakLockMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_breakLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_breakLockMethod = value;
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
            if (m_locked != null)
            {
                children.Add(m_locked);
            }

            if (m_lockingClient != null)
            {
                children.Add(m_lockingClient);
            }

            if (m_lockingUser != null)
            {
                children.Add(m_lockingUser);
            }

            if (m_remainingLockTime != null)
            {
                children.Add(m_remainingLockTime);
            }

            if (m_initLockMethod != null)
            {
                children.Add(m_initLockMethod);
            }

            if (m_renewLockMethod != null)
            {
                children.Add(m_renewLockMethod);
            }

            if (m_exitLockMethod != null)
            {
                children.Add(m_exitLockMethod);
            }

            if (m_breakLockMethod != null)
            {
                children.Add(m_breakLockMethod);
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
                case Opc.Ua.Di.BrowseNames.Locked:
                {
                    if (createOrReplace)
                    {
                        if (Locked == null)
                        {
                            if (replacement == null)
                            {
                                Locked = new PropertyState<bool>(this);
                            }
                            else
                            {
                                Locked = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = Locked;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.LockingClient:
                {
                    if (createOrReplace)
                    {
                        if (LockingClient == null)
                        {
                            if (replacement == null)
                            {
                                LockingClient = new PropertyState<string>(this);
                            }
                            else
                            {
                                LockingClient = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LockingClient;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.LockingUser:
                {
                    if (createOrReplace)
                    {
                        if (LockingUser == null)
                        {
                            if (replacement == null)
                            {
                                LockingUser = new PropertyState<bool>(this);
                            }
                            else
                            {
                                LockingUser = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = LockingUser;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.RemainingLockTime:
                {
                    if (createOrReplace)
                    {
                        if (RemainingLockTime == null)
                        {
                            if (replacement == null)
                            {
                                RemainingLockTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                RemainingLockTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = RemainingLockTime;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.InitLock:
                {
                    if (createOrReplace)
                    {
                        if (InitLock == null)
                        {
                            if (replacement == null)
                            {
                                InitLock = new InitLockMethodState(this);
                            }
                            else
                            {
                                InitLock = (InitLockMethodState)replacement;
                            }
                        }
                    }

                    instance = InitLock;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.RenewLock:
                {
                    if (createOrReplace)
                    {
                        if (RenewLock == null)
                        {
                            if (replacement == null)
                            {
                                RenewLock = new RenewLockMethodState(this);
                            }
                            else
                            {
                                RenewLock = (RenewLockMethodState)replacement;
                            }
                        }
                    }

                    instance = RenewLock;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ExitLock:
                {
                    if (createOrReplace)
                    {
                        if (ExitLock == null)
                        {
                            if (replacement == null)
                            {
                                ExitLock = new ExitLockMethodState(this);
                            }
                            else
                            {
                                ExitLock = (ExitLockMethodState)replacement;
                            }
                        }
                    }

                    instance = ExitLock;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.BreakLock:
                {
                    if (createOrReplace)
                    {
                        if (BreakLock == null)
                        {
                            if (replacement == null)
                            {
                                BreakLock = new BreakLockMethodState(this);
                            }
                            else
                            {
                                BreakLock = (BreakLockMethodState)replacement;
                            }
                        }
                    }

                    instance = BreakLock;
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
        private PropertyState<bool> m_locked;
        private PropertyState<string> m_lockingClient;
        private PropertyState<bool> m_lockingUser;
        private PropertyState<double> m_remainingLockTime;
        private InitLockMethodState m_initLockMethod;
        private RenewLockMethodState m_renewLockMethod;
        private ExitLockMethodState m_exitLockMethod;
        private BreakLockMethodState m_breakLockMethod;
        #endregion
    }
    #endif
    #endregion
}