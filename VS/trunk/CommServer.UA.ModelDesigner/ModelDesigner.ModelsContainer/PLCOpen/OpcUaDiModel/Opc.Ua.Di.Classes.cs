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
        public const uint DeviceHealthEnumeration = 256;

        /// <summary>
        /// The identifier for the TransferStatusType DataType.
        /// </summary>
        public const uint TransferStatusType = 445;

        /// <summary>
        /// The identifier for the TransferResult DataType.
        /// </summary>
        public const uint TransferResult = 446;

        /// <summary>
        /// The identifier for the ParameterResult DataType.
        /// </summary>
        public const uint ParameterResult = 447;
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
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_InitLock = 17;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RenewLock Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_RenewLock = 20;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_ExitLock Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_ExitLock = 22;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_BreakLock Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_BreakLock = 24;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_EnterEditMode = 27;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_ExitEditMode Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_ExitEditMode = 30;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_AbortEditMode Method.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_AbortEditMode = 32;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_InitLock = 58;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_RenewLock = 61;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_ExitLock = 63;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_BreakLock = 65;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock Method.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_InitLock = 75;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RenewLock Method.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_RenewLock = 78;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_ExitLock Method.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_ExitLock = 80;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_BreakLock Method.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_BreakLock = 82;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_InitLock = 97;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RenewLock Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_RenewLock = 100;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_ExitLock Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_ExitLock = 102;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_BreakLock Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_BreakLock = 104;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_EnterEditMode = 107;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_ExitEditMode Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_ExitEditMode = 110;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_AbortEditMode Method.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_AbortEditMode = 112;

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet_MethodIdentifier Method.
        /// </summary>
        public const uint TopologyElementType_MethodSet_MethodIdentifier = 135;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock = 145;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock = 148;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock = 150;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock = 152;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode Method.
        /// </summary>
        public const uint TopologyElementType_EditMode_EnterEditMode = 155;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_ExitEditMode Method.
        /// </summary>
        public const uint TopologyElementType_EditMode_ExitEditMode = 158;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_AbortEditMode Method.
        /// </summary>
        public const uint TopologyElementType_EditMode_AbortEditMode = 160;

        /// <summary>
        /// The identifier for the FunctionalGroupType_MethodIdentifier Method.
        /// </summary>
        public const uint FunctionalGroupType_MethodIdentifier = 253;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock = 295;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock = 298;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock = 300;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock = 302;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_InitLock = 311;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock = 314;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock = 316;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock = 318;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock = 357;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock = 360;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock = 362;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock = 364;

        /// <summary>
        /// The identifier for the InitLockMethodType Method.
        /// </summary>
        public const uint InitLockMethodType = 400;

        /// <summary>
        /// The identifier for the RenewLockMethodType Method.
        /// </summary>
        public const uint RenewLockMethodType = 403;

        /// <summary>
        /// The identifier for the ExitLockMethodType Method.
        /// </summary>
        public const uint ExitLockMethodType = 405;

        /// <summary>
        /// The identifier for the BreakLockMethodType Method.
        /// </summary>
        public const uint BreakLockMethodType = 407;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock Method.
        /// </summary>
        public const uint LockingServicesType_InitLock = 414;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock Method.
        /// </summary>
        public const uint LockingServicesType_RenewLock = 417;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock Method.
        /// </summary>
        public const uint LockingServicesType_ExitLock = 419;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock Method.
        /// </summary>
        public const uint LockingServicesType_BreakLock = 421;

        /// <summary>
        /// The identifier for the EnterEditModeMethodType Method.
        /// </summary>
        public const uint EnterEditModeMethodType = 423;

        /// <summary>
        /// The identifier for the ExitEditModeMethodType Method.
        /// </summary>
        public const uint ExitEditModeMethodType = 426;

        /// <summary>
        /// The identifier for the AbortEditModeErrorMethodType Method.
        /// </summary>
        public const uint AbortEditModeErrorMethodType = 428;

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode Method.
        /// </summary>
        public const uint EditModeType_EnterEditMode = 431;

        /// <summary>
        /// The identifier for the EditModeType_ExitEditMode Method.
        /// </summary>
        public const uint EditModeType_ExitEditMode = 434;

        /// <summary>
        /// The identifier for the EditModeType_AbortEditMode Method.
        /// </summary>
        public const uint EditModeType_AbortEditMode = 436;

        /// <summary>
        /// The identifier for the TransferToDevice Method.
        /// </summary>
        public const uint TransferToDevice = 438;

        /// <summary>
        /// The identifier for the TransferFromDevice Method.
        /// </summary>
        public const uint TransferFromDevice = 440;

        /// <summary>
        /// The identifier for the FetchTransferResultData Method.
        /// </summary>
        public const uint FetchTransferResultData = 442;
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
        public const uint DeviceSet = 4;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_ParameterSet Object.
        /// </summary>
        public const uint DeviceSet_DeviceName_ParameterSet = 6;

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public const uint NetworkSet = 51;

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public const uint DeviceTopology = 67;

        /// <summary>
        /// The identifier for the CommunicationDevices Object.
        /// </summary>
        public const uint CommunicationDevices = 84;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_ParameterSet Object.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_ParameterSet = 86;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public const uint TopologyElementType_ParameterSet = 132;

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public const uint TopologyElementType_MethodSet = 134;

        /// <summary>
        /// The identifier for the TopologyElementType_GroupName Object.
        /// </summary>
        public const uint TopologyElementType_GroupName = 136;

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public const uint TopologyElementType_Identification = 138;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public const uint TopologyElementType_Lock = 140;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode Object.
        /// </summary>
        public const uint TopologyElementType_EditMode = 154;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage Object.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage = 202;

        /// <summary>
        /// The identifier for the DeviceType_Documentation Object.
        /// </summary>
        public const uint DeviceType_Documentation = 204;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport Object.
        /// </summary>
        public const uint DeviceType_ProtocolSupport = 206;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet Object.
        /// </summary>
        public const uint DeviceType_ImageSet = 208;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_SupportedTypes Object.
        /// </summary>
        public const uint ConfigurableObjectType_SupportedTypes = 247;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_ObjectIdentifier Object.
        /// </summary>
        public const uint ConfigurableObjectType_ObjectIdentifier = 248;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier Object.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier = 250;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier = 260;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock = 290;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkAddress = 304;

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public const uint NetworkType_Lock = 306;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier = 351;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkAddress = 366;

        /// <summary>
        /// The identifier for the TransferStatusType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint TransferStatusType_Encoding_DefaultXml = 448;

        /// <summary>
        /// The identifier for the TransferResult_Encoding_DefaultXml Object.
        /// </summary>
        public const uint TransferResult_Encoding_DefaultXml = 449;

        /// <summary>
        /// The identifier for the ParameterResult_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ParameterResult_Encoding_DefaultXml = 450;

        /// <summary>
        /// The identifier for the TransferStatusType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint TransferStatusType_Encoding_DefaultBinary = 463;

        /// <summary>
        /// The identifier for the TransferResult_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint TransferResult_Encoding_DefaultBinary = 464;

        /// <summary>
        /// The identifier for the ParameterResult_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ParameterResult_Encoding_DefaultBinary = 465;
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
        public const uint TopologyElementType = 131;

        /// <summary>
        /// The identifier for the DeviceType ObjectType.
        /// </summary>
        public const uint DeviceType = 162;

        /// <summary>
        /// The identifier for the BlockType ObjectType.
        /// </summary>
        public const uint BlockType = 210;

        /// <summary>
        /// The identifier for the ConfigurableObjectType ObjectType.
        /// </summary>
        public const uint ConfigurableObjectType = 246;

        /// <summary>
        /// The identifier for the FunctionalGroupType ObjectType.
        /// </summary>
        public const uint FunctionalGroupType = 249;

        /// <summary>
        /// The identifier for the ProtocolType ObjectType.
        /// </summary>
        public const uint ProtocolType = 255;

        /// <summary>
        /// The identifier for the NetworkType ObjectType.
        /// </summary>
        public const uint NetworkType = 259;

        /// <summary>
        /// The identifier for the ConnectionPointType ObjectType.
        /// </summary>
        public const uint ConnectionPointType = 320;

        /// <summary>
        /// The identifier for the OnlineElementType ObjectType.
        /// </summary>
        public const uint OnlineElementType = 368;

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public const uint LockingServicesType = 409;

        /// <summary>
        /// The identifier for the EditModeType ObjectType.
        /// </summary>
        public const uint EditModeType = 430;
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
        /// The identifier for the Uses ReferenceType.
        /// </summary>
        public const uint Uses = 1;

        /// <summary>
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public const uint ConnectsTo = 2;

        /// <summary>
        /// The identifier for the IsOnline ReferenceType.
        /// </summary>
        public const uint IsOnline = 3;
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
        /// The identifier for the DeviceSet_DeviceName_Lock_LockedStatus Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_LockedStatus = 13;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_LockingClient Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_LockingClient = 14;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_LockingUser Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_LockingUser = 15;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_RemainingLockTime = 16;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_InitLock_InputArguments = 18;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_InitLock_OutputArguments = 19;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_RenewLock_OutputArguments = 21;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_ExitLock_OutputArguments = 23;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Lock_BreakLock_OutputArguments = 25;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_EnterEditMode_InputArguments = 28;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_EnterEditMode_OutputArguments = 29;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_ExitEditMode_OutputArguments = 31;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_EditMode_AbortEditMode_OutputArguments = 33;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_SerialNumber Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_SerialNumber = 34;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_RevisionCounter Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_RevisionCounter = 35;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Manufacturer Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Manufacturer = 36;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Model Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_Model = 37;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceManual Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_DeviceManual = 38;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceRevision Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_DeviceRevision = 39;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_SoftwareRevision Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_SoftwareRevision = 40;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_HardwareRevision Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_HardwareRevision = 41;

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceHealth Variable.
        /// </summary>
        public const uint DeviceSet_DeviceName_DeviceHealth = 42;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockedStatus Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_LockedStatus = 54;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_LockingClient = 55;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_LockingUser = 56;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_RemainingLockTime = 57;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_InitLock_InputArguments = 59;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_InitLock_OutputArguments = 60;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_RenewLock_OutputArguments = 62;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_ExitLock_OutputArguments = 64;

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkSet_NetworkName_Lock_BreakLock_OutputArguments = 66;

        /// <summary>
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public const uint DeviceTopology_OnlineAccess = 68;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockedStatus Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_LockedStatus = 71;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockingClient Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_LockingClient = 72;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockingUser Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_LockingUser = 73;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_RemainingLockTime = 74;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_InitLock_InputArguments = 76;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_InitLock_OutputArguments = 77;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_RenewLock_OutputArguments = 79;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_ExitLock_OutputArguments = 81;

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceTopology_NetworkName_Lock_BreakLock_OutputArguments = 83;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockedStatus Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_LockedStatus = 93;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockingClient Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_LockingClient = 94;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockingUser Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_LockingUser = 95;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_RemainingLockTime = 96;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_InitLock_InputArguments = 98;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_InitLock_OutputArguments = 99;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_RenewLock_OutputArguments = 101;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_ExitLock_OutputArguments = 103;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Lock_BreakLock_OutputArguments = 105;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_EnterEditMode_InputArguments = 108;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_EnterEditMode_OutputArguments = 109;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_ExitEditMode_OutputArguments = 111;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_EditMode_AbortEditMode_OutputArguments = 113;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_SerialNumber Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_SerialNumber = 114;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_RevisionCounter Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_RevisionCounter = 115;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Manufacturer Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Manufacturer = 116;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Model Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_Model = 117;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceManual Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_DeviceManual = 118;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceRevision Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_DeviceRevision = 119;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_SoftwareRevision Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_SoftwareRevision = 120;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_HardwareRevision Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_HardwareRevision = 121;

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceHealth Variable.
        /// </summary>
        public const uint CommunicationDevices_DeviceName_DeviceHealth = 122;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public const uint TopologyElementType_ParameterSet_ParameterIdentifier = 133;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockedStatus Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockedStatus = 141;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingClient Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingClient = 142;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingUser Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingUser = 143;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RemainingLockTime = 144;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_InputArguments = 146;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_OutputArguments = 147;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock_OutputArguments = 149;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock_OutputArguments = 151;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock_OutputArguments = 153;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_EditMode_EnterEditMode_InputArguments = 156;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_EditMode_EnterEditMode_OutputArguments = 157;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_EditMode_ExitEditMode_OutputArguments = 159;

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_EditMode_AbortEditMode_OutputArguments = 161;

        /// <summary>
        /// The identifier for the DeviceType_SerialNumber Variable.
        /// </summary>
        public const uint DeviceType_SerialNumber = 193;

        /// <summary>
        /// The identifier for the DeviceType_RevisionCounter Variable.
        /// </summary>
        public const uint DeviceType_RevisionCounter = 194;

        /// <summary>
        /// The identifier for the DeviceType_Manufacturer Variable.
        /// </summary>
        public const uint DeviceType_Manufacturer = 195;

        /// <summary>
        /// The identifier for the DeviceType_Model Variable.
        /// </summary>
        public const uint DeviceType_Model = 196;

        /// <summary>
        /// The identifier for the DeviceType_DeviceManual Variable.
        /// </summary>
        public const uint DeviceType_DeviceManual = 197;

        /// <summary>
        /// The identifier for the DeviceType_DeviceRevision Variable.
        /// </summary>
        public const uint DeviceType_DeviceRevision = 198;

        /// <summary>
        /// The identifier for the DeviceType_SoftwareRevision Variable.
        /// </summary>
        public const uint DeviceType_SoftwareRevision = 199;

        /// <summary>
        /// The identifier for the DeviceType_HardwareRevision Variable.
        /// </summary>
        public const uint DeviceType_HardwareRevision = 200;

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealth Variable.
        /// </summary>
        public const uint DeviceType_DeviceHealth = 201;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage_ImageIdentifier = 203;

        /// <summary>
        /// The identifier for the DeviceType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public const uint DeviceType_Documentation_DocumentIdentifier = 205;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ProtocolSupport_ProtocolSupportIdentifier = 207;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ImageSet_ImageIdentifier = 209;

        /// <summary>
        /// The identifier for the BlockType_RevisionCounter Variable.
        /// </summary>
        public const uint BlockType_RevisionCounter = 241;

        /// <summary>
        /// The identifier for the BlockType_ActualMode Variable.
        /// </summary>
        public const uint BlockType_ActualMode = 242;

        /// <summary>
        /// The identifier for the BlockType_PermittedMode Variable.
        /// </summary>
        public const uint BlockType_PermittedMode = 243;

        /// <summary>
        /// The identifier for the BlockType_NormalMode Variable.
        /// </summary>
        public const uint BlockType_NormalMode = 244;

        /// <summary>
        /// The identifier for the BlockType_TargetMode Variable.
        /// </summary>
        public const uint BlockType_TargetMode = 245;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier_UIElement = 251;

        /// <summary>
        /// The identifier for the FunctionalGroupType_ParameterIdentifier Variable.
        /// </summary>
        public const uint FunctionalGroupType_ParameterIdentifier = 252;

        /// <summary>
        /// The identifier for the FunctionalGroupType_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_UIElement = 254;

        /// <summary>
        /// The identifier for the DeviceHealthEnumeration_EnumStrings Variable.
        /// </summary>
        public const uint DeviceHealthEnumeration_EnumStrings = 257;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockedStatus Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockedStatus = 291;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingClient = 292;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingUser = 293;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_RemainingLockTime = 294;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_InputArguments = 296;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_OutputArguments = 297;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock_OutputArguments = 299;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock_OutputArguments = 301;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock_OutputArguments = 303;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockedStatus Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockedStatus = 307;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingClient = 308;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingUser = 309;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkType_Lock_RemainingLockTime = 310;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_InputArguments = 312;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_OutputArguments = 313;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock_OutputArguments = 315;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock_OutputArguments = 317;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock_OutputArguments = 319;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockedStatus Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockedStatus = 353;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingClient = 354;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingUser = 355;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = 356;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = 358;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = 359;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = 361;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = 363;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = 365;

        /// <summary>
        /// The identifier for the MaxInactiveLockTime Variable.
        /// </summary>
        public const uint MaxInactiveLockTime = 399;

        /// <summary>
        /// The identifier for the InitLockMethodType_InputArguments Variable.
        /// </summary>
        public const uint InitLockMethodType_InputArguments = 401;

        /// <summary>
        /// The identifier for the InitLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint InitLockMethodType_OutputArguments = 402;

        /// <summary>
        /// The identifier for the RenewLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint RenewLockMethodType_OutputArguments = 404;

        /// <summary>
        /// The identifier for the ExitLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint ExitLockMethodType_OutputArguments = 406;

        /// <summary>
        /// The identifier for the BreakLockMethodType_OutputArguments Variable.
        /// </summary>
        public const uint BreakLockMethodType_OutputArguments = 408;

        /// <summary>
        /// The identifier for the LockingServicesType_LockedStatus Variable.
        /// </summary>
        public const uint LockingServicesType_LockedStatus = 410;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingClient Variable.
        /// </summary>
        public const uint LockingServicesType_LockingClient = 411;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingUser Variable.
        /// </summary>
        public const uint LockingServicesType_LockingUser = 412;

        /// <summary>
        /// The identifier for the LockingServicesType_RemainingLockTime Variable.
        /// </summary>
        public const uint LockingServicesType_RemainingLockTime = 413;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_InputArguments = 415;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_OutputArguments = 416;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_RenewLock_OutputArguments = 418;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_ExitLock_OutputArguments = 420;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_BreakLock_OutputArguments = 422;

        /// <summary>
        /// The identifier for the EnterEditModeMethodType_InputArguments Variable.
        /// </summary>
        public const uint EnterEditModeMethodType_InputArguments = 424;

        /// <summary>
        /// The identifier for the EnterEditModeMethodType_OutputArguments Variable.
        /// </summary>
        public const uint EnterEditModeMethodType_OutputArguments = 425;

        /// <summary>
        /// The identifier for the ExitEditModeMethodType_OutputArguments Variable.
        /// </summary>
        public const uint ExitEditModeMethodType_OutputArguments = 427;

        /// <summary>
        /// The identifier for the AbortEditModeErrorMethodType_OutputArguments Variable.
        /// </summary>
        public const uint AbortEditModeErrorMethodType_OutputArguments = 429;

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode_InputArguments Variable.
        /// </summary>
        public const uint EditModeType_EnterEditMode_InputArguments = 432;

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public const uint EditModeType_EnterEditMode_OutputArguments = 433;

        /// <summary>
        /// The identifier for the EditModeType_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public const uint EditModeType_ExitEditMode_OutputArguments = 435;

        /// <summary>
        /// The identifier for the EditModeType_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public const uint EditModeType_AbortEditMode_OutputArguments = 437;

        /// <summary>
        /// The identifier for the TransferToDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferToDevice_OutputArguments = 439;

        /// <summary>
        /// The identifier for the TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferFromDevice_OutputArguments = 441;

        /// <summary>
        /// The identifier for the FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public const uint FetchTransferResultData_InputArguments = 443;

        /// <summary>
        /// The identifier for the FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public const uint FetchTransferResultData_OutputArguments = 444;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema = 451;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_NamespaceUri = 453;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferStatusType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_TransferStatusType = 454;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResult Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_TransferResult = 457;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResult Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_ParameterResult = 460;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema = 466;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_NamespaceUri = 468;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferStatusType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_TransferStatusType = 469;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResult Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_TransferResult = 472;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResult Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_ParameterResult = 475;
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
        public const uint UIElementType = 258;
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
        /// The identifier for the TransferStatusType DataType.
        /// </summary>
        public static readonly ExpandedNodeId TransferStatusType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.TransferStatusType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResult DataType.
        /// </summary>
        public static readonly ExpandedNodeId TransferResult = new ExpandedNodeId(Opc.Ua.Di.DataTypes.TransferResult, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResult DataType.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResult = new ExpandedNodeId(Opc.Ua.Di.DataTypes.ParameterResult, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_EnterEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_EditMode_EnterEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_ExitEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_ExitEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_EditMode_ExitEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_AbortEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_AbortEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceSet_DeviceName_EditMode_AbortEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkSet_NetworkName_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkSet_NetworkName_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkSet_NetworkName_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkSet_NetworkName_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceTopology_NetworkName_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceTopology_NetworkName_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceTopology_NetworkName_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceTopology_NetworkName_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_EnterEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_EditMode_EnterEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_ExitEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_ExitEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_EditMode_ExitEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_AbortEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_AbortEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.CommunicationDevices_DeviceName_EditMode_AbortEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_EnterEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_EditMode_EnterEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_ExitEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_ExitEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_EditMode_ExitEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_AbortEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_AbortEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_EditMode_AbortEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_MethodIdentifier Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_MethodIdentifier = new ExpandedNodeId(Opc.Ua.Di.Methods.FunctionalGroupType_MethodIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

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

        /// <summary>
        /// The identifier for the EnterEditModeMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId EnterEditModeMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.EnterEditModeMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ExitEditModeMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId ExitEditModeMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.ExitEditModeMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the AbortEditModeErrorMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AbortEditModeErrorMethodType = new ExpandedNodeId(Opc.Ua.Di.Methods.AbortEditModeErrorMethodType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_EnterEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.EditModeType_EnterEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_ExitEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_ExitEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.EditModeType_ExitEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_AbortEditMode Method.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_AbortEditMode = new ExpandedNodeId(Opc.Ua.Di.Methods.EditModeType_AbortEditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferToDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferToDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferToDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferFromDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferFromDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferFromDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultData Method.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultData = new ExpandedNodeId(Opc.Ua.Di.Methods.FetchTransferResultData, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the DeviceSet_DeviceName_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_ParameterSet = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceSet_DeviceName_ParameterSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceTopology, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices = new ExpandedNodeId(Opc.Ua.Di.Objects.CommunicationDevices, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_ParameterSet = new ExpandedNodeId(Opc.Ua.Di.Objects.CommunicationDevices_DeviceName_ParameterSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_ParameterSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_MethodSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_MethodSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_GroupName Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_GroupName = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_GroupName, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Identification = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Identification, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_EditMode, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier_NetworkIdentifier_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferStatusType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferStatusType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferStatusType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResult_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResult_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResult_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferStatusType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferStatusType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferStatusType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResult_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResult_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResult_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the OnlineElementType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OnlineElementType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.OnlineElementType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.LockingServicesType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.EditModeType, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The identifier for the Uses ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId Uses = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.Uses, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectsTo = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.ConnectsTo, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the DeviceSet_DeviceName_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_EnterEditMode_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_EditMode_EnterEditMode_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_EnterEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_EditMode_EnterEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_ExitEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_EditMode_ExitEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_EditMode_AbortEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_EditMode_AbortEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet_DeviceName_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet_DeviceName_DeviceHealth = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceSet_DeviceName_DeviceHealth, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet_NetworkName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet_NetworkName_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkSet_NetworkName_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_OnlineAccess = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_OnlineAccess, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_NetworkName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_NetworkName_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_NetworkName_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_EnterEditMode_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_EditMode_EnterEditMode_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_EnterEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_EditMode_EnterEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_ExitEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_EditMode_ExitEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_EditMode_AbortEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_EditMode_AbortEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CommunicationDevices_DeviceName_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationDevices_DeviceName_DeviceHealth = new ExpandedNodeId(Opc.Ua.Di.Variables.CommunicationDevices_DeviceName_DeviceHealth, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet_ParameterIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_ParameterSet_ParameterIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_EnterEditMode_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_EditMode_EnterEditMode_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_EnterEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_EditMode_EnterEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_ExitEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_EditMode_ExitEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_EditMode_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_EditMode_AbortEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_EditMode_AbortEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_NetworkIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the LockingServicesType_LockedStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_LockedStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_LockedStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

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
        /// The identifier for the EnterEditModeMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EnterEditModeMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EnterEditModeMethodType_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EnterEditModeMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EnterEditModeMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EnterEditModeMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ExitEditModeMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExitEditModeMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ExitEditModeMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the AbortEditModeErrorMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AbortEditModeErrorMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.AbortEditModeErrorMethodType_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_EnterEditMode_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EditModeType_EnterEditMode_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_EnterEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_EnterEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EditModeType_EnterEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_ExitEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_ExitEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EditModeType_ExitEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the EditModeType_AbortEditMode_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId EditModeType_AbortEditMode_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.EditModeType_AbortEditMode_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferToDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferToDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferToDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferFromDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferFromDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultData_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FetchTransferResultData_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FetchTransferResultData_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FetchTransferResultData_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferStatusType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_TransferStatusType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_TransferStatusType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_TransferResult = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_TransferResult, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_ParameterResult = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_ParameterResult, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferStatusType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_TransferStatusType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_TransferStatusType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_TransferResult = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_TransferResult, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_ParameterResult = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_ParameterResult, Opc.Ua.Di.Namespaces.OpcUaDi);
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
        /// The BrowseName for the AbortEditMode component.
        /// </summary>
        public const string AbortEditMode = "AbortEditMode";

        /// <summary>
        /// The BrowseName for the AbortEditModeErrorMethodType component.
        /// </summary>
        public const string AbortEditModeErrorMethodType = "AbortEditModeErrorMethodType";

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
        /// The BrowseName for the CommunicationDevices component.
        /// </summary>
        public const string CommunicationDevices = "CommunicationDevices";

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
        /// The BrowseName for the CPIdentifier component.
        /// </summary>
        public const string CPIdentifier = "<CPIdentifier>";

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
        /// The BrowseName for the DeviceName component.
        /// </summary>
        public const string DeviceName = "<DeviceName>";

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
        /// The BrowseName for the EditMode component.
        /// </summary>
        public const string EditMode = "EditMode";

        /// <summary>
        /// The BrowseName for the EditModeType component.
        /// </summary>
        public const string EditModeType = "EditModeType";

        /// <summary>
        /// The BrowseName for the EnterEditMode component.
        /// </summary>
        public const string EnterEditMode = "EnterEditMode";

        /// <summary>
        /// The BrowseName for the EnterEditModeMethodType component.
        /// </summary>
        public const string EnterEditModeMethodType = "EnterEditModeMethodType";

        /// <summary>
        /// The BrowseName for the ExitEditMode component.
        /// </summary>
        public const string ExitEditMode = "ExitEditMode";

        /// <summary>
        /// The BrowseName for the ExitEditModeMethodType component.
        /// </summary>
        public const string ExitEditModeMethodType = "ExitEditModeMethodType";

        /// <summary>
        /// The BrowseName for the ExitLock component.
        /// </summary>
        public const string ExitLock = "ExitLock";

        /// <summary>
        /// The BrowseName for the ExitLockMethodType component.
        /// </summary>
        public const string ExitLockMethodType = "ExitLockMethodType";

        /// <summary>
        /// The BrowseName for the FetchTransferResultData component.
        /// </summary>
        public const string FetchTransferResultData = "FetchTransferResultData";

        /// <summary>
        /// The BrowseName for the FunctionalGroupType component.
        /// </summary>
        public const string FunctionalGroupType = "FunctionalGroupType";

        /// <summary>
        /// The BrowseName for the GroupIdentifier component.
        /// </summary>
        public const string GroupIdentifier = "<GroupIdentifier>";

        /// <summary>
        /// The BrowseName for the GroupName component.
        /// </summary>
        public const string GroupName = "<GroupIdentifier>";

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
        /// The BrowseName for the LockedStatus component.
        /// </summary>
        public const string LockedStatus = "LockedStatus";

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
        public const string NetworkIdentifier = "<CPIdentifier>";

        /// <summary>
        /// The BrowseName for the NetworkName component.
        /// </summary>
        public const string NetworkName = "<NetworkName>";

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
        /// The BrowseName for the OnlineElementType component.
        /// </summary>
        public const string OnlineElementType = "OnlineElementType";

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
        /// The BrowseName for the ParameterResult component.
        /// </summary>
        public const string ParameterResult = "ParameterResult";

        /// <summary>
        /// The BrowseName for the ParameterSet component.
        /// </summary>
        public const string ParameterSet = "ParameterSet";

        /// <summary>
        /// The BrowseName for the PermittedMode component.
        /// </summary>
        public const string PermittedMode = "PermittedMode";

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
        /// The BrowseName for the TransferResult component.
        /// </summary>
        public const string TransferResult = "TransferResult";

        /// <summary>
        /// The BrowseName for the TransferStatusType component.
        /// </summary>
        public const string TransferStatusType = "TransferStatusType";

        /// <summary>
        /// The BrowseName for the TransferToDevice component.
        /// </summary>
        public const string TransferToDevice = "TransferToDevice";

        /// <summary>
        /// The BrowseName for the UIElement component.
        /// </summary>
        public const string UIElement = "UIElement";

        /// <summary>
        /// The BrowseName for the UIElementType component.
        /// </summary>
        public const string UIElementType = "UIElementType";

        /// <summary>
        /// The BrowseName for the Uses component.
        /// </summary>
        public const string Uses = "Uses";
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

            if (EditMode != null)
            {
                EditMode.Initialize(context, EditMode_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAJAAAATWV0" +
           "aG9kU2V0AQGGAAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOoYAAAD/////AAAAAA==";

        private const string Identification_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24BAYoAAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVu" +
           "dGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQH5AIoAAAD/////AAAAAA==";

        private const string Lock_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAEAAAATG9j" +
           "awEBjAADAAAAACIAAABVc2VkIHRvIGxvY2sgdGhlIHRvcG9sb2d5IGVsZW1lbnQuAC8BAZkBjAAAAP//" +
           "//8IAAAAFWCJCgIAAAABAAwAAABMb2NrZWRTdGF0dXMBAY0AAC4ARI0AAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAABAA0AAABMb2NraW5nQ2xpZW50AQGOAAAuAESOAAAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQALAAAATG9ja2luZ1VzZXIBAY8AAC4ARI8AAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEA" +
           "AABSZW1haW5pbmdMb2NrVGltZQEBkAAALgBEkAAAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAI" +
           "AAAASW5pdExvY2sBAZEAAC8BAZ4BkQAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQGSAAAuAESSAAAAlgEAAAABACoBAR0AAAAOAAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGTAAAuAESTAAAAlgEA" +
           "AAABACoBARwAAAANAAAASW5pdExvY2tFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAkAAABSZW5ld0xvY2sBAZQAAC8BAaEBlAAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBlQAALgBElQAAAJYBAAAAAQAqAQEdAAAADgAAAFJlbmV3TG9ja0Vycm9yAAb/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQGWAAAvAQGjAZYA" +
           "AAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZcAAC4ARJcAAACWAQAAAAEA" +
           "KgEBHAAAAA0AAABFeGl0TG9ja0Vycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAEACQAAAEJyZWFrTG9jawEBmAAALwEBpQGYAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGZAAAuAESZAAAAlgEAAAABACoBAR0AAAAOAAAAQnJlYWtMb2NrRXJyb3IABv////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string EditMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAIAAAARWRp" +
           "dE1vZGUBAZoAAwAAAAA0AAAAVXNlZCB0byB3b3JrIHdpdGggdGhlIHRvcG9sb2d5IGVsZW1lbnQgaW4g" +
           "YSBzYW5kYm94LgAvAQGuAZoAAAD/////AwAAAARhggoEAAAAAQANAAAARW50ZXJFZGl0TW9kZQEBmwAA" +
           "LwEBrwGbAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZwAAC4ARJwAAACW" +
           "AQAAAAEAKgEBHQAAAA4AAABDdXJyZW50Q29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "FWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZ0AAC4ARJ0AAACWAQAAAAEAKgEBIQAAABIAAABF" +
           "bnRlckVkaXRNb2RlRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAMAAAA" +
           "RXhpdEVkaXRNb2RlAQGeAAAvAQGyAZ4AAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAZ8AAC4ARJ8AAACWAQAAAAEAKgEBIAAAABEAAABFeGl0RWRpdE1vZGVFcnJvcgAG/////wAA" +
           "AAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAA0AAABBYm9ydEVkaXRNb2RlAQGgAAAvAQG0AaAA" +
           "AAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaEAAC4ARKEAAACWAQAAAAEA" +
           "KgEBIQAAABIAAABBYm9ydEVkaXRNb2RlRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAAVG9w" +
           "b2xvZ3lFbGVtZW50VHlwZUluc3RhbmNlAQGDAAEBgwD/////BQAAACRggAoBAAAAAQAMAAAAUGFyYW1l" +
           "dGVyU2V0AQGEAAMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOoQAAAD/////AAAAACRg" +
           "gAoBAAAAAQAJAAAATWV0aG9kU2V0AQGGAAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOoYA" +
           "AAD/////AAAAACRggAoBAAAAAQAOAAAASWRlbnRpZmljYXRpb24BAYoAAwAAAABGAAAAVXNlZCB0byBv" +
           "cmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVudGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVu" +
           "dAAvAQH5AIoAAAD/////AAAAACRggAoBAAAAAQAEAAAATG9jawEBjAADAAAAACIAAABVc2VkIHRvIGxv" +
           "Y2sgdGhlIHRvcG9sb2d5IGVsZW1lbnQuAC8BAZkBjAAAAP////8IAAAAFWCJCgIAAAABAAwAAABMb2Nr" +
           "ZWRTdGF0dXMBAY0AAC4ARI0AAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAA0AAABMb2NraW5nQ2xp" +
           "ZW50AQGOAAAuAESOAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAATG9ja2luZ1VzZXIBAY8A" +
           "AC4ARI8AAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1haW5pbmdMb2NrVGltZQEBkAAA" +
           "LgBEkAAAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5pdExvY2sBAZEAAC8BAZ4BkQAA" +
           "AAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGSAAAuAESSAAAAlgEAAAABACoB" +
           "AR0AAAAOAAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQGTAAAuAESTAAAAlgEAAAABACoBARwAAAANAAAASW5pdExvY2tF" +
           "cnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABSZW5ld0xvY2sBAZQA" +
           "AC8BAaEBlAAAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBlQAALgBElQAA" +
           "AJYBAAAAAQAqAQEdAAAADgAAAFJlbmV3TG9ja0Vycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQGWAAAvAQGjAZYAAAABAf////8BAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAZcAAC4ARJcAAACWAQAAAAEAKgEBHAAAAA0AAABFeGl0TG9ja0Vycm9y" +
           "AAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFrTG9jawEBmAAALwEB" +
           "pQGYAAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGZAAAuAESZAAAAlgEA" +
           "AAABACoBAR0AAAAOAAAAQnJlYWtMb2NrRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAACRg" +
           "gAoBAAAAAQAIAAAARWRpdE1vZGUBAZoAAwAAAAA0AAAAVXNlZCB0byB3b3JrIHdpdGggdGhlIHRvcG9s" +
           "b2d5IGVsZW1lbnQgaW4gYSBzYW5kYm94LgAvAQGuAZoAAAD/////AwAAAARhggoEAAAAAQANAAAARW50" +
           "ZXJFZGl0TW9kZQEBmwAALwEBrwGbAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAZwAAC4ARJwAAACWAQAAAAEAKgEBHQAAAA4AAABDdXJyZW50Q29udGV4dAAM/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZ0AAC4ARJ0AAACWAQAA" +
           "AAEAKgEBIQAAABIAAABFbnRlckVkaXRNb2RlRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAMAAAARXhpdEVkaXRNb2RlAQGeAAAvAQGyAZ4AAAABAf////8BAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAZ8AAC4ARJ8AAACWAQAAAAEAKgEBIAAAABEAAABFeGl0RWRpdE1v" +
           "ZGVFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAA0AAABBYm9ydEVkaXRN" +
           "b2RlAQGgAAAvAQG0AaAAAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaEA" +
           "AC4ARKEAAACWAQAAAAEAKgEBIQAAABIAAABBYm9ydEVkaXRNb2RlRXJyb3IABv////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAA==";
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

        /// <summary>
        /// Used to work with the topology element in a sandbox.
        /// </summary>
        public EditModeState EditMode
        {
            get
            {
                return m_editMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_editMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_editMode = value;
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

            if (m_editMode != null)
            {
                children.Add(m_editMode);
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

                case Opc.Ua.Di.BrowseNames.EditMode:
                {
                    if (createOrReplace)
                    {
                        if (EditMode == null)
                        {
                            if (replacement == null)
                            {
                                EditMode = new EditModeState(this);
                            }
                            else
                            {
                                EditMode = (EditModeState)replacement;
                            }
                        }
                    }

                    instance = EditMode;
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
        private EditModeState m_editMode;
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
        private const string DeviceTypeImage_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAPAAAARGV2" +
           "aWNlVHlwZUltYWdlAQHKAAMAAAAAIQAAAE9yZ2FuaXplcyBwaWN0dXJlcyBvZiB0aGUgZGV2aWNlLgAv" +
           "AD3KAAAA/////wAAAAA=";

        private const string Documentation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQANAAAARG9j" +
           "dW1lbnRhdGlvbgEBzAADAAAAACMAAABPcmdhbml6ZXMgZG9jdW1lbnRzIGZvciB0aGUgZGV2aWNlLgAv" +
           "AD3MAAAA/////wAAAAA=";

        private const string ProtocolSupport_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAPAAAAUHJv" +
           "dG9jb2xTdXBwb3J0AQHOAAMAAAAAJwAAAFByb3RvY29sLXNwZWNpZmljIGZpbGVzIGZvciB0aGUgZGV2" +
           "aWNlLgAvAD3OAAAA/////wAAAAA=";

        private const string ImageSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRggAoBAAAAAQAIAAAASW1h" +
           "Z2VTZXQBAdAAAwAAAAAxAAAAT3JnYW5pemVzIGltYWdlcyB0aGF0IGFyZSB1c2VkIHdpdGhpbiBVSUVs" +
           "ZW1lbnRzLgAvAD3QAAAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAARGV2" +
           "aWNlVHlwZUluc3RhbmNlAQGiAAEBogD/////DgAAACRggAoBAAAAAQAMAAAAUGFyYW1ldGVyU2V0AQGj" +
           "AAMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOqMAAAD/////AAAAADVgiQoCAAAAAQAM" +
           "AAAAU2VyaWFsTnVtYmVyAQHBAAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARMEAAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAABAA8AAABSZXZpc2lvbkNvdW50ZXIBAcIAAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARMIAAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXIBAcMAAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARMMAAAAAFf////8BAf////8AAAAANWCJCgIAAAABAAUAAABNb2RlbAEBxAADAAAAADAAAABO" +
           "YW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBExAAAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEADAAAAERldmljZU1hbnVhbAEBxQADAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBExQAAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAERl" +
           "dmljZVJldmlzaW9uAQHGAAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAETGAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAQAAAAU29mdHdhcmVSZXZpc2lvbgEBxwAD" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAETHAAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAQAAAASGFyZHdhcmVSZXZpc2lvbgEByAAD" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAETIAAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAMAAAARGV2aWNlSGVhbHRoAQHJAAMAAAAAPAAAAFN0YXR1" +
           "cyBvZiBhIGRldmljZSBhcyBkZWZpbmVkIGJ5IE5BTVVSIFJlY29tbWVuZGF0aW9uIE5FMTA3LgAuAETJ" +
           "AAAAAQEAAf////8BAf////8AAAAAJGCACgEAAAABAA8AAABEZXZpY2VUeXBlSW1hZ2UBAcoAAwAAAAAh" +
           "AAAAT3JnYW5pemVzIHBpY3R1cmVzIG9mIHRoZSBkZXZpY2UuAC8APcoAAAD/////AAAAACRggAoBAAAA" +
           "AQANAAAARG9jdW1lbnRhdGlvbgEBzAADAAAAACMAAABPcmdhbml6ZXMgZG9jdW1lbnRzIGZvciB0aGUg" +
           "ZGV2aWNlLgAvAD3MAAAA/////wAAAAAkYIAKAQAAAAEADwAAAFByb3RvY29sU3VwcG9ydAEBzgADAAAA" +
           "ACcAAABQcm90b2NvbC1zcGVjaWZpYyBmaWxlcyBmb3IgdGhlIGRldmljZS4ALwA9zgAAAP////8AAAAA" +
           "JGCACgEAAAABAAgAAABJbWFnZVNldAEB0AADAAAAADEAAABPcmdhbml6ZXMgaW1hZ2VzIHRoYXQgYXJl" +
           "IHVzZWQgd2l0aGluIFVJRWxlbWVudHMuAC8APdAAAAD/////AAAAAA==";
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
           "aXNpb25Db3VudGVyAQHxAAMAAAAAZQAAAEluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUg" +
           "bnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIEJsb2NrIGhhcyBiZWVuIG1v" +
           "ZGlmaWVkAC4ARPEAAAAAB/////8BAf////8AAAAA";

        private const string ActualMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAAQWN0" +
           "dWFsTW9kZQEB8gADAAAAADYAAABDdXJyZW50IG1vZGUgb2Ygb3BlcmF0aW9uIHRoZSBCbG9jayBpcyBh" +
           "YmxlIHRvIGFjaGlldmUALgBE8gAAAAAV/////wEB/////wAAAAA=";

        private const string PermittedMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQANAAAAUGVy" +
           "bWl0dGVkTW9kZQEB8wADAAAAAFMAAABNb2RlcyBvZiBvcGVyYXRpb24gdGhhdCBhcmUgYWxsb3dlZCBm" +
           "b3IgdGhlIEJsb2NrIGJhc2VkIG9uIGFwcGxpY2F0aW9uIHJlcXVpcmVtZW50cwAuAETzAAAAABX/////" +
           "AQH/////AAAAAA==";

        private const string NormalMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAATm9y" +
           "bWFsTW9kZQEB9AADAAAAAEIAAABNb2RlIHRoZSBCbG9jayBzaG91bGQgYmUgc2V0IHRvIGR1cmluZyBu" +
           "b3JtYWwgb3BlcmF0aW5nIGNvbmRpdGlvbnMALgBE9AAAAAAV/////wEB/////wAAAAA=";

        private const string TargetMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAAVGFy" +
           "Z2V0TW9kZQEB9QADAAAAAC8AAABNb2RlIG9mIG9wZXJhdGlvbiB0aGF0IGlzIGRlc2lyZWQgZm9yIHRo" +
           "ZSBCbG9jawAuAET1AAAAABX/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQARAAAAQmxv" +
           "Y2tUeXBlSW5zdGFuY2UBAdIAAQHSAP////8GAAAAJGCACgEAAAABAAwAAABQYXJhbWV0ZXJTZXQBAdMA" +
           "AwAAAAAXAAAARmxhdCBsaXN0IG9mIFBhcmFtZXRlcnMALwA60wAAAP////8AAAAANWCJCgIAAAABAA8A" +
           "AABSZXZpc2lvbkNvdW50ZXIBAfEAAwAAAABlAAAASW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5n" +
           "IHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgQmxvY2sgaGFzIGJl" +
           "ZW4gbW9kaWZpZWQALgBE8QAAAAAH/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAEFjdHVhbE1vZGUB" +
           "AfIAAwAAAAA2AAAAQ3VycmVudCBtb2RlIG9mIG9wZXJhdGlvbiB0aGUgQmxvY2sgaXMgYWJsZSB0byBh" +
           "Y2hpZXZlAC4ARPIAAAAAFf////8BAf////8AAAAANWCJCgIAAAABAA0AAABQZXJtaXR0ZWRNb2RlAQHz" +
           "AAMAAAAAUwAAAE1vZGVzIG9mIG9wZXJhdGlvbiB0aGF0IGFyZSBhbGxvd2VkIGZvciB0aGUgQmxvY2sg" +
           "YmFzZWQgb24gYXBwbGljYXRpb24gcmVxdWlyZW1lbnRzAC4ARPMAAAAAFf////8BAf////8AAAAANWCJ" +
           "CgIAAAABAAoAAABOb3JtYWxNb2RlAQH0AAMAAAAAQgAAAE1vZGUgdGhlIEJsb2NrIHNob3VsZCBiZSBz" +
           "ZXQgdG8gZHVyaW5nIG5vcm1hbCBvcGVyYXRpbmcgY29uZGl0aW9ucwAuAET0AAAAABX/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAKAAAAVGFyZ2V0TW9kZQEB9QADAAAAAC8AAABNb2RlIG9mIG9wZXJhdGlvbiB0" +
           "aGF0IGlzIGRlc2lyZWQgZm9yIHRoZSBCbG9jawAuAET1AAAAABX/////AQH/////AAAAAA==";
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
        public PropertyState<LocalizedText> PermittedMode
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
        public PropertyState<LocalizedText> NormalMode
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
        public PropertyState<LocalizedText> TargetMode
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
                                PermittedMode = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                PermittedMode = (PropertyState<LocalizedText>)replacement;
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
                                NormalMode = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                NormalMode = (PropertyState<LocalizedText>)replacement;
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
                                TargetMode = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                TargetMode = (PropertyState<LocalizedText>)replacement;
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
        private PropertyState<LocalizedText> m_permittedMode;
        private PropertyState<LocalizedText> m_normalMode;
        private PropertyState<LocalizedText> m_targetMode;
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
           "ZmlndXJhYmxlT2JqZWN0VHlwZUluc3RhbmNlAQH2AAEB9gD/////AQAAACRggAoBAAAAAQAOAAAAU3Vw" +
           "cG9ydGVkVHlwZXMBAfcAAwAAAAByAAAARm9sZGVyIG1haW50YWluaW5nIHRoZSBzZXQgb2YgKHN1Yi10" +
           "eXBlcyBvZikgQmFzZU9iamVjdFR5cGVzIHRoYXQgY2FuIGJlIGluc3RhbnRpYXRlZCBpbiB0aGUgQ29u" +
           "ZmlndXJhYmxlQ29tcG9uZW50AC8APfcAAAD/////AAAAAA==";
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
           "bGVtZW50AQH+AAMAAAAAMAAAAEEgdXNlciBpbnRlcmZhY2UgZWxlbWVudCBhc3NpZ25lZCB0byB0aGlz" +
           "IGdyb3VwLgAvAQECAf4AAAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAARnVu" +
           "Y3Rpb25hbEdyb3VwVHlwZUluc3RhbmNlAQH5AAEB+QD/////AQAAADVgiQoCAAAAAQAJAAAAVUlFbGVt" +
           "ZW50AQH+AAMAAAAAMAAAAEEgdXNlciBpbnRlcmZhY2UgZWxlbWVudCBhc3NpZ25lZCB0byB0aGlzIGdy" +
           "b3VwLgAvAQECAf4AAAAAGP////8BAf////8AAAAA";
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
           "dG9jb2xUeXBlSW5zdGFuY2UBAf8AAQH/AP////8AAAAA";
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
           "bGVtZW50VHlwZUluc3RhbmNlAQECAQEBAgEAGP////8BAf////8AAAAA";
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
           "awEBMgEDAAAAABkAAABVc2VkIHRvIGxvY2sgdGhlIE5ldHdvcmsuAC8BAZkBMgEAAP////8IAAAAFWCJ" +
           "CgIAAAABAAwAAABMb2NrZWRTdGF0dXMBATMBAC4ARDMBAAAAAf////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AA0AAABMb2NraW5nQ2xpZW50AQE0AQAuAEQ0AQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "TG9ja2luZ1VzZXIBATUBAC4ARDUBAAAAAf////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1haW5p" +
           "bmdMb2NrVGltZQEBNgEALgBENgEAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5pdExv" +
           "Y2sBATcBAC8BAZ4BNwEAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE4AQAu" +
           "AEQ4AQAAlgEAAAABACoBAR0AAAAOAAAAQ3VycmVudENvbnRleHQADP////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE5AQAuAEQ5AQAAlgEAAAABACoBARwA" +
           "AAANAAAASW5pdExvY2tFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkA" +
           "AABSZW5ld0xvY2sBAToBAC8BAaEBOgEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBOwEALgBEOwEAAJYBAAAAAQAqAQEdAAAADgAAAFJlbmV3TG9ja0Vycm9yAAb/////AAAAAAAB" +
           "ACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQE8AQAvAQGjATwBAAABAf////8B" +
           "AAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAT0BAC4ARD0BAACWAQAAAAEAKgEBHAAAAA0A" +
           "AABFeGl0TG9ja0Vycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJy" +
           "ZWFrTG9jawEBPgEALwEBpQE+AQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQE/AQAuAEQ/AQAAlgEAAAABACoBAR0AAAAOAAAAQnJlYWtMb2NrRXJyb3IABv////8AAAAAAAEAKAEB" +
           "AAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQATAAAATmV0" +
           "d29ya1R5cGVJbnN0YW5jZQEBAwEBAQMBAQAAAAEBAQAAAQH/AAEAAAAkYIAKAQAAAAEABAAAAExvY2sB" +
           "ATIBAwAAAAAZAAAAVXNlZCB0byBsb2NrIHRoZSBOZXR3b3JrLgAvAQGZATIBAAD/////CAAAABVgiQoC" +
           "AAAAAQAMAAAATG9ja2VkU3RhdHVzAQEzAQAuAEQzAQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAN" +
           "AAAATG9ja2luZ0NsaWVudAEBNAEALgBENAEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExv" +
           "Y2tpbmdVc2VyAQE1AQAuAEQ1AQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQARAAAAUmVtYWluaW5n" +
           "TG9ja1RpbWUBATYBAC4ARDYBAAABACIB/////wEB/////wAAAAAEYYIKBAAAAAEACAAAAEluaXRMb2Nr" +
           "AQE3AQAvAQGeATcBAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBOAEALgBE" +
           "OAEAAJYBAAAAAQAqAQEdAAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOQEALgBEOQEAAJYBAAAAAQAqAQEcAAAA" +
           "DQAAAEluaXRMb2NrRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAA" +
           "UmVuZXdMb2NrAQE6AQAvAQGhAToBAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBATsBAC4ARDsBAACWAQAAAAEAKgEBHQAAAA4AAABSZW5ld0xvY2tFcnJvcgAG/////wAAAAAAAQAo" +
           "AQEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABFeGl0TG9jawEBPAEALwEBowE8AQAAAQH/////AQAA" +
           "ABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE9AQAuAEQ9AQAAlgEAAAABACoBARwAAAANAAAA" +
           "RXhpdExvY2tFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABCcmVh" +
           "a0xvY2sBAT4BAC8BAaUBPgEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "PwEALgBEPwEAAJYBAAAAAQAqAQEdAAAADgAAAEJyZWFrTG9ja0Vycm9yAAb/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAA=";
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

            if (NetworkIdentifier != null)
            {
                NetworkIdentifier.Initialize(context, NetworkIdentifier_InitializationString);
            }
        }

        #region Initialization String
        private const string NetworkIdentifier_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////yRgwAoBAAAAEQAAAE5ldHdv" +
           "cmtJZGVudGlmaWVyAQAOAAAAPENQSWRlbnRpZmllcj4BAV8BAwAAAAAtAAAAVGhlIE5ldHdvcmsgdG8g" +
           "d2hpY2ggdGhpcyBDUCBpcyBjb25uZWN0ZWQgdG8uAQECAAEBAwFfAQAAAQAAAAEBAQAAAQH/AAAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAAQ29u" +
           "bmVjdGlvblBvaW50VHlwZUluc3RhbmNlAQFAAQEBQAECAAAAAC8BAQGiAAEBAQAAAQH/AAMAAAAkYIAK" +
           "AQAAAAEADAAAAFBhcmFtZXRlclNldAEBQQEDAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAv" +
           "ADpBAQAA/////wAAAAAkYMAKAQAAABEAAABOZXR3b3JrSWRlbnRpZmllcgEADgAAADxDUElkZW50aWZp" +
           "ZXI+AQFfAQMAAAAALQAAAFRoZSBOZXR3b3JrIHRvIHdoaWNoIHRoaXMgQ1AgaXMgY29ubmVjdGVkIHRv" +
           "LgEBAgABAQMBXwEAAAEAAAABAQEAAAEB/wAAAAAAJGCACgEAAAABAA4AAABOZXR3b3JrQWRkcmVzcwEB" +
           "bgEDAAAAACoAAABUaGUgYWRkcmVzcyBvZiB0aGUgZGV2aWNlIG9uIHRoaXMgbmV0d29yay4ALwEB+QBu" +
           "AQAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// The Network to which this CP is connected to.
        /// </summary>
        public NetworkState NetworkIdentifier
        {
            get
            {
                return m_networkIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_networkIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_networkIdentifier = value;
            }
        }

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
            if (m_networkIdentifier != null)
            {
                children.Add(m_networkIdentifier);
            }

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
                case Opc.Ua.Di.BrowseNames.NetworkIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (NetworkIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                NetworkIdentifier = new NetworkState(this);
                            }
                            else
                            {
                                NetworkIdentifier = (NetworkState)replacement;
                            }
                        }
                    }

                    instance = NetworkIdentifier;
                    break;
                }

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
        private NetworkState m_networkIdentifier;
        private FunctionalGroupState m_networkAddress;
        #endregion
    }
    #endif
    #endregion

    #region OnlineElementState Class
    #if (!OPCUA_EXCLUDE_OnlineElementState)
    /// <summary>
    /// Stores an instance of the OnlineElementType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OnlineElementState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OnlineElementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.OnlineElementType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAZAAAAT25s" +
           "aW5lRWxlbWVudFR5cGVJbnN0YW5jZQEBcAEBAXAB/////wEAAAAkYIAKAQAAAAEADAAAAFBhcmFtZXRl" +
           "clNldAEBcQEDAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADpxAQAA/////wAAAAA=";
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
           "dExvY2tNZXRob2RUeXBlAQGQAQAvAQGQAZABAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBkQEALgBEkQEAAJYBAAAAAQAqAQEdAAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBkgEALgBEkgEA" +
           "AJYBAAAAAQAqAQEcAAAADQAAAEluaXRMb2NrRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "AA==";
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

            int initLockError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    currentContext,
                    ref initLockError);
            }

            outputArguments[0] = initLockError;

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
        ref int initLockError);
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
           "ZXdMb2NrTWV0aG9kVHlwZQEBkwEALwEBkwGTAQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGUAQAuAESUAQAAlgEAAAABACoBAR0AAAAOAAAAUmVuZXdMb2NrRXJyb3IABv////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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

            int renewLockError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref renewLockError);
            }

            outputArguments[0] = renewLockError;

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
        ref int renewLockError);
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
           "dExvY2tNZXRob2RUeXBlAQGVAQAvAQGVAZUBAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAZYBAC4ARJYBAACWAQAAAAEAKgEBHAAAAA0AAABFeGl0TG9ja0Vycm9yAAb/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAA=";
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

            int exitLockError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref exitLockError);
            }

            outputArguments[0] = exitLockError;

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
        ref int exitLockError);
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
           "YWtMb2NrTWV0aG9kVHlwZQEBlwEALwEBlwGXAQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGYAQAuAESYAQAAlgEAAAABACoBAR0AAAAOAAAAQnJlYWtMb2NrRXJyb3IABv////8A" +
           "AAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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

            int breakLockError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref breakLockError);
            }

            outputArguments[0] = breakLockError;

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
        ref int breakLockError);
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
           "a2luZ1NlcnZpY2VzVHlwZUluc3RhbmNlAQGZAQEBmQH/////CAAAABVgiQoCAAAAAQAMAAAATG9ja2Vk" +
           "U3RhdHVzAQGaAQAuAESaAQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQANAAAATG9ja2luZ0NsaWVu" +
           "dAEBmwEALgBEmwEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExvY2tpbmdVc2VyAQGcAQAu" +
           "AEScAQAAAAH/////AQH/////AAAAABVgiQoCAAAAAQARAAAAUmVtYWluaW5nTG9ja1RpbWUBAZ0BAC4A" +
           "RJ0BAAABACIB/////wEB/////wAAAAAEYYIKBAAAAAEACAAAAEluaXRMb2NrAQGeAQAvAQGeAZ4BAAAB" +
           "Af////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnwEALgBEnwEAAJYBAAAAAQAqAQEd" +
           "AAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBoAEALgBEoAEAAJYBAAAAAQAqAQEcAAAADQAAAEluaXRMb2NrRXJy" +
           "b3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAAUmVuZXdMb2NrAQGhAQAv" +
           "AQGhAaEBAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaIBAC4ARKIBAACW" +
           "AQAAAAEAKgEBHQAAAA4AAABSZW5ld0xvY2tFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "BGGCCgQAAAABAAgAAABFeGl0TG9jawEBowEALwEBowGjAQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQGkAQAuAESkAQAAlgEAAAABACoBARwAAAANAAAARXhpdExvY2tFcnJvcgAG" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABCcmVha0xvY2sBAaUBAC8BAaUB" +
           "pQEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBpgEALgBEpgEAAJYBAAAA" +
           "AQAqAQEdAAAADgAAAEJyZWFrTG9ja0Vycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LockedStatus Property.
        /// </summary>
        public PropertyState<bool> LockedStatus
        {
            get
            {
                return m_lockedStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lockedStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockedStatus = value;
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
            if (m_lockedStatus != null)
            {
                children.Add(m_lockedStatus);
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
                case Opc.Ua.Di.BrowseNames.LockedStatus:
                {
                    if (createOrReplace)
                    {
                        if (LockedStatus == null)
                        {
                            if (replacement == null)
                            {
                                LockedStatus = new PropertyState<bool>(this);
                            }
                            else
                            {
                                LockedStatus = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = LockedStatus;
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
        private PropertyState<bool> m_lockedStatus;
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

    #region EnterEditModeMethodState Class
    #if (!OPCUA_EXCLUDE_EnterEditModeMethodState)
    /// <summary>
    /// Stores an instance of the EnterEditModeMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnterEditModeMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EnterEditModeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new EnterEditModeMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAXAAAARW50" +
           "ZXJFZGl0TW9kZU1ldGhvZFR5cGUBAacBAC8BAacBpwEAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQGoAQAuAESoAQAAlgEAAAABACoBAR0AAAAOAAAAQ3VycmVudENvbnRleHQADP//" +
           "//8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGpAQAu" +
           "AESpAQAAlgEAAAABACoBASEAAAASAAAARW50ZXJFZGl0TW9kZUVycm9yAAb/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public EnterEditModeMethodStateMethodCallHandler OnCall;
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

            int enterEditModeError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    currentContext,
                    ref enterEditModeError);
            }

            outputArguments[0] = enterEditModeError;

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
    public delegate ServiceResult EnterEditModeMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string currentContext,
        ref int enterEditModeError);
    #endif
    #endregion

    #region ExitEditModeMethodState Class
    #if (!OPCUA_EXCLUDE_ExitEditModeMethodState)
    /// <summary>
    /// Stores an instance of the ExitEditModeMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExitEditModeMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ExitEditModeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ExitEditModeMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAARXhp" +
           "dEVkaXRNb2RlTWV0aG9kVHlwZQEBqgEALwEBqgGqAQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQGrAQAuAESrAQAAlgEAAAABACoBASAAAAARAAAARXhpdEVkaXRNb2RlRXJyb3IA" +
           "Bv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ExitEditModeMethodStateMethodCallHandler OnCall;
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

            int exitEditModeError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref exitEditModeError);
            }

            outputArguments[0] = exitEditModeError;

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
    public delegate ServiceResult ExitEditModeMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int exitEditModeError);
    #endif
    #endregion

    #region AbortEditModeErrorMethodState Class
    #if (!OPCUA_EXCLUDE_AbortEditModeErrorMethodState)
    /// <summary>
    /// Stores an instance of the AbortEditModeErrorMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AbortEditModeErrorMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AbortEditModeErrorMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AbortEditModeErrorMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAcAAAAQWJv" +
           "cnRFZGl0TW9kZUVycm9yTWV0aG9kVHlwZQEBrAEALwEBrAGsAQAAAQH/////AQAAABVgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQGtAQAuAEStAQAAlgEAAAABACoBASEAAAASAAAAQWJvcnRFZGl0TW9k" +
           "ZUVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AbortEditModeErrorMethodStateMethodCallHandler OnCall;
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

            int abortEditModeError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref abortEditModeError);
            }

            outputArguments[0] = abortEditModeError;

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
    public delegate ServiceResult AbortEditModeErrorMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref int abortEditModeError);
    #endif
    #endregion

    #region EditModeState Class
    #if (!OPCUA_EXCLUDE_EditModeState)
    /// <summary>
    /// Stores an instance of the EditModeType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EditModeState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EditModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Di.ObjectTypes.EditModeType, Opc.Ua.Di.Namespaces.OpcUaDi, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAUAAAARWRp" +
           "dE1vZGVUeXBlSW5zdGFuY2UBAa4BAQGuAf////8DAAAABGGCCgQAAAABAA0AAABFbnRlckVkaXRNb2Rl" +
           "AQGvAQAvAQGvAa8BAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBsAEALgBE" +
           "sAEAAJYBAAAAAQAqAQEdAAAADgAAAEN1cnJlbnRDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBsQEALgBEsQEAAJYBAAAAAQAqAQEhAAAA" +
           "EgAAAEVudGVyRWRpdE1vZGVFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAwAAABFeGl0RWRpdE1vZGUBAbIBAC8BAbIBsgEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBswEALgBEswEAAJYBAAAAAQAqAQEgAAAAEQAAAEV4aXRFZGl0TW9kZUVycm9yAAb/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADQAAAEFib3J0RWRpdE1vZGUBAbQBAC8B" +
           "AbQBtAEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBtQEALgBEtQEAAJYB" +
           "AAAAAQAqAQEhAAAAEgAAAEFib3J0RWRpdE1vZGVFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the EnterEditModeMethodType Method.
        /// </summary>
        public EnterEditModeMethodState EnterEditMode
        {
            get
            {
                return m_enterEditModeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_enterEditModeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_enterEditModeMethod = value;
            }
        }

        /// <summary>
        /// A description for the ExitEditModeMethodType Method.
        /// </summary>
        public ExitEditModeMethodState ExitEditMode
        {
            get
            {
                return m_exitEditModeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_exitEditModeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_exitEditModeMethod = value;
            }
        }

        /// <summary>
        /// A description for the AbortEditModeErrorMethodType Method.
        /// </summary>
        public AbortEditModeErrorMethodState AbortEditMode
        {
            get
            {
                return m_abortEditModeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_abortEditModeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_abortEditModeMethod = value;
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
            if (m_enterEditModeMethod != null)
            {
                children.Add(m_enterEditModeMethod);
            }

            if (m_exitEditModeMethod != null)
            {
                children.Add(m_exitEditModeMethod);
            }

            if (m_abortEditModeMethod != null)
            {
                children.Add(m_abortEditModeMethod);
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
                case Opc.Ua.Di.BrowseNames.EnterEditMode:
                {
                    if (createOrReplace)
                    {
                        if (EnterEditMode == null)
                        {
                            if (replacement == null)
                            {
                                EnterEditMode = new EnterEditModeMethodState(this);
                            }
                            else
                            {
                                EnterEditMode = (EnterEditModeMethodState)replacement;
                            }
                        }
                    }

                    instance = EnterEditMode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.ExitEditMode:
                {
                    if (createOrReplace)
                    {
                        if (ExitEditMode == null)
                        {
                            if (replacement == null)
                            {
                                ExitEditMode = new ExitEditModeMethodState(this);
                            }
                            else
                            {
                                ExitEditMode = (ExitEditModeMethodState)replacement;
                            }
                        }
                    }

                    instance = ExitEditMode;
                    break;
                }

                case Opc.Ua.Di.BrowseNames.AbortEditMode:
                {
                    if (createOrReplace)
                    {
                        if (AbortEditMode == null)
                        {
                            if (replacement == null)
                            {
                                AbortEditMode = new AbortEditModeErrorMethodState(this);
                            }
                            else
                            {
                                AbortEditMode = (AbortEditModeErrorMethodState)replacement;
                            }
                        }
                    }

                    instance = AbortEditMode;
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
        private EnterEditModeMethodState m_enterEditModeMethod;
        private ExitEditModeMethodState m_exitEditModeMethod;
        private AbortEditModeErrorMethodState m_abortEditModeMethod;
        #endregion
    }
    #endif
    #endregion

    #region TransferToDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_TransferToDeviceMethodState)
    /// <summary>
    /// Stores an instance of the TransferToDevice Method.
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAQAAAAVHJh" +
           "bnNmZXJUb0RldmljZQEBtgEALwEBtgG2AQAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQG3AQAuAES3AQAAlgIAAAABACoBARkAAAAKAAAAVHJhbnNmZXJJRAAG/////wAAAAAAAQAq" +
           "AQEhAAAAEgAAAEluaXRUcmFuc2ZlclN0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
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
    /// Stores an instance of the TransferFromDevice Method.
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQASAAAAVHJh" +
           "bnNmZXJGcm9tRGV2aWNlAQG4AQAvAQG4AbgBAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAbkBAC4ARLkBAACWAgAAAAEAKgEBGQAAAAoAAABUcmFuc2ZlcklEAAb/////AAAAAAAB" +
           "ACoBASEAAAASAAAASW5pdFRyYW5zZmVyU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
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
    /// Stores an instance of the FetchTransferResultData Method.
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
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAXAAAARmV0" +
           "Y2hUcmFuc2ZlclJlc3VsdERhdGEBAboBAC8BAboBugEAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQG7AQAuAES7AQAAlgMAAAABACoBARkAAAAKAAAAVHJhbnNmZXJJRAAG/////wAA" +
           "AAAAAQAqAQEqAAAAGwAAAE1heFBhcmFtZXRlclJlc3VsdHNUb1JldHVybgAG/////wAAAAAAAQAqAQEe" +
           "AAAADwAAAE9taXRHb29kUmVzdWx0cwAB/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAbwBAC4ARLwBAACWAQAAAAEAKgEBGwAAAAoAAABOZXh0UmVzdWx0" +
           "AQG+Af////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
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
            int maxParameterResultsToReturn = (int)inputArguments[1];
            bool omitGoodResults = (bool)inputArguments[2];

            TransferResult nextResult = (TransferResult)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    transferID,
                    maxParameterResultsToReturn,
                    omitGoodResults,
                    ref nextResult);
            }

            outputArguments[0] = nextResult;

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
        int maxParameterResultsToReturn,
        bool omitGoodResults,
        ref TransferResult nextResult);
    #endif
    #endregion

    #region TransferStatusType Class
    #if (!OPCUA_EXCLUDE_TransferStatusType)
    /// <summary>
    /// A description for the TransferStatusType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class TransferStatusType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public TransferStatusType()
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
        /// A description for the status field.
        /// </summary>
        [DataMember(Name = "status", IsRequired = false, Order = 1)]
        public int status
        {
            get { return m_status;  }
            set { m_status = value; }
        }

        /// <summary>
        /// A description for the diagnostics field.
        /// </summary>
        [DataMember(Name = "diagnostics", IsRequired = false, Order = 2)]
        public DiagnosticInfo diagnostics
        {
            get { return m_diagnostics;  }
            set { m_diagnostics = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.TransferStatusType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.TransferStatusType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.TransferStatusType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteInt32("status", status);
            encoder.WriteDiagnosticInfo("diagnostics", diagnostics);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            status = decoder.ReadInt32("status");
            diagnostics = decoder.ReadDiagnosticInfo("diagnostics");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TransferStatusType value = encodeable as TransferStatusType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_status, value.m_status)) return false;
            if (!Utils.IsEqual(m_diagnostics, value.m_diagnostics)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            TransferStatusType clone = (TransferStatusType)this.MemberwiseClone();

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

    #region TransferStatusTypeCollection Class
    /// <summary>
    /// A collection of TransferStatusType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfTransferStatusType", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "TransferStatusType")]
    public partial class TransferStatusTypeCollection : List<TransferStatusType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public TransferStatusTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public TransferStatusTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public TransferStatusTypeCollection(IEnumerable<TransferStatusType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator TransferStatusTypeCollection(TransferStatusType[] values)
        {
            if (values != null)
            {
                return new TransferStatusTypeCollection(values);
            }

            return new TransferStatusTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator TransferStatusType[](TransferStatusTypeCollection values)
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
            TransferStatusTypeCollection clone = new TransferStatusTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TransferStatusType)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TransferResult Class
    #if (!OPCUA_EXCLUDE_TransferResult)
    /// <summary>
    /// A description for the TransferResult DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class TransferResult : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public TransferResult()
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
            m_transferFinished = true;
            m_transferStatus = new TransferStatusType();
            m_endOfResults = true;
            m_parameterDefs = new ParameterResultCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the TransferFinished field.
        /// </summary>
        [DataMember(Name = "TransferFinished", IsRequired = false, Order = 1)]
        public bool TransferFinished
        {
            get { return m_transferFinished;  }
            set { m_transferFinished = value; }
        }

        /// <summary>
        /// A description for the transferStatus field.
        /// </summary>
        [DataMember(Name = "transferStatus", IsRequired = false, Order = 2)]
        public TransferStatusType transferStatus
        {
            get
            {
                return m_transferStatus;
            }

            set
            {
                m_transferStatus = value;

                if (value == null)
                {
                    m_transferStatus = new TransferStatusType();
                }
            }
        }

        /// <summary>
        /// A description for the endOfResults field.
        /// </summary>
        [DataMember(Name = "endOfResults", IsRequired = false, Order = 3)]
        public bool endOfResults
        {
            get { return m_endOfResults;  }
            set { m_endOfResults = value; }
        }

        /// <summary>
        /// A description for the parameterDefs field.
        /// </summary>
        [DataMember(Name = "parameterDefs", IsRequired = false, Order = 4)]
        public ParameterResultCollection parameterDefs
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
                    m_parameterDefs = new ParameterResultCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.TransferResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.TransferResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.TransferResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteBoolean("TransferFinished", TransferFinished);
            encoder.WriteEncodeable("transferStatus", transferStatus, typeof(TransferStatusType));
            encoder.WriteBoolean("endOfResults", endOfResults);
            encoder.WriteEncodeableArray("parameterDefs", parameterDefs.ToArray(), typeof(ParameterResult));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            TransferFinished = decoder.ReadBoolean("TransferFinished");
            transferStatus = (TransferStatusType)decoder.ReadEncodeable("transferStatus", typeof(TransferStatusType));
            endOfResults = decoder.ReadBoolean("endOfResults");
            parameterDefs = (ParameterResultCollection)decoder.ReadEncodeableArray("parameterDefs", typeof(ParameterResult));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            TransferResult value = encodeable as TransferResult;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_transferFinished, value.m_transferFinished)) return false;
            if (!Utils.IsEqual(m_transferStatus, value.m_transferStatus)) return false;
            if (!Utils.IsEqual(m_endOfResults, value.m_endOfResults)) return false;
            if (!Utils.IsEqual(m_parameterDefs, value.m_parameterDefs)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            TransferResult clone = (TransferResult)this.MemberwiseClone();

            clone.m_transferFinished = (bool)Utils.Clone(this.m_transferFinished);
            clone.m_transferStatus = (TransferStatusType)Utils.Clone(this.m_transferStatus);
            clone.m_endOfResults = (bool)Utils.Clone(this.m_endOfResults);
            clone.m_parameterDefs = (ParameterResultCollection)Utils.Clone(this.m_parameterDefs);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_transferFinished;
        private TransferStatusType m_transferStatus;
        private bool m_endOfResults;
        private ParameterResultCollection m_parameterDefs;
        #endregion
    }

    #region TransferResultCollection Class
    /// <summary>
    /// A collection of TransferResult objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfTransferResult", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "TransferResult")]
    public partial class TransferResultCollection : List<TransferResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public TransferResultCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public TransferResultCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public TransferResultCollection(IEnumerable<TransferResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator TransferResultCollection(TransferResult[] values)
        {
            if (values != null)
            {
                return new TransferResultCollection(values);
            }

            return new TransferResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator TransferResult[](TransferResultCollection values)
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
            TransferResultCollection clone = new TransferResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((TransferResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ParameterResult Class
    #if (!OPCUA_EXCLUDE_ParameterResult)
    /// <summary>
    /// A description for the ParameterResult DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd)]
    public partial class ParameterResult : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ParameterResult()
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
            m_node = null;
            m_statusCode = StatusCodes.Good;
            m_diagnostics = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the node field.
        /// </summary>
        [DataMember(Name = "node", IsRequired = false, Order = 1)]
        public NodeId node
        {
            get { return m_node;  }
            set { m_node = value; }
        }

        /// <summary>
        /// A description for the statusCode field.
        /// </summary>
        [DataMember(Name = "statusCode", IsRequired = false, Order = 2)]
        public StatusCode statusCode
        {
            get { return m_statusCode;  }
            set { m_statusCode = value; }
        }

        /// <summary>
        /// A description for the diagnostics field.
        /// </summary>
        [DataMember(Name = "diagnostics", IsRequired = false, Order = 3)]
        public DiagnosticInfo diagnostics
        {
            get { return m_diagnostics;  }
            set { m_diagnostics = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ParameterResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ParameterResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ParameterResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            encoder.WriteNodeId("node", node);
            encoder.WriteStatusCode("statusCode", statusCode);
            encoder.WriteDiagnosticInfo("diagnostics", diagnostics);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Di.Namespaces.OpcUaDiXsd);

            node = decoder.ReadNodeId("node");
            statusCode = decoder.ReadStatusCode("statusCode");
            diagnostics = decoder.ReadDiagnosticInfo("diagnostics");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ParameterResult value = encodeable as ParameterResult;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_node, value.m_node)) return false;
            if (!Utils.IsEqual(m_statusCode, value.m_statusCode)) return false;
            if (!Utils.IsEqual(m_diagnostics, value.m_diagnostics)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            ParameterResult clone = (ParameterResult)this.MemberwiseClone();

            clone.m_node = (NodeId)Utils.Clone(this.m_node);
            clone.m_statusCode = (StatusCode)Utils.Clone(this.m_statusCode);
            clone.m_diagnostics = (DiagnosticInfo)Utils.Clone(this.m_diagnostics);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_node;
        private StatusCode m_statusCode;
        private DiagnosticInfo m_diagnostics;
        #endregion
    }

    #region ParameterResultCollection Class
    /// <summary>
    /// A collection of ParameterResult objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfParameterResult", Namespace = Opc.Ua.Di.Namespaces.OpcUaDiXsd, ItemName = "ParameterResult")]
    public partial class ParameterResultCollection : List<ParameterResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ParameterResultCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ParameterResultCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ParameterResultCollection(IEnumerable<ParameterResult> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ParameterResultCollection(ParameterResult[] values)
        {
            if (values != null)
            {
                return new ParameterResultCollection(values);
            }

            return new ParameterResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ParameterResult[](ParameterResultCollection values)
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
            ParameterResultCollection clone = new ParameterResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ParameterResult)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion
}