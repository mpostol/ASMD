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
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Adi
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
        /// The identifier for the ExecutionCycleEnumeration DataType.
        /// </summary>
        public const uint ExecutionCycleEnumeration = 9378;

        /// <summary>
        /// The identifier for the AcquisitionResultStatusEnumeration DataType.
        /// </summary>
        public const uint AcquisitionResultStatusEnumeration = 3003;

        /// <summary>
        /// The identifier for the AlarmStateEnumeration DataType.
        /// </summary>
        public const uint AlarmStateEnumeration = 3009;
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
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfiguration Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GetConfiguration = 9443;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_SetConfiguration = 9445;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GetConfigDataDigest = 9448;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_CompareConfigDataDigest = 9450;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_ResetAllChannels Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_ResetAllChannels = 9453;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_StartAllChannels Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_StartAllChannels = 9454;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_StopAllChannels Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_StopAllChannels = 9455;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_AbortAllChannels Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_AbortAllChannels = 9456;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GotoOperating = 9457;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GotoMaintenance = 9458;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Open = 9467;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Close = 9470;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Read = 9472;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Write = 9475;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_GetPosition = 9477;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_SetPosition = 9480;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoOperating = 9521;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance = 9522;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition = 9523;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Reset = 9525;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Start = 9526;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Stop = 9527;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Hold = 9528;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Unhold = 9529;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Suspend = 9530;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Unsuspend = 9531;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Abort = 9532;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_Clear = 9533;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigurationMethodType Method.
        /// </summary>
        public const uint AnalyserDeviceTypeGetConfigurationMethodType = 9626;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType Method.
        /// </summary>
        public const uint AnalyserDeviceTypeSetConfigurationMethodType = 9628;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigDataDigestMethodType Method.
        /// </summary>
        public const uint AnalyserDeviceTypeGetConfigDataDigestMethodType = 9631;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType Method.
        /// </summary>
        public const uint AnalyserDeviceTypeCompareConfigDataDigestMethodType = 9633;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_GotoOperating = 9699;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_GotoMaintenance = 9700;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_StartSingleAcquisition = 9701;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Reset Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Reset = 9703;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Start Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Start = 9704;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Stop Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Stop = 9705;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Hold Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Hold = 9706;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Unhold Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Unhold = 9707;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Suspend Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Suspend = 9708;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Unsuspend = 9709;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Abort Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Abort = 9710;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Clear Method.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_Clear = 9711;

        /// <summary>
        /// The identifier for the AnalyserChannelTypeStartSingleAcquisitionMethodType Method.
        /// </summary>
        public const uint AnalyserChannelTypeStartSingleAcquisitionMethodType = 9932;

        /// <summary>
        /// The identifier for the MVAPredictMethodType Method.
        /// </summary>
        public const uint MVAPredictMethodType = 13051;
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
        /// The identifier for the AnalyserDeviceType_ParameterSet Object.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet = 5001;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet Object.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet = 9382;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Identification Object.
        /// </summary>
        public const uint AnalyserDeviceType_Identification = 9386;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData Object.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData = 9462;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Configuration Object.
        /// </summary>
        public const uint AnalyserDeviceType_Configuration = 9482;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Status Object.
        /// </summary>
        public const uint AnalyserDeviceType_Status = 9484;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_FactorySettings Object.
        /// </summary>
        public const uint AnalyserDeviceType_FactorySettings = 9486;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AnalyserStateMachine Object.
        /// </summary>
        public const uint AnalyserDeviceType_AnalyserStateMachine = 9488;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier = 9500;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_Configuration Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_Configuration = 9546;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_Status Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_Status = 9548;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine = 9550;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = 9562;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 9574;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier Object.
        /// </summary>
        public const uint AnalyserDeviceType_AccessorySlotIdentifier = 9610;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint AnalyserDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine = 9614;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Powerup Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Powerup = 9647;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Operating Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Operating = 9649;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Local Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Local = 9651;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Maintenance Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Maintenance = 9653;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Shutdown Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Shutdown = 9655;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_PowerupToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_PowerupToOperatingTransition = 9657;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToLocalTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToLocalTransition = 9659;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition = 9661;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToOperatingTransition = 9663;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToMaintenanceTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToMaintenanceTransition = 9665;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition = 9667;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToLocalTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToLocalTransition = 9669;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToShutdownTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToShutdownTransition = 9671;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToShutdownTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToShutdownTransition = 9673;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition Object.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition = 9675;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet Object.
        /// </summary>
        public const uint AnalyserChannelType_ParameterSet = 9677;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet Object.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet = 9679;

        /// <summary>
        /// The identifier for the AnalyserChannelType_GroupIdentifier Object.
        /// </summary>
        public const uint AnalyserChannelType_GroupIdentifier = 9788;

        /// <summary>
        /// The identifier for the AnalyserChannelType_Configuration Object.
        /// </summary>
        public const uint AnalyserChannelType_Configuration = 9724;

        /// <summary>
        /// The identifier for the AnalyserChannelType_Status Object.
        /// </summary>
        public const uint AnalyserChannelType_Status = 9726;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelType_ChannelStateMachine = 9728;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine = 9740;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 9752;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier = 9790;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Configuration Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_Configuration = 9902;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Status Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_Status = 9904;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionSettings Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_AcquisitionSettings = 9906;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionStatus Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_AcquisitionStatus = 9908;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionData Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_AcquisitionData = 9910;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ChemometricModelSettings Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ChemometricModelSettings = 9912;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Context Object.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_Context = 9914;

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier Object.
        /// </summary>
        public const uint AnalyserChannelType_AccessorySlotIdentifier = 9916;

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelType_AccessorySlotIdentifier_AccessorySlotStateMachine = 9920;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingSubStateMachine = 9948;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 9960;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalSubStateMachine = 9972;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceSubStateMachine = 9984;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveMode Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_SlaveMode = 9996;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Operating Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Operating = 9998;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Local Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Local = 10000;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Maintenance Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Maintenance = 10002;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveModeToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_SlaveModeToOperatingTransition = 10004;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToLocalTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToLocalTransition = 10006;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToMaintenanceTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToMaintenanceTransition = 10008;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToOperatingTransition = 10010;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToMaintenanceTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToMaintenanceTransition = 10012;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToOperatingTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToOperatingTransition = 10014;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToLocalTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToLocalTransition = 10016;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToSlaveModeTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToSlaveModeTransition = 10018;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToSlaveModeTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToSlaveModeTransition = 10020;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition Object.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition = 10022;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_OperatingExecuteSubStateMachine = 10036;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopped Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Stopped = 10048;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Resetting Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Resetting = 10050;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Idle Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Idle = 10052;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Starting Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Starting = 10054;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Execute Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Execute = 10056;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Completing Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Completing = 10058;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Complete Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Complete = 10060;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspending Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Suspending = 10062;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspended Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Suspended = 10064;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending = 10066;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Holding Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Holding = 10068;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Held Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Held = 10070;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unholding Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Unholding = 10072;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopping Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Stopping = 10074;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborting Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Aborting = 10076;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborted Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Aborted = 10078;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Clearing Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Clearing = 10080;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition = 10082;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition = 10084;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition = 10086;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition = 10088;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition = 10090;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition = 10092;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition = 10094;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition = 10096;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition = 10098;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition = 10100;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition = 10102;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition = 10104;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition = 10106;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition = 10108;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition = 10110;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition = 10112;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition = 10114;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition = 10116;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition = 10118;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition = 10120;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition = 10122;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition = 10124;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition = 10126;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition = 10128;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition = 10130;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition = 10132;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition = 10134;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition = 10136;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition = 10138;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition = 10140;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition = 10142;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition = 10144;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition = 10146;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition = 10148;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition = 10150;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition = 10152;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition = 10154;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition = 10156;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition = 10158;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition = 10160;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition = 10162;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition = 10164;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition = 10166;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition = 10168;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition = 10170;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition = 10172;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition = 10174;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition = 10176;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition = 10178;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition = 10180;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition = 10182;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition = 10184;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition = 10186;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition = 10188;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle = 10201;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger = 10203;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample = 10205;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample = 10207;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample = 10209;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger = 10211;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample = 10213;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample = 10215;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample = 10217;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger = 10219;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample = 10221;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample = 10223;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample = 10225;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger = 10227;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic = 10229;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger = 10231;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning = 10233;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults = 10235;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample = 10237;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem = 10239;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition = 10241;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition = 10243;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition = 10245;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition = 10247;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition = 10249;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition = 10251;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition = 10253;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition = 10255;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition = 10257;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition = 10259;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition = 10261;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition = 10263;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition = 10265;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition = 10267;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition = 10269;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition = 10271;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition = 10273;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition = 10275;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition = 10277;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition = 10279;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition = 10281;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition = 10283;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition = 10285;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition = 10287;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition = 10289;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition = 10291;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition = 10293;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition = 10295;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition = 10297;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition = 10299;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition = 10301;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition = 10303;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition = 10305;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition = 10307;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition = 10309;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition = 10311;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition = 10313;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition Object.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition = 10315;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet Object.
        /// </summary>
        public const uint StreamType_ParameterSet = 10317;

        /// <summary>
        /// The identifier for the StreamType_GroupIdentifier Object.
        /// </summary>
        public const uint StreamType_GroupIdentifier = 10444;

        /// <summary>
        /// The identifier for the StreamType_Configuration Object.
        /// </summary>
        public const uint StreamType_Configuration = 10430;

        /// <summary>
        /// The identifier for the StreamType_Status Object.
        /// </summary>
        public const uint StreamType_Status = 10432;

        /// <summary>
        /// The identifier for the StreamType_AcquisitionSettings Object.
        /// </summary>
        public const uint StreamType_AcquisitionSettings = 10434;

        /// <summary>
        /// The identifier for the StreamType_AcquisitionStatus Object.
        /// </summary>
        public const uint StreamType_AcquisitionStatus = 10436;

        /// <summary>
        /// The identifier for the StreamType_AcquisitionData Object.
        /// </summary>
        public const uint StreamType_AcquisitionData = 10438;

        /// <summary>
        /// The identifier for the StreamType_ChemometricModelSettings Object.
        /// </summary>
        public const uint StreamType_ChemometricModelSettings = 10440;

        /// <summary>
        /// The identifier for the StreamType_Context Object.
        /// </summary>
        public const uint StreamType_Context = 10442;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet = 10446;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_Configuration Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_Configuration = 10559;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionSettings Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_AcquisitionSettings = 10563;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionStatus Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_AcquisitionStatus = 10565;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionData Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_AcquisitionData = 10567;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_FactorySettings Object.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_FactorySettings = 10638;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet Object.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet = 10768;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_AcquisitionData Object.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_AcquisitionData = 10889;

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_ParameterSet Object.
        /// </summary>
        public const uint SpectrometerDeviceType_ParameterSet = 11305;

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_FactorySettings Object.
        /// </summary>
        public const uint SpectrometerDeviceType_FactorySettings = 11411;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint AccessorySlotType_AccessorySlotStateMachine = 12788;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier Object.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier = 12800;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_Configuration Object.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier_Configuration = 12821;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_Status Object.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier_Status = 12823;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_FactorySettings Object.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier_FactorySettings = 12825;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Powerup Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Powerup = 12840;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Empty Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Empty = 12842;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Inserting Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Inserting = 12844;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Installed Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Installed = 12846;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Removing Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Removing = 12848;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Shutdown Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Shutdown = 12850;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_PowerupToEmptyTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_PowerupToEmptyTransition = 12852;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToInsertingTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_EmptyToInsertingTransition = 12854;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingTransition = 12856;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToRemovingTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToRemovingTransition = 12858;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToInstalledTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToInstalledTransition = 12860;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToRemovingTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InstalledToRemovingTransition = 12862;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingTransition = 12864;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToEmptyTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingToEmptyTransition = 12866;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToShutdownTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_EmptyToShutdownTransition = 12868;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToShutdownTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToShutdownTransition = 12870;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToShutdownTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InstalledToShutdownTransition = 12872;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToShutdownTransition Object.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingToShutdownTransition = 12874;

        /// <summary>
        /// The identifier for the AccessoryType_Configuration Object.
        /// </summary>
        public const uint AccessoryType_Configuration = 12898;

        /// <summary>
        /// The identifier for the AccessoryType_Status Object.
        /// </summary>
        public const uint AccessoryType_Status = 12900;

        /// <summary>
        /// The identifier for the AccessoryType_FactorySettings Object.
        /// </summary>
        public const uint AccessoryType_FactorySettings = 12902;
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
        /// The identifier for the AnalyserDeviceType ObjectType.
        /// </summary>
        public const uint AnalyserDeviceType = 1001;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType ObjectType.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType = 1002;

        /// <summary>
        /// The identifier for the AnalyserChannelType ObjectType.
        /// </summary>
        public const uint AnalyserChannelType = 1003;

        /// <summary>
        /// The identifier for the AnalyserChannelOperatingStateType ObjectType.
        /// </summary>
        public const uint AnalyserChannelOperatingStateType = 1004;

        /// <summary>
        /// The identifier for the AnalyserChannelLocalStateType ObjectType.
        /// </summary>
        public const uint AnalyserChannelLocalStateType = 1005;

        /// <summary>
        /// The identifier for the AnalyserChannelMaintenanceStateType ObjectType.
        /// </summary>
        public const uint AnalyserChannelMaintenanceStateType = 1006;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType ObjectType.
        /// </summary>
        public const uint AnalyserChannelStateMachineType = 1007;

        /// <summary>
        /// The identifier for the AnalyserChannelOperatingExecuteStateType ObjectType.
        /// </summary>
        public const uint AnalyserChannelOperatingExecuteStateType = 8964;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType ObjectType.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType = 1008;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType ObjectType.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType = 1009;

        /// <summary>
        /// The identifier for the StreamType ObjectType.
        /// </summary>
        public const uint StreamType = 1010;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public const uint SpectrometerDeviceStreamType = 1030;

        /// <summary>
        /// The identifier for the MassSpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public const uint MassSpectrometerDeviceStreamType = 1031;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType ObjectType.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType = 1032;

        /// <summary>
        /// The identifier for the AcousticSpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public const uint AcousticSpectrometerDeviceStreamType = 1033;

        /// <summary>
        /// The identifier for the ChromatographDeviceStreamType ObjectType.
        /// </summary>
        public const uint ChromatographDeviceStreamType = 1034;

        /// <summary>
        /// The identifier for the MNRDeviceStreamType ObjectType.
        /// </summary>
        public const uint MNRDeviceStreamType = 1035;

        /// <summary>
        /// The identifier for the SpectrometerDeviceType ObjectType.
        /// </summary>
        public const uint SpectrometerDeviceType = 1011;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceType ObjectType.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceType = 1012;

        /// <summary>
        /// The identifier for the ChromatographDeviceType ObjectType.
        /// </summary>
        public const uint ChromatographDeviceType = 1013;

        /// <summary>
        /// The identifier for the MassSpectrometerDeviceType ObjectType.
        /// </summary>
        public const uint MassSpectrometerDeviceType = 1014;

        /// <summary>
        /// The identifier for the AcousticSpectrometerDeviceType ObjectType.
        /// </summary>
        public const uint AcousticSpectrometerDeviceType = 1015;

        /// <summary>
        /// The identifier for the NMRDeviceType ObjectType.
        /// </summary>
        public const uint NMRDeviceType = 1016;

        /// <summary>
        /// The identifier for the AccessorySlotType ObjectType.
        /// </summary>
        public const uint AccessorySlotType = 1017;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType ObjectType.
        /// </summary>
        public const uint AccessorySlotStateMachineType = 1018;

        /// <summary>
        /// The identifier for the AccessoryType ObjectType.
        /// </summary>
        public const uint AccessoryType = 1019;

        /// <summary>
        /// The identifier for the DetectorType ObjectType.
        /// </summary>
        public const uint DetectorType = 9350;

        /// <summary>
        /// The identifier for the SmartSamplingSystemType ObjectType.
        /// </summary>
        public const uint SmartSamplingSystemType = 9359;

        /// <summary>
        /// The identifier for the SourceType ObjectType.
        /// </summary>
        public const uint SourceType = 9368;

        /// <summary>
        /// The identifier for the GcOvenType ObjectType.
        /// </summary>
        public const uint GcOvenType = 1020;
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
        /// The identifier for the HasDataSource ReferenceType.
        /// </summary>
        public const uint HasDataSource = 4001;

        /// <summary>
        /// The identifier for the HasInput ReferenceType.
        /// </summary>
        public const uint HasInput = 4002;

        /// <summary>
        /// The identifier for the HasOutput ReferenceType.
        /// </summary>
        public const uint HasOutput = 4003;
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
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GetConfiguration_OutputArguments = 9444;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_SetConfiguration_InputArguments = 9446;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_SetConfiguration_OutputArguments = 9447;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_GetConfigDataDigest_OutputArguments = 9449;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_CompareConfigDataDigest_InputArguments = 9451;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments = 9452;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_DiagnosticStatus = 9459;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Size = 9463;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Writeable Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Writeable = 13269;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_UserWriteable Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_UserWriteable = 13270;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_OpenCount = 9466;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Open_InputArguments = 9468;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Open_OutputArguments = 9469;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Close_InputArguments = 9471;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Read_InputArguments = 9473;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Read_OutputArguments = 9474;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_Write_InputArguments = 9476;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments = 9478;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments = 9479;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments = 9481;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = 9524;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ParameterSet_IsEnabled = 9537;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus = 9540;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint AnalyserDeviceType_ChannelIdentifier_ParameterSet_ActiveStream = 9543;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public const uint AnalyserDeviceType_AccessorySlotIdentifier_IsHotSwappable = 9612;

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public const uint AnalyserDeviceType_AccessorySlotIdentifier_IsEnabled = 9613;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigurationMethodType_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeGetConfigurationMethodType_OutputArguments = 9627;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeSetConfigurationMethodType_InputArguments = 9629;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeSetConfigurationMethodType_OutputArguments = 9630;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigDataDigestMethodType_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeGetConfigDataDigestMethodType_OutputArguments = 9632;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType_InputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeCompareConfigDataDigestMethodType_InputArguments = 9634;

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType_OutputArguments Variable.
        /// </summary>
        public const uint AnalyserDeviceTypeCompareConfigDataDigestMethodType_OutputArguments = 9635;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Powerup_StateNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Powerup_StateNumber = 9648;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Operating_StateNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Operating_StateNumber = 9650;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Local_StateNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Local_StateNumber = 9652;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Maintenance_StateNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Maintenance_StateNumber = 9654;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Shutdown_StateNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_Shutdown_StateNumber = 9656;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_PowerupToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_PowerupToOperatingTransition_TransitionNumber = 9658;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToLocalTransition_TransitionNumber = 9660;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition_TransitionNumber = 9662;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToOperatingTransition_TransitionNumber = 9664;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToMaintenanceTransition_TransitionNumber = 9666;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition_TransitionNumber = 9668;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToLocalTransition_TransitionNumber = 9670;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_OperatingToShutdownTransition_TransitionNumber = 9672;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_LocalToShutdownTransition_TransitionNumber = 9674;

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition_TransitionNumber = 9676;

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint AnalyserChannelType_MethodSet_StartSingleAcquisition_InputArguments = 9702;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_ChannelId Variable.
        /// </summary>
        public const uint AnalyserChannelType_ParameterSet_ChannelId = 9712;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint AnalyserChannelType_ParameterSet_IsEnabled = 9715;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint AnalyserChannelType_ParameterSet_DiagnosticStatus = 9718;

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint AnalyserChannelType_ParameterSet_ActiveStream = 9721;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_IsEnabled = 9811;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_DiagnosticStatus = 9817;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_LastSampleTime = 9826;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_TimeBetweenSamples_EURange = 9833;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_IsActive = 9835;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycle = 9838;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode = 9841;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode_EnumStrings = 9844;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_Progress Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_Progress = 9845;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter = 9848;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter_EURange = 9852;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionResultStatus = 9854;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_ScaledData = 9860;

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionEndTime = 9866;

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public const uint AnalyserChannelType_AccessorySlotIdentifier_IsHotSwappable = 9918;

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public const uint AnalyserChannelType_AccessorySlotIdentifier_IsEnabled = 9919;

        /// <summary>
        /// The identifier for the AnalyserChannelTypeStartSingleAcquisitionMethodType_InputArguments Variable.
        /// </summary>
        public const uint AnalyserChannelTypeStartSingleAcquisitionMethodType_InputArguments = 9933;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveMode_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_SlaveMode_StateNumber = 9997;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Operating_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Operating_StateNumber = 9999;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Local_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Local_StateNumber = 10001;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Maintenance_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_Maintenance_StateNumber = 10003;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveModeToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_SlaveModeToOperatingTransition_TransitionNumber = 10005;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToLocalTransition_TransitionNumber = 10007;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToMaintenanceTransition_TransitionNumber = 10009;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToOperatingTransition_TransitionNumber = 10011;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToMaintenanceTransition_TransitionNumber = 10013;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToOperatingTransition_TransitionNumber = 10015;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToLocalTransition_TransitionNumber = 10017;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_OperatingToSlaveModeTransition_TransitionNumber = 10019;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_LocalToSlaveModeTransition_TransitionNumber = 10021;

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition_TransitionNumber = 10023;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopped_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Stopped_StateNumber = 10049;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Resetting_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Resetting_StateNumber = 10051;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Idle_StateNumber = 10053;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Starting_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Starting_StateNumber = 10055;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Execute_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Execute_StateNumber = 10057;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Completing_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Completing_StateNumber = 10059;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Complete_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Complete_StateNumber = 10061;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspending_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Suspending_StateNumber = 10063;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Suspended_StateNumber = 10065;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending_StateNumber = 10067;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Holding_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Holding_StateNumber = 10069;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Held_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Held_StateNumber = 10071;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unholding_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Unholding_StateNumber = 10073;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopping_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Stopping_StateNumber = 10075;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborting_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Aborting_StateNumber = 10077;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborted_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Aborted_StateNumber = 10079;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Clearing_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_Clearing_StateNumber = 10081;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition_TransitionNumber = 10083;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition_TransitionNumber = 10085;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition_TransitionNumber = 10087;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition_TransitionNumber = 10089;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition_TransitionNumber = 10091;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition_TransitionNumber = 10093;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition_TransitionNumber = 10095;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition_TransitionNumber = 10097;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition_TransitionNumber = 10099;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition_TransitionNumber = 10101;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition_TransitionNumber = 10103;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition_TransitionNumber = 10105;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition_TransitionNumber = 10107;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition_TransitionNumber = 10109;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition_TransitionNumber = 10111;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition_TransitionNumber = 10113;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition_TransitionNumber = 10115;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition_TransitionNumber = 10117;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition_TransitionNumber = 10119;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition_TransitionNumber = 10121;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition_TransitionNumber = 10123;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition_TransitionNumber = 10125;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition_TransitionNumber = 10127;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition_TransitionNumber = 10129;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition_TransitionNumber = 10131;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition_TransitionNumber = 10133;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition_TransitionNumber = 10135;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition_TransitionNumber = 10137;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition_TransitionNumber = 10139;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition_TransitionNumber = 10141;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition_TransitionNumber = 10143;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition_TransitionNumber = 10145;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition_TransitionNumber = 10147;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition_TransitionNumber = 10149;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition_TransitionNumber = 10151;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition_TransitionNumber = 10153;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition_TransitionNumber = 10155;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition_TransitionNumber = 10157;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition_TransitionNumber = 10159;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition_TransitionNumber = 10161;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition_TransitionNumber = 10163;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition_TransitionNumber = 10165;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition_TransitionNumber = 10167;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition_TransitionNumber = 10169;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition_TransitionNumber = 10171;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition_TransitionNumber = 10173;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition_TransitionNumber = 10175;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition_TransitionNumber = 10177;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition_TransitionNumber = 10179;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition_TransitionNumber = 10181;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition_TransitionNumber = 10183;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition_TransitionNumber = 10185;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition_TransitionNumber = 10187;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition_TransitionNumber = 10189;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle_StateNumber = 10202;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger_StateNumber = 10204;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample_StateNumber = 10206;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample_StateNumber = 10208;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample_StateNumber = 10210;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger_StateNumber = 10212;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample_StateNumber = 10214;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample_StateNumber = 10216;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample_StateNumber = 10218;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger_StateNumber = 10220;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample_StateNumber = 10222;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample_StateNumber = 10224;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample_StateNumber = 10226;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger_StateNumber = 10228;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic_StateNumber = 10230;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger_StateNumber = 10232;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning_StateNumber = 10234;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults_StateNumber = 10236;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample_StateNumber = 10238;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem_StateNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem_StateNumber = 10240;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition_TransitionNumber = 10242;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition_TransitionNumber = 10244;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition_TransitionNumber = 10246;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition_TransitionNumber = 10248;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition_TransitionNumber = 10250;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition_TransitionNumber = 10252;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition_TransitionNumber = 10254;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition_TransitionNumber = 10256;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition_TransitionNumber = 10258;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition_TransitionNumber = 10260;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition_TransitionNumber = 10262;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition_TransitionNumber = 10264;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition_TransitionNumber = 10266;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition_TransitionNumber = 10268;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition_TransitionNumber = 10270;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition_TransitionNumber = 10272;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition_TransitionNumber = 10274;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition_TransitionNumber = 10276;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition_TransitionNumber = 10278;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition_TransitionNumber = 10280;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition_TransitionNumber = 10282;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition_TransitionNumber = 10284;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition_TransitionNumber = 10286;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition_TransitionNumber = 10288;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition_TransitionNumber = 10290;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition_TransitionNumber = 10292;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition_TransitionNumber = 10294;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition_TransitionNumber = 10296;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition_TransitionNumber = 10298;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition_TransitionNumber = 10300;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition_TransitionNumber = 10302;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition_TransitionNumber = 10304;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition_TransitionNumber = 10306;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition_TransitionNumber = 10308;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition_TransitionNumber = 10310;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition_TransitionNumber = 10312;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition_TransitionNumber = 10314;

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition_TransitionNumber = 10316;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_IsEnabled = 10339;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsForced Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_IsForced = 10342;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_DiagnosticStatus = 10345;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastCalibrationTime Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_LastCalibrationTime = 10348;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastValidationTime Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_LastValidationTime = 10351;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_LastSampleTime = 10354;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_TimeBetweenSamples Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_TimeBetweenSamples = 10357;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_TimeBetweenSamples_EURange = 10361;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_IsActive = 10363;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_ExecutionCycle = 10366;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_ExecutionCycleSubcode = 10369;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_ExecutionCycleSubcode_EnumStrings = 10372;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Progress Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Progress = 10373;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_AcquisitionCounter = 10376;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_AcquisitionCounter_EURange = 10380;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_AcquisitionResultStatus = 10382;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_RawData Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_RawData = 10385;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_ScaledData = 10388;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Offset Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Offset = 10391;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_AcquisitionEndTime = 10394;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_CampaignId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_CampaignId = 10397;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_BatchId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_BatchId = 10400;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_SubBatchId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_SubBatchId = 10403;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LotId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_LotId = 10406;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_MaterialId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_MaterialId = 10409;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Process Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Process = 10412;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Unit Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Unit = 10415;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Operation Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Operation = 10418;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Phase Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_Phase = 10421;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_UserId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_UserId = 10424;

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_SampleId Variable.
        /// </summary>
        public const uint StreamType_ParameterSet_SampleId = 10427;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_ActiveBackground = 10575;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground_XAxisDefinition Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_ActiveBackground_XAxisDefinition = 10583;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1 Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1 = 10584;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1_XAxisDefinition Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1_XAxisDefinition = 10592;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_SpectralRange Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_SpectralRange = 10593;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_Resolution Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_Resolution = 10596;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_RequestedNumberOfScans Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_RequestedNumberOfScans = 10599;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_Gain Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_Gain = 10602;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_TransmittanceCutoff Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_TransmittanceCutoff = 10605;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_AbsorbanceCutoff Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_AbsorbanceCutoff = 10608;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_NumberOfScansDone Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_NumberOfScansDone = 10611;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_TotalNumberOfScansDone Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_TotalNumberOfScansDone = 10614;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_BackgroundAcquisitionTime Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_BackgroundAcquisitionTime = 10617;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_PendingBackground = 10620;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground_XAxisDefinition Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_PendingBackground_XAxisDefinition = 10628;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground1 Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_PendingBackground1 = 10629;

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground1_XAxisDefinition Variable.
        /// </summary>
        public const uint SpectrometerDeviceStreamType_ParameterSet_PendingBackground1_XAxisDefinition = 10637;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_Background Variable.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet_Background = 10897;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_Background_XAxisDefinition Variable.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet_Background_XAxisDefinition = 10905;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution Variable.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution = 10906;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution_XAxisDefinition Variable.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution_XAxisDefinition = 10914;

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_BackgroundAcquisitionTime Variable.
        /// </summary>
        public const uint ParticleSizeMonitorDeviceStreamType_ParameterSet_BackgroundAcquisitionTime = 10915;

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_ParameterSet_SpectralRange Variable.
        /// </summary>
        public const uint SpectrometerDeviceType_ParameterSet_SpectralRange = 11551;

        /// <summary>
        /// The identifier for the AccessorySlotType_IsHotSwappable Variable.
        /// </summary>
        public const uint AccessorySlotType_IsHotSwappable = 12786;

        /// <summary>
        /// The identifier for the AccessorySlotType_IsEnabled Variable.
        /// </summary>
        public const uint AccessorySlotType_IsEnabled = 12787;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_IsHotSwappable Variable.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier_IsHotSwappable = 12827;

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_IsReady Variable.
        /// </summary>
        public const uint AccessorySlotType_AccessoryIdentifier_IsReady = 12828;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Powerup_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Powerup_StateNumber = 12841;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Empty_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Empty_StateNumber = 12843;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Inserting_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Inserting_StateNumber = 12845;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Installed_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Installed_StateNumber = 12847;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Removing_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Removing_StateNumber = 12849;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Shutdown_StateNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_Shutdown_StateNumber = 12851;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_PowerupToEmptyTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_PowerupToEmptyTransition_TransitionNumber = 12853;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToInsertingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_EmptyToInsertingTransition_TransitionNumber = 12855;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingTransition_TransitionNumber = 12857;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToRemovingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToRemovingTransition_TransitionNumber = 12859;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToInstalledTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToInstalledTransition_TransitionNumber = 12861;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToRemovingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InstalledToRemovingTransition_TransitionNumber = 12863;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingTransition_TransitionNumber = 12865;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToEmptyTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingToEmptyTransition_TransitionNumber = 12867;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_EmptyToShutdownTransition_TransitionNumber = 12869;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InsertingToShutdownTransition_TransitionNumber = 12871;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_InstalledToShutdownTransition_TransitionNumber = 12873;

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public const uint AccessorySlotStateMachineType_RemovingToShutdownTransition_TransitionNumber = 12875;

        /// <summary>
        /// The identifier for the AccessoryType_IsHotSwappable Variable.
        /// </summary>
        public const uint AccessoryType_IsHotSwappable = 12904;

        /// <summary>
        /// The identifier for the AccessoryType_IsReady Variable.
        /// </summary>
        public const uint AccessoryType_IsReady = 12905;

        /// <summary>
        /// The identifier for the ExecutionCycleEnumeration_EnumValues Variable.
        /// </summary>
        public const uint ExecutionCycleEnumeration_EnumValues = 13026;

        /// <summary>
        /// The identifier for the AcquisitionResultStatusEnumeration_EnumStrings Variable.
        /// </summary>
        public const uint AcquisitionResultStatusEnumeration_EnumStrings = 13027;

        /// <summary>
        /// The identifier for the EngineeringValueType_Identifier Variable.
        /// </summary>
        public const uint EngineeringValueType_Identifier = 13030;

        /// <summary>
        /// The identifier for the ChemometricModelType_Name Variable.
        /// </summary>
        public const uint ChemometricModelType_Name = 13033;

        /// <summary>
        /// The identifier for the ChemometricModelType_CreationDate Variable.
        /// </summary>
        public const uint ChemometricModelType_CreationDate = 13034;

        /// <summary>
        /// The identifier for the ChemometricModelType_ModelDescription Variable.
        /// </summary>
        public const uint ChemometricModelType_ModelDescription = 13035;

        /// <summary>
        /// The identifier for the ChemometricModelType_User_defined_Input Variable.
        /// </summary>
        public const uint ChemometricModelType_User_defined_Input = 13036;

        /// <summary>
        /// The identifier for the ChemometricModelType_User_defined_Output Variable.
        /// </summary>
        public const uint ChemometricModelType_User_defined_Output = 13037;

        /// <summary>
        /// The identifier for the ProcessVariableType_SourceName Variable.
        /// </summary>
        public const uint ProcessVariableType_SourceName = 13040;

        /// <summary>
        /// The identifier for the MVAModelType_User_defined_Output Variable.
        /// </summary>
        public const uint MVAModelType_User_defined_Output = 13045;

        /// <summary>
        /// The identifier for the MVAModelType_MainDataIndex Variable.
        /// </summary>
        public const uint MVAModelType_MainDataIndex = 13046;

        /// <summary>
        /// The identifier for the MVAModelType_User_defined_Output_AlarmState Variable.
        /// </summary>
        public const uint MVAModelType_User_defined_Output_AlarmState = 13049;

        /// <summary>
        /// The identifier for the MVAPredictMethodType_InputArguments Variable.
        /// </summary>
        public const uint MVAPredictMethodType_InputArguments = 13052;

        /// <summary>
        /// The identifier for the MVAPredictMethodType_OutputArguments Variable.
        /// </summary>
        public const uint MVAPredictMethodType_OutputArguments = 13053;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_WarningLimits Variable.
        /// </summary>
        public const uint MVAOutputParameterType_WarningLimits = 13054;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_AlarmLimits Variable.
        /// </summary>
        public const uint MVAOutputParameterType_AlarmLimits = 13055;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_AlarmState Variable.
        /// </summary>
        public const uint MVAOutputParameterType_AlarmState = 13056;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_VendorSpecificError Variable.
        /// </summary>
        public const uint MVAOutputParameterType_VendorSpecificError = 13057;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics Variable.
        /// </summary>
        public const uint MVAOutputParameterType_Statistics = 13058;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_WarningLimits Variable.
        /// </summary>
        public const uint MVAOutputParameterType_Statistics_WarningLimits = 13059;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_AlarmLimits Variable.
        /// </summary>
        public const uint MVAOutputParameterType_Statistics_AlarmLimits = 13060;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_AlarmState Variable.
        /// </summary>
        public const uint MVAOutputParameterType_Statistics_AlarmState = 13061;

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_VendorSpecificError Variable.
        /// </summary>
        public const uint MVAOutputParameterType_Statistics_VendorSpecificError = 13062;

        /// <summary>
        /// The identifier for the AlarmStateEnumeration_EnumValues Variable.
        /// </summary>
        public const uint AlarmStateEnumeration_EnumValues = 13063;

        /// <summary>
        /// The identifier for the OpcUaAdi_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaAdi_XmlSchema = 13064;

        /// <summary>
        /// The identifier for the OpcUaAdi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaAdi_XmlSchema_NamespaceUri = 13066;

        /// <summary>
        /// The identifier for the OpcUaAdi_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaAdi_BinarySchema = 13067;

        /// <summary>
        /// The identifier for the OpcUaAdi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaAdi_BinarySchema_NamespaceUri = 13069;
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
        /// The identifier for the EngineeringValueType VariableType.
        /// </summary>
        public const uint EngineeringValueType = 9380;

        /// <summary>
        /// The identifier for the ChemometricModelType VariableType.
        /// </summary>
        public const uint ChemometricModelType = 2007;

        /// <summary>
        /// The identifier for the ProcessVariableType VariableType.
        /// </summary>
        public const uint ProcessVariableType = 2008;

        /// <summary>
        /// The identifier for the MVAModelType VariableType.
        /// </summary>
        public const uint MVAModelType = 2009;

        /// <summary>
        /// The identifier for the MVAOutputParameterType VariableType.
        /// </summary>
        public const uint MVAOutputParameterType = 2010;
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
        /// The identifier for the ExecutionCycleEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionCycleEnumeration = new ExpandedNodeId(Opc.Ua.Adi.DataTypes.ExecutionCycleEnumeration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AcquisitionResultStatusEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId AcquisitionResultStatusEnumeration = new ExpandedNodeId(Opc.Ua.Adi.DataTypes.AcquisitionResultStatusEnumeration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AlarmStateEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId AlarmStateEnumeration = new ExpandedNodeId(Opc.Ua.Adi.DataTypes.AlarmStateEnumeration, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GetConfiguration = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_GetConfiguration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_SetConfiguration = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_SetConfiguration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GetConfigDataDigest = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_GetConfigDataDigest, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_CompareConfigDataDigest = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_CompareConfigDataDigest, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_ResetAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_ResetAllChannels = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_ResetAllChannels, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_StartAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_StartAllChannels = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_StartAllChannels, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_StopAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_StopAllChannels = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_StopAllChannels, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_AbortAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_AbortAllChannels = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_AbortAllChannels, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GotoOperating = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_GotoOperating, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GotoMaintenance = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_MethodSet_GotoMaintenance, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Open = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_Open, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Close = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_Close, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Read = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_Read, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Write = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_Write, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_GetPosition = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_GetPosition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_SetPosition = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ParameterSet_ConfigData_SetPosition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoOperating = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoOperating, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Reset = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Reset, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Start = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Start, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Stop = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Stop, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Hold = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Hold, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Unhold = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Unhold, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Suspend = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Suspend, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Unsuspend = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Unsuspend, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Abort = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Abort, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_Clear = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceType_ChannelIdentifier_MethodSet_Clear, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigurationMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeGetConfigurationMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceTypeGetConfigurationMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeSetConfigurationMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceTypeSetConfigurationMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigDataDigestMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeGetConfigDataDigestMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceTypeGetConfigDataDigestMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeCompareConfigDataDigestMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserDeviceTypeCompareConfigDataDigestMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_GotoOperating = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_GotoOperating, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_GotoMaintenance = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_GotoMaintenance, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_StartSingleAcquisition = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_StartSingleAcquisition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Reset = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Reset, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Start = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Start, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Stop = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Stop, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Hold = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Hold, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Unhold = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Unhold, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Suspend = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Suspend, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Unsuspend = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Unsuspend, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Abort = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Abort, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_Clear = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelType_MethodSet_Clear, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelTypeStartSingleAcquisitionMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelTypeStartSingleAcquisitionMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.AnalyserChannelTypeStartSingleAcquisitionMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAPredictMethodType Method.
        /// </summary>
        public static readonly ExpandedNodeId MVAPredictMethodType = new ExpandedNodeId(Opc.Ua.Adi.Methods.MVAPredictMethodType, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the AnalyserDeviceType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_MethodSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_Identification = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_Identification, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ParameterSet_ConfigData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_FactorySettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_FactorySettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AnalyserStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_AnalyserStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_AnalyserStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_AccessorySlotIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_AccessorySlotIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Powerup Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Powerup = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_Powerup, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Operating Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Operating = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_Operating, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Local Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Local = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_Local, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Maintenance Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Maintenance = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_Maintenance, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Shutdown Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Shutdown = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_Shutdown, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_PowerupToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_PowerupToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_PowerupToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToLocalTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToLocalTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_OperatingToLocalTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_LocalToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToMaintenanceTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToMaintenanceTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_LocalToMaintenanceTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToLocalTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToLocalTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_MaintenanceToLocalTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_OperatingToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_LocalToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_MethodSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_GroupIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ChannelStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_ChannelStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_AcquisitionSettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_AcquisitionSettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_AcquisitionStatus = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_AcquisitionStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_AcquisitionData = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_AcquisitionData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ChemometricModelSettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_ChemometricModelSettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_Context = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_StreamIdentifier_Context, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_AccessorySlotIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_AccessorySlotIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_AccessorySlotIdentifier_AccessorySlotStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelType_AccessorySlotIdentifier_AccessorySlotStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_OperatingSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_OperatingSubStateMachine_OperatingExecuteSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_LocalSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_MaintenanceSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveMode Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_SlaveMode = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_SlaveMode, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Operating Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Operating = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_Operating, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Local Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Local = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_Local, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Maintenance Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Maintenance = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_Maintenance, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveModeToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_SlaveModeToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_SlaveModeToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToLocalTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToLocalTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_OperatingToLocalTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToMaintenanceTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToMaintenanceTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_OperatingToMaintenanceTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_LocalToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToMaintenanceTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToMaintenanceTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_LocalToMaintenanceTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToOperatingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToOperatingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_MaintenanceToOperatingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToLocalTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToLocalTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_MaintenanceToLocalTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToSlaveModeTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToSlaveModeTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_OperatingToSlaveModeTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToSlaveModeTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToSlaveModeTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_LocalToSlaveModeTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_OperatingExecuteSubStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_OperatingExecuteSubStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopped Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Stopped = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Stopped, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Resetting Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Resetting = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Resetting, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Idle Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Idle = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Idle, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Starting Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Starting = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Starting, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Execute Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Execute = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Execute, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Completing Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Completing = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Completing, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Complete Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Complete = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Complete, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspending Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Suspending = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Suspending, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Suspended = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Suspended, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Holding Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Holding = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Holding, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Held Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Held = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Held, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unholding Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Unholding = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Unholding, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopping Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Stopping = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Stopping, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborting Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Aborting = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Aborting, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborted Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Aborted = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Aborted, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Clearing Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Clearing = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_Clearing, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_GroupIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_AcquisitionSettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_AcquisitionSettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_AcquisitionStatus = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_AcquisitionStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_AcquisitionData = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_AcquisitionData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ChemometricModelSettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_ChemometricModelSettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_Context = new ExpandedNodeId(Opc.Ua.Adi.Objects.StreamType_Context, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_AcquisitionSettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_AcquisitionSettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_AcquisitionStatus = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_AcquisitionStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_AcquisitionData = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_AcquisitionData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_FactorySettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceStreamType_FactorySettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.ParticleSizeMonitorDeviceStreamType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_AcquisitionData = new ExpandedNodeId(Opc.Ua.Adi.Objects.ParticleSizeMonitorDeviceStreamType_AcquisitionData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceType_ParameterSet = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceType_ParameterSet, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceType_FactorySettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.SpectrometerDeviceType_FactorySettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessorySlotStateMachine = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotType_AccessorySlotStateMachine, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotType_AccessoryIdentifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotType_AccessoryIdentifier_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotType_AccessoryIdentifier_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier_FactorySettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotType_AccessoryIdentifier_FactorySettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Powerup Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Powerup = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Powerup, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Empty Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Empty = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Empty, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Inserting Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Inserting = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Inserting, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Installed Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Installed = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Installed, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Removing Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Removing = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Removing, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Shutdown Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Shutdown = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_Shutdown, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_PowerupToEmptyTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_PowerupToEmptyTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_PowerupToEmptyTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToInsertingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_EmptyToInsertingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_EmptyToInsertingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InsertingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToRemovingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToRemovingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InsertingToRemovingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToInstalledTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToInstalledTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InsertingToInstalledTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToRemovingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InstalledToRemovingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InstalledToRemovingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_RemovingTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToEmptyTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingToEmptyTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_RemovingToEmptyTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_EmptyToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_EmptyToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InsertingToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InstalledToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_InstalledToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToShutdownTransition Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingToShutdownTransition = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessorySlotStateMachineType_RemovingToShutdownTransition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType_Configuration = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessoryType_Configuration, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType_Status = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessoryType_Status, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType_FactorySettings = new ExpandedNodeId(Opc.Ua.Adi.Objects.AccessoryType_FactorySettings, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the AnalyserDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelOperatingStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelOperatingStateType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelLocalStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelLocalStateType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelLocalStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelMaintenanceStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelMaintenanceStateType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelMaintenanceStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelOperatingExecuteStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelOperatingExecuteStateType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingExecuteStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeExecuteSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId StreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.StreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MassSpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MassSpectrometerDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AcousticSpectrometerDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AcousticSpectrometerDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChromatographDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ChromatographDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MNRDeviceStreamType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MNRDeviceStreamType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.MNRDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChromatographDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ChromatographDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MassSpectrometerDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MassSpectrometerDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AcousticSpectrometerDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AcousticSpectrometerDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the NMRDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId NMRDeviceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.NMRDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AccessorySlotType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AccessorySlotStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.AccessoryType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the DetectorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DetectorType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.DetectorType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SmartSamplingSystemType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SmartSamplingSystemType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.SmartSamplingSystemType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SourceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SourceType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.SourceType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the GcOvenType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GcOvenType = new ExpandedNodeId(Opc.Ua.Adi.ObjectTypes.GcOvenType, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the HasDataSource ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasDataSource = new ExpandedNodeId(Opc.Ua.Adi.ReferenceTypes.HasDataSource, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the HasInput ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasInput = new ExpandedNodeId(Opc.Ua.Adi.ReferenceTypes.HasInput, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the HasOutput ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId HasOutput = new ExpandedNodeId(Opc.Ua.Adi.ReferenceTypes.HasOutput, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GetConfiguration_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_GetConfiguration_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_SetConfiguration_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_SetConfiguration_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_SetConfiguration_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_SetConfiguration_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_GetConfigDataDigest_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_GetConfigDataDigest_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_CompareConfigDataDigest_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_CompareConfigDataDigest_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_DiagnosticStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Size = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Size, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Writeable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Writeable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Writeable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_UserWriteable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_UserWriteable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_UserWriteable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_OpenCount = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_OpenCount, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Open_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Open_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Open_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Close_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Close_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Read_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Read_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Read_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_Write_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_Write_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ParameterSet_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ChannelIdentifier_ParameterSet_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_ChannelIdentifier_ParameterSet_ActiveStream = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_ChannelIdentifier_ParameterSet_ActiveStream, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_AccessorySlotIdentifier_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_AccessorySlotIdentifier_IsHotSwappable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceType_AccessorySlotIdentifier_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceType_AccessorySlotIdentifier_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigurationMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeGetConfigurationMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeGetConfigurationMethodType_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeSetConfigurationMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeSetConfigurationMethodType_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeSetConfigurationMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeSetConfigurationMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeSetConfigurationMethodType_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeGetConfigDataDigestMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeGetConfigDataDigestMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeGetConfigDataDigestMethodType_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeCompareConfigDataDigestMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeCompareConfigDataDigestMethodType_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceTypeCompareConfigDataDigestMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceTypeCompareConfigDataDigestMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceTypeCompareConfigDataDigestMethodType_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Powerup_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Powerup_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_Powerup_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Operating_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Operating_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_Operating_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Local_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Local_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_Local_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Maintenance_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Maintenance_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_Maintenance_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_Shutdown_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_Shutdown_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_Shutdown_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_PowerupToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_PowerupToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_PowerupToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToLocalTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_OperatingToLocalTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_OperatingToMaintenanceTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_LocalToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToMaintenanceTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_LocalToMaintenanceTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_MaintenanceToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToLocalTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_MaintenanceToLocalTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_OperatingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_OperatingToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_OperatingToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_LocalToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_LocalToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_LocalToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserDeviceStateMachineType_MaintenanceToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_MethodSet_StartSingleAcquisition_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_ChannelId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ParameterSet_ChannelId = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_ParameterSet_ChannelId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ParameterSet_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_ParameterSet_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_ParameterSet_DiagnosticStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_ParameterSet_ActiveStream = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_ParameterSet_ActiveStream, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_DiagnosticStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_LastSampleTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_LastSampleTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_TimeBetweenSamples_EURange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_IsActive = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_IsActive, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycle = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycle, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_ExecutionCycleSubcode_EnumStrings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_Progress = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_Progress, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionCounter_EURange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionResultStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_ScaledData = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_ScaledData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_StreamIdentifier_ParameterSet_AcquisitionEndTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_AccessorySlotIdentifier_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_AccessorySlotIdentifier_IsHotSwappable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelType_AccessorySlotIdentifier_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelType_AccessorySlotIdentifier_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelTypeStartSingleAcquisitionMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelTypeStartSingleAcquisitionMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelTypeStartSingleAcquisitionMethodType_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveMode_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_SlaveMode_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_SlaveMode_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Operating_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Operating_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_Operating_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Local_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Local_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_Local_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_Maintenance_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_Maintenance_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_Maintenance_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_SlaveModeToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_SlaveModeToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_SlaveModeToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToLocalTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_OperatingToLocalTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToMaintenanceTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_OperatingToMaintenanceTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_LocalToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToMaintenanceTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToMaintenanceTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_LocalToMaintenanceTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToOperatingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToOperatingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_MaintenanceToOperatingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToLocalTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToLocalTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_MaintenanceToLocalTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_OperatingToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_OperatingToSlaveModeTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_OperatingToSlaveModeTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_LocalToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_LocalToSlaveModeTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_LocalToSlaveModeTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannelStateMachineType_MaintenanceToSlaveModeTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopped_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Stopped_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Stopped_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Resetting_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Resetting_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Resetting_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Idle_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Idle_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Starting_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Starting_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Starting_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Execute_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Execute_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Execute_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Completing_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Completing_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Completing_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Complete_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Complete_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Complete_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspending_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Suspending_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Suspending_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Suspended_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Suspended_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Unsuspending_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Holding_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Holding_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Holding_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Held_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Held_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Held_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Unholding_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Unholding_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Unholding_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Stopping_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Stopping_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Stopping_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborting_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Aborting_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Aborting_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Aborted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Aborted_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Aborted_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_Clearing_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_Clearing_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_Clearing_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StoppedToResettingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ResettingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToIdleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_IdleToStartingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StartingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StartingToExecuteTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToCompletingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompletingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToCompleteTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppedTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToHoldingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HoldingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToHeldTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HeldToUnholdingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToHoldingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToExecuteTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToSuspendingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToSuspendedTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToUnsuspendingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToSuspendingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToExecuteTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StoppingToStoppedTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_AbortingToAbortedTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_AbortedToClearingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ClearingToStoppedTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_IdleToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StartingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HeldToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToStoppingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StoppedToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ResettingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_IdleToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StartingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_ExecuteToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompletingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_CompleteToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_SuspendedToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnsuspendingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HoldingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_HeldToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_UnholdingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeSubStateMachineType_StoppingToAbortingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycle_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTrigger_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTrigger_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTrigger_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTrigger_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_Diagnostic_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTrigger_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_Cleaning_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResults_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSample_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystem_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCalibrationTriggerTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCalibrationTriggerToExtractCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractCalibrationSampleToPrepareCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareCalibrationSampleToAnalyseCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseCalibrationSampleToPublishResultsTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForValidationTriggerTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForValidationTriggerToExtractValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractValidationSampleToPrepareValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareValidationSampleToAnalyseValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseValidationSampleToPublishResultsTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForSampleTriggerTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForSampleTriggerToExtractSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_ExtractSampleToPrepareSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PrepareSampleToAnalyseSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_AnalyseSampleToPublishResultsTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForDiagnosticTriggerTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForDiagnosticTriggerToDiagnosticTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_DiagnosticToPublishResultsTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_SelectExecutionCycleToWaitForCleaningTriggerTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_WaitForCleaningTriggerToCleaningTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleaningToPublishResultsTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToCleanupSamplingSystemTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_PublishResultsToEjectGrabSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_EjectGrabSampleToCleanupSamplingSystemTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AnalyserChannel_OperatingModeExecuteSubStateMachineType_CleanupSamplingSystemToSelectExecutionCycleTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsForced Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_IsForced = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_IsForced, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_DiagnosticStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastCalibrationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_LastCalibrationTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_LastCalibrationTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastValidationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_LastValidationTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_LastValidationTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_LastSampleTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_LastSampleTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_TimeBetweenSamples Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_TimeBetweenSamples = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_TimeBetweenSamples, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_TimeBetweenSamples_EURange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_IsActive = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_IsActive, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_ExecutionCycle = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_ExecutionCycle, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_ExecutionCycleSubcode, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_ExecutionCycleSubcode_EnumStrings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Progress = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Progress, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_AcquisitionCounter = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_AcquisitionCounter, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_AcquisitionCounter_EURange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_AcquisitionResultStatus, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_RawData Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_RawData = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_RawData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_ScaledData = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_ScaledData, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Offset Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Offset = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Offset, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_AcquisitionEndTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_CampaignId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_CampaignId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_CampaignId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_BatchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_BatchId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_BatchId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_SubBatchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_SubBatchId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_SubBatchId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_LotId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_LotId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_LotId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_MaterialId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_MaterialId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_MaterialId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Process Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Process = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Process, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Unit Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Unit = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Unit, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Operation Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Operation = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Operation, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_Phase Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_Phase = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_Phase, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_UserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_UserId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_UserId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the StreamType_ParameterSet_SampleId Variable.
        /// </summary>
        public static readonly ExpandedNodeId StreamType_ParameterSet_SampleId = new ExpandedNodeId(Opc.Ua.Adi.Variables.StreamType_ParameterSet_SampleId, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_ActiveBackground = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_ActiveBackground, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_ActiveBackground_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_ActiveBackground_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1 = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_ActiveBackground1_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_SpectralRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_SpectralRange = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_SpectralRange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_Resolution Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_Resolution = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_Resolution, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_RequestedNumberOfScans Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_RequestedNumberOfScans = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_RequestedNumberOfScans, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_Gain Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_Gain = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_Gain, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_TransmittanceCutoff Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_TransmittanceCutoff = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_TransmittanceCutoff, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_AbsorbanceCutoff Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_AbsorbanceCutoff = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_AbsorbanceCutoff, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_NumberOfScansDone Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_NumberOfScansDone = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_NumberOfScansDone, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_TotalNumberOfScansDone Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_TotalNumberOfScansDone = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_TotalNumberOfScansDone, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_BackgroundAcquisitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_BackgroundAcquisitionTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_BackgroundAcquisitionTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_PendingBackground = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_PendingBackground, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_PendingBackground_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_PendingBackground_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_PendingBackground1 = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_PendingBackground1, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceStreamType_ParameterSet_PendingBackground1_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceStreamType_ParameterSet_PendingBackground1_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceStreamType_ParameterSet_PendingBackground1_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_Background Variable.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet_Background = new ExpandedNodeId(Opc.Ua.Adi.Variables.ParticleSizeMonitorDeviceStreamType_ParameterSet_Background, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_Background_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet_Background_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.ParticleSizeMonitorDeviceStreamType_ParameterSet_Background_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution Variable.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution = new ExpandedNodeId(Opc.Ua.Adi.Variables.ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution_XAxisDefinition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution_XAxisDefinition = new ExpandedNodeId(Opc.Ua.Adi.Variables.ParticleSizeMonitorDeviceStreamType_ParameterSet_SizeDistribution_XAxisDefinition, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ParticleSizeMonitorDeviceStreamType_ParameterSet_BackgroundAcquisitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ParticleSizeMonitorDeviceStreamType_ParameterSet_BackgroundAcquisitionTime = new ExpandedNodeId(Opc.Ua.Adi.Variables.ParticleSizeMonitorDeviceStreamType_ParameterSet_BackgroundAcquisitionTime, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the SpectrometerDeviceType_ParameterSet_SpectralRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SpectrometerDeviceType_ParameterSet_SpectralRange = new ExpandedNodeId(Opc.Ua.Adi.Variables.SpectrometerDeviceType_ParameterSet_SpectralRange, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotType_IsHotSwappable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_IsEnabled = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotType_IsEnabled, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotType_AccessoryIdentifier_IsHotSwappable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotType_AccessoryIdentifier_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotType_AccessoryIdentifier_IsReady = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotType_AccessoryIdentifier_IsReady, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Powerup_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Powerup_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Powerup_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Empty_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Empty_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Empty_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Inserting_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Inserting_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Inserting_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Installed_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Installed_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Installed_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Removing_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Removing_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Removing_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_Shutdown_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_Shutdown_StateNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_Shutdown_StateNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_PowerupToEmptyTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_PowerupToEmptyTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_PowerupToEmptyTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToInsertingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_EmptyToInsertingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_EmptyToInsertingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InsertingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToRemovingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToRemovingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InsertingToRemovingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToInstalledTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToInstalledTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InsertingToInstalledTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToRemovingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InstalledToRemovingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InstalledToRemovingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_RemovingTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToEmptyTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingToEmptyTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_RemovingToEmptyTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_EmptyToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_EmptyToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_EmptyToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InsertingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InsertingToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InsertingToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_InstalledToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_InstalledToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_InstalledToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessorySlotStateMachineType_RemovingToShutdownTransition_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessorySlotStateMachineType_RemovingToShutdownTransition_TransitionNumber = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessorySlotStateMachineType_RemovingToShutdownTransition_TransitionNumber, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessoryType_IsHotSwappable, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AccessoryType_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccessoryType_IsReady = new ExpandedNodeId(Opc.Ua.Adi.Variables.AccessoryType_IsReady, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ExecutionCycleEnumeration_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionCycleEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.Adi.Variables.ExecutionCycleEnumeration_EnumValues, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AcquisitionResultStatusEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId AcquisitionResultStatusEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.Adi.Variables.AcquisitionResultStatusEnumeration_EnumStrings, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the EngineeringValueType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId EngineeringValueType_Identifier = new ExpandedNodeId(Opc.Ua.Adi.Variables.EngineeringValueType_Identifier, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType_Name = new ExpandedNodeId(Opc.Ua.Adi.Variables.ChemometricModelType_Name, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType_CreationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType_CreationDate = new ExpandedNodeId(Opc.Ua.Adi.Variables.ChemometricModelType_CreationDate, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType_ModelDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType_ModelDescription = new ExpandedNodeId(Opc.Ua.Adi.Variables.ChemometricModelType_ModelDescription, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType_User_defined_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType_User_defined_Input = new ExpandedNodeId(Opc.Ua.Adi.Variables.ChemometricModelType_User_defined_Input, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType_User_defined_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType_User_defined_Output = new ExpandedNodeId(Opc.Ua.Adi.Variables.ChemometricModelType_User_defined_Output, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ProcessVariableType_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProcessVariableType_SourceName = new ExpandedNodeId(Opc.Ua.Adi.Variables.ProcessVariableType_SourceName, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAModelType_User_defined_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAModelType_User_defined_Output = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAModelType_User_defined_Output, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAModelType_MainDataIndex Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAModelType_MainDataIndex = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAModelType_MainDataIndex, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAModelType_User_defined_Output_AlarmState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAModelType_User_defined_Output_AlarmState = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAModelType_User_defined_Output_AlarmState, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAPredictMethodType_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAPredictMethodType_InputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAPredictMethodType_InputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAPredictMethodType_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAPredictMethodType_OutputArguments = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAPredictMethodType_OutputArguments, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_WarningLimits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_WarningLimits = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_WarningLimits, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_AlarmLimits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_AlarmLimits = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_AlarmLimits, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_AlarmState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_AlarmState = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_AlarmState, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_VendorSpecificError Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_VendorSpecificError = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_VendorSpecificError, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_Statistics = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_Statistics, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_WarningLimits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_Statistics_WarningLimits = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_Statistics_WarningLimits, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_AlarmLimits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_Statistics_AlarmLimits = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_Statistics_AlarmLimits, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_AlarmState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_Statistics_AlarmState = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_Statistics_AlarmState, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType_Statistics_VendorSpecificError Variable.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType_Statistics_VendorSpecificError = new ExpandedNodeId(Opc.Ua.Adi.Variables.MVAOutputParameterType_Statistics_VendorSpecificError, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the AlarmStateEnumeration_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId AlarmStateEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.Adi.Variables.AlarmStateEnumeration_EnumValues, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the OpcUaAdi_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaAdi_XmlSchema = new ExpandedNodeId(Opc.Ua.Adi.Variables.OpcUaAdi_XmlSchema, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the OpcUaAdi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaAdi_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Adi.Variables.OpcUaAdi_XmlSchema_NamespaceUri, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the OpcUaAdi_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaAdi_BinarySchema = new ExpandedNodeId(Opc.Ua.Adi.Variables.OpcUaAdi_BinarySchema, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the OpcUaAdi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaAdi_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Adi.Variables.OpcUaAdi_BinarySchema_NamespaceUri, Opc.Ua.Adi.Namespaces.OpcUaAdi);
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
        /// The identifier for the EngineeringValueType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId EngineeringValueType = new ExpandedNodeId(Opc.Ua.Adi.VariableTypes.EngineeringValueType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ChemometricModelType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ChemometricModelType = new ExpandedNodeId(Opc.Ua.Adi.VariableTypes.ChemometricModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the ProcessVariableType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ProcessVariableType = new ExpandedNodeId(Opc.Ua.Adi.VariableTypes.ProcessVariableType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAModelType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MVAModelType = new ExpandedNodeId(Opc.Ua.Adi.VariableTypes.MVAModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi);

        /// <summary>
        /// The identifier for the MVAOutputParameterType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MVAOutputParameterType = new ExpandedNodeId(Opc.Ua.Adi.VariableTypes.MVAOutputParameterType, Opc.Ua.Adi.Namespaces.OpcUaAdi);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Aborted component.
        /// </summary>
        public const string Aborted = "Aborted";

        /// <summary>
        /// The BrowseName for the AbortedToClearingTransition component.
        /// </summary>
        public const string AbortedToClearingTransition = "AbortedToClearingTransition";

        /// <summary>
        /// The BrowseName for the Aborting component.
        /// </summary>
        public const string Aborting = "Aborting";

        /// <summary>
        /// The BrowseName for the AbortingToAbortedTransition component.
        /// </summary>
        public const string AbortingToAbortedTransition = "AbortingToAbortedTransition";

        /// <summary>
        /// The BrowseName for the AccessoryIdentifier component.
        /// </summary>
        public const string AccessoryIdentifier = "<AccessoryIdentifier>";

        /// <summary>
        /// The BrowseName for the AccessorySlotIdentifier component.
        /// </summary>
        public const string AccessorySlotIdentifier = "<AccessorySlotIdentifier>";

        /// <summary>
        /// The BrowseName for the AccessorySlotStateMachine component.
        /// </summary>
        public const string AccessorySlotStateMachine = "AccessorySlotStateMachine";

        /// <summary>
        /// The BrowseName for the AccessorySlotStateMachineType component.
        /// </summary>
        public const string AccessorySlotStateMachineType = "AccessorySlotStateMachineType";

        /// <summary>
        /// The BrowseName for the AccessorySlotType component.
        /// </summary>
        public const string AccessorySlotType = "AccessorySlotType";

        /// <summary>
        /// The BrowseName for the AccessoryType component.
        /// </summary>
        public const string AccessoryType = "AccessoryType";

        /// <summary>
        /// The BrowseName for the AcousticSpectrometerDeviceStreamType component.
        /// </summary>
        public const string AcousticSpectrometerDeviceStreamType = "AcousticSpectrometerDeviceStreamType";

        /// <summary>
        /// The BrowseName for the AcousticSpectrometerDeviceType component.
        /// </summary>
        public const string AcousticSpectrometerDeviceType = "AcousticSpectrometerDeviceType";

        /// <summary>
        /// The BrowseName for the AcquisitionData component.
        /// </summary>
        public const string AcquisitionData = "AcquisitionData";

        /// <summary>
        /// The BrowseName for the AcquisitionResultStatusEnumeration component.
        /// </summary>
        public const string AcquisitionResultStatusEnumeration = "AcquisitionResultStatusEnumeration";

        /// <summary>
        /// The BrowseName for the AcquisitionSettings component.
        /// </summary>
        public const string AcquisitionSettings = "AcquisitionSettings";

        /// <summary>
        /// The BrowseName for the AcquisitionStatus component.
        /// </summary>
        public const string AcquisitionStatus = "AcquisitionStatus";

        /// <summary>
        /// The BrowseName for the AlarmLimits component.
        /// </summary>
        public const string AlarmLimits = "AlarmLimits";

        /// <summary>
        /// The BrowseName for the AlarmState component.
        /// </summary>
        public const string AlarmState = "AlarmState";

        /// <summary>
        /// The BrowseName for the AlarmStateEnumeration component.
        /// </summary>
        public const string AlarmStateEnumeration = "AlarmStateEnumeration";

        /// <summary>
        /// The BrowseName for the AnalyseCalibrationSample component.
        /// </summary>
        public const string AnalyseCalibrationSample = "AnalyseCalibrationSample";

        /// <summary>
        /// The BrowseName for the AnalyseCalibrationSampleToPublishResultsTransition component.
        /// </summary>
        public const string AnalyseCalibrationSampleToPublishResultsTransition = "AnalyseCalibrationSampleToPublishResultsTransition";

        /// <summary>
        /// The BrowseName for the AnalyseCalibrationSampleTransition component.
        /// </summary>
        public const string AnalyseCalibrationSampleTransition = "AnalyseCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the AnalyserChannel_OperatingModeExecuteSubStateMachineType component.
        /// </summary>
        public const string AnalyserChannel_OperatingModeExecuteSubStateMachineType = "AnalyserChannel_OperatingModeExecuteSubStateMachineType";

        /// <summary>
        /// The BrowseName for the AnalyserChannel_OperatingModeSubStateMachineType component.
        /// </summary>
        public const string AnalyserChannel_OperatingModeSubStateMachineType = "AnalyserChannel_OperatingModeSubStateMachineType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelLocalStateType component.
        /// </summary>
        public const string AnalyserChannelLocalStateType = "AnalyserChannelLocalStateType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelMaintenanceStateType component.
        /// </summary>
        public const string AnalyserChannelMaintenanceStateType = "AnalyserChannelMaintenanceStateType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelOperatingExecuteStateType component.
        /// </summary>
        public const string AnalyserChannelOperatingExecuteStateType = "AnalyserChannelOperatingExecuteStateType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelOperatingStateType component.
        /// </summary>
        public const string AnalyserChannelOperatingStateType = "AnalyserChannelOperatingStateType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelStateMachineType component.
        /// </summary>
        public const string AnalyserChannelStateMachineType = "AnalyserChannelStateMachineType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelType component.
        /// </summary>
        public const string AnalyserChannelType = "AnalyserChannelType";

        /// <summary>
        /// The BrowseName for the AnalyserChannelTypeStartSingleAcquisitionMethodType component.
        /// </summary>
        public const string AnalyserChannelTypeStartSingleAcquisitionMethodType = "AnalyserChannelTypeStartSingleAcquisitionMethodType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceStateMachineType component.
        /// </summary>
        public const string AnalyserDeviceStateMachineType = "AnalyserDeviceStateMachineType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceType component.
        /// </summary>
        public const string AnalyserDeviceType = "AnalyserDeviceType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceTypeCompareConfigDataDigestMethodType component.
        /// </summary>
        public const string AnalyserDeviceTypeCompareConfigDataDigestMethodType = "AnalyserDeviceTypeCompareConfigDataDigestMethodType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceTypeGetConfigDataDigestMethodType component.
        /// </summary>
        public const string AnalyserDeviceTypeGetConfigDataDigestMethodType = "AnalyserDeviceTypeGetConfigDataDigestMethodType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceTypeGetConfigurationMethodType component.
        /// </summary>
        public const string AnalyserDeviceTypeGetConfigurationMethodType = "AnalyserDeviceTypeGetConfigurationMethodType";

        /// <summary>
        /// The BrowseName for the AnalyserDeviceTypeSetConfigurationMethodType component.
        /// </summary>
        public const string AnalyserDeviceTypeSetConfigurationMethodType = "AnalyserDeviceTypeSetConfigurationMethodType";

        /// <summary>
        /// The BrowseName for the AnalyserStateMachine component.
        /// </summary>
        public const string AnalyserStateMachine = "AnalyserStateMachine";

        /// <summary>
        /// The BrowseName for the AnalyseSample component.
        /// </summary>
        public const string AnalyseSample = "AnalyseSample";

        /// <summary>
        /// The BrowseName for the AnalyseSampleToPublishResultsTransition component.
        /// </summary>
        public const string AnalyseSampleToPublishResultsTransition = "AnalyseSampleToPublishResultsTransition";

        /// <summary>
        /// The BrowseName for the AnalyseSampleTransition component.
        /// </summary>
        public const string AnalyseSampleTransition = "AnalyseSampleTransition";

        /// <summary>
        /// The BrowseName for the AnalyseValidationSample component.
        /// </summary>
        public const string AnalyseValidationSample = "AnalyseValidationSample";

        /// <summary>
        /// The BrowseName for the AnalyseValidationSampleToPublishResultsTransition component.
        /// </summary>
        public const string AnalyseValidationSampleToPublishResultsTransition = "AnalyseValidationSampleToPublishResultsTransition";

        /// <summary>
        /// The BrowseName for the AnalyseValidationSampleTransition component.
        /// </summary>
        public const string AnalyseValidationSampleTransition = "AnalyseValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the ChannelIdentifier component.
        /// </summary>
        public const string ChannelIdentifier = "<ChannelIdentifier>";

        /// <summary>
        /// The BrowseName for the ChannelStateMachine component.
        /// </summary>
        public const string ChannelStateMachine = "ChannelStateMachine";

        /// <summary>
        /// The BrowseName for the ChemometricModelSettings component.
        /// </summary>
        public const string ChemometricModelSettings = "ChemometricModelSettings";

        /// <summary>
        /// The BrowseName for the ChemometricModelType component.
        /// </summary>
        public const string ChemometricModelType = "ChemometricModelType";

        /// <summary>
        /// The BrowseName for the ChromatographDeviceStreamType component.
        /// </summary>
        public const string ChromatographDeviceStreamType = "ChromatographDeviceStreamType";

        /// <summary>
        /// The BrowseName for the ChromatographDeviceType component.
        /// </summary>
        public const string ChromatographDeviceType = "ChromatographDeviceType";

        /// <summary>
        /// The BrowseName for the Cleaning component.
        /// </summary>
        public const string Cleaning = "Cleaning";

        /// <summary>
        /// The BrowseName for the CleaningToPublishResultsTransition component.
        /// </summary>
        public const string CleaningToPublishResultsTransition = "CleaningToPublishResultsTransition";

        /// <summary>
        /// The BrowseName for the CleaningTransition component.
        /// </summary>
        public const string CleaningTransition = "CleaningTransition";

        /// <summary>
        /// The BrowseName for the CleanupSamplingSystem component.
        /// </summary>
        public const string CleanupSamplingSystem = "CleanupSamplingSystem";

        /// <summary>
        /// The BrowseName for the CleanupSamplingSystemToSelectExecutionCycleTransition component.
        /// </summary>
        public const string CleanupSamplingSystemToSelectExecutionCycleTransition = "CleanupSamplingSystemToSelectExecutionCycleTransition";

        /// <summary>
        /// The BrowseName for the CleanupSamplingSystemTransition component.
        /// </summary>
        public const string CleanupSamplingSystemTransition = "CleanupSamplingSystemTransition";

        /// <summary>
        /// The BrowseName for the Clearing component.
        /// </summary>
        public const string Clearing = "Clearing";

        /// <summary>
        /// The BrowseName for the ClearingToStoppedTransition component.
        /// </summary>
        public const string ClearingToStoppedTransition = "ClearingToStoppedTransition";

        /// <summary>
        /// The BrowseName for the Complete component.
        /// </summary>
        public const string Complete = "Complete";

        /// <summary>
        /// The BrowseName for the CompleteToAbortingTransition component.
        /// </summary>
        public const string CompleteToAbortingTransition = "CompleteToAbortingTransition";

        /// <summary>
        /// The BrowseName for the CompleteToStoppedTransition component.
        /// </summary>
        public const string CompleteToStoppedTransition = "CompleteToStoppedTransition";

        /// <summary>
        /// The BrowseName for the CompleteToStoppingTransition component.
        /// </summary>
        public const string CompleteToStoppingTransition = "CompleteToStoppingTransition";

        /// <summary>
        /// The BrowseName for the Completing component.
        /// </summary>
        public const string Completing = "Completing";

        /// <summary>
        /// The BrowseName for the CompletingToAbortingTransition component.
        /// </summary>
        public const string CompletingToAbortingTransition = "CompletingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the CompletingToCompleteTransition component.
        /// </summary>
        public const string CompletingToCompleteTransition = "CompletingToCompleteTransition";

        /// <summary>
        /// The BrowseName for the CompletingToStoppingTransition component.
        /// </summary>
        public const string CompletingToStoppingTransition = "CompletingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the CompletingTransition component.
        /// </summary>
        public const string CompletingTransition = "CompletingTransition";

        /// <summary>
        /// The BrowseName for the Configuration component.
        /// </summary>
        public const string Configuration = "Configuration";

        /// <summary>
        /// The BrowseName for the Context component.
        /// </summary>
        public const string Context = "Context";

        /// <summary>
        /// The BrowseName for the CreationDate component.
        /// </summary>
        public const string CreationDate = "CreationDate";

        /// <summary>
        /// The BrowseName for the DetectorType component.
        /// </summary>
        public const string DetectorType = "DetectorType";

        /// <summary>
        /// The BrowseName for the Diagnostic component.
        /// </summary>
        public const string Diagnostic = "Diagnostic";

        /// <summary>
        /// The BrowseName for the DiagnosticToPublishResultsTransition component.
        /// </summary>
        public const string DiagnosticToPublishResultsTransition = "DiagnosticToPublishResultsTransition";

        /// <summary>
        /// The BrowseName for the DiagnosticTransition component.
        /// </summary>
        public const string DiagnosticTransition = "DiagnosticTransition";

        /// <summary>
        /// The BrowseName for the EjectGrabSample component.
        /// </summary>
        public const string EjectGrabSample = "EjectGrabSample";

        /// <summary>
        /// The BrowseName for the EjectGrabSampleToCleanupSamplingSystemTransition component.
        /// </summary>
        public const string EjectGrabSampleToCleanupSamplingSystemTransition = "EjectGrabSampleToCleanupSamplingSystemTransition";

        /// <summary>
        /// The BrowseName for the EjectGrabSampleTransition component.
        /// </summary>
        public const string EjectGrabSampleTransition = "EjectGrabSampleTransition";

        /// <summary>
        /// The BrowseName for the Empty component.
        /// </summary>
        public const string Empty = "Empty";

        /// <summary>
        /// The BrowseName for the EmptyToInsertingTransition component.
        /// </summary>
        public const string EmptyToInsertingTransition = "EmptyToInsertingTransition";

        /// <summary>
        /// The BrowseName for the EmptyToShutdownTransition component.
        /// </summary>
        public const string EmptyToShutdownTransition = "EmptyToShutdownTransition";

        /// <summary>
        /// The BrowseName for the EngineeringValueType component.
        /// </summary>
        public const string EngineeringValueType = "EngineeringValueType";

        /// <summary>
        /// The BrowseName for the Execute component.
        /// </summary>
        public const string Execute = "Execute";

        /// <summary>
        /// The BrowseName for the ExecuteToAbortingTransition component.
        /// </summary>
        public const string ExecuteToAbortingTransition = "ExecuteToAbortingTransition";

        /// <summary>
        /// The BrowseName for the ExecuteToCompletingTransition component.
        /// </summary>
        public const string ExecuteToCompletingTransition = "ExecuteToCompletingTransition";

        /// <summary>
        /// The BrowseName for the ExecuteToHoldingTransition component.
        /// </summary>
        public const string ExecuteToHoldingTransition = "ExecuteToHoldingTransition";

        /// <summary>
        /// The BrowseName for the ExecuteToStoppingTransition component.
        /// </summary>
        public const string ExecuteToStoppingTransition = "ExecuteToStoppingTransition";

        /// <summary>
        /// The BrowseName for the ExecuteToSuspendingTransition component.
        /// </summary>
        public const string ExecuteToSuspendingTransition = "ExecuteToSuspendingTransition";

        /// <summary>
        /// The BrowseName for the ExecutionCycleEnumeration component.
        /// </summary>
        public const string ExecutionCycleEnumeration = "ExecutionCycleEnumeration";

        /// <summary>
        /// The BrowseName for the ExtractCalibrationSample component.
        /// </summary>
        public const string ExtractCalibrationSample = "ExtractCalibrationSample";

        /// <summary>
        /// The BrowseName for the ExtractCalibrationSampleToPrepareCalibrationSampleTransition component.
        /// </summary>
        public const string ExtractCalibrationSampleToPrepareCalibrationSampleTransition = "ExtractCalibrationSampleToPrepareCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the ExtractCalibrationSampleTransition component.
        /// </summary>
        public const string ExtractCalibrationSampleTransition = "ExtractCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the ExtractSample component.
        /// </summary>
        public const string ExtractSample = "ExtractSample";

        /// <summary>
        /// The BrowseName for the ExtractSampleToPrepareSampleTransition component.
        /// </summary>
        public const string ExtractSampleToPrepareSampleTransition = "ExtractSampleToPrepareSampleTransition";

        /// <summary>
        /// The BrowseName for the ExtractSampleTransition component.
        /// </summary>
        public const string ExtractSampleTransition = "ExtractSampleTransition";

        /// <summary>
        /// The BrowseName for the ExtractValidationSample component.
        /// </summary>
        public const string ExtractValidationSample = "ExtractValidationSample";

        /// <summary>
        /// The BrowseName for the ExtractValidationSampleToPrepareValidationSampleTransition component.
        /// </summary>
        public const string ExtractValidationSampleToPrepareValidationSampleTransition = "ExtractValidationSampleToPrepareValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the ExtractValidationSampleTransition component.
        /// </summary>
        public const string ExtractValidationSampleTransition = "ExtractValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the FactorySettings component.
        /// </summary>
        public const string FactorySettings = "FactorySettings";

        /// <summary>
        /// The BrowseName for the GcOvenType component.
        /// </summary>
        public const string GcOvenType = "GcOvenType";

        /// <summary>
        /// The BrowseName for the GroupIdentifier component.
        /// </summary>
        public const string GroupIdentifier = "<GroupIdentifier>";

        /// <summary>
        /// The BrowseName for the HasDataSource component.
        /// </summary>
        public const string HasDataSource = "HasDataSource";

        /// <summary>
        /// The BrowseName for the HasInput component.
        /// </summary>
        public const string HasInput = "HasInput";

        /// <summary>
        /// The BrowseName for the HasOutput component.
        /// </summary>
        public const string HasOutput = "HasOutput";

        /// <summary>
        /// The BrowseName for the Held component.
        /// </summary>
        public const string Held = "Held";

        /// <summary>
        /// The BrowseName for the HeldToAbortingTransition component.
        /// </summary>
        public const string HeldToAbortingTransition = "HeldToAbortingTransition";

        /// <summary>
        /// The BrowseName for the HeldToStoppingTransition component.
        /// </summary>
        public const string HeldToStoppingTransition = "HeldToStoppingTransition";

        /// <summary>
        /// The BrowseName for the HeldToUnholdingTransition component.
        /// </summary>
        public const string HeldToUnholdingTransition = "HeldToUnholdingTransition";

        /// <summary>
        /// The BrowseName for the Holding component.
        /// </summary>
        public const string Holding = "Holding";

        /// <summary>
        /// The BrowseName for the HoldingToAbortingTransition component.
        /// </summary>
        public const string HoldingToAbortingTransition = "HoldingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the HoldingToHeldTransition component.
        /// </summary>
        public const string HoldingToHeldTransition = "HoldingToHeldTransition";

        /// <summary>
        /// The BrowseName for the HoldingToStoppingTransition component.
        /// </summary>
        public const string HoldingToStoppingTransition = "HoldingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the HoldingTransition component.
        /// </summary>
        public const string HoldingTransition = "HoldingTransition";

        /// <summary>
        /// The BrowseName for the Identifier component.
        /// </summary>
        public const string Identifier = "<Identifier>";

        /// <summary>
        /// The BrowseName for the Idle component.
        /// </summary>
        public const string Idle = "Idle";

        /// <summary>
        /// The BrowseName for the IdleToAbortingTransition component.
        /// </summary>
        public const string IdleToAbortingTransition = "IdleToAbortingTransition";

        /// <summary>
        /// The BrowseName for the IdleToStartingTransition component.
        /// </summary>
        public const string IdleToStartingTransition = "IdleToStartingTransition";

        /// <summary>
        /// The BrowseName for the IdleToStoppingTransition component.
        /// </summary>
        public const string IdleToStoppingTransition = "IdleToStoppingTransition";

        /// <summary>
        /// The BrowseName for the Inserting component.
        /// </summary>
        public const string Inserting = "Inserting";

        /// <summary>
        /// The BrowseName for the InsertingToInstalledTransition component.
        /// </summary>
        public const string InsertingToInstalledTransition = "InsertingToInstalledTransition";

        /// <summary>
        /// The BrowseName for the InsertingToRemovingTransition component.
        /// </summary>
        public const string InsertingToRemovingTransition = "InsertingToRemovingTransition";

        /// <summary>
        /// The BrowseName for the InsertingToShutdownTransition component.
        /// </summary>
        public const string InsertingToShutdownTransition = "InsertingToShutdownTransition";

        /// <summary>
        /// The BrowseName for the InsertingTransition component.
        /// </summary>
        public const string InsertingTransition = "InsertingTransition";

        /// <summary>
        /// The BrowseName for the Installed component.
        /// </summary>
        public const string Installed = "Installed";

        /// <summary>
        /// The BrowseName for the InstalledToRemovingTransition component.
        /// </summary>
        public const string InstalledToRemovingTransition = "InstalledToRemovingTransition";

        /// <summary>
        /// The BrowseName for the InstalledToShutdownTransition component.
        /// </summary>
        public const string InstalledToShutdownTransition = "InstalledToShutdownTransition";

        /// <summary>
        /// The BrowseName for the IsEnabled component.
        /// </summary>
        public const string IsEnabled = "IsEnabled";

        /// <summary>
        /// The BrowseName for the IsHotSwappable component.
        /// </summary>
        public const string IsHotSwappable = "IsHotSwappable";

        /// <summary>
        /// The BrowseName for the IsReady component.
        /// </summary>
        public const string IsReady = "IsReady";

        /// <summary>
        /// The BrowseName for the Local component.
        /// </summary>
        public const string Local = "Local";

        /// <summary>
        /// The BrowseName for the LocalSubStateMachine component.
        /// </summary>
        public const string LocalSubStateMachine = "LocalSubStateMachine";

        /// <summary>
        /// The BrowseName for the LocalToMaintenanceTransition component.
        /// </summary>
        public const string LocalToMaintenanceTransition = "LocalToMaintenanceTransition";

        /// <summary>
        /// The BrowseName for the LocalToOperatingTransition component.
        /// </summary>
        public const string LocalToOperatingTransition = "LocalToOperatingTransition";

        /// <summary>
        /// The BrowseName for the LocalToShutdownTransition component.
        /// </summary>
        public const string LocalToShutdownTransition = "LocalToShutdownTransition";

        /// <summary>
        /// The BrowseName for the LocalToSlaveModeTransition component.
        /// </summary>
        public const string LocalToSlaveModeTransition = "LocalToSlaveModeTransition";

        /// <summary>
        /// The BrowseName for the MainDataIndex component.
        /// </summary>
        public const string MainDataIndex = "MainDataIndex";

        /// <summary>
        /// The BrowseName for the Maintenance component.
        /// </summary>
        public const string Maintenance = "Maintenance";

        /// <summary>
        /// The BrowseName for the MaintenanceSubStateMachine component.
        /// </summary>
        public const string MaintenanceSubStateMachine = "MaintenanceSubStateMachine";

        /// <summary>
        /// The BrowseName for the MaintenanceToLocalTransition component.
        /// </summary>
        public const string MaintenanceToLocalTransition = "MaintenanceToLocalTransition";

        /// <summary>
        /// The BrowseName for the MaintenanceToOperatingTransition component.
        /// </summary>
        public const string MaintenanceToOperatingTransition = "MaintenanceToOperatingTransition";

        /// <summary>
        /// The BrowseName for the MaintenanceToShutdownTransition component.
        /// </summary>
        public const string MaintenanceToShutdownTransition = "MaintenanceToShutdownTransition";

        /// <summary>
        /// The BrowseName for the MaintenanceToSlaveModeTransition component.
        /// </summary>
        public const string MaintenanceToSlaveModeTransition = "MaintenanceToSlaveModeTransition";

        /// <summary>
        /// The BrowseName for the MassSpectrometerDeviceStreamType component.
        /// </summary>
        public const string MassSpectrometerDeviceStreamType = "MassSpectrometerDeviceStreamType";

        /// <summary>
        /// The BrowseName for the MassSpectrometerDeviceType component.
        /// </summary>
        public const string MassSpectrometerDeviceType = "MassSpectrometerDeviceType";

        /// <summary>
        /// The BrowseName for the MNRDeviceStreamType component.
        /// </summary>
        public const string MNRDeviceStreamType = "MNRDeviceStreamType";

        /// <summary>
        /// The BrowseName for the ModelDescription component.
        /// </summary>
        public const string ModelDescription = "ModelDescription";

        /// <summary>
        /// The BrowseName for the MVAModelType component.
        /// </summary>
        public const string MVAModelType = "MVAModelType";

        /// <summary>
        /// The BrowseName for the MVAOutputParameterType component.
        /// </summary>
        public const string MVAOutputParameterType = "MVAOutputParameterType";

        /// <summary>
        /// The BrowseName for the MVAPredictMethodType component.
        /// </summary>
        public const string MVAPredictMethodType = "MVAPredictMethodType";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the NMRDeviceType component.
        /// </summary>
        public const string NMRDeviceType = "NMRDeviceType";

        /// <summary>
        /// The BrowseName for the OpcUaAdi_BinarySchema component.
        /// </summary>
        public const string OpcUaAdi_BinarySchema = "Opc.Ua.Adi";

        /// <summary>
        /// The BrowseName for the OpcUaAdi_XmlSchema component.
        /// </summary>
        public const string OpcUaAdi_XmlSchema = "Opc.Ua.Adi";

        /// <summary>
        /// The BrowseName for the Operating component.
        /// </summary>
        public const string Operating = "Operating";

        /// <summary>
        /// The BrowseName for the OperatingExecuteSubStateMachine component.
        /// </summary>
        public const string OperatingExecuteSubStateMachine = "OperatingExecuteSubStateMachine";

        /// <summary>
        /// The BrowseName for the OperatingSubStateMachine component.
        /// </summary>
        public const string OperatingSubStateMachine = "OperatingSubStateMachine";

        /// <summary>
        /// The BrowseName for the OperatingToLocalTransition component.
        /// </summary>
        public const string OperatingToLocalTransition = "OperatingToLocalTransition";

        /// <summary>
        /// The BrowseName for the OperatingToMaintenanceTransition component.
        /// </summary>
        public const string OperatingToMaintenanceTransition = "OperatingToMaintenanceTransition";

        /// <summary>
        /// The BrowseName for the OperatingToShutdownTransition component.
        /// </summary>
        public const string OperatingToShutdownTransition = "OperatingToShutdownTransition";

        /// <summary>
        /// The BrowseName for the OperatingToSlaveModeTransition component.
        /// </summary>
        public const string OperatingToSlaveModeTransition = "OperatingToSlaveModeTransition";

        /// <summary>
        /// The BrowseName for the ParticleSizeMonitorDeviceStreamType component.
        /// </summary>
        public const string ParticleSizeMonitorDeviceStreamType = "ParticleSizeMonitorDeviceStreamType";

        /// <summary>
        /// The BrowseName for the ParticleSizeMonitorDeviceType component.
        /// </summary>
        public const string ParticleSizeMonitorDeviceType = "ParticleSizeMonitorDeviceType";

        /// <summary>
        /// The BrowseName for the Powerup component.
        /// </summary>
        public const string Powerup = "Powerup";

        /// <summary>
        /// The BrowseName for the PowerupToEmptyTransition component.
        /// </summary>
        public const string PowerupToEmptyTransition = "PowerupToEmptyTransition";

        /// <summary>
        /// The BrowseName for the PowerupToOperatingTransition component.
        /// </summary>
        public const string PowerupToOperatingTransition = "PowerupToOperatingTransition";

        /// <summary>
        /// The BrowseName for the PrepareCalibrationSample component.
        /// </summary>
        public const string PrepareCalibrationSample = "PrepareCalibrationSample";

        /// <summary>
        /// The BrowseName for the PrepareCalibrationSampleToAnalyseCalibrationSampleTransition component.
        /// </summary>
        public const string PrepareCalibrationSampleToAnalyseCalibrationSampleTransition = "PrepareCalibrationSampleToAnalyseCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the PrepareCalibrationSampleTransition component.
        /// </summary>
        public const string PrepareCalibrationSampleTransition = "PrepareCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the PrepareSample component.
        /// </summary>
        public const string PrepareSample = "PrepareSample";

        /// <summary>
        /// The BrowseName for the PrepareSampleToAnalyseSampleTransition component.
        /// </summary>
        public const string PrepareSampleToAnalyseSampleTransition = "PrepareSampleToAnalyseSampleTransition";

        /// <summary>
        /// The BrowseName for the PrepareSampleTransition component.
        /// </summary>
        public const string PrepareSampleTransition = "PrepareSampleTransition";

        /// <summary>
        /// The BrowseName for the PrepareValidationSample component.
        /// </summary>
        public const string PrepareValidationSample = "PrepareValidationSample";

        /// <summary>
        /// The BrowseName for the PrepareValidationSampleToAnalyseValidationSampleTransition component.
        /// </summary>
        public const string PrepareValidationSampleToAnalyseValidationSampleTransition = "PrepareValidationSampleToAnalyseValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the PrepareValidationSampleTransition component.
        /// </summary>
        public const string PrepareValidationSampleTransition = "PrepareValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the ProcessVariableType component.
        /// </summary>
        public const string ProcessVariableType = "ProcessVariableType";

        /// <summary>
        /// The BrowseName for the PublishResults component.
        /// </summary>
        public const string PublishResults = "PublishResults";

        /// <summary>
        /// The BrowseName for the PublishResultsToCleanupSamplingSystemTransition component.
        /// </summary>
        public const string PublishResultsToCleanupSamplingSystemTransition = "PublishResultsToCleanupSamplingSystemTransition";

        /// <summary>
        /// The BrowseName for the PublishResultsToEjectGrabSampleTransition component.
        /// </summary>
        public const string PublishResultsToEjectGrabSampleTransition = "PublishResultsToEjectGrabSampleTransition";

        /// <summary>
        /// The BrowseName for the Removing component.
        /// </summary>
        public const string Removing = "Removing";

        /// <summary>
        /// The BrowseName for the RemovingToEmptyTransition component.
        /// </summary>
        public const string RemovingToEmptyTransition = "RemovingToEmptyTransition";

        /// <summary>
        /// The BrowseName for the RemovingToShutdownTransition component.
        /// </summary>
        public const string RemovingToShutdownTransition = "RemovingToShutdownTransition";

        /// <summary>
        /// The BrowseName for the RemovingTransition component.
        /// </summary>
        public const string RemovingTransition = "RemovingTransition";

        /// <summary>
        /// The BrowseName for the Resetting component.
        /// </summary>
        public const string Resetting = "Resetting";

        /// <summary>
        /// The BrowseName for the ResettingToAbortingTransition component.
        /// </summary>
        public const string ResettingToAbortingTransition = "ResettingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the ResettingToIdleTransition component.
        /// </summary>
        public const string ResettingToIdleTransition = "ResettingToIdleTransition";

        /// <summary>
        /// The BrowseName for the ResettingToStoppingTransition component.
        /// </summary>
        public const string ResettingToStoppingTransition = "ResettingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the ResettingTransition component.
        /// </summary>
        public const string ResettingTransition = "ResettingTransition";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycle component.
        /// </summary>
        public const string SelectExecutionCycle = "SelectExecutionCycle";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycleToWaitForCalibrationTriggerTransition component.
        /// </summary>
        public const string SelectExecutionCycleToWaitForCalibrationTriggerTransition = "SelectExecutionCycleToWaitForCalibrationTriggerTransition";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycleToWaitForCleaningTriggerTransition component.
        /// </summary>
        public const string SelectExecutionCycleToWaitForCleaningTriggerTransition = "SelectExecutionCycleToWaitForCleaningTriggerTransition";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycleToWaitForDiagnosticTriggerTransition component.
        /// </summary>
        public const string SelectExecutionCycleToWaitForDiagnosticTriggerTransition = "SelectExecutionCycleToWaitForDiagnosticTriggerTransition";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycleToWaitForSampleTriggerTransition component.
        /// </summary>
        public const string SelectExecutionCycleToWaitForSampleTriggerTransition = "SelectExecutionCycleToWaitForSampleTriggerTransition";

        /// <summary>
        /// The BrowseName for the SelectExecutionCycleToWaitForValidationTriggerTransition component.
        /// </summary>
        public const string SelectExecutionCycleToWaitForValidationTriggerTransition = "SelectExecutionCycleToWaitForValidationTriggerTransition";

        /// <summary>
        /// The BrowseName for the Shutdown component.
        /// </summary>
        public const string Shutdown = "Shutdown";

        /// <summary>
        /// The BrowseName for the SlaveMode component.
        /// </summary>
        public const string SlaveMode = "SlaveMode";

        /// <summary>
        /// The BrowseName for the SlaveModeToOperatingTransition component.
        /// </summary>
        public const string SlaveModeToOperatingTransition = "SlaveModeToOperatingTransition";

        /// <summary>
        /// The BrowseName for the SmartSamplingSystemType component.
        /// </summary>
        public const string SmartSamplingSystemType = "SmartSamplingSystemType";

        /// <summary>
        /// The BrowseName for the SourceName component.
        /// </summary>
        public const string SourceName = "<Source>";

        /// <summary>
        /// The BrowseName for the SourceType component.
        /// </summary>
        public const string SourceType = "SourceType";

        /// <summary>
        /// The BrowseName for the SpectrometerDeviceStreamType component.
        /// </summary>
        public const string SpectrometerDeviceStreamType = "SpectrometerDeviceStreamType";

        /// <summary>
        /// The BrowseName for the SpectrometerDeviceType component.
        /// </summary>
        public const string SpectrometerDeviceType = "SpectrometerDeviceType";

        /// <summary>
        /// The BrowseName for the Starting component.
        /// </summary>
        public const string Starting = "Starting";

        /// <summary>
        /// The BrowseName for the StartingToAbortingTransition component.
        /// </summary>
        public const string StartingToAbortingTransition = "StartingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the StartingToExecuteTransition component.
        /// </summary>
        public const string StartingToExecuteTransition = "StartingToExecuteTransition";

        /// <summary>
        /// The BrowseName for the StartingToStoppingTransition component.
        /// </summary>
        public const string StartingToStoppingTransition = "StartingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the StartingTransition component.
        /// </summary>
        public const string StartingTransition = "StartingTransition";

        /// <summary>
        /// The BrowseName for the Statistics component.
        /// </summary>
        public const string Statistics = "Statistics";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the Stopped component.
        /// </summary>
        public const string Stopped = "Stopped";

        /// <summary>
        /// The BrowseName for the StoppedToAbortingTransition component.
        /// </summary>
        public const string StoppedToAbortingTransition = "StoppedToAbortingTransition";

        /// <summary>
        /// The BrowseName for the StoppedToResettingTransition component.
        /// </summary>
        public const string StoppedToResettingTransition = "StoppedToResettingTransition";

        /// <summary>
        /// The BrowseName for the Stopping component.
        /// </summary>
        public const string Stopping = "Stopping";

        /// <summary>
        /// The BrowseName for the StoppingToAbortingTransition component.
        /// </summary>
        public const string StoppingToAbortingTransition = "StoppingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the StoppingToStoppedTransition component.
        /// </summary>
        public const string StoppingToStoppedTransition = "StoppingToStoppedTransition";

        /// <summary>
        /// The BrowseName for the StreamIdentifier component.
        /// </summary>
        public const string StreamIdentifier = "<StreamIdentifier>";

        /// <summary>
        /// The BrowseName for the StreamType component.
        /// </summary>
        public const string StreamType = "StreamType";

        /// <summary>
        /// The BrowseName for the Suspended component.
        /// </summary>
        public const string Suspended = "Suspended";

        /// <summary>
        /// The BrowseName for the SuspendedToAbortingTransition component.
        /// </summary>
        public const string SuspendedToAbortingTransition = "SuspendedToAbortingTransition";

        /// <summary>
        /// The BrowseName for the SuspendedToStoppingTransition component.
        /// </summary>
        public const string SuspendedToStoppingTransition = "SuspendedToStoppingTransition";

        /// <summary>
        /// The BrowseName for the SuspendedToUnsuspendingTransition component.
        /// </summary>
        public const string SuspendedToUnsuspendingTransition = "SuspendedToUnsuspendingTransition";

        /// <summary>
        /// The BrowseName for the Suspending component.
        /// </summary>
        public const string Suspending = "Suspending";

        /// <summary>
        /// The BrowseName for the SuspendingToAbortingTransition component.
        /// </summary>
        public const string SuspendingToAbortingTransition = "SuspendingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the SuspendingToStoppingTransition component.
        /// </summary>
        public const string SuspendingToStoppingTransition = "SuspendingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the SuspendingToSuspendedTransition component.
        /// </summary>
        public const string SuspendingToSuspendedTransition = "SuspendingToSuspendedTransition";

        /// <summary>
        /// The BrowseName for the SuspendingTransition component.
        /// </summary>
        public const string SuspendingTransition = "SuspendingTransition";

        /// <summary>
        /// The BrowseName for the Unholding component.
        /// </summary>
        public const string Unholding = "Unholding";

        /// <summary>
        /// The BrowseName for the UnholdingToAbortingTransition component.
        /// </summary>
        public const string UnholdingToAbortingTransition = "UnholdingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the UnholdingToExecuteTransition component.
        /// </summary>
        public const string UnholdingToExecuteTransition = "UnholdingToExecuteTransition";

        /// <summary>
        /// The BrowseName for the UnholdingToHoldingTransition component.
        /// </summary>
        public const string UnholdingToHoldingTransition = "UnholdingToHoldingTransition";

        /// <summary>
        /// The BrowseName for the UnholdingToStoppingTransition component.
        /// </summary>
        public const string UnholdingToStoppingTransition = "UnholdingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the UnholdingTransition component.
        /// </summary>
        public const string UnholdingTransition = "UnholdingTransition";

        /// <summary>
        /// The BrowseName for the Unsuspending component.
        /// </summary>
        public const string Unsuspending = "Unsuspending";

        /// <summary>
        /// The BrowseName for the UnsuspendingToAbortingTransition component.
        /// </summary>
        public const string UnsuspendingToAbortingTransition = "UnsuspendingToAbortingTransition";

        /// <summary>
        /// The BrowseName for the UnsuspendingToExecuteTransition component.
        /// </summary>
        public const string UnsuspendingToExecuteTransition = "UnsuspendingToExecuteTransition";

        /// <summary>
        /// The BrowseName for the UnsuspendingToStoppingTransition component.
        /// </summary>
        public const string UnsuspendingToStoppingTransition = "UnsuspendingToStoppingTransition";

        /// <summary>
        /// The BrowseName for the UnsuspendingToSuspendingTransition component.
        /// </summary>
        public const string UnsuspendingToSuspendingTransition = "UnsuspendingToSuspendingTransition";

        /// <summary>
        /// The BrowseName for the UnsuspendingTransition component.
        /// </summary>
        public const string UnsuspendingTransition = "UnsuspendingTransition";

        /// <summary>
        /// The BrowseName for the User_defined_Input component.
        /// </summary>
        public const string User_defined_Input = "<User defined Input#>";

        /// <summary>
        /// The BrowseName for the User_defined_Output component.
        /// </summary>
        public const string User_defined_Output = "<User defined Output#>";

        /// <summary>
        /// The BrowseName for the VendorSpecificError component.
        /// </summary>
        public const string VendorSpecificError = "VendorSpecificError";

        /// <summary>
        /// The BrowseName for the WaitForCalibrationTrigger component.
        /// </summary>
        public const string WaitForCalibrationTrigger = "WaitForCalibrationTrigger";

        /// <summary>
        /// The BrowseName for the WaitForCalibrationTriggerToExtractCalibrationSampleTransition component.
        /// </summary>
        public const string WaitForCalibrationTriggerToExtractCalibrationSampleTransition = "WaitForCalibrationTriggerToExtractCalibrationSampleTransition";

        /// <summary>
        /// The BrowseName for the WaitForCleaningTrigger component.
        /// </summary>
        public const string WaitForCleaningTrigger = "WaitForCleaningTrigger";

        /// <summary>
        /// The BrowseName for the WaitForCleaningTriggerToCleaningTransition component.
        /// </summary>
        public const string WaitForCleaningTriggerToCleaningTransition = "WaitForCleaningTriggerToCleaningTransition";

        /// <summary>
        /// The BrowseName for the WaitForDiagnosticTrigger component.
        /// </summary>
        public const string WaitForDiagnosticTrigger = "WaitForDiagnosticTrigger";

        /// <summary>
        /// The BrowseName for the WaitForDiagnosticTriggerToDiagnosticTransition component.
        /// </summary>
        public const string WaitForDiagnosticTriggerToDiagnosticTransition = "WaitForDiagnosticTriggerToDiagnosticTransition";

        /// <summary>
        /// The BrowseName for the WaitForSampleTrigger component.
        /// </summary>
        public const string WaitForSampleTrigger = "WaitForSampleTrigger";

        /// <summary>
        /// The BrowseName for the WaitForSampleTriggerToExtractSampleTransition component.
        /// </summary>
        public const string WaitForSampleTriggerToExtractSampleTransition = "WaitForSampleTriggerToExtractSampleTransition";

        /// <summary>
        /// The BrowseName for the WaitForValidationTrigger component.
        /// </summary>
        public const string WaitForValidationTrigger = "WaitForValidationTrigger";

        /// <summary>
        /// The BrowseName for the WaitForValidationTriggerToExtractValidationSampleTransition component.
        /// </summary>
        public const string WaitForValidationTriggerToExtractValidationSampleTransition = "WaitForValidationTriggerToExtractValidationSampleTransition";

        /// <summary>
        /// The BrowseName for the WarningLimits component.
        /// </summary>
        public const string WarningLimits = "WarningLimits";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaAdi namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcUaAdi = "http://opcfoundation.org/UA/ADI/";

        /// <summary>
        /// The URI for the OpcUaAdiXsd namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcUaAdiXsd = "http://opcfoundation.org/UA/ADI/Types.xsd";

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

    #region AnalyserDeviceState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAaAAAAQW5hbHlzZXJEZXZpY2VUeXBlSW5zdGFuY2UB" +
           "AekDAQHpAwH/////DwAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQGJEwMAAAAAFwAAAEZsYXQg" +
           "bGlzdCBvZiBQYXJhbWV0ZXJzAC8AOokTAAD/////AgAAADVgiQoCAAAAAQAQAAAARGlhZ25vc3RpY1N0" +
           "YXR1cwEB8yQDAAAAACUAAABHZW5lcmFsIGhlYWx0aCBzdGF0dXMgb2YgdGhlIGFuYWx5c2VyAC8BAD0J" +
           "8yQAAAECZBj/////AQEBAAAAACMBAQEMJQAAAAAkYIAKAQAAAAEACgAAAENvbmZpZ0RhdGEBAfYkAwAA" +
           "AAAsAAAAT3B0aW9uYWwgYW5hbHlzZXIgZGV2aWNlIGxhcmdlIGNvbmZpZ3VyYXRpb24ALwEANy32JAAA" +
           "AQAAAAAjAQEBCiUKAAAANWCJCgIAAAAAAAQAAABTaXplAQH3JAMAAAAAHgAAAFRoZSBzaXplIG9mIHRo" +
           "ZSBmaWxlIGluIGJ5dGVzLgAuAET3JAAAAAn/////AQH/////AAAAADVgiQoCAAAAAAAJAAAAV3JpdGVh" +
           "YmxlAQHVMwMAAAAAHgAAAFdoZXRoZXIgdGhlIGZpbGUgaXMgd3JpdGVhYmxlLgAuAETVMwAAAAH/////" +
           "AQH/////AAAAADVgiQoCAAAAAAANAAAAVXNlcldyaXRlYWJsZQEB1jMDAAAAADIAAABXaGV0aGVyIHRo" +
           "ZSBmaWxlIGlzIHdyaXRlYWJsZSBieSB0aGUgY3VycmVudCB1c2VyLgAuAETWMwAAAAH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAJAAAAT3BlbkNvdW50AQH6JAMAAAAAKAAAAFRoZSBjdXJyZW50IG51bWJlciBv" +
           "ZiBvcGVuIGZpbGUgaGFuZGxlcy4ALgBE+iQAAAAF/////wEB/////wAAAAAEYYIKBAAAAAAABAAAAE9w" +
           "ZW4BAfskAC8BADwt+yQAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH8JAAu" +
           "AET8JAAAlgEAAAABACoBARMAAAAEAAAATW9kZQAD/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf0kAC4ARP0kAACWAQAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "SGFuZGxlAAf/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAAABQAAAENsb3NlAQH+JAAv" +
           "AQA/Lf4kAAABAf////8BAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB/yQALgBE/yQAAJYB" +
           "AAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAAAEAAAAUmVhZAEBACUALwEAQS0AJQAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAQElAC4ARAElAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoB" +
           "ARUAAAAGAAAATGVuZ3RoAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBAiUALgBEAiUAAJYBAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAV3JpdGUBAQMlAC8BAEQtAyUAAAEB/////wEAAAAV" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEEJQAuAEQEJQAAlgIAAAABACoBARkAAAAKAAAARmls" +
           "ZUhhbmRsZQAH/////wAAAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAAARhggoEAAAAAAALAAAAR2V0UG9zaXRpb24BAQUlAC8BAEYtBSUAAAEB/////wIAAAAVYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEGJQAuAEQGJQAAlgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRs" +
           "ZQAH/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AQclAC4ARAclAACWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAABGGCCgQAAAAAAAsAAABTZXRQb3NpdGlvbgEBCCUALwEASS0IJQAAAQH/////AQAAABVgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQklAC4ARAklAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFu" +
           "ZGxlAAf/////AAAAAAABACoBARcAAAAIAAAAUG9zaXRpb24ACf////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQGmJAMAAAAAFAAAAEZsYXQgbGlzdCBvZiBNZXRob2Rz" +
           "AC8AOqYkAAD/////CgAAAARhggoEAAAAAQAQAAAAR2V0Q29uZmlndXJhdGlvbgEB4yQALwEB4yTjJAAA" +
           "AQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHkJAAuAETkJAAAlgEAAAABACoB" +
           "ARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABAA" +
           "AABTZXRDb25maWd1cmF0aW9uAQHlJAAvAQHlJOUkAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEB5iQALgBE5iQAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHnJAAuAETnJAAA" +
           "lgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAABGGCCgQAAAABABMAAABHZXRDb25maWdEYXRhRGlnZXN0AQHoJAAvAQHoJOgkAAABAf////8BAAAA" +
           "FWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAekkAC4AROkkAACWAQAAAAEAKgEBHwAAABAAAABD" +
           "b25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAFwAAAENv" +
           "bXBhcmVDb25maWdEYXRhRGlnZXN0AQHqJAAvAQHqJOokAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEB6yQALgBE6yQAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QA" +
           "DP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHs" +
           "JAAuAETsJAAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAJGGCCgQAAAABABAAAABSZXNldEFsbENoYW5uZWxzAQHtJAMAAAAAPAAAAFJlc2V0IGFsbCBBbmFs" +
           "eXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQHtJO0kAAABAf//" +
           "//8AAAAAJGGCCgQAAAABABAAAABTdGFydEFsbENoYW5uZWxzAQHuJAMAAAAAPAAAAFN0YXJ0IGFsbCBB" +
           "bmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQHuJO4kAAAB" +
           "Af////8AAAAAJGGCCgQAAAABAA8AAABTdG9wQWxsQ2hhbm5lbHMBAe8kAwAAAAA7AAAAU3RvcCBhbGwg" +
           "QW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7yTvJAAA" +
           "AQH/////AAAAACRhggoEAAAAAQAQAAAAQWJvcnRBbGxDaGFubmVscwEB8CQDAAAAADwAAABBYm9ydCBh" +
           "bGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB8CTw" +
           "JAAAAQH/////AAAAACRhggoEAAAAAQANAAAAR290b09wZXJhdGluZwEB8SQDAAAAAI0AAABBbmFseXNl" +
           "ckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBPcGVyYXRpbmcgc3RhdGUsIGZvcmNpbmcgYWxsIEFu" +
           "YWx5c2VyQ2hhbm5lbHMgdG8gbGVhdmUgdGhlIFNsYXZlTW9kZSBzdGF0ZSBhbmQgZ28gdG8gdGhlIE9w" +
           "ZXJhdGluZyBzdGF0ZS4ALwEB8STxJAAAAQH/////AAAAACRhggoEAAAAAQAPAAAAR290b01haW50ZW5h" +
           "bmNlAQHyJAMAAAAAZwAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE1haW50ZW5h" +
           "bmNlIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIFNsYXZlTW9kZSBzdGF0ZS4A" +
           "LwEB8iTyJAAAAQH/////AAAAACRggAoBAAAAAgAOAAAASWRlbnRpZmljYXRpb24BAaokAwAAAABGAAAA" +
           "VXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVudGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9s" +
           "b2d5RWxlbWVudAAvAQLtA6okAAADAAAAACMAAQJzFwAjAAECdBcAIwABAnEXAAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQG6JAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARLokAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAbskAwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARLskAAAABv////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBAbwkAwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2" +
           "aWNlAC4ARLwkAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEBvSQDAAAAADAAAABO" +
           "YW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEvSQAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBviQDAAAAAFoAAABBZGRyZXNzIChw" +
           "YXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBt" +
           "YW51YWwgZm9yIHRoZSBkZXZpY2UALgBEviQAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERl" +
           "dmljZVJldmlzaW9uAQG/JAMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmlj" +
           "ZQAuAES/JAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBwCQD" +
           "AAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmlj" +
           "ZQAuAETAJAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBwSQD" +
           "AAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAETBJAAA" +
           "AAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBCiUALwEC7QMKJQAAAQAA" +
           "AAAjAAEB9iQAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAQwlAC8BAu0DDCUAAAEAAAAAIwABAfMkAAAA" +
           "AARggAoBAAAAAQAPAAAARmFjdG9yeVNldHRpbmdzAQEOJQAvAQLtAw4lAAD/////AAAAAARggAoBAAAA" +
           "AQAUAAAAQW5hbHlzZXJTdGF0ZU1hY2hpbmUBARAlAC8BAeoDECUAAP////8BAAAAFWCJCgIAAAAAAAwA" +
           "AABDdXJyZW50U3RhdGUBARElAC8BAMgKESUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQESJQAuAEQSJQAAABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
        public FunctionalGroupState Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
        public FunctionalGroupState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
            }
        }

        /// <summary>
        /// A description for the AnalyserStateMachine Object.
        /// </summary>
        public AnalyserDeviceStateMachineState AnalyserStateMachine
        {
            get
            {
                return m_analyserStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_analyserStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_analyserStateMachine = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
            }

            if (m_analyserStateMachine != null)
            {
                children.Add(m_analyserStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                FactorySettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AnalyserStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (AnalyserStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                AnalyserStateMachine = new AnalyserDeviceStateMachineState(this);
                            }
                            else
                            {
                                AnalyserStateMachine = (AnalyserDeviceStateMachineState)replacement;
                            }
                        }
                    }

                    instance = AnalyserStateMachine;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_factorySettings;
        private AnalyserDeviceStateMachineState m_analyserStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserDeviceTypeGetConfigurationMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeGetConfigurationMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeGetConfigurationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeGetConfigurationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeGetConfigurationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeGetConfigurationMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAsAAAAQW5hbHlzZXJEZXZpY2VUeXBlR2V0Q29uZmln" +
           "dXJhdGlvbk1ldGhvZFR5cGUBAZolAC8BAZolmiUAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBmyUALgBEmyUAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeGetConfigurationMethodStateMethodCallHandler OnCall;
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

            byte[] configData = (byte[])outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref configData);
            }

            outputArguments[0] = configData;

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
    public delegate ServiceResult AnalyserDeviceTypeGetConfigurationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref byte[] configData);
    #endif
    #endregion

    #region AnalyserDeviceTypeSetConfigurationMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeSetConfigurationMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeSetConfigurationMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeSetConfigurationMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeSetConfigurationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeSetConfigurationMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAsAAAAQW5hbHlzZXJEZXZpY2VUeXBlU2V0Q29uZmln" +
           "dXJhdGlvbk1ldGhvZFR5cGUBAZwlAC8BAZwlnCUAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0" +
           "QXJndW1lbnRzAQGdJQAuAESdJQAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZ4lAC4ARJ4lAACW" +
           "AQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeSetConfigurationMethodStateMethodCallHandler OnCall;
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

            byte[] configData = (byte[])inputArguments[0];

            string configDataDigest = (string)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    configData,
                    ref configDataDigest);
            }

            outputArguments[0] = configDataDigest;

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
    public delegate ServiceResult AnalyserDeviceTypeSetConfigurationMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        byte[] configData,
        ref string configDataDigest);
    #endif
    #endregion

    #region AnalyserDeviceTypeGetConfigDataDigestMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeGetConfigDataDigestMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeGetConfigDataDigestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeGetConfigDataDigestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeGetConfigDataDigestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeGetConfigDataDigestMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAvAAAAQW5hbHlzZXJEZXZpY2VUeXBlR2V0Q29uZmln" +
           "RGF0YURpZ2VzdE1ldGhvZFR5cGUBAZ8lAC8BAZ8lnyUAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBoCUALgBEoCUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QA" +
           "DP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeGetConfigDataDigestMethodStateMethodCallHandler OnCall;
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

            string configDataDigest = (string)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    ref configDataDigest);
            }

            outputArguments[0] = configDataDigest;

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
    public delegate ServiceResult AnalyserDeviceTypeGetConfigDataDigestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ref string configDataDigest);
    #endif
    #endregion

    #region AnalyserDeviceTypeCompareConfigDataDigestMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceTypeCompareConfigDataDigestMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceTypeCompareConfigDataDigestMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceTypeCompareConfigDataDigestMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceTypeCompareConfigDataDigestMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserDeviceTypeCompareConfigDataDigestMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAzAAAAQW5hbHlzZXJEZXZpY2VUeXBlQ29tcGFyZUNv" +
           "bmZpZ0RhdGFEaWdlc3RNZXRob2RUeXBlAQGhJQAvAQGhJaElAAABAf////8CAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBoiUALgBEoiUAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQGjJQAuAESjJQAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserDeviceTypeCompareConfigDataDigestMethodStateMethodCallHandler OnCall;
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

            string configDataDigest = (string)inputArguments[0];

            bool isEqual = (bool)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    configDataDigest,
                    ref isEqual);
            }

            outputArguments[0] = isEqual;

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
    public delegate ServiceResult AnalyserDeviceTypeCompareConfigDataDigestMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string configDataDigest,
        ref bool isEqual);
    #endif
    #endregion

    #region AnalyserDeviceStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserDeviceStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserDeviceStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserDeviceStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserDeviceStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserDeviceStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAmAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmVU" +
           "eXBlSW5zdGFuY2UBAeoDAQHqAwH/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGkJQAv" +
           "AQDICqQlAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBpSUALgBEpSUAAAAR/////wEB" +
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

    #region AnalyserChannelState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAbAAAAQW5hbHlzZXJDaGFubmVsVHlwZUluc3RhbmNl" +
           "AQHrAwEB6wMB/////wUAAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEBzSUDAAAAABcAAABGbGF0" +
           "IGxpc3Qgb2YgUGFyYW1ldGVycwAvADrNJQAA/////wQAAAA1YIkKAgAAAAEACQAAAENoYW5uZWxJZAEB" +
           "8CUDAAAAABoAAABDaGFubmVsIElkIGRlZmluZWQgYnkgdXNlcgAvAQA9CfAlAAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABAAkAAABJc0VuYWJsZWQBAfMlAwAAAAA1AAAAVHJ1ZSBpZiB0aGUgY2hhbm5lbCBp" +
           "cyBlbmFibGVkIGFuZCBhY2NlcHRpbmcgY29tbWFuZHMALwEAPQnzJQAAAAH/////AQEBAAAAACMBAQH8" +
           "JQAAAAA1YIkKAgAAAAEAEAAAAERpYWdub3N0aWNTdGF0dXMBAfYlAwAAAAAdAAAAQW5hbHlzZXJDaGFu" +
           "bmVsIGhlYWx0aCBzdGF0dXMALwEAPQn2JQAAAQJkGP////8BAQEAAAAAIwEBAf4lAAAAADVgiQoCAAAA" +
           "AQAMAAAAQWN0aXZlU3RyZWFtAQH5JQMAAAAAJgAAAEFjdGl2ZSBzdHJlYW0gZm9yIHRoaXMgQW5hbHlz" +
           "ZXJDaGFubmVsAC8BAD0J+SUAAAAM/////wEBAQAAAAAjAQEB/iUAAAAAJGCACgEAAAACAAkAAABNZXRo" +
           "b2RTZXQBAc8lAwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6zyUAAP////8MAAAAJGGCCgQA" +
           "AAABAA0AAABHb3RvT3BlcmF0aW5nAQHjJQMAAAAAMgAAAFRyYW5zaXRpb25zIHRoZSBBbmFseXNlckNo" +
           "YW5uZWwgdG8gT3BlcmF0aW5nIG1vZGUuAC8BAeMl4yUAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdv" +
           "dG9NYWludGVuYW5jZQEB5CUDAAAAADQAAABUcmFuc2l0aW9ucyB0aGUgQW5hbHlzZXJDaGFubmVsIHRv" +
           "IE1haW50ZW5hbmNlIG1vZGUuAC8BAeQl5CUAAAEB/////wAAAAAEYYIKBAAAAAEAFgAAAFN0YXJ0U2lu" +
           "Z2xlQWNxdWlzaXRpb24BAeUlAC8BAeUl5SUAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHmJQAuAETmJQAAlgMAAAABACoBAR8AAAAOAAAARXhlY3V0aW9uQ3ljbGUBAaIk/////wAA" +
           "AAAAAQAqAQEkAAAAFQAAAEV4ZWN1dGlvbkN5Y2xlU3ViY29kZQAH/////wAAAAAAAQAqAQEdAAAADgAA" +
           "AFNlbGVjdGVkU3RyZWFtAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEABQAAAFJl" +
           "c2V0AQHnJQMAAAAAKQAAAENhdXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBSZXNldHRpbmcgc3RhdGUuAC8B" +
           "Aecl5yUAAAEB/////wAAAAAkYYIKBAAAAAEABQAAAFN0YXJ0AQHoJQMAAAAAKAAAAENhdXNlcyB0cmFu" +
           "c2l0aW9uIHRvIHRoZSBTdGFydGluZyBzdGF0ZS4ALwEB6CXoJQAAAQH/////AAAAACRhggoEAAAAAQAE" +
           "AAAAU3RvcAEB6SUDAAAAACgAAABDYXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgU3RvcHBpbmcgc3RhdGUu" +
           "AC8BAekl6SUAAAEB/////wAAAAAkYYIKBAAAAAEABAAAAEhvbGQBAeolAwAAAAAnAAAAQ2F1c2VzIHRy" +
           "YW5zaXRpb24gdG8gdGhlIEhvbGRpbmcgc3RhdGUuAC8BAeol6iUAAAEB/////wAAAAAkYYIKBAAAAAEA" +
           "BgAAAFVuaG9sZAEB6yUDAAAAACkAAABDYXVzZXMgdHJhbnNpdGlvbiB0byB0aGUgVW5ob2xkaW5nIHN0" +
           "YXRlLgAvAQHrJeslAAABAf////8AAAAAJGGCCgQAAAABAAcAAABTdXNwZW5kAQHsJQMAAAAAKgAAAENh" +
           "dXNlcyB0cmFuc2l0aW9uIHRvIHRoZSBTdXNwZW5kaW5nIHN0YXRlLgAvAQHsJewlAAABAf////8AAAAA" +
           "JGGCCgQAAAABAAkAAABVbnN1c3BlbmQBAe0lAwAAAAAsAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhl" +
           "IFVuc3VzcGVuZGluZyBzdGF0ZS4ALwEB7SXtJQAAAQH/////AAAAACRhggoEAAAAAQAFAAAAQWJvcnQB" +
           "Ae4lAwAAAAAoAAAAQ2F1c2VzIHRyYW5zaXRpb24gdG8gdGhlIEFib3J0aW5nIHN0YXRlLgAvAQHuJe4l" +
           "AAABAf////8AAAAAJGGCCgQAAAABAAUAAABDbGVhcgEB7yUDAAAAACgAAABDYXVzZXMgdHJhbnNpdGlv" +
           "biB0byB0aGUgQ2xlYXJpbmcgc3RhdGUuAC8BAe8l7yUAAAEB/////wAAAAAEYIAKAQAAAAEADQAAAENv" +
           "bmZpZ3VyYXRpb24BAfwlAC8BAu0D/CUAAAEAAAAAIwABAfMlAAAAAARggAoBAAAAAQAGAAAAU3RhdHVz" +
           "AQH+JQAvAQLtA/4lAAACAAAAACMAAQH2JQAjAAEB+SUAAAAAhGCACgEAAAABABMAAABDaGFubmVsU3Rh" +
           "dGVNYWNoaW5lAQEAJgAvAQHvAwAmAAAB/////wIAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEB" +
           "ASYALwEAyAoBJgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQImAC4ARAImAAAAEf//" +
           "//8BAf////8AAAAABGCACgEAAAABABgAAABPcGVyYXRpbmdTdWJTdGF0ZU1hY2hpbmUBAQwmAC8BAfAD" +
           "DCYAAP////8CAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQ0mAC8BAMgKDSYAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEOJgAuAEQOJgAAABH/////AQH/////AAAAAARggAoBAAAA" +
           "AQAfAAAAT3BlcmF0aW5nRXhlY3V0ZVN1YlN0YXRlTWFjaGluZQEBGCYALwEB8QMYJgAA/////wEAAAAV" +
           "YIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBGSYALwEAyAoZJgAAABX/////AQH/////AQAAABVgiQoC" +
           "AAAAAAACAAAASWQBARomAC4ARBomAAAAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
        public FunctionalGroupState Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <summary>
        /// A description for the ChannelStateMachine Object.
        /// </summary>
        public AnalyserChannelStateMachineState ChannelStateMachine
        {
            get
            {
                return m_channelStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_channelStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_channelStateMachine = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_channelStateMachine != null)
            {
                children.Add(m_channelStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ChannelStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (ChannelStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                ChannelStateMachine = new AnalyserChannelStateMachineState(this);
                            }
                            else
                            {
                                ChannelStateMachine = (AnalyserChannelStateMachineState)replacement;
                            }
                        }
                    }

                    instance = ChannelStateMachine;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private AnalyserChannelStateMachineState m_channelStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannelTypeStartSingleAcquisitionMethodState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelTypeStartSingleAcquisitionMethodState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelTypeStartSingleAcquisitionMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelTypeStartSingleAcquisitionMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelTypeStartSingleAcquisitionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AnalyserChannelTypeStartSingleAcquisitionMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAzAAAAQW5hbHlzZXJDaGFubmVsVHlwZVN0YXJ0U2lu" +
           "Z2xlQWNxdWlzaXRpb25NZXRob2RUeXBlAQHMJgAvAQHMJswmAAABAf////8BAAAAFWCpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBzSYALgBEzSYAAJYDAAAAAQAqAQEfAAAADgAAAEV4ZWN1dGlvbkN5Y2xl" +
           "AQGiJP////8AAAAAAAEAKgEBJAAAABUAAABFeGVjdXRpb25DeWNsZVN1YmNvZGUAB/////8AAAAAAAEA" +
           "KgEBHQAAAA4AAABTZWxlY3RlZFN0cmVhbQAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AnalyserChannelTypeStartSingleAcquisitionMethodStateMethodCallHandler OnCall;
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

            ExecutionCycleEnumeration executionCycle = (ExecutionCycleEnumeration)inputArguments[0];
            uint executionCycleSubcode = (uint)inputArguments[1];
            string selectedStream = (string)inputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    executionCycle,
                    executionCycleSubcode,
                    selectedStream);
            }

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
    public delegate ServiceResult AnalyserChannelTypeStartSingleAcquisitionMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        ExecutionCycleEnumeration executionCycle,
        uint executionCycleSubcode,
        string selectedStream);
    #endif
    #endregion

    #region AnalyserChannelOperatingStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelOperatingStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelOperatingStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelOperatingStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelOperatingStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQApAAAAQW5hbHlzZXJDaGFubmVsT3BlcmF0aW5nU3Rh" +
           "dGVUeXBlSW5zdGFuY2UBAewDAQHsAwH/////AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAc4m" +
           "AC4ARM4mAAAAB/////8BAf////8AAAAA";
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

    #region AnalyserChannelLocalStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelLocalStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelLocalStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelLocalStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelLocalStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelLocalStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQW5hbHlzZXJDaGFubmVsTG9jYWxTdGF0ZVR5" +
           "cGVJbnN0YW5jZQEB7QMBAe0D/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHPJgAuAETP" +
           "JgAAAAf/////AQH/////AAAAAA==";
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

    #region AnalyserChannelMaintenanceStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelMaintenanceStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelMaintenanceStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelMaintenanceStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelMaintenanceStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelMaintenanceStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQArAAAAQW5hbHlzZXJDaGFubmVsTWFpbnRlbmFuY2VT" +
           "dGF0ZVR5cGVJbnN0YW5jZQEB7gMBAe4D/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHQ" +
           "JgAuAETQJgAAAAf/////AQH/////AAAAAA==";
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

    #region AnalyserChannelStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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

            if (LocalSubStateMachine != null)
            {
                LocalSubStateMachine.Initialize(context, LocalSubStateMachine_InitializationString);
            }

            if (MaintenanceSubStateMachine != null)
            {
                MaintenanceSubStateMachine.Initialize(context, MaintenanceSubStateMachine_InitializationString);
            }
        }

        #region Initialization String
        private const string LocalSubStateMachine_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAUAAAATG9jYWxTdWJTdGF0ZU1hY2hpbmUBAfQmAC8B" +
           "ANMK9CYAAAEAAAAAdQEBARAnAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQH1JgAvAQDICvUm" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB9iYALgBE9iYAAAAR/////wEB/////wAA" +
           "AAA=";

        private const string MaintenanceSubStateMachine_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAaAAAATWFpbnRlbmFuY2VTdWJTdGF0ZU1hY2hpbmUB" +
           "AQAnAC8BANMKACcAAAEAAAAAdQEBARInAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEBJwAv" +
           "AQDICgEnAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAicALgBEAicAAAAR/////wEB" +
           "/////wAAAAA=";

        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAnAAAAQW5hbHlzZXJDaGFubmVsU3RhdGVNYWNoaW5l" +
           "VHlwZUluc3RhbmNlAQHvAwEB7wMB/////wQAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEB0SYA" +
           "LwEAyArRJgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdImAC4ARNImAAAAEf////8B" +
           "Af////8AAAAABGCACgEAAAABABgAAABPcGVyYXRpbmdTdWJTdGF0ZU1hY2hpbmUBAdwmAC8BAfAD3CYA" +
           "AAEAAAAAdQEBAQ4nAgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQHdJgAvAQDICt0mAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB3iYALgBE3iYAAAAR/////wEB/////wAAAAAEYIAK" +
           "AQAAAAEAHwAAAE9wZXJhdGluZ0V4ZWN1dGVTdWJTdGF0ZU1hY2hpbmUBAegmAC8BAfED6CYAAP////8B" +
           "AAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAekmAC8BAMgK6SYAAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQHqJgAuAETqJgAAABH/////AQH/////AAAAAARggAoBAAAAAQAUAAAATG9j" +
           "YWxTdWJTdGF0ZU1hY2hpbmUBAfQmAC8BANMK9CYAAAEAAAAAdQEBARAnAQAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQH1JgAvAQDICvUmAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "9iYALgBE9iYAAAAR/////wEB/////wAAAAAEYIAKAQAAAAEAGgAAAE1haW50ZW5hbmNlU3ViU3RhdGVN" +
           "YWNoaW5lAQEAJwAvAQDTCgAnAAABAAAAAHUBAQESJwEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0" +
           "ZQEBAScALwEAyAoBJwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQInAC4ARAInAAAA" +
           "Ef////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the OperatingSubStateMachine Object.
        /// </summary>
        public AnalyserChannel_OperatingModeSubStateMachineState OperatingSubStateMachine
        {
            get
            {
                return m_operatingSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingSubStateMachine = value;
            }
        }

        /// <summary>
        /// A description for the LocalSubStateMachine Object.
        /// </summary>
        public FiniteStateMachineState LocalSubStateMachine
        {
            get
            {
                return m_localSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_localSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_localSubStateMachine = value;
            }
        }

        /// <summary>
        /// A description for the MaintenanceSubStateMachine Object.
        /// </summary>
        public FiniteStateMachineState MaintenanceSubStateMachine
        {
            get
            {
                return m_maintenanceSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenanceSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenanceSubStateMachine = value;
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
            if (m_operatingSubStateMachine != null)
            {
                children.Add(m_operatingSubStateMachine);
            }

            if (m_localSubStateMachine != null)
            {
                children.Add(m_localSubStateMachine);
            }

            if (m_maintenanceSubStateMachine != null)
            {
                children.Add(m_maintenanceSubStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.OperatingSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (OperatingSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                OperatingSubStateMachine = new AnalyserChannel_OperatingModeSubStateMachineState(this);
                            }
                            else
                            {
                                OperatingSubStateMachine = (AnalyserChannel_OperatingModeSubStateMachineState)replacement;
                            }
                        }
                    }

                    instance = OperatingSubStateMachine;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.LocalSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (LocalSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                LocalSubStateMachine = new FiniteStateMachineState(this);
                            }
                            else
                            {
                                LocalSubStateMachine = (FiniteStateMachineState)replacement;
                            }
                        }
                    }

                    instance = LocalSubStateMachine;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.MaintenanceSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (MaintenanceSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                MaintenanceSubStateMachine = new FiniteStateMachineState(this);
                            }
                            else
                            {
                                MaintenanceSubStateMachine = (FiniteStateMachineState)replacement;
                            }
                        }
                    }

                    instance = MaintenanceSubStateMachine;
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
        private AnalyserChannel_OperatingModeSubStateMachineState m_operatingSubStateMachine;
        private FiniteStateMachineState m_localSubStateMachine;
        private FiniteStateMachineState m_maintenanceSubStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannelOperatingExecuteStateState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannelOperatingExecuteStateState)
    /// <summary>
    /// Stores an instance of the AnalyserChannelOperatingExecuteStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannelOperatingExecuteStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannelOperatingExecuteStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannelOperatingExecuteStateType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAwAAAAQW5hbHlzZXJDaGFubmVsT3BlcmF0aW5nRXhl" +
           "Y3V0ZVN0YXRlVHlwZUluc3RhbmNlAQEEIwEBBCMB/////wEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVt" +
           "YmVyAQEoJwAuAEQoJwAAAAf/////AQH/////AAAAAA==";
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

    #region AnalyserChannel_OperatingModeSubStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannel_OperatingModeSubStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannel_OperatingModeSubStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannel_OperatingModeSubStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannel_OperatingModeSubStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQA4AAAAQW5hbHlzZXJDaGFubmVsX09wZXJhdGluZ01v" +
           "ZGVTdWJTdGF0ZU1hY2hpbmVUeXBlSW5zdGFuY2UBAfADAQHwAwH/////AgAAABVgiQoCAAAAAAAMAAAA" +
           "Q3VycmVudFN0YXRlAQEpJwAvAQDICiknAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "KicALgBEKicAAAAR/////wEB/////wAAAAAEYIAKAQAAAAEAHwAAAE9wZXJhdGluZ0V4ZWN1dGVTdWJT" +
           "dGF0ZU1hY2hpbmUBATQnAC8BAfEDNCcAAAEAAAAAdQEBAUgnAQAAABVgiQoCAAAAAAAMAAAAQ3VycmVu" +
           "dFN0YXRlAQE1JwAvAQDICjUnAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBNicALgBE" +
           "NicAAAAR/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the OperatingExecuteSubStateMachine Object.
        /// </summary>
        public AnalyserChannel_OperatingModeExecuteSubStateMachineState OperatingExecuteSubStateMachine
        {
            get
            {
                return m_operatingExecuteSubStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingExecuteSubStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingExecuteSubStateMachine = value;
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
            if (m_operatingExecuteSubStateMachine != null)
            {
                children.Add(m_operatingExecuteSubStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.OperatingExecuteSubStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (OperatingExecuteSubStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                OperatingExecuteSubStateMachine = new AnalyserChannel_OperatingModeExecuteSubStateMachineState(this);
                            }
                            else
                            {
                                OperatingExecuteSubStateMachine = (AnalyserChannel_OperatingModeExecuteSubStateMachineState)replacement;
                            }
                        }
                    }

                    instance = OperatingExecuteSubStateMachine;
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
        private AnalyserChannel_OperatingModeExecuteSubStateMachineState m_operatingExecuteSubStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AnalyserChannel_OperatingModeExecuteSubStateMachineState Class
    #if (!OPCUA_EXCLUDE_AnalyserChannel_OperatingModeExecuteSubStateMachineState)
    /// <summary>
    /// Stores an instance of the AnalyserChannel_OperatingModeExecuteSubStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalyserChannel_OperatingModeExecuteSubStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalyserChannel_OperatingModeExecuteSubStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AnalyserChannel_OperatingModeExecuteSubStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQA/AAAAQW5hbHlzZXJDaGFubmVsX09wZXJhdGluZ01v" +
           "ZGVFeGVjdXRlU3ViU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQHxAwEB8QMB/////wEAAAAVYIkKAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBzicALwEAyArOJwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAC" +
           "AAAASWQBAc8nAC4ARM8nAAAAEf////8BAf////8AAAAA";
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

    #region StreamState Class
    #if (!OPCUA_EXCLUDE_StreamState)
    /// <summary>
    /// Stores an instance of the StreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StreamState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.StreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAU3RyZWFtVHlwZUluc3RhbmNlAQHyAwEB8gP/" +
           "////CAAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQFNKAMAAAAAFwAAAEZsYXQgbGlzdCBvZiBQ" +
           "YXJhbWV0ZXJzAC8AOk0oAAD/////HAAAADVgiQoCAAAAAQAJAAAASXNFbmFibGVkAQFjKAMAAAAANQAA" +
           "AFRydWUgaWYgdGhpcyBzdHJlYW0gbWF5YmUgdXNlZCB0byBwZXJmb3JtIGFjcXVpc2l0aW9uAC8BAD0J" +
           "YygAAAAB/////wEBAQAAAAAjAQEBvigAAAAANWCJCgIAAAABAAgAAABJc0ZvcmNlZAEBZigDAAAAAIIA" +
           "AABUcnVlIGlmIHRoaXMgc3RyZWFtIGlzIGZvcmNlZCwgd2hpY2ggbWVhbnMgdGhhdCBpcyB0aGUgb25s" +
           "eSBTdHJlYW0gb24gdGhpcyBBbmFseXNlckNoYW5uZWwgdGhhdCBjYW4gYmUgdXNlZCB0byBwZXJmb3Jt" +
           "IGFjcXVpc2l0aW9uAC8BAD0JZigAAAAB/////wEBAQAAAAAjAQEBvigAAAAANWCJCgIAAAABABAAAABE" +
           "aWFnbm9zdGljU3RhdHVzAQFpKAMAAAAAFAAAAFN0cmVhbSBoZWFsdGggc3RhdHVzAC8BAD0JaSgAAAEC" +
           "ZBj/////AQEBAAAAACMBAQHAKAAAAAA1YIkKAgAAAAEAEwAAAExhc3RDYWxpYnJhdGlvblRpbWUBAWwo" +
           "AwAAAAAqAAAAVGltZSBhdCB3aGljaCB0aGUgbGFzdCBjYWxpYnJhdGlvbiB3YXMgcnVuAC8BAD0JbCgA" +
           "AAAN/////wEBAQAAAAAjAQEBwCgAAAAANWCJCgIAAAABABIAAABMYXN0VmFsaWRhdGlvblRpbWUBAW8o" +
           "AwAAAAApAAAAVGltZSBhdCB3aGljaCB0aGUgbGFzdCB2YWxpZGF0aW9uIHdhcyBydW4ALwEAPQlvKAAA" +
           "AA3/////AQEBAAAAACMBAQHAKAAAAAA1YIkKAgAAAAEADgAAAExhc3RTYW1wbGVUaW1lAQFyKAMAAAAA" +
           "KgAAAFRpbWUgYXQgd2hpY2ggdGhlIGxhc3Qgc2FtcGxlIHdhcyBhY3F1aXJlZAAvAQA9CXIoAAAADf//" +
           "//8BAQEAAAAAIwEBAcAoAAAAADVgiQoCAAAAAQASAAAAVGltZUJldHdlZW5TYW1wbGVzAQF1KAMAAAAA" +
           "RAAAAE51bWJlciBvZiBtaWxsaXNlY29uZHMgYmV0d2VlbiB0d28gY29uc2VjdXRpdmUgc3RhcnRzIG9m" +
           "IGFjcXVpc2l0aW9uAC8BAEAJdSgAAAEAIgH/////AQEBAAAAACMBAQHCKAEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAXkoAC4ARHkoAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACAAAAElzQWN0aXZl" +
           "AQF7KAMAAAAANwAAAFRydWUgaWYgdGhpcyBzdHJlYW0gaXMgYWN0dWFsbHkgcnVubmluZywgYWNxdWly" +
           "aW5nIGRhdGEALwEAPQl7KAAAAAH/////AQEBAAAAACMBAQHEKAAAAAA1YIkKAgAAAAEADgAAAEV4ZWN1" +
           "dGlvbkN5Y2xlAQF+KAMAAAAALgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgaXMgaW4g" +
           "cHJvZ3Jlc3MALwEAPQl+KAAAAQGiJP////8BAQEAAAAAIwEBAcQoAAAAADVgiQoCAAAAAQAVAAAARXhl" +
           "Y3V0aW9uQ3ljbGVTdWJjb2RlAQGBKAMAAAAANgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3lj" +
           "bGUgc3ViY29kZSBpcyBpbiBwcm9ncmVzcwAvAQBICYEoAAAAHP////8BAQEAAAAAIwEBAcQoAQAAABVg" +
           "iQoCAAAAAAALAAAARW51bVN0cmluZ3MBAYQoAC4ARIQoAAAAFQEAAAABAf////8AAAAANWCJCgIAAAAB" +
           "AAgAAABQcm9ncmVzcwEBhSgDAAAAAHQAAABJbmRpY2F0ZXMgdGhlIHByb2dyZXNzIG9mIGFuIGFjcXVp" +
           "c2l0aW9uIGluIHRlcm1zIG9mIHBlcmNlbnRhZ2Ugb2YgY29tcGxldGlvbi4gSXRzIHZhbHVlIHNoYWxs" +
           "IGJlIGJldHdlZW4gMCBhbmQgMTAwLgAvAQA9CYUoAAAACv////8BAQEAAAAAIwEBAcQoAAAAADVgiQoC" +
           "AAAAAQASAAAAQWNxdWlzaXRpb25Db3VudGVyAQGIKAMAAAAAUwAAAFNpbXBsZSBjb3VudGVyIGluY3Jl" +
           "bWVudGVkIGFmdGVyIGVhY2ggU2FtcGxpbmcgYWNxdWlzaXRpb24gcGVyZm9ybWVkIG9uIHRoaXMgU3Ry" +
           "ZWFtAC8BAEAJiCgAAAEAIQH/////AQEBAAAAACMBAQHGKAEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AYwoAC4ARIwoAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEFjcXVpc2l0aW9uUmVzdWx0" +
           "U3RhdHVzAQGOKAMAAAAAGgAAAFF1YWxpdHkgb2YgdGhlIGFjcXVpc2l0aW9uAC8BAD0JjigAAAEBuwv/" +
           "////AQEBAAAAACMBAQHGKAAAAAA1YIkKAgAAAAEABwAAAFJhd0RhdGEBAZEoAwAAAAA/AAAAUmF3IGRh" +
           "dGEgcHJvZHVjZWQgYXMgYSByZXN1bHQgb2YgZGF0YSBhY3F1aXNpdGlvbiBvbiB0aGUgU3RyZWFtAC8B" +
           "AD0JkSgAAAAY/////wEBAQAAAAAjAQEBxigAAAAANWCJCgIAAAABAAoAAABTY2FsZWREYXRhAQGUKAMA" +
           "AAAAaAAAAFNjYWxlZCBkYXRhIHByb2R1Y2VkIGFzIGEgcmVzdWx0IG9mIGRhdGEgYWNxdWlzaXRpb24g" +
           "b24gdGhlIFN0cmVhbSBhbmQgYXBwbGljYXRpb24gb2YgdGhlIGFuYWx5c2VyIG1vZGVsAC8BAD0JlCgA" +
           "AAAY/////wEBAQAAAAAjAQEBxigAAAAANWCJCgIAAAABAAYAAABPZmZzZXQBAZcoAwAAAABgAAAARGlm" +
           "ZmVyZW5jZSBpbiBtaWxsaXNlY29uZHMgYmV0d2VlbiB0aGUgc3RhcnQgb2Ygc2FtcGxlIGV4dHJhY3Rp" +
           "b24gYW5kIHRoZSBzdGFydCBvZiB0aGUgYW5hbHlzaXMuAC8BAD0JlygAAAEAIgH/////AQEBAAAAACMB" +
           "AQHGKAAAAAA1YIkKAgAAAAEAEgAAAEFjcXVpc2l0aW9uRW5kVGltZQEBmigDAAAAAKcAAABUaGUgZW5k" +
           "IHRpbWUgb2YgdGhlIEFuYWx5c2VTYW1wbGUgb3IgQW5hbHlzZUNhbGlicmF0aW9uU2FtcGxlIG9yIEFu" +
           "YWx5c2VWYWxpZGF0aW9uU2FtcGxlIHN0YXRlIG9mIHRoZSBBbmFseXNlckNoYW5uZWxfT3BlcmF0aW5n" +
           "TW9kZUV4ZWN1dGVTdWJTdGF0ZU1hY2hpbmUgc3RhdGUgbWFjaGluZQAvAQA9CZooAAAADf////8BAQEA" +
           "AAAAIwEBAcYoAAAAADVgiQoCAAAAAQAKAAAAQ2FtcGFpZ25JZAEBnSgDAAAAABwAAABEZWZpbmVzIHRo" +
           "ZSBjdXJyZW50IGNhbXBhaWduAC8BAD0JnSgAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAAB" +
           "AAcAAABCYXRjaElkAQGgKAMAAAAAGQAAAERlZmluZXMgdGhlIGN1cnJlbnQgYmF0Y2gALwEAPQmgKAAA" +
           "AAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEACgAAAFN1YkJhdGNoSWQBAaMoAwAAAAAdAAAA" +
           "RGVmaW5lcyB0aGUgY3VycmVudCBzdWItYmF0Y2gALwEAPQmjKAAAAAz/////AwMBAAAAACMBAQHKKAAA" +
           "AAA1YIkKAgAAAAEABQAAAExvdElkAQGmKAMAAAAAFwAAAERlZmluZXMgdGhlIGN1cnJlbnQgbG90AC8B" +
           "AD0JpigAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAABAAoAAABNYXRlcmlhbElkAQGpKAMA" +
           "AAAAHAAAAERlZmluZXMgdGhlIGN1cnJlbnQgbWF0ZXJpYWwALwEAPQmpKAAAAAz/////AwMBAAAAACMB" +
           "AQHKKAAAAAA1YIkKAgAAAAEABwAAAFByb2Nlc3MBAawoAwAAAAAUAAAAQ3VycmVudCBQcm9jZXNzIG5h" +
           "bWUALwEAPQmsKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEABAAAAFVuaXQBAa8oAwAA" +
           "AAARAAAAQ3VycmVudCBVbml0IG5hbWUALwEAPQmvKAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkK" +
           "AgAAAAEACQAAAE9wZXJhdGlvbgEBsigDAAAAABYAAABDdXJyZW50IE9wZXJhdGlvbiBuYW1lAC8BAD0J" +
           "sigAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJCgIAAAABAAUAAABQaGFzZQEBtSgDAAAAABIAAABD" +
           "dXJyZW50IFBoYXNlIG5hbWUALwEAPQm1KAAAAAz/////AwMBAAAAACMBAQHKKAAAAAA1YIkKAgAAAAEA" +
           "BgAAAFVzZXJJZAEBuCgDAAAAAD0AAABMb2dpbiBuYW1lIG9mIHRoZSB1c2VyIHdobyBpcyBsb2dnZWQg" +
           "b24gYXQgdGhlIGRldmljZSBjb25zb2xlAC8BAD0JuCgAAAAM/////wMDAQAAAAAjAQEByigAAAAANWCJ" +
           "CgIAAAABAAgAAABTYW1wbGVJZAEBuygDAAAAABkAAABJZGVudGlmaWVyIGZvciB0aGUgc2FtcGxlAC8B" +
           "AD0JuygAAAAM/////wMDAQAAAAAjAQEByigAAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQG+" +
           "KAAvAQLtA74oAAACAAAAACMAAQFjKAAjAAEBZigAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAcAoAC8B" +
           "Au0DwCgAAAQAAAAAIwABAWkoACMAAQFsKAAjAAEBbygAIwABAXIoAAAAAARggAoBAAAAAQATAAAAQWNx" +
           "dWlzaXRpb25TZXR0aW5ncwEBwigALwEC7QPCKAAAAQAAAAAjAAEBdSgAAAAABGCACgEAAAABABEAAABB" +
           "Y3F1aXNpdGlvblN0YXR1cwEBxCgALwEC7QPEKAAABAAAAAAjAAEBeygAIwABAX4oACMAAQGBKAAjAAEB" +
           "hSgAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAcYoAC8BAu0DxigAAAYAAAAAIwABAYgo" +
           "ACMAAQGOKAAjAAEBkSgAIwABAZQoACMAAQGXKAAjAAEBmigAAAAABGCACgEAAAABABgAAABDaGVtb21l" +
           "dHJpY01vZGVsU2V0dGluZ3MBAcgoAC8BAu0DyCgAAP////8AAAAABGCACgEAAAABAAcAAABDb250ZXh0" +
           "AQHKKAAvAQLtA8ooAAALAAAAACMAAQGdKAAjAAEBoCgAIwABAaMoACMAAQGmKAAjAAEBqSgAIwABAawo" +
           "ACMAAQGvKAAjAAEBsigAIwABAbUoACMAAQG4KAAjAAEBuygAAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
        public FunctionalGroupState Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <summary>
        /// A description for the AcquisitionSettings Object.
        /// </summary>
        public FunctionalGroupState AcquisitionSettings
        {
            get
            {
                return m_acquisitionSettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionSettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionSettings = value;
            }
        }

        /// <summary>
        /// A description for the AcquisitionStatus Object.
        /// </summary>
        public FunctionalGroupState AcquisitionStatus
        {
            get
            {
                return m_acquisitionStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionStatus = value;
            }
        }

        /// <summary>
        /// A description for the AcquisitionData Object.
        /// </summary>
        public FunctionalGroupState AcquisitionData
        {
            get
            {
                return m_acquisitionData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acquisitionData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acquisitionData = value;
            }
        }

        /// <summary>
        /// A description for the ChemometricModelSettings Object.
        /// </summary>
        public FunctionalGroupState ChemometricModelSettings
        {
            get
            {
                return m_chemometricModelSettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_chemometricModelSettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_chemometricModelSettings = value;
            }
        }

        /// <summary>
        /// A description for the Context Object.
        /// </summary>
        public FunctionalGroupState Context
        {
            get
            {
                return m_context;
            }

            set
            {
                if (!Object.ReferenceEquals(m_context, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_context = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_acquisitionSettings != null)
            {
                children.Add(m_acquisitionSettings);
            }

            if (m_acquisitionStatus != null)
            {
                children.Add(m_acquisitionStatus);
            }

            if (m_acquisitionData != null)
            {
                children.Add(m_acquisitionData);
            }

            if (m_chemometricModelSettings != null)
            {
                children.Add(m_chemometricModelSettings);
            }

            if (m_context != null)
            {
                children.Add(m_context);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionSettings:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionSettings == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionSettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionSettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionSettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionStatus:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionStatus == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionStatus = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionStatus = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionStatus;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AcquisitionData:
                {
                    if (createOrReplace)
                    {
                        if (AcquisitionData == null)
                        {
                            if (replacement == null)
                            {
                                AcquisitionData = new FunctionalGroupState(this);
                            }
                            else
                            {
                                AcquisitionData = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = AcquisitionData;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ChemometricModelSettings:
                {
                    if (createOrReplace)
                    {
                        if (ChemometricModelSettings == null)
                        {
                            if (replacement == null)
                            {
                                ChemometricModelSettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                ChemometricModelSettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = ChemometricModelSettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.Context:
                {
                    if (createOrReplace)
                    {
                        if (Context == null)
                        {
                            if (replacement == null)
                            {
                                Context = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Context = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Context;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_acquisitionSettings;
        private FunctionalGroupState m_acquisitionStatus;
        private FunctionalGroupState m_acquisitionData;
        private FunctionalGroupState m_chemometricModelSettings;
        private FunctionalGroupState m_context;
        #endregion
    }
    #endif
    #endregion

    #region SpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_SpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the SpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAkAAAAU3BlY3Ryb21ldGVyRGV2aWNlU3RyZWFtVHlw" +
           "ZUluc3RhbmNlAQEGBAEBBgT/////CQAAACRggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHOKAMAAAAA" +
           "FwAAAEZsYXQgbGlzdCBvZiBQYXJhbWV0ZXJzAC8AOs4oAAD/////GAAAADVgiQoCAAAAAQAJAAAASXNF" +
           "bmFibGVkAQHkKAMAAAAANQAAAFRydWUgaWYgdGhpcyBzdHJlYW0gbWF5YmUgdXNlZCB0byBwZXJmb3Jt" +
           "IGFjcXVpc2l0aW9uAC8BAD0J5CgAAAAB/////wEBAQAAAAAjAQEBPykAAAAANWCJCgIAAAABABAAAABE" +
           "aWFnbm9zdGljU3RhdHVzAQHqKAMAAAAAFAAAAFN0cmVhbSBoZWFsdGggc3RhdHVzAC8BAD0J6igAAAEC" +
           "ZBj/////AQEBAAAAACMBAQFBKQAAAAA1YIkKAgAAAAEADgAAAExhc3RTYW1wbGVUaW1lAQHzKAMAAAAA" +
           "KgAAAFRpbWUgYXQgd2hpY2ggdGhlIGxhc3Qgc2FtcGxlIHdhcyBhY3F1aXJlZAAvAQA9CfMoAAAADf//" +
           "//8BAQEAAAAAIwEBAUEpAAAAADVgiQoCAAAAAQAIAAAASXNBY3RpdmUBAfwoAwAAAAA3AAAAVHJ1ZSBp" +
           "ZiB0aGlzIHN0cmVhbSBpcyBhY3R1YWxseSBydW5uaW5nLCBhY3F1aXJpbmcgZGF0YQAvAQA9CfwoAAAA" +
           "Af////8BAQEAAAAAIwEBAUUpAAAAADVgiQoCAAAAAQAOAAAARXhlY3V0aW9uQ3ljbGUBAf8oAwAAAAAu" +
           "AAAASW5kaWNhdGVzIHdoaWNoIEV4ZWN1dGlvbiBjeWNsZSBpcyBpbiBwcm9ncmVzcwAvAQA9Cf8oAAAB" +
           "AaIk/////wEBAQAAAAAjAQEBRSkAAAAANWCJCgIAAAABABUAAABFeGVjdXRpb25DeWNsZVN1YmNvZGUB" +
           "AQIpAwAAAAA2AAAASW5kaWNhdGVzIHdoaWNoIEV4ZWN1dGlvbiBjeWNsZSBzdWJjb2RlIGlzIGluIHBy" +
           "b2dyZXNzAC8BAEgJAikAAAAc/////wEBAQAAAAAjAQEBRSkBAAAAFWCJCgIAAAAAAAsAAABFbnVtU3Ry" +
           "aW5ncwEBBSkALgBEBSkAAAAVAQAAAAEB/////wAAAAA1YIkKAgAAAAEACAAAAFByb2dyZXNzAQEGKQMA" +
           "AAAAdAAAAEluZGljYXRlcyB0aGUgcHJvZ3Jlc3Mgb2YgYW4gYWNxdWlzaXRpb24gaW4gdGVybXMgb2Yg" +
           "cGVyY2VudGFnZSBvZiBjb21wbGV0aW9uLiBJdHMgdmFsdWUgc2hhbGwgYmUgYmV0d2VlbiAwIGFuZCAx" +
           "MDAuAC8BAD0JBikAAAAK/////wEBAQAAAAAjAQEBRSkAAAAANWCJCgIAAAABABIAAABBY3F1aXNpdGlv" +
           "bkNvdW50ZXIBAQkpAwAAAABTAAAAU2ltcGxlIGNvdW50ZXIgaW5jcmVtZW50ZWQgYWZ0ZXIgZWFjaCBT" +
           "YW1wbGluZyBhY3F1aXNpdGlvbiBwZXJmb3JtZWQgb24gdGhpcyBTdHJlYW0ALwEAQAkJKQAAAQAhAf//" +
           "//8BAQEAAAAAIwEBAUcpAQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBDSkALgBEDSkAAAEAdAP/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAXAAAAQWNxdWlzaXRpb25SZXN1bHRTdGF0dXMBAQ8pAwAAAAAaAAAA" +
           "UXVhbGl0eSBvZiB0aGUgYWNxdWlzaXRpb24ALwEAPQkPKQAAAQG7C/////8BAQEAAAAAIwEBAUcpAAAA" +
           "ADVgiQoCAAAAAQAKAAAAU2NhbGVkRGF0YQEBFSkDAAAAAGgAAABTY2FsZWQgZGF0YSBwcm9kdWNlZCBh" +
           "cyBhIHJlc3VsdCBvZiBkYXRhIGFjcXVpc2l0aW9uIG9uIHRoZSBTdHJlYW0gYW5kIGFwcGxpY2F0aW9u" +
           "IG9mIHRoZSBhbmFseXNlciBtb2RlbAAvAQA9CRUpAAAAGP////8BAQEAAAAAIwEBAUcpAAAAADVgiQoC" +
           "AAAAAQASAAAAQWNxdWlzaXRpb25FbmRUaW1lAQEbKQMAAAAApwAAAFRoZSBlbmQgdGltZSBvZiB0aGUg" +
           "QW5hbHlzZVNhbXBsZSBvciBBbmFseXNlQ2FsaWJyYXRpb25TYW1wbGUgb3IgQW5hbHlzZVZhbGlkYXRp" +
           "b25TYW1wbGUgc3RhdGUgb2YgdGhlIEFuYWx5c2VyQ2hhbm5lbF9PcGVyYXRpbmdNb2RlRXhlY3V0ZVN1" +
           "YlN0YXRlTWFjaGluZSBzdGF0ZSBtYWNoaW5lAC8BAD0JGykAAAAN/////wEBAQAAAAAjAQEBRykAAAAA" +
           "FWCJCgIAAAABABAAAABBY3RpdmVCYWNrZ3JvdW5kAQFPKQAvAQD9Lk8pAAAACv////8BAQEAAAAAIwEB" +
           "AT8pBQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBUykALgBEUykAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBVCkALgBEVCkAAAEAdwP/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAFAAAAVGl0bGUBAVUpAC4ARFUpAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABB" +
           "eGlzU2NhbGVUeXBlAQFWKQAuAERWKQAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhp" +
           "c0RlZmluaXRpb24BAVcpAC4ARFcpAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAEFjdGl2" +
           "ZUJhY2tncm91bmQxAQFYKQAvAQD9LlgpAAAACv////8BAQEAAAAAIwEBAT8pBQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBXCkALgBEXCkAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwEBXSkALgBEXSkAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUB" +
           "AV4pAC4ARF4pAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABBeGlzU2NhbGVUeXBlAQFfKQAu" +
           "AERfKQAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhpc0RlZmluaXRpb24BAWApAC4A" +
           "RGApAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAFNwZWN0cmFsUmFuZ2UBAWEpAC8BAD0J" +
           "YSkAAAEAdAMBAAAAAQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEACgAAAFJlc29sdXRpb24BAWQpAC8B" +
           "AD0JZCkAAAAY/////wEBAQAAAAAjAQEBQykAAAAAFWCJCgIAAAABABYAAABSZXF1ZXN0ZWROdW1iZXJP" +
           "ZlNjYW5zAQFnKQAvAQA9CWcpAAAABv////8BAQEAAAAAIwEBAUMpAAAAABVgiQoCAAAAAQAEAAAAR2Fp" +
           "bgEBaikALwEAPQlqKQAAABj/////AQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEAEwAAAFRyYW5zbWl0" +
           "dGFuY2VDdXRvZmYBAW0pAC8BAD0JbSkAAAEAdAP/////AQEBAAAAACMBAQFDKQAAAAAVYIkKAgAAAAEA" +
           "EAAAAEFic29yYmFuY2VDdXRvZmYBAXApAC8BAD0JcCkAAAEAdAP/////AQEBAAAAACMBAQFDKQAAAAAV" +
           "YIkKAgAAAAEAEQAAAE51bWJlck9mU2NhbnNEb25lAQFzKQAvAQA9CXMpAAAABv////8BAQEAAAAAIwEB" +
           "AUUpAAAAABVgiQoCAAAAAQAWAAAAVG90YWxOdW1iZXJPZlNjYW5zRG9uZQEBdikALwEAPQl2KQAAAAb/" +
           "////AQEBAAAAACMBAQFHKQAAAAAVYIkKAgAAAAEAGQAAAEJhY2tncm91bmRBY3F1aXNpdGlvblRpbWUB" +
           "AXkpAC8BAD0JeSkAAAAN/////wEBAQAAAAAjAQEBRykAAAAAFWCJCgIAAAABABEAAABQZW5kaW5nQmFj" +
           "a2dyb3VuZAEBfCkALwEA/S58KQAAAAr/////AQEBAAAAACMBAQFHKQUAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAYApAC4ARIApAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMBAYEpAC4ARIEpAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAAABQAAAFRpdGxlAQGCKQAu" +
           "AESCKQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQXhpc1NjYWxlVHlwZQEBgykALgBEgykA" +
           "AAEALS//////AQH/////AAAAABVgiQoCAAAAAAAPAAAAWEF4aXNEZWZpbml0aW9uAQGEKQAuAESEKQAA" +
           "AQAvL/////8BAf////8AAAAAFWCJCgIAAAABABIAAABQZW5kaW5nQmFja2dyb3VuZDEBAYUpAC8BAP0u" +
           "hSkAAAAK/////wEBAQAAAAAjAQEBRykFAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGJKQAuAESJKQAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQGKKQAuAESKKQAA" +
           "AQB3A/////8BAf////8AAAAAFWCJCgIAAAAAAAUAAABUaXRsZQEBiykALgBEiykAAAAV/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADQAAAEF4aXNTY2FsZVR5cGUBAYwpAC4ARIwpAAABAC0v/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADwAAAFhBeGlzRGVmaW5pdGlvbgEBjSkALgBEjSkAAAEALy//////AQH/////AAAA" +
           "AARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBPykALwEC7QM/KQAABAAAAAAjAAEB5CgAIwABAeco" +
           "ACMAAQFPKQAjAAEBWCkAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAUEpAC8BAu0DQSkAAAQAAAAAIwAB" +
           "AeooACMAAQHtKAAjAAEB8CgAIwABAfMoAAAAAARggAoBAAAAAQATAAAAQWNxdWlzaXRpb25TZXR0aW5n" +
           "cwEBQykALwEC7QNDKQAABwAAAAAjAAEB9igAIwABAWEpACMAAQFkKQAjAAEBZykAIwABAWopACMAAQFt" +
           "KQAjAAEBcCkAAAAABGCACgEAAAABABEAAABBY3F1aXNpdGlvblN0YXR1cwEBRSkALwEC7QNFKQAABQAA" +
           "AAAjAAEB/CgAIwABAf8oACMAAQECKQAjAAEBBikAIwABAXMpAAAAAARggAoBAAAAAQAPAAAAQWNxdWlz" +
           "aXRpb25EYXRhAQFHKQAvAQLtA0cpAAAKAAAAACMAAQEJKQAjAAEBDykAIwABARIpACMAAQEVKQAjAAEB" +
           "GCkAIwABARspACMAAQF2KQAjAAEBeSkAIwABAXwpACMAAQGFKQAAAAAEYIAKAQAAAAEAGAAAAENoZW1v" +
           "bWV0cmljTW9kZWxTZXR0aW5ncwEBSSkALwEC7QNJKQAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRl" +
           "eHQBAUspAC8BAu0DSykAAAsAAAAAIwABAR4pACMAAQEhKQAjAAEBJCkAIwABAScpACMAAQEqKQAjAAEB" +
           "LSkAIwABATApACMAAQEzKQAjAAEBNikAIwABATkpACMAAQE8KQAAAAAEYIAKAQAAAAEADwAAAEZhY3Rv" +
           "cnlTZXR0aW5ncwEBjikALwA6jikAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
        public BaseObjectState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
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
            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
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
                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new BaseObjectState(this);
                            }
                            else
                            {
                                FactorySettings = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
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
        private BaseObjectState m_factorySettings;
        #endregion
    }
    #endif
    #endregion

    #region MassSpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_MassSpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the MassSpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassSpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassSpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAoAAAATWFzc1NwZWN0cm9tZXRlckRldmljZVN0cmVh" +
           "bVR5cGVJbnN0YW5jZQEBBwQBAQcE/////wcAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAQAq" +
           "AC8BAu0DACoAAAIAAAAAIwABAaUpACMAAQGoKQAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBAioALwEC" +
           "7QMCKgAABAAAAAAjAAEBqykAIwABAa4pACMAAQGxKQAjAAEBtCkAAAAABGCACgEAAAABABMAAABBY3F1" +
           "aXNpdGlvblNldHRpbmdzAQEEKgAvAQLtAwQqAAABAAAAACMAAQG3KQAAAAAEYIAKAQAAAAEAEQAAAEFj" +
           "cXVpc2l0aW9uU3RhdHVzAQEGKgAvAQLtAwYqAAAEAAAAACMAAQG9KQAjAAEBwCkAIwABAcMpACMAAQHH" +
           "KQAAAAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBCCoALwEC7QMIKgAABgAAAAAjAAEByikA" +
           "IwABAdApACMAAQHTKQAjAAEB1ikAIwABAdkpACMAAQHcKQAAAAAEYIAKAQAAAAEAGAAAAENoZW1vbWV0" +
           "cmljTW9kZWxTZXR0aW5ncwEBCioALwEC7QMKKgAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRleHQB" +
           "AQwqAC8BAu0DDCoAAAsAAAAAIwABAd8pACMAAQHiKQAjAAEB5SkAIwABAegpACMAAQHrKQAjAAEB7ikA" +
           "IwABAfEpACMAAQH0KQAjAAEB9ykAIwABAfopACMAAQH9KQAAAAA=";
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

    #region ParticleSizeMonitorDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_ParticleSizeMonitorDeviceStreamState)
    /// <summary>
    /// Stores an instance of the ParticleSizeMonitorDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ParticleSizeMonitorDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ParticleSizeMonitorDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQArAAAAUGFydGljbGVTaXplTW9uaXRvckRldmljZVN0" +
           "cmVhbVR5cGVJbnN0YW5jZQEBCAQBAQgE/////wgAAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEB" +
           "ECoDAAAAABcAAABGbGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADoQKgAA/////w4AAAA1YIkKAgAAAAEA" +
           "CQAAAElzRW5hYmxlZAEBJioDAAAAADUAAABUcnVlIGlmIHRoaXMgc3RyZWFtIG1heWJlIHVzZWQgdG8g" +
           "cGVyZm9ybSBhY3F1aXNpdGlvbgAvAQA9CSYqAAAAAf////8BAQEAAAAAIwEBAYEqAAAAADVgiQoCAAAA" +
           "AQAQAAAARGlhZ25vc3RpY1N0YXR1cwEBLCoDAAAAABQAAABTdHJlYW0gaGVhbHRoIHN0YXR1cwAvAQA9" +
           "CSwqAAABAmQY/////wEBAQAAAAAjAQEBgyoAAAAANWCJCgIAAAABAA4AAABMYXN0U2FtcGxlVGltZQEB" +
           "NSoDAAAAACoAAABUaW1lIGF0IHdoaWNoIHRoZSBsYXN0IHNhbXBsZSB3YXMgYWNxdWlyZWQALwEAPQk1" +
           "KgAAAA3/////AQEBAAAAACMBAQGDKgAAAAA1YIkKAgAAAAEACAAAAElzQWN0aXZlAQE+KgMAAAAANwAA" +
           "AFRydWUgaWYgdGhpcyBzdHJlYW0gaXMgYWN0dWFsbHkgcnVubmluZywgYWNxdWlyaW5nIGRhdGEALwEA" +
           "PQk+KgAAAAH/////AQEBAAAAACMBAQGHKgAAAAA1YIkKAgAAAAEADgAAAEV4ZWN1dGlvbkN5Y2xlAQFB" +
           "KgMAAAAALgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgaXMgaW4gcHJvZ3Jlc3MALwEA" +
           "PQlBKgAAAQGiJP////8BAQEAAAAAIwEBAYcqAAAAADVgiQoCAAAAAQAVAAAARXhlY3V0aW9uQ3ljbGVT" +
           "dWJjb2RlAQFEKgMAAAAANgAAAEluZGljYXRlcyB3aGljaCBFeGVjdXRpb24gY3ljbGUgc3ViY29kZSBp" +
           "cyBpbiBwcm9ncmVzcwAvAQBICUQqAAAAHP////8BAQEAAAAAIwEBAYcqAQAAABVgiQoCAAAAAAALAAAA" +
           "RW51bVN0cmluZ3MBAUcqAC4AREcqAAAAFQEAAAABAf////8AAAAANWCJCgIAAAABAAgAAABQcm9ncmVz" +
           "cwEBSCoDAAAAAHQAAABJbmRpY2F0ZXMgdGhlIHByb2dyZXNzIG9mIGFuIGFjcXVpc2l0aW9uIGluIHRl" +
           "cm1zIG9mIHBlcmNlbnRhZ2Ugb2YgY29tcGxldGlvbi4gSXRzIHZhbHVlIHNoYWxsIGJlIGJldHdlZW4g" +
           "MCBhbmQgMTAwLgAvAQA9CUgqAAAACv////8BAQEAAAAAIwEBAYcqAAAAADVgiQoCAAAAAQASAAAAQWNx" +
           "dWlzaXRpb25Db3VudGVyAQFLKgMAAAAAUwAAAFNpbXBsZSBjb3VudGVyIGluY3JlbWVudGVkIGFmdGVy" +
           "IGVhY2ggU2FtcGxpbmcgYWNxdWlzaXRpb24gcGVyZm9ybWVkIG9uIHRoaXMgU3RyZWFtAC8BAEAJSyoA" +
           "AAEAIQH/////AQEBAAAAACMBAQGJKgEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAU8qAC4ARE8qAAAB" +
           "AHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEFjcXVpc2l0aW9uUmVzdWx0U3RhdHVzAQFRKgMA" +
           "AAAAGgAAAFF1YWxpdHkgb2YgdGhlIGFjcXVpc2l0aW9uAC8BAD0JUSoAAAEBuwv/////AQEBAAAAACMB" +
           "AQGJKgAAAAA1YIkKAgAAAAEACgAAAFNjYWxlZERhdGEBAVcqAwAAAABoAAAAU2NhbGVkIGRhdGEgcHJv" +
           "ZHVjZWQgYXMgYSByZXN1bHQgb2YgZGF0YSBhY3F1aXNpdGlvbiBvbiB0aGUgU3RyZWFtIGFuZCBhcHBs" +
           "aWNhdGlvbiBvZiB0aGUgYW5hbHlzZXIgbW9kZWwALwEAPQlXKgAAABj/////AQEBAAAAACMBAQGJKgAA" +
           "AAA1YIkKAgAAAAEAEgAAAEFjcXVpc2l0aW9uRW5kVGltZQEBXSoDAAAAAKcAAABUaGUgZW5kIHRpbWUg" +
           "b2YgdGhlIEFuYWx5c2VTYW1wbGUgb3IgQW5hbHlzZUNhbGlicmF0aW9uU2FtcGxlIG9yIEFuYWx5c2VW" +
           "YWxpZGF0aW9uU2FtcGxlIHN0YXRlIG9mIHRoZSBBbmFseXNlckNoYW5uZWxfT3BlcmF0aW5nTW9kZUV4" +
           "ZWN1dGVTdWJTdGF0ZU1hY2hpbmUgc3RhdGUgbWFjaGluZQAvAQA9CV0qAAAADf////8BAQEAAAAAIwEB" +
           "AYkqAAAAABVgiQoCAAAAAQAKAAAAQmFja2dyb3VuZAEBkSoALwEA/S6RKgAAAAr/////AQEBAAAAACMB" +
           "AQGJKgUAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZUqAC4ARJUqAAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAZYqAC4ARJYqAAABAHcD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABQAAAFRpdGxlAQGXKgAuAESXKgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "QXhpc1NjYWxlVHlwZQEBmCoALgBEmCoAAAEALS//////AQH/////AAAAABVgiQoCAAAAAAAPAAAAWEF4" +
           "aXNEZWZpbml0aW9uAQGZKgAuAESZKgAAAQAvL/////8BAf////8AAAAAFWCJCgIAAAABABAAAABTaXpl" +
           "RGlzdHJpYnV0aW9uAQGaKgAvAQD9LpoqAAAACv////8BAQEAAAAAIwEBAYkqBQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBnioALgBEnioAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwEBnyoALgBEnyoAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAAAFAAAAVGl0bGUB" +
           "AaAqAC4ARKAqAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABBeGlzU2NhbGVUeXBlAQGhKgAu" +
           "AEShKgAAAQAtL/////8BAf////8AAAAAFWCJCgIAAAAAAA8AAABYQXhpc0RlZmluaXRpb24BAaIqAC4A" +
           "RKIqAAABAC8v/////wEB/////wAAAAAVYIkKAgAAAAEAGQAAAEJhY2tncm91bmRBY3F1aXNpdGlvblRp" +
           "bWUBAaMqAC8BAD0JoyoAAAAN/////wEBAQAAAAAjAQEBiSoAAAAABGCACgEAAAABAA0AAABDb25maWd1" +
           "cmF0aW9uAQGBKgAvAQLtA4EqAAACAAAAACMAAQEmKgAjAAEBKSoAAAAABGCACgEAAAABAAYAAABTdGF0" +
           "dXMBAYMqAC8BAu0DgyoAAAQAAAAAIwABASwqACMAAQEvKgAjAAEBMioAIwABATUqAAAAAARggAoBAAAA" +
           "AQATAAAAQWNxdWlzaXRpb25TZXR0aW5ncwEBhSoALwEC7QOFKgAAAQAAAAAjAAEBOCoAAAAABGCACgEA" +
           "AAABABEAAABBY3F1aXNpdGlvblN0YXR1cwEBhyoALwEC7QOHKgAABAAAAAAjAAEBPioAIwABAUEqACMA" +
           "AQFEKgAjAAEBSCoAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAYkqAC8BAu0DiSoAAAkA" +
           "AAAAIwABAUsqACMAAQFRKgAjAAEBVCoAIwABAVcqACMAAQFaKgAjAAEBXSoAIwABAZEqACMAAQGaKgAj" +
           "AAEBoyoAAAAABGCACgEAAAABABgAAABDaGVtb21ldHJpY01vZGVsU2V0dGluZ3MBAYsqAC8BAu0DiyoA" +
           "AP////8AAAAABGCACgEAAAABAAcAAABDb250ZXh0AQGNKgAvAQLtA40qAAALAAAAACMAAQFgKgAjAAEB" +
           "YyoAIwABAWYqACMAAQFpKgAjAAEBbCoAIwABAW8qACMAAQFyKgAjAAEBdSoAIwABAXgqACMAAQF7KgAj" +
           "AAEBfioAAAAA";
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

    #region AcousticSpectrometerDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_AcousticSpectrometerDeviceStreamState)
    /// <summary>
    /// Stores an instance of the AcousticSpectrometerDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcousticSpectrometerDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AcousticSpectrometerDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAsAAAAQWNvdXN0aWNTcGVjdHJvbWV0ZXJEZXZpY2VT" +
           "dHJlYW1UeXBlSW5zdGFuY2UBAQkEAQEJBP////8HAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9u" +
           "AQEXKwAvAQLtAxcrAAACAAAAACMAAQG8KgAjAAEBvyoAAAAABGCACgEAAAABAAYAAABTdGF0dXMBARkr" +
           "AC8BAu0DGSsAAAQAAAAAIwABAcIqACMAAQHFKgAjAAEByCoAIwABAcsqAAAAAARggAoBAAAAAQATAAAA" +
           "QWNxdWlzaXRpb25TZXR0aW5ncwEBGysALwEC7QMbKwAAAQAAAAAjAAEBzioAAAAABGCACgEAAAABABEA" +
           "AABBY3F1aXNpdGlvblN0YXR1cwEBHSsALwEC7QMdKwAABAAAAAAjAAEB1CoAIwABAdcqACMAAQHaKgAj" +
           "AAEB3ioAAAAABGCACgEAAAABAA8AAABBY3F1aXNpdGlvbkRhdGEBAR8rAC8BAu0DHysAAAYAAAAAIwAB" +
           "AeEqACMAAQHnKgAjAAEB6ioAIwABAe0qACMAAQHwKgAjAAEB8yoAAAAABGCACgEAAAABABgAAABDaGVt" +
           "b21ldHJpY01vZGVsU2V0dGluZ3MBASErAC8BAu0DISsAAP////8AAAAABGCACgEAAAABAAcAAABDb250" +
           "ZXh0AQEjKwAvAQLtAyMrAAALAAAAACMAAQH2KgAjAAEB+SoAIwABAfwqACMAAQH/KgAjAAEBAisAIwAB" +
           "AQUrACMAAQEIKwAjAAEBCysAIwABAQ4rACMAAQERKwAjAAEBFCsAAAAA";
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

    #region ChromatographDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_ChromatographDeviceStreamState)
    /// <summary>
    /// Stores an instance of the ChromatographDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChromatographDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChromatographDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQ2hyb21hdG9ncmFwaERldmljZVN0cmVhbVR5" +
           "cGVJbnN0YW5jZQEBCgQBAQoE/////wcAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAZgrAC8B" +
           "Au0DmCsAAAIAAAAAIwABAT0rACMAAQFAKwAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBmisALwEC7QOa" +
           "KwAABAAAAAAjAAEBQysAIwABAUYrACMAAQFJKwAjAAEBTCsAAAAABGCACgEAAAABABMAAABBY3F1aXNp" +
           "dGlvblNldHRpbmdzAQGcKwAvAQLtA5wrAAABAAAAACMAAQFPKwAAAAAEYIAKAQAAAAEAEQAAAEFjcXVp" +
           "c2l0aW9uU3RhdHVzAQGeKwAvAQLtA54rAAAEAAAAACMAAQFVKwAjAAEBWCsAIwABAVsrACMAAQFfKwAA" +
           "AAAEYIAKAQAAAAEADwAAAEFjcXVpc2l0aW9uRGF0YQEBoCsALwEC7QOgKwAABgAAAAAjAAEBYisAIwAB" +
           "AWgrACMAAQFrKwAjAAEBbisAIwABAXErACMAAQF0KwAAAAAEYIAKAQAAAAEAGAAAAENoZW1vbWV0cmlj" +
           "TW9kZWxTZXR0aW5ncwEBoisALwEC7QOiKwAA/////wAAAAAEYIAKAQAAAAEABwAAAENvbnRleHQBAaQr" +
           "AC8BAu0DpCsAAAsAAAAAIwABAXcrACMAAQF6KwAjAAEBfSsAIwABAYArACMAAQGDKwAjAAEBhisAIwAB" +
           "AYkrACMAAQGMKwAjAAEBjysAIwABAZIrACMAAQGVKwAAAAA=";
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

    #region MNRDeviceStreamState Class
    #if (!OPCUA_EXCLUDE_MNRDeviceStreamState)
    /// <summary>
    /// Stores an instance of the MNRDeviceStreamType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MNRDeviceStreamState : StreamState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MNRDeviceStreamState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MNRDeviceStreamType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAbAAAATU5SRGV2aWNlU3RyZWFtVHlwZUluc3RhbmNl" +
           "AQELBAEBCwT/////BwAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBGSwALwEC7QMZLAAAAgAA" +
           "AAAjAAEBvisAIwABAcErAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQEbLAAvAQLtAxssAAAEAAAAACMA" +
           "AQHEKwAjAAEBxysAIwABAcorACMAAQHNKwAAAAAEYIAKAQAAAAEAEwAAAEFjcXVpc2l0aW9uU2V0dGlu" +
           "Z3MBAR0sAC8BAu0DHSwAAAEAAAAAIwABAdArAAAAAARggAoBAAAAAQARAAAAQWNxdWlzaXRpb25TdGF0" +
           "dXMBAR8sAC8BAu0DHywAAAQAAAAAIwABAdYrACMAAQHZKwAjAAEB3CsAIwABAeArAAAAAARggAoBAAAA" +
           "AQAPAAAAQWNxdWlzaXRpb25EYXRhAQEhLAAvAQLtAyEsAAAGAAAAACMAAQHjKwAjAAEB6SsAIwABAewr" +
           "ACMAAQHvKwAjAAEB8isAIwABAfUrAAAAAARggAoBAAAAAQAYAAAAQ2hlbW9tZXRyaWNNb2RlbFNldHRp" +
           "bmdzAQEjLAAvAQLtAyMsAAD/////AAAAAARggAoBAAAAAQAHAAAAQ29udGV4dAEBJSwALwEC7QMlLAAA" +
           "CwAAAAAjAAEB+CsAIwABAfsrACMAAQH+KwAjAAEBASwAIwABAQQsACMAAQEHLAAjAAEBCiwAIwABAQ0s" +
           "ACMAAQEQLAAjAAEBEywAIwABARYsAAAAAA==";
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

    #region SpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_SpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the SpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAeAAAAU3BlY3Ryb21ldGVyRGV2aWNlVHlwZUluc3Rh" +
           "bmNlAQHzAwEB8wMB/////w8AAAAkYIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEBKSwDAAAAABcAAABG" +
           "bGF0IGxpc3Qgb2YgUGFyYW1ldGVycwAvADopLAAA/////wIAAAA1YIkKAgAAAAEAEAAAAERpYWdub3N0" +
           "aWNTdGF0dXMBAXgsAwAAAAAlAAAAR2VuZXJhbCBoZWFsdGggc3RhdHVzIG9mIHRoZSBhbmFseXNlcgAv" +
           "AQA9CXgsAAABAmQY/////wEBAQAAAAAjAQEBkSwAAAAAFWCJCgIAAAABAA0AAABTcGVjdHJhbFJhbmdl" +
           "AQEfLQAvAQA9CR8tAAABAHQDAQAAAAEB/////wAAAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEBKywD" +
           "AAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADorLAAA/////woAAAAEYYIKBAAAAAEAEAAAAEdl" +
           "dENvbmZpZ3VyYXRpb24BAWgsAC8BAeMkaCwAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBaSwALgBEaSwAAJYBAAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAARhggoEAAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBaiwALwEB5SRqLAAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWssAC4ARGssAACWAQAAAAEAKgEB" +
           "GQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBbCwALgBEbCwAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdl" +
           "c3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0YURp" +
           "Z2VzdAEBbSwALwEB6CRtLAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFu" +
           "LAAuAERuLAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABABcAAABDb21wYXJlQ29uZmlnRGF0YURpZ2VzdAEBbywALwEB6iRv" +
           "LAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXAsAC4ARHAsAACWAQAAAAEA" +
           "KgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBcSwALgBEcSwAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1" +
           "YWwAAf////8AAAAAAAEAKAEBAAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAUmVzZXRBbGxDaGFubmVs" +
           "cwEBciwDAAAAADwAAABSZXNldCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBB" +
           "bmFseXNlckRldmljZS4ALwEB7SRyLAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFu" +
           "bmVscwEBcywDAAAAADwAAABTdGFydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhp" +
           "cyBBbmFseXNlckRldmljZS4ALwEB7iRzLAAAAQH/////AAAAACRhggoEAAAAAQAPAAAAU3RvcEFsbENo" +
           "YW5uZWxzAQF0LAMAAAAAOwAAAFN0b3AgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRo" +
           "aXMgQW5hbHlzZXJEZXZpY2UuAC8BAe8kdCwAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAEFib3J0QWxs" +
           "Q2hhbm5lbHMBAXUsAwAAAAA8AAAAQWJvcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRv" +
           "IHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAfAkdSwAAAEB/////wAAAAAkYYIKBAAAAAEADQAAAEdvdG9P" +
           "cGVyYXRpbmcBAXYsAwAAAACNAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3Bl" +
           "cmF0aW5nIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2" +
           "ZU1vZGUgc3RhdGUgYW5kIGdvIHRvIHRoZSBPcGVyYXRpbmcgc3RhdGUuAC8BAfEkdiwAAAEB/////wAA" +
           "AAAkYYIKBAAAAAEADwAAAEdvdG9NYWludGVuYW5jZQEBdywDAAAAAGcAAABBbmFseXNlckRldmljZVN0" +
           "YXRlTWFjaGluZSB0byBnbyB0byBNYWludGVuYW5jZSBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJD" +
           "aGFubmVscyB0byBTbGF2ZU1vZGUgc3RhdGUuAC8BAfIkdywAAAEB/////wAAAAAkYIAKAQAAAAIADgAA" +
           "AElkZW50aWZpY2F0aW9uAQEvLAMAAAAARgAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3Ig" +
           "aWRlbnRpZmljYXRpb24gb2YgdGhpcyBUb3BvbG9neUVsZW1lbnQALwEC7QMvLAAAAwAAAAAjAAECcxcA" +
           "IwABAnQXACMAAQJxFwAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBPywDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQ/LAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQFALAMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAERALAAAAAb/////AQH/////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQFBLAMA" +
           "AAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAERBLAAAABX/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAFAAAATW9kZWwBAUIsAwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0" +
           "dXJlZCB0aGUgZGV2aWNlAC4AREIsAAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VN" +
           "YW51YWwBAUMsAwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEg" +
           "VVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4AREMsAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBRCwDAAAAACQAAABPdmVyYWxs" +
           "IHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBERCwAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAFNvZnR3YXJlUmV2aXNpb24BAUUsAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNv" +
           "ZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBERSwAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAUYsAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhh" +
           "cmR3YXJlIG9mIHRoZSBkZXZpY2UALgBERiwAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAENv" +
           "bmZpZ3VyYXRpb24BAY8sAC8BAu0DjywAAAEAAAAAIwABAXssAAAAAARggAoBAAAAAQAGAAAAU3RhdHVz" +
           "AQGRLAAvAQLtA5EsAAABAAAAACMAAQF4LAAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlTZXR0aW5ncwEB" +
           "kywALwEC7QOTLAAA/////wAAAAAEYIAKAQAAAAEAFAAAAEFuYWx5c2VyU3RhdGVNYWNoaW5lAQGVLAAv" +
           "AQHqA5UsAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGWLAAvAQDICpYsAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBlywALgBElywAAAAR/////wEB/////wAAAAA=";
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

    #region ParticleSizeMonitorDeviceState Class
    #if (!OPCUA_EXCLUDE_ParticleSizeMonitorDeviceState)
    /// <summary>
    /// Stores an instance of the ParticleSizeMonitorDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ParticleSizeMonitorDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ParticleSizeMonitorDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ParticleSizeMonitorDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAlAAAAUGFydGljbGVTaXplTW9uaXRvckRldmljZVR5" +
           "cGVJbnN0YW5jZQEB9AMBAfQDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBASQtAwAAAAAU" +
           "AAAARmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6JC0AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25m" +
           "aWd1cmF0aW9uAQFhLQAvAQHjJGEtAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAWItAC4ARGItAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAWMtAC8BAeUkYy0AAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFkLQAuAERkLQAAlgEAAAABACoBARkAAAAK" +
           "AAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAWUtAC4ARGUtAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QB" +
           "AWYtAC8BAegkZi0AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBZy0ALgBE" +
           "Zy0AAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAWgtAC8BAeokaC0AAAEB" +
           "/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFpLQAuAERpLQAAlgEAAAABACoBAR8A" +
           "AAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAWotAC4ARGotAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWst" +
           "AwAAAAA8AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlz" +
           "ZXJEZXZpY2UuAC8BAe0kay0AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMB" +
           "AWwtAwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5h" +
           "bHlzZXJEZXZpY2UuAC8BAe4kbC0AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVs" +
           "cwEBbS0DAAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHvJG0tAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5u" +
           "ZWxzAQFuLQMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlz" +
           "IEFuYWx5c2VyRGV2aWNlLgAvAQHwJG4tAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0" +
           "aW5nAQFvLQMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGlu" +
           "ZyBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2Rl" +
           "IHN0YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJG8tAAABAf////8AAAAAJGGC" +
           "CgQAAAABAA8AAABHb3RvTWFpbnRlbmFuY2UBAXAtAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1h" +
           "Y2hpbmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5l" +
           "bHMgdG8gU2xhdmVNb2RlIHN0YXRlLgAvAQHyJHAtAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVu" +
           "dGlmaWNhdGlvbgEBKC0DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50" +
           "aWZpY2F0aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DKC0AAAMAAAAAIwABAnMXACMAAQJ0" +
           "FwAjAAECcRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBATgtAwAAAABNAAAASWRlbnRpZmll" +
           "ciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2Ug" +
           "aW5zdGFuY2UALgBEOC0AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRl" +
           "cgEBOS0DAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBv" +
           "ZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQA" +
           "LgBEOS0AAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBOi0DAAAAABgA" +
           "AABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEOi0AAAAV/////wEB/////wAAAAA1YIkKAgAAAAIA" +
           "BQAAAE1vZGVsAQE7LQMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQg" +
           "dGhlIGRldmljZQAuAEQ7LQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFs" +
           "AQE8LQMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8" +
           "IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQ8LQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAT0tAwAAAAAkAAAAT3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARD0tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABTb2Z0d2FyZVJldmlzaW9uAQE+LQMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2Fy" +
           "ZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARD4tAAAADP////8BAf////8AAAAANWCJCgIAAAACABAA" +
           "AABIYXJkd2FyZVJldmlzaW9uAQE/LQMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2Fy" +
           "ZSBvZiB0aGUgZGV2aWNlAC4ARD8tAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1" +
           "cmF0aW9uAQGILQAvAQLtA4gtAAABAAAAACMAAQF0LQAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBii0A" +
           "LwEC7QOKLQAAAQAAAAAjAAEBcS0AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYwtAC8B" +
           "Au0DjC0AAP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBji0ALwEB6gOO" +
           "LQAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBjy0ALwEAyAqPLQAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAZAtAC4ARJAtAAAAEf////8BAf////8AAAAA";
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

    #region ChromatographDeviceState Class
    #if (!OPCUA_EXCLUDE_ChromatographDeviceState)
    /// <summary>
    /// Stores an instance of the ChromatographDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChromatographDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChromatographDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.ChromatographDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAfAAAAQ2hyb21hdG9ncmFwaERldmljZVR5cGVJbnN0" +
           "YW5jZQEB9QMBAfUDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBARouAwAAAAAUAAAARmxh" +
           "dCBsaXN0IG9mIE1ldGhvZHMALwA6Gi4AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25maWd1cmF0" +
           "aW9uAQFXLgAvAQHjJFcuAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVgu" +
           "AC4ARFguAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAVkuAC8BAeUkWS4AAAEB/////wIAAAAV" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFaLgAuAERaLgAAlgEAAAABACoBARkAAAAKAAAAQ29u" +
           "ZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAVsuAC4ARFsuAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAVwuAC8B" +
           "AegkXC4AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBXS4ALgBEXS4AAJYB" +
           "AAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAV4uAC8BAeokXi4AAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFfLgAuAERfLgAAlgEAAAABACoBAR8AAAAQAAAA" +
           "Q29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAWAuAC4ARGAuAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////AAAA" +
           "AAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAWEuAwAAAAA8" +
           "AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZp" +
           "Y2UuAC8BAe0kYS4AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAWIuAwAA" +
           "AAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJE" +
           "ZXZpY2UuAC8BAe4kYi4AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEBYy4D" +
           "AAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2Vy" +
           "RGV2aWNlLgAvAQHvJGMuAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxzAQFk" +
           "LgMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHwJGQuAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5nAQFl" +
           "LgMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0" +
           "ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRl" +
           "IGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJGUuAAABAf////8AAAAAJGGCCgQAAAAB" +
           "AA8AAABHb3RvTWFpbnRlbmFuY2UBAWYuAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUg" +
           "dG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8g" +
           "U2xhdmVNb2RlIHN0YXRlLgAvAQHyJGYuAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlmaWNh" +
           "dGlvbgEBHi4DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0" +
           "aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DHi4AAAMAAAAAIwABAnMXACMAAQJ0FwAjAAEC" +
           "cRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAS4uAwAAAABNAAAASWRlbnRpZmllciB0aGF0" +
           "IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFu" +
           "Y2UALgBELi4AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEBLy4D" +
           "AAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1l" +
           "cyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBELy4A" +
           "AAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBMC4DAAAAABgAAABNb2Rl" +
           "bCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEMC4AAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1v" +
           "ZGVsAQExLgMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRl" +
           "dmljZQAuAEQxLgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEyLgMA" +
           "AAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBh" +
           "ZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQyLgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BATMuAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgZGV2aWNlAC4ARDMuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0" +
           "d2FyZVJldmlzaW9uAQE0LgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJt" +
           "d2FyZSBvZiB0aGUgZGV2aWNlAC4ARDQuAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJk" +
           "d2FyZVJldmlzaW9uAQE1LgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARDUuAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9u" +
           "AQF+LgAvAQLtA34uAAABAAAAACMAAQFqLgAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBgC4ALwEC7QOA" +
           "LgAAAQAAAAAjAAEBZy4AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAYIuAC8BAu0Dgi4A" +
           "AP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBhC4ALwEB6gOELgAA////" +
           "/wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBhS4ALwEAyAqFLgAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAYYuAC4ARIYuAAAAEf////8BAf////8AAAAA";
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

    #region MassSpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_MassSpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the MassSpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassSpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassSpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.MassSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAiAAAATWFzc1NwZWN0cm9tZXRlckRldmljZVR5cGVJ" +
           "bnN0YW5jZQEB9gMBAfYDAf////8OAAAAJGCACgEAAAACAAkAAABNZXRob2RTZXQBARAvAwAAAAAUAAAA" +
           "RmxhdCBsaXN0IG9mIE1ldGhvZHMALwA6EC8AAP////8KAAAABGGCCgQAAAABABAAAABHZXRDb25maWd1" +
           "cmF0aW9uAQFNLwAvAQHjJE0vAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AU4vAC4ARE4vAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAEAAAAFNldENvbmZpZ3VyYXRpb24BAU8vAC8BAeUkTy8AAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFQLwAuAERQLwAAlgEAAAABACoBARkAAAAKAAAA" +
           "Q29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAVEvAC4ARFEvAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAEdldENvbmZpZ0RhdGFEaWdlc3QBAVIv" +
           "AC8BAegkUi8AAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBUy8ALgBEUy8A" +
           "AJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////" +
           "AAAAAARhggoEAAAAAQAXAAAAQ29tcGFyZUNvbmZpZ0RhdGFEaWdlc3QBAVQvAC8BAeokVC8AAAEB////" +
           "/wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFVLwAuAERVLwAAlgEAAAABACoBAR8AAAAQ" +
           "AAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAVYvAC4ARFYvAACWAQAAAAEAKgEBFgAAAAcAAABJc0VxdWFsAAH/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAVcvAwAA" +
           "AAA8AAAAUmVzZXQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJE" +
           "ZXZpY2UuAC8BAe0kVy8AAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAVgv" +
           "AwAAAAA8AAAAU3RhcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlz" +
           "ZXJEZXZpY2UuAC8BAe4kWC8AAAEB/////wAAAAAkYYIKBAAAAAEADwAAAFN0b3BBbGxDaGFubmVscwEB" +
           "WS8DAAAAADsAAABTdG9wIGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHvJFkvAAABAf////8AAAAAJGGCCgQAAAABABAAAABBYm9ydEFsbENoYW5uZWxz" +
           "AQFaLwMAAAAAPAAAAEFib3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHwJFovAAABAf////8AAAAAJGGCCgQAAAABAA0AAABHb3RvT3BlcmF0aW5n" +
           "AQFbLwMAAAAAjQAAAEFuYWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBz" +
           "dGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0" +
           "YXRlIGFuZCBnbyB0byB0aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQHxJFsvAAABAf////8AAAAAJGGCCgQA" +
           "AAABAA8AAABHb3RvTWFpbnRlbmFuY2UBAVwvAwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hp" +
           "bmUgdG8gZ28gdG8gTWFpbnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMg" +
           "dG8gU2xhdmVNb2RlIHN0YXRlLgAvAQHyJFwvAAABAf////8AAAAAJGCACgEAAAACAA4AAABJZGVudGlm" +
           "aWNhdGlvbgEBFC8DAAAAAEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZp" +
           "Y2F0aW9uIG9mIHRoaXMgVG9wb2xvZ3lFbGVtZW50AC8BAu0DFC8AAAMAAAAAIwABAnMXACMAAQJ0FwAj" +
           "AAECcRcAAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBASQvAwAAAABNAAAASWRlbnRpZmllciB0" +
           "aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5z" +
           "dGFuY2UALgBEJC8AAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB" +
           "JS8DAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0" +
           "aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE" +
           "JS8AAAAG/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBJi8DAAAAABgAAABN" +
           "b2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEJi8AAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAA" +
           "AE1vZGVsAQEnLwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhl" +
           "IGRldmljZQAuAEQnLwAAABX/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQEo" +
           "LwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdl" +
           "YiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAEQoLwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BASkvAwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lv" +
           "biBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARCkvAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABT" +
           "b2Z0d2FyZVJldmlzaW9uAQEqLwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9m" +
           "aXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARCovAAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABI" +
           "YXJkd2FyZVJldmlzaW9uAQErLwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBv" +
           "ZiB0aGUgZGV2aWNlAC4ARCsvAAAADP////8BAf////8AAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0" +
           "aW9uAQF0LwAvAQLtA3QvAAABAAAAACMAAQFgLwAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBdi8ALwEC" +
           "7QN2LwAAAQAAAAAjAAEBXS8AAAAABGCACgEAAAABAA8AAABGYWN0b3J5U2V0dGluZ3MBAXgvAC8BAu0D" +
           "eC8AAP////8AAAAABGCACgEAAAABABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBei8ALwEB6gN6LwAA" +
           "/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBey8ALwEAyAp7LwAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAXwvAC4ARHwvAAAAEf////8BAf////8AAAAA";
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

    #region AcousticSpectrometerDeviceState Class
    #if (!OPCUA_EXCLUDE_AcousticSpectrometerDeviceState)
    /// <summary>
    /// Stores an instance of the AcousticSpectrometerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcousticSpectrometerDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AcousticSpectrometerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AcousticSpectrometerDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAmAAAAQWNvdXN0aWNTcGVjdHJvbWV0ZXJEZXZpY2VU" +
           "eXBlSW5zdGFuY2UBAfcDAQH3AwH/////DgAAACRggAoBAAAAAgAJAAAATWV0aG9kU2V0AQEGMAMAAAAA" +
           "FAAAAEZsYXQgbGlzdCBvZiBNZXRob2RzAC8AOgYwAAD/////CgAAAARhggoEAAAAAQAQAAAAR2V0Q29u" +
           "ZmlndXJhdGlvbgEBQzAALwEB4yRDMAAAAQH/////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQFEMAAuAEREMAAAlgEAAAABACoBARkAAAAKAAAAQ29uZmlnRGF0YQAP/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABABAAAABTZXRDb25maWd1cmF0aW9uAQFFMAAvAQHlJEUwAAABAf//" +
           "//8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRjAALgBERjAAAJYBAAAAAQAqAQEZAAAA" +
           "CgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQFHMAAuAERHMAAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABABMAAABHZXRDb25maWdEYXRhRGlnZXN0" +
           "AQFIMAAvAQHoJEgwAAABAf////8BAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUkwAC4A" +
           "REkwAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAFwAAAENvbXBhcmVDb25maWdEYXRhRGlnZXN0AQFKMAAvAQHqJEowAAAB" +
           "Af////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBSzAALgBESzAAAJYBAAAAAQAqAQEf" +
           "AAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQFMMAAuAERMMAAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAJGGCCgQAAAABABAAAABSZXNldEFsbENoYW5uZWxzAQFN" +
           "MAMAAAAAPAAAAFJlc2V0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5" +
           "c2VyRGV2aWNlLgAvAQHtJE0wAAABAf////8AAAAAJGGCCgQAAAABABAAAABTdGFydEFsbENoYW5uZWxz" +
           "AQFOMAMAAAAAPAAAAFN0YXJ0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFu" +
           "YWx5c2VyRGV2aWNlLgAvAQHuJE4wAAABAf////8AAAAAJGGCCgQAAAABAA8AAABTdG9wQWxsQ2hhbm5l" +
           "bHMBAU8wAwAAAAA7AAAAU3RvcCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBB" +
           "bmFseXNlckRldmljZS4ALwEB7yRPMAAAAQH/////AAAAACRhggoEAAAAAQAQAAAAQWJvcnRBbGxDaGFu" +
           "bmVscwEBUDADAAAAADwAAABBYm9ydCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhp" +
           "cyBBbmFseXNlckRldmljZS4ALwEB8CRQMAAAAQH/////AAAAACRhggoEAAAAAQANAAAAR290b09wZXJh" +
           "dGluZwEBUTADAAAAAI0AAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBPcGVyYXRp" +
           "bmcgc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gbGVhdmUgdGhlIFNsYXZlTW9k" +
           "ZSBzdGF0ZSBhbmQgZ28gdG8gdGhlIE9wZXJhdGluZyBzdGF0ZS4ALwEB8SRRMAAAAQH/////AAAAACRh" +
           "ggoEAAAAAQAPAAAAR290b01haW50ZW5hbmNlAQFSMAMAAAAAZwAAAEFuYWx5c2VyRGV2aWNlU3RhdGVN" +
           "YWNoaW5lIHRvIGdvIHRvIE1haW50ZW5hbmNlIHN0YXRlLCBmb3JjaW5nIGFsbCBBbmFseXNlckNoYW5u" +
           "ZWxzIHRvIFNsYXZlTW9kZSBzdGF0ZS4ALwEB8iRSMAAAAQH/////AAAAACRggAoBAAAAAgAOAAAASWRl" +
           "bnRpZmljYXRpb24BAQowAwAAAABGAAAAVXNlZCB0byBvcmdhbml6ZSBwYXJhbWV0ZXJzIGZvciBpZGVu" +
           "dGlmaWNhdGlvbiBvZiB0aGlzIFRvcG9sb2d5RWxlbWVudAAvAQLtAwowAAADAAAAACMAAQJzFwAjAAEC" +
           "dBcAIwABAnEXAAAAADVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQEaMAMAAAAATQAAAElkZW50aWZp" +
           "ZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNl" +
           "IGluc3RhbmNlAC4ARBowAAAADP////8BAf////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50" +
           "ZXIBARswAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIg" +
           "b2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVk" +
           "AC4ARBswAAAABv////8BAf////8AAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIBARwwAwAAAAAY" +
           "AAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARBwwAAAAFf////8BAf////8AAAAANWCJCgIAAAAC" +
           "AAUAAABNb2RlbAEBHTADAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVk" +
           "IHRoZSBkZXZpY2UALgBEHTAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVh" +
           "bAEBHjADAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwg" +
           "fCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEHjAAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlzaW9uAQEfMAMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAEQfMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEBIDADAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAEQgMAAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQ" +
           "AAAASGFyZHdhcmVSZXZpc2lvbgEBITADAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdh" +
           "cmUgb2YgdGhlIGRldmljZQAuAEQhMAAAAAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29uZmln" +
           "dXJhdGlvbgEBajAALwEC7QNqMAAAAQAAAAAjAAEBVjAAAAAABGCACgEAAAABAAYAAABTdGF0dXMBAWww" +
           "AC8BAu0DbDAAAAEAAAAAIwABAVMwAAAAAARggAoBAAAAAQAPAAAARmFjdG9yeVNldHRpbmdzAQFuMAAv" +
           "AQLtA24wAAD/////AAAAAARggAoBAAAAAQAUAAAAQW5hbHlzZXJTdGF0ZU1hY2hpbmUBAXAwAC8BAeoD" +
           "cDAAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAXEwAC8BAMgKcTAAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFyMAAuAERyMAAAABH/////AQH/////AAAAAA==";
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

    #region NMRDeviceState Class
    #if (!OPCUA_EXCLUDE_NMRDeviceState)
    /// <summary>
    /// Stores an instance of the NMRDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NMRDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public NMRDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.NMRDeviceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////4RggAABAAAAAQAVAAAATk1SRGV2aWNlVHlwZUluc3RhbmNlAQH4AwEB" +
           "+AMB/////w4AAAAkYIAKAQAAAAIACQAAAE1ldGhvZFNldAEB/DADAAAAABQAAABGbGF0IGxpc3Qgb2Yg" +
           "TWV0aG9kcwAvADr8MAAA/////woAAAAEYYIKBAAAAAEAEAAAAEdldENvbmZpZ3VyYXRpb24BATkxAC8B" +
           "AeMkOTEAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOjEALgBEOjEAAJYB" +
           "AAAAAQAqAQEZAAAACgAAAENvbmZpZ0RhdGEAD/////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAQAAAAU2V0Q29uZmlndXJhdGlvbgEBOzEALwEB5SQ7MQAAAQH/////AgAAABVgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBATwxAC4ARDwxAACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPTEA" +
           "LgBEPTEAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAAARhggoEAAAAAQATAAAAR2V0Q29uZmlnRGF0YURpZ2VzdAEBPjEALwEB6CQ+MQAAAQH/" +
           "////AQAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE/MQAuAEQ/MQAAlgEAAAABACoBAR8A" +
           "AAAQAAAAQ29uZmlnRGF0YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAAB" +
           "ABcAAABDb21wYXJlQ29uZmlnRGF0YURpZ2VzdAEBQDEALwEB6iRAMQAAAQH/////AgAAABVgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAUExAC4AREExAACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRh" +
           "RGlnZXN0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBQjEALgBEQjEAAJYBAAAAAQAqAQEWAAAABwAAAElzRXF1YWwAAf////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAACRhggoEAAAAAQAQAAAAUmVzZXRBbGxDaGFubmVscwEBQzEDAAAAADwAAABSZXNldCBh" +
           "bGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB7SRD" +
           "MQAAAQH/////AAAAACRhggoEAAAAAQAQAAAAU3RhcnRBbGxDaGFubmVscwEBRDEDAAAAADwAAABTdGFy" +
           "dCBhbGwgQW5hbHlzZXJDaGFubmVscyBiZWxvbmdpbmcgdG8gdGhpcyBBbmFseXNlckRldmljZS4ALwEB" +
           "7iREMQAAAQH/////AAAAACRhggoEAAAAAQAPAAAAU3RvcEFsbENoYW5uZWxzAQFFMQMAAAAAOwAAAFN0" +
           "b3AgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8B" +
           "Ae8kRTEAAAEB/////wAAAAAkYYIKBAAAAAEAEAAAAEFib3J0QWxsQ2hhbm5lbHMBAUYxAwAAAAA8AAAA" +
           "QWJvcnQgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2Uu" +
           "AC8BAfAkRjEAAAEB/////wAAAAAkYYIKBAAAAAEADQAAAEdvdG9PcGVyYXRpbmcBAUcxAwAAAACNAAAA" +
           "QW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gT3BlcmF0aW5nIHN0YXRlLCBmb3JjaW5n" +
           "IGFsbCBBbmFseXNlckNoYW5uZWxzIHRvIGxlYXZlIHRoZSBTbGF2ZU1vZGUgc3RhdGUgYW5kIGdvIHRv" +
           "IHRoZSBPcGVyYXRpbmcgc3RhdGUuAC8BAfEkRzEAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAEdvdG9N" +
           "YWludGVuYW5jZQEBSDEDAAAAAGcAAABBbmFseXNlckRldmljZVN0YXRlTWFjaGluZSB0byBnbyB0byBN" +
           "YWludGVuYW5jZSBzdGF0ZSwgZm9yY2luZyBhbGwgQW5hbHlzZXJDaGFubmVscyB0byBTbGF2ZU1vZGUg" +
           "c3RhdGUuAC8BAfIkSDEAAAEB/////wAAAAAkYIAKAQAAAAIADgAAAElkZW50aWZpY2F0aW9uAQEAMQMA" +
           "AAAARgAAAFVzZWQgdG8gb3JnYW5pemUgcGFyYW1ldGVycyBmb3IgaWRlbnRpZmljYXRpb24gb2YgdGhp" +
           "cyBUb3BvbG9neUVsZW1lbnQALwEC7QMAMQAAAwAAAAAjAAECcxcAIwABAnQXACMAAQJxFwAAAAA1YIkK" +
           "AgAAAAIADAAAAFNlcmlhbE51bWJlcgEBEDEDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkg" +
           "aWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAEQQMQAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQERMQMAAAAAaQAAAEFu" +
           "IGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0" +
           "aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQRMQAAAAb/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQESMQMAAAAAGAAAAE1vZGVsIG5hbWUgb2Yg" +
           "dGhlIGRldmljZQAuAEQSMQAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBARMxAwAA" +
           "AAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARBMx" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBARQxAwAAAABaAAAAQWRk" +
           "cmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9m" +
           "IHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARBQxAAAADP////8BAf////8AAAAANWCJCgIAAAAC" +
           "AA4AAABEZXZpY2VSZXZpc2lvbgEBFTEDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRo" +
           "ZSBkZXZpY2UALgBEFTEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BARYxAwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRo" +
           "ZSBkZXZpY2UALgBEFjEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNp" +
           "b24BARcxAwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UA" +
           "LgBEFzEAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAWAxAC8BAu0D" +
           "YDEAAAEAAAAAIwABAUwxAAAAAARggAoBAAAAAQAGAAAAU3RhdHVzAQFiMQAvAQLtA2IxAAABAAAAACMA" +
           "AQFJMQAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlTZXR0aW5ncwEBZDEALwEC7QNkMQAA/////wAAAAAE" +
           "YIAKAQAAAAEAFAAAAEFuYWx5c2VyU3RhdGVNYWNoaW5lAQFmMQAvAQHqA2YxAAD/////AQAAABVgiQoC" +
           "AAAAAAAMAAAAQ3VycmVudFN0YXRlAQFnMQAvAQDICmcxAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBaDEALgBEaDEAAAAR/////wEB/////wAAAAA=";
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

    #region AccessorySlotState Class
    #if (!OPCUA_EXCLUDE_AccessorySlotState)
    /// <summary>
    /// Stores an instance of the AccessorySlotType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessorySlotState : ConfigurableObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessorySlotState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessorySlotType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAZAAAAQWNjZXNzb3J5U2xvdFR5cGVJbnN0YW5jZQEB" +
           "+QMBAfkD/////wQAAAAkYIAKAQAAAAIADgAAAFN1cHBvcnRlZFR5cGVzAQHwMQMAAAAAcgAAAEZvbGRl" +
           "ciBtYWludGFpbmluZyB0aGUgc2V0IG9mIChzdWItdHlwZXMgb2YpIEJhc2VPYmplY3RUeXBlcyB0aGF0" +
           "IGNhbiBiZSBpbnN0YW50aWF0ZWQgaW4gdGhlIENvbmZpZ3VyYWJsZUNvbXBvbmVudAAvAD3wMQAA////" +
           "/wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHyMQMAAAAATgAAAFRydWUgaWYgYW4gYWNj" +
           "ZXNzb3J5IGNhbiBiZSBpbnNlcnRlZCBpbiB0aGUgYWNjZXNzb3J5IHNsb3Qgd2hpbGUgaXQgaXMgcG93" +
           "ZXJlZAAuAETyMQAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAJAAAASXNFbmFibGVkAQHzMQMAAAAA" +
           "RgAAAFRydWUgaWYgdGhpcyBhY2Nlc3Nvcnkgc2xvdCBpcyBjYXBhYmxlIG9mIGFjY2VwdGluZyBhbiBh" +
           "Y2Nlc3NvcnkgaW4gaXQALgBE8zEAAAAB/////wEB/////wAAAAAEYIAKAQAAAAEAGQAAAEFjY2Vzc29y" +
           "eVNsb3RTdGF0ZU1hY2hpbmUBAfQxAC8BAfoD9DEAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50" +
           "U3RhdGUBAfUxAC8BAMgK9TEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQH2MQAuAET2" +
           "MQAAABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// True if an accessory can be inserted in the accessory slot while it is powered
        /// </summary>
        public PropertyState<bool> IsHotSwappable
        {
            get
            {
                return m_isHotSwappable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isHotSwappable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isHotSwappable = value;
            }
        }

        /// <summary>
        /// True if this accessory slot is capable of accepting an accessory in it
        /// </summary>
        public PropertyState<bool> IsEnabled
        {
            get
            {
                return m_isEnabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isEnabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isEnabled = value;
            }
        }

        /// <summary>
        /// A description for the AccessorySlotStateMachine Object.
        /// </summary>
        public AccessorySlotStateMachineState AccessorySlotStateMachine
        {
            get
            {
                return m_accessorySlotStateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accessorySlotStateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accessorySlotStateMachine = value;
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
            if (m_isHotSwappable != null)
            {
                children.Add(m_isHotSwappable);
            }

            if (m_isEnabled != null)
            {
                children.Add(m_isEnabled);
            }

            if (m_accessorySlotStateMachine != null)
            {
                children.Add(m_accessorySlotStateMachine);
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
                case Opc.Ua.Adi.BrowseNames.IsHotSwappable:
                {
                    if (createOrReplace)
                    {
                        if (IsHotSwappable == null)
                        {
                            if (replacement == null)
                            {
                                IsHotSwappable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsHotSwappable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsHotSwappable;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsEnabled:
                {
                    if (createOrReplace)
                    {
                        if (IsEnabled == null)
                        {
                            if (replacement == null)
                            {
                                IsEnabled = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsEnabled = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsEnabled;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AccessorySlotStateMachine:
                {
                    if (createOrReplace)
                    {
                        if (AccessorySlotStateMachine == null)
                        {
                            if (replacement == null)
                            {
                                AccessorySlotStateMachine = new AccessorySlotStateMachineState(this);
                            }
                            else
                            {
                                AccessorySlotStateMachine = (AccessorySlotStateMachineState)replacement;
                            }
                        }
                    }

                    instance = AccessorySlotStateMachine;
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
        private PropertyState<bool> m_isHotSwappable;
        private PropertyState<bool> m_isEnabled;
        private AccessorySlotStateMachineState m_accessorySlotStateMachine;
        #endregion
    }
    #endif
    #endregion

    #region AccessorySlotStateMachineState Class
    #if (!OPCUA_EXCLUDE_AccessorySlotStateMachineState)
    /// <summary>
    /// Stores an instance of the AccessorySlotStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessorySlotStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessorySlotStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessorySlotStateMachineType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAlAAAAQWNjZXNzb3J5U2xvdFN0YXRlTWFjaGluZVR5" +
           "cGVJbnN0YW5jZQEB+gMBAfoD/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBHTIALwEA" +
           "yAodMgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAR4yAC4ARB4yAAAAEf////8BAf//" +
           "//8AAAAA";
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

    #region AccessoryState Class
    #if (!OPCUA_EXCLUDE_AccessoryState)
    /// <summary>
    /// Stores an instance of the AccessoryType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccessoryState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccessoryState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.AccessoryType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAVAAAAQWNjZXNzb3J5VHlwZUluc3RhbmNlAQH7AwEB" +
           "+wP/////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBYjIALwEC7QNiMgAA/////wAAAAAE" +
           "YIAKAQAAAAEABgAAAFN0YXR1cwEBZDIALwEC7QNkMgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3Rv" +
           "cnlTZXR0aW5ncwEBZjIALwEC7QNmMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxl" +
           "AQFoMgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBh" +
           "Y2Nlc3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARGgyAAAAAf////8BAf////8AAAAANWCJ" +
           "CgIAAAABAAcAAABJc1JlYWR5AQFpMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVh" +
           "ZHkgZm9yIHVzZQAuAERpMgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        /// A description for the Status Object.
        /// </summary>
        public FunctionalGroupState Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <summary>
        /// A description for the FactorySettings Object.
        /// </summary>
        public FunctionalGroupState FactorySettings
        {
            get
            {
                return m_factorySettings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_factorySettings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_factorySettings = value;
            }
        }

        /// <summary>
        /// True if this accessory can be inserted in the accessory slot while it is powered
        /// </summary>
        public PropertyState<bool> IsHotSwappable
        {
            get
            {
                return m_isHotSwappable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isHotSwappable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isHotSwappable = value;
            }
        }

        /// <summary>
        /// True if this accessory is ready for use
        /// </summary>
        public PropertyState<bool> IsReady
        {
            get
            {
                return m_isReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isReady = value;
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
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_factorySettings != null)
            {
                children.Add(m_factorySettings);
            }

            if (m_isHotSwappable != null)
            {
                children.Add(m_isHotSwappable);
            }

            if (m_isReady != null)
            {
                children.Add(m_isReady);
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
                case Opc.Ua.Adi.BrowseNames.Configuration:
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

                case Opc.Ua.Adi.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Status = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.FactorySettings:
                {
                    if (createOrReplace)
                    {
                        if (FactorySettings == null)
                        {
                            if (replacement == null)
                            {
                                FactorySettings = new FunctionalGroupState(this);
                            }
                            else
                            {
                                FactorySettings = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = FactorySettings;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsHotSwappable:
                {
                    if (createOrReplace)
                    {
                        if (IsHotSwappable == null)
                        {
                            if (replacement == null)
                            {
                                IsHotSwappable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsHotSwappable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsHotSwappable;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.IsReady:
                {
                    if (createOrReplace)
                    {
                        if (IsReady == null)
                        {
                            if (replacement == null)
                            {
                                IsReady = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsReady = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsReady;
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
        private FunctionalGroupState m_configuration;
        private FunctionalGroupState m_status;
        private FunctionalGroupState m_factorySettings;
        private PropertyState<bool> m_isHotSwappable;
        private PropertyState<bool> m_isReady;
        #endregion
    }
    #endif
    #endregion

    #region DetectorState Class
    #if (!OPCUA_EXCLUDE_DetectorState)
    /// <summary>
    /// Stores an instance of the DetectorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DetectorState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DetectorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.DetectorType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAUAAAARGV0ZWN0b3JUeXBlSW5zdGFuY2UBAYYkAQGG" +
           "JP////8FAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQGAMgAvAQLtA4AyAAD/////AAAAAARg" +
           "gAoBAAAAAQAGAAAAU3RhdHVzAQGCMgAvAQLtA4IyAAD/////AAAAAARggAoBAAAAAQAPAAAARmFjdG9y" +
           "eVNldHRpbmdzAQGEMgAvAQLtA4QyAAD/////AAAAADVgiQoCAAAAAQAOAAAASXNIb3RTd2FwcGFibGUB" +
           "AYYyAwAAAABQAAAAVHJ1ZSBpZiB0aGlzIGFjY2Vzc29yeSBjYW4gYmUgaW5zZXJ0ZWQgaW4gdGhlIGFj" +
           "Y2Vzc29yeSBzbG90IHdoaWxlIGl0IGlzIHBvd2VyZWQALgBEhjIAAAAB/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEABwAAAElzUmVhZHkBAYcyAwAAAAAnAAAAVHJ1ZSBpZiB0aGlzIGFjY2Vzc29yeSBpcyByZWFk" +
           "eSBmb3IgdXNlAC4ARIcyAAAAAf////8BAf////8AAAAA";
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

    #region SmartSamplingSystemState Class
    #if (!OPCUA_EXCLUDE_SmartSamplingSystemState)
    /// <summary>
    /// Stores an instance of the SmartSamplingSystemType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SmartSamplingSystemState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SmartSamplingSystemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SmartSamplingSystemType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAfAAAAU21hcnRTYW1wbGluZ1N5c3RlbVR5cGVJbnN0" +
           "YW5jZQEBjyQBAY8k/////wUAAAAEYIAKAQAAAAEADQAAAENvbmZpZ3VyYXRpb24BAZ4yAC8BAu0DnjIA" +
           "AP////8AAAAABGCACgEAAAABAAYAAABTdGF0dXMBAaAyAC8BAu0DoDIAAP////8AAAAABGCACgEAAAAB" +
           "AA8AAABGYWN0b3J5U2V0dGluZ3MBAaIyAC8BAu0DojIAAP////8AAAAANWCJCgIAAAABAA4AAABJc0hv" +
           "dFN3YXBwYWJsZQEBpDIDAAAAAFAAAABUcnVlIGlmIHRoaXMgYWNjZXNzb3J5IGNhbiBiZSBpbnNlcnRl" +
           "ZCBpbiB0aGUgYWNjZXNzb3J5IHNsb3Qgd2hpbGUgaXQgaXMgcG93ZXJlZAAuAESkMgAAAAH/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAHAAAASXNSZWFkeQEBpTIDAAAAACcAAABUcnVlIGlmIHRoaXMgYWNjZXNz" +
           "b3J5IGlzIHJlYWR5IGZvciB1c2UALgBEpTIAAAAB/////wEB/////wAAAAA=";
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

    #region SourceState Class
    #if (!OPCUA_EXCLUDE_SourceState)
    /// <summary>
    /// Stores an instance of the SourceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SourceState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SourceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.SourceType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAU291cmNlVHlwZUluc3RhbmNlAQGYJAEBmCT/" +
           "////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEBvDIALwEC7QO8MgAA/////wAAAAAEYIAK" +
           "AQAAAAEABgAAAFN0YXR1cwEBvjIALwEC7QO+MgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlT" +
           "ZXR0aW5ncwEBwDIALwEC7QPAMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHC" +
           "MgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBhY2Nl" +
           "c3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4ARMIyAAAAAf////8BAf////8AAAAANWCJCgIA" +
           "AAABAAcAAABJc1JlYWR5AQHDMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVhZHkg" +
           "Zm9yIHVzZQAuAETDMgAAAAH/////AQH/////AAAAAA==";
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

    #region GcOvenState Class
    #if (!OPCUA_EXCLUDE_GcOvenState)
    /// <summary>
    /// Stores an instance of the GcOvenType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GcOvenState : AccessoryState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GcOvenState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.ObjectTypes.GcOvenType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAR2NPdmVuVHlwZUluc3RhbmNlAQH8AwEB/AP/" +
           "////BQAAAARggAoBAAAAAQANAAAAQ29uZmlndXJhdGlvbgEB2jIALwEC7QPaMgAA/////wAAAAAEYIAK" +
           "AQAAAAEABgAAAFN0YXR1cwEB3DIALwEC7QPcMgAA/////wAAAAAEYIAKAQAAAAEADwAAAEZhY3RvcnlT" +
           "ZXR0aW5ncwEB3jIALwEC7QPeMgAA/////wAAAAA1YIkKAgAAAAEADgAAAElzSG90U3dhcHBhYmxlAQHg" +
           "MgMAAAAAUAAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgY2FuIGJlIGluc2VydGVkIGluIHRoZSBhY2Nl" +
           "c3Nvcnkgc2xvdCB3aGlsZSBpdCBpcyBwb3dlcmVkAC4AROAyAAAAAf////8BAf////8AAAAANWCJCgIA" +
           "AAABAAcAAABJc1JlYWR5AQHhMgMAAAAAJwAAAFRydWUgaWYgdGhpcyBhY2Nlc3NvcnkgaXMgcmVhZHkg" +
           "Zm9yIHVzZQAuAEThMgAAAAH/////AQH/////AAAAAA==";
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

    #region ExecutionCycleEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_ExecutionCycleEnumeration)
    /// <summary>
    /// A description for the ExecutionCycleEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum ExecutionCycleEnumeration
    {
        /// <summary>
        /// Idle, no cleaning or acquisition cycle in progress
        /// </summary>
        [EnumMember(Value = "IDLE_0")]
        IDLE = 0,

        /// <summary>
        /// Scquisition cycle collecting data for diagnostic purpose
        /// </summary>
        [EnumMember(Value = "DIAGNOSTIC_1")]
        DIAGNOSTIC = 1,

        /// <summary>
        /// Cleaning cycle
        /// </summary>
        [EnumMember(Value = "CLEANING_2")]
        CLEANING = 2,

        /// <summary>
        /// Calibration acquisition cycle
        /// </summary>
        [EnumMember(Value = "CALIBRATION_4")]
        CALIBRATION = 4,

        /// <summary>
        /// Validation acquisition cycle
        /// </summary>
        [EnumMember(Value = "VALIDATION_8")]
        VALIDATION = 8,

        /// <summary>
        /// Sample acquisition cycle
        /// </summary>
        [EnumMember(Value = "SAMPLING_16")]
        SAMPLING = 16,

        /// <summary>
        /// Scquisition cycle collecting data for diagnostic purpose and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "DIAGNOSTIC_WITH_GRAB_SAMPLE_32769")]
        DIAGNOSTIC_WITH_GRAB_SAMPLE = 32769,

        /// <summary>
        /// Cleaning cycle with or without acquisition and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "CLEANING_WITH_GRAB_SAMPLE_32770")]
        CLEANING_WITH_GRAB_SAMPLE = 32770,

        /// <summary>
        /// Calibration acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "CALIBRATION_WITH_GRAB_SAMPLE_32772")]
        CALIBRATION_WITH_GRAB_SAMPLE = 32772,

        /// <summary>
        /// Validation acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "VALIDATION_WITH_GRAB_SAMPLE_32776")]
        VALIDATION_WITH_GRAB_SAMPLE = 32776,

        /// <summary>
        /// Sample acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "SAMPLING_WITH_GRAB_SAMPLE_32784")]
        SAMPLING_WITH_GRAB_SAMPLE = 32784,
    }

    #region ExecutionCycleEnumerationCollection Class
    /// <summary>
    /// A collection of ExecutionCycleEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfExecutionCycleEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "ExecutionCycleEnumeration")]
    public partial class ExecutionCycleEnumerationCollection : List<ExecutionCycleEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ExecutionCycleEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ExecutionCycleEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ExecutionCycleEnumerationCollection(IEnumerable<ExecutionCycleEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ExecutionCycleEnumerationCollection(ExecutionCycleEnumeration[] values)
        {
            if (values != null)
            {
                return new ExecutionCycleEnumerationCollection(values);
            }

            return new ExecutionCycleEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ExecutionCycleEnumeration[](ExecutionCycleEnumerationCollection values)
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
            ExecutionCycleEnumerationCollection clone = new ExecutionCycleEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExecutionCycleEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AcquisitionResultStatusEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AcquisitionResultStatusEnumeration)
    /// <summary>
    /// A description for the AcquisitionResultStatusEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum AcquisitionResultStatusEnumeration
    {
        /// <summary>
        /// No longer used.
        /// </summary>
        [EnumMember(Value = "NOT_USED_0")]
        NOT_USED = 0,

        /// <summary>
        /// The acquisition has been completed as requested without any error.
        /// </summary>
        [EnumMember(Value = "GOOD_1")]
        GOOD = 1,

        /// <summary>
        /// The acquisition has been completed as requested with error.
        /// </summary>
        [EnumMember(Value = "BAD_2")]
        BAD = 2,

        /// <summary>
        /// The acquisition has been completed but nothing can be said about the quality of the result.
        /// </summary>
        [EnumMember(Value = "UNKNOWN_3")]
        UNKNOWN = 3,

        /// <summary>
        /// The acquisition has been partially completed as requested without any error.
        /// </summary>
        [EnumMember(Value = "PARTIAL_4")]
        PARTIAL = 4,
    }

    #region AcquisitionResultStatusEnumerationCollection Class
    /// <summary>
    /// A collection of AcquisitionResultStatusEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAcquisitionResultStatusEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "AcquisitionResultStatusEnumeration")]
    public partial class AcquisitionResultStatusEnumerationCollection : List<AcquisitionResultStatusEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection(IEnumerable<AcquisitionResultStatusEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AcquisitionResultStatusEnumerationCollection(AcquisitionResultStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new AcquisitionResultStatusEnumerationCollection(values);
            }

            return new AcquisitionResultStatusEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AcquisitionResultStatusEnumeration[](AcquisitionResultStatusEnumerationCollection values)
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
            AcquisitionResultStatusEnumerationCollection clone = new AcquisitionResultStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AcquisitionResultStatusEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region EngineeringValueState Class
    #if (!OPCUA_EXCLUDE_EngineeringValueState)
    /// <summary>
    /// Stores an instance of the EngineeringValueType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EngineeringValueState : DataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EngineeringValueState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.EngineeringValueType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAcAAAARW5naW5lZXJpbmdWYWx1ZVR5cGVJbnN0YW5j" +
           "ZQEBpCQBAaQkABgBAf////8AAAAA";
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

    #region EngineeringValueState<T> Class
    /// <summary>
    /// A typed version of the EngineeringValueType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class EngineeringValueState<T> : EngineeringValueState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public EngineeringValueState(NodeState parent) : base(parent)
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

    #region ChemometricModelState Class
    #if (!OPCUA_EXCLUDE_ChemometricModelState)
    /// <summary>
    /// Stores an instance of the ChemometricModelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChemometricModelState : BaseDataVariableState<byte[]>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChemometricModelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.ChemometricModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAcAAAAQ2hlbW9tZXRyaWNNb2RlbFR5cGVJbnN0YW5j" +
           "ZQEB1wcBAdcHAA8BAf////8DAAAAFWCJCgIAAAABAAQAAABOYW1lAQHpMgAuAETpMgAAABX/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAMAAAAQ3JlYXRpb25EYXRlAQHqMgAuAETqMgAAAA3/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAQAAAATW9kZWxEZXNjcmlwdGlvbgEB6zIALgBE6zIAAAAV/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Name Property.
        /// </summary>
        public PropertyState<LocalizedText> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <summary>
        /// A description for the CreationDate Property.
        /// </summary>
        public PropertyState<DateTime> CreationDate
        {
            get
            {
                return m_creationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_creationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_creationDate = value;
            }
        }

        /// <summary>
        /// A description for the ModelDescription Property.
        /// </summary>
        public PropertyState<LocalizedText> ModelDescription
        {
            get
            {
                return m_modelDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modelDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modelDescription = value;
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
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_creationDate != null)
            {
                children.Add(m_creationDate);
            }

            if (m_modelDescription != null)
            {
                children.Add(m_modelDescription);
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
                case Opc.Ua.Adi.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Name = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.CreationDate:
                {
                    if (createOrReplace)
                    {
                        if (CreationDate == null)
                        {
                            if (replacement == null)
                            {
                                CreationDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                CreationDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = CreationDate;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.ModelDescription:
                {
                    if (createOrReplace)
                    {
                        if (ModelDescription == null)
                        {
                            if (replacement == null)
                            {
                                ModelDescription = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ModelDescription = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ModelDescription;
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
        private PropertyState<LocalizedText> m_name;
        private PropertyState<DateTime> m_creationDate;
        private PropertyState<LocalizedText> m_modelDescription;
        #endregion
    }
    #endif
    #endregion

    #region ProcessVariableState Class
    #if (!OPCUA_EXCLUDE_ProcessVariableState)
    /// <summary>
    /// Stores an instance of the ProcessVariableType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProcessVariableState : DataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProcessVariableState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.ProcessVariableType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAbAAAAUHJvY2Vzc1ZhcmlhYmxlVHlwZUluc3RhbmNl" +
           "AQHYBwEB2AcAGAEB/////wAAAAA=";
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

    #region ProcessVariableState<T> Class
    /// <summary>
    /// A typed version of the ProcessVariableType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProcessVariableState<T> : ProcessVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProcessVariableState(NodeState parent) : base(parent)
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

    #region MVAModelState Class
    #if (!OPCUA_EXCLUDE_MVAModelState)
    /// <summary>
    /// Stores an instance of the MVAModelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAModelState : ChemometricModelState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAModelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.MVAModelType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAUAAAATVZBTW9kZWxUeXBlSW5zdGFuY2UBAdkHAQHZ" +
           "BwAPAQH/////BAAAABVgiQoCAAAAAQAEAAAATmFtZQEB8TIALgBE8TIAAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEADAAAAENyZWF0aW9uRGF0ZQEB8jIALgBE8jIAAAAN/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEAAAAE1vZGVsRGVzY3JpcHRpb24BAfMyAC4ARPMyAAAAFf////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AA0AAABNYWluRGF0YUluZGV4AQH2MgAuAET2MgAAAAb/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MainDataIndex Property.
        /// </summary>
        public PropertyState<int> MainDataIndex
        {
            get
            {
                return m_mainDataIndex;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mainDataIndex, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mainDataIndex = value;
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
            if (m_mainDataIndex != null)
            {
                children.Add(m_mainDataIndex);
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
                case Opc.Ua.Adi.BrowseNames.MainDataIndex:
                {
                    if (createOrReplace)
                    {
                        if (MainDataIndex == null)
                        {
                            if (replacement == null)
                            {
                                MainDataIndex = new PropertyState<int>(this);
                            }
                            else
                            {
                                MainDataIndex = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = MainDataIndex;
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
        private PropertyState<int> m_mainDataIndex;
        #endregion
    }
    #endif
    #endregion

    #region MVAPredictMethodState Class
    #if (!OPCUA_EXCLUDE_MVAPredictMethodState)
    /// <summary>
    /// Stores an instance of the MVAPredictMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAPredictMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAPredictMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new MVAPredictMethodState(parent);
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
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAUAAAATVZBUHJlZGljdE1ldGhvZFR5cGUBAfsyAC8B" +
           "Afsy+zIAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH8MgAuAET8MgAAlgMA" +
           "AAABACoBARoAAAALAAAAVGFyZ2V0TW9kZWwAEf////8AAAAAAAEAKgEBHAAAAA0AAABNYWluRGF0YUlu" +
           "ZGV4AAb/////AAAAAAABACoBARUAAAAGAAAASW5wdXRzABgBAAAAAAAAAAABACgBAQAAAAEB/////wAA" +
           "AAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/TIALgBE/TIAAJYBAAAAAQAqAQEWAAAABwAA" +
           "AE91dHB1dHMAGAEAAAAAAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public MVAPredictMethodStateMethodCallHandler OnCall;
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

            NodeId targetModel = (NodeId)inputArguments[0];
            int mainDataIndex = (int)inputArguments[1];
            Variant[] inputs = (Variant[])inputArguments[2];

            Variant[] outputs = (Variant[])outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    targetModel,
                    mainDataIndex,
                    inputs,
                    ref outputs);
            }

            outputArguments[0] = outputs;

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
    public delegate ServiceResult MVAPredictMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId targetModel,
        int mainDataIndex,
        Variant[] inputs,
        ref Variant[] outputs);
    #endif
    #endregion

    #region MVAOutputParameterState Class
    #if (!OPCUA_EXCLUDE_MVAOutputParameterState)
    /// <summary>
    /// Stores an instance of the MVAOutputParameterType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MVAOutputParameterState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MVAOutputParameterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Adi.VariableTypes.MVAOutputParameterType, Opc.Ua.Adi.Namespaces.OpcUaAdi, namespaceUris);
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

            if (WarningLimits != null)
            {
                WarningLimits.Initialize(context, WarningLimits_InitializationString);
            }

            if (AlarmLimits != null)
            {
                AlarmLimits.Initialize(context, AlarmLimits_InitializationString);
            }

            if (VendorSpecificError != null)
            {
                VendorSpecificError.Initialize(context, VendorSpecificError_InitializationString);
            }
        }

        #region Initialization String
        private const string WarningLimits_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAV2FybmluZ0xpbWl0cwEB/jIALgBE/jIAAAEA" +
           "dAP/////AQH/////AAAAAA==";

        private const string AlarmLimits_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAQWxhcm1MaW1pdHMBAf8yAC4ARP8yAAABAHQD" +
           "/////wEB/////wAAAAA=";

        private const string VendorSpecificError_InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQATAAAAVmVuZG9yU3BlY2lmaWNFcnJvcgEBATMALgBE" +
           "ATMAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AgAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvQURJLx8AAABodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvREkv/////xVggQACAAAAAQAeAAAATVZBT3V0cHV0UGFyYW1ldGVyVHlwZUluc3Rh" +
           "bmNlAQHaBwEB2gcAGAEB/////wQAAAAVYIkKAgAAAAEADQAAAFdhcm5pbmdMaW1pdHMBAf4yAC4ARP4y" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFsYXJtTGltaXRzAQH/MgAuAET/MgAAAQB0" +
           "A/////8BAf////8AAAAAFWCJCgIAAAABAAoAAABBbGFybVN0YXRlAQEAMwAuAEQAMwAAAQHBC/////8B" +
           "Af////8AAAAAFWCJCgIAAAABABMAAABWZW5kb3JTcGVjaWZpY0Vycm9yAQEBMwAuAEQBMwAAAAz/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the WarningLimits Property.
        /// </summary>
        public PropertyState<Range> WarningLimits
        {
            get
            {
                return m_warningLimits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_warningLimits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningLimits = value;
            }
        }

        /// <summary>
        /// A description for the AlarmLimits Property.
        /// </summary>
        public PropertyState<Range> AlarmLimits
        {
            get
            {
                return m_alarmLimits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmLimits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmLimits = value;
            }
        }

        /// <summary>
        /// A description for the AlarmState Property.
        /// </summary>
        public PropertyState<AlarmStateEnumeration> AlarmState
        {
            get
            {
                return m_alarmState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmState = value;
            }
        }

        /// <summary>
        /// A description for the VendorSpecificError Property.
        /// </summary>
        public PropertyState<string> VendorSpecificError
        {
            get
            {
                return m_vendorSpecificError;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vendorSpecificError, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vendorSpecificError = value;
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
            if (m_warningLimits != null)
            {
                children.Add(m_warningLimits);
            }

            if (m_alarmLimits != null)
            {
                children.Add(m_alarmLimits);
            }

            if (m_alarmState != null)
            {
                children.Add(m_alarmState);
            }

            if (m_vendorSpecificError != null)
            {
                children.Add(m_vendorSpecificError);
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
                case Opc.Ua.Adi.BrowseNames.WarningLimits:
                {
                    if (createOrReplace)
                    {
                        if (WarningLimits == null)
                        {
                            if (replacement == null)
                            {
                                WarningLimits = new PropertyState<Range>(this);
                            }
                            else
                            {
                                WarningLimits = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = WarningLimits;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AlarmLimits:
                {
                    if (createOrReplace)
                    {
                        if (AlarmLimits == null)
                        {
                            if (replacement == null)
                            {
                                AlarmLimits = new PropertyState<Range>(this);
                            }
                            else
                            {
                                AlarmLimits = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = AlarmLimits;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.AlarmState:
                {
                    if (createOrReplace)
                    {
                        if (AlarmState == null)
                        {
                            if (replacement == null)
                            {
                                AlarmState = new PropertyState<AlarmStateEnumeration>(this);
                            }
                            else
                            {
                                AlarmState = (PropertyState<AlarmStateEnumeration>)replacement;
                            }
                        }
                    }

                    instance = AlarmState;
                    break;
                }

                case Opc.Ua.Adi.BrowseNames.VendorSpecificError:
                {
                    if (createOrReplace)
                    {
                        if (VendorSpecificError == null)
                        {
                            if (replacement == null)
                            {
                                VendorSpecificError = new PropertyState<string>(this);
                            }
                            else
                            {
                                VendorSpecificError = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = VendorSpecificError;
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
        private PropertyState<Range> m_warningLimits;
        private PropertyState<Range> m_alarmLimits;
        private PropertyState<AlarmStateEnumeration> m_alarmState;
        private PropertyState<string> m_vendorSpecificError;
        #endregion
    }

    #region MVAOutputParameterState<T> Class
    /// <summary>
    /// A typed version of the MVAOutputParameterType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MVAOutputParameterState<T> : MVAOutputParameterState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MVAOutputParameterState(NodeState parent) : base(parent)
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

    #region AlarmStateEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AlarmStateEnumeration)
    /// <summary>
    /// A description for the AlarmStateEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum AlarmStateEnumeration
    {
        /// <summary>
        /// Normal
        /// </summary>
        [EnumMember(Value = "NORMAL_0")]
        NORMAL_0 = 0,

        /// <summary>
        /// In low warning range
        /// </summary>
        [EnumMember(Value = "WARNING_LOW_1")]
        WARNING_LOW_1 = 1,

        /// <summary>
        /// In high warning range
        /// </summary>
        [EnumMember(Value = "WARNING_HIGH_2")]
        WARNING_HIGH_2 = 2,

        /// <summary>
        /// In warning range (low or high) or some other warning cause
        /// </summary>
        [EnumMember(Value = "WARNING_4")]
        WARNING_4 = 4,

        /// <summary>
        /// In low alarm range
        /// </summary>
        [EnumMember(Value = "ALARM_LOW_8")]
        ALARM_LOW_8 = 8,

        /// <summary>
        /// In high alarm range
        /// </summary>
        [EnumMember(Value = "ALARM_HIGH_16")]
        ALARM_HIGH_16 = 16,

        /// <summary>
        /// In alarm range (low or high) or some other alarm cause
        /// </summary>
        [EnumMember(Value = "ALARM_32")]
        ALARM_32 = 32,
    }

    #region AlarmStateEnumerationCollection Class
    /// <summary>
    /// A collection of AlarmStateEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAlarmStateEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "AlarmStateEnumeration")]
    public partial class AlarmStateEnumerationCollection : List<AlarmStateEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AlarmStateEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AlarmStateEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AlarmStateEnumerationCollection(IEnumerable<AlarmStateEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AlarmStateEnumerationCollection(AlarmStateEnumeration[] values)
        {
            if (values != null)
            {
                return new AlarmStateEnumerationCollection(values);
            }

            return new AlarmStateEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AlarmStateEnumeration[](AlarmStateEnumerationCollection values)
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
            AlarmStateEnumerationCollection clone = new AlarmStateEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AlarmStateEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion
}