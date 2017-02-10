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
using FTNIR;

namespace FTNIRInstance
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
        /// The identifier for the FTNIR_Simulator_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_InitLock = 14402;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_RenewLock = 14405;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_ExitLock = 14407;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_BreakLock = 14409;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_InitLock = 14433;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_RenewLock = 14436;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_ExitLock = 14438;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_BreakLock = 14440;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfiguration Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GetConfiguration = 13024;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_SetConfiguration = 13026;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GetConfigDataDigest = 13029;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_CompareConfigDataDigest = 13031;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_ResetAllChannels Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_ResetAllChannels = 13034;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_StartAllChannels Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_StartAllChannels = 13035;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_StopAllChannels Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_StopAllChannels = 13036;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_AbortAllChannels Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_AbortAllChannels = 13037;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GotoOperating = 13038;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GotoMaintenance = 13039;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Open = 14449;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Close = 14452;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Read = 14454;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Write = 14457;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_GetPosition = 14459;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_SetPosition = 14462;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_InitLock = 14480;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock = 14483;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock = 14485;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock = 14487;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoOperating = 14489;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoMaintenance = 14490;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition = 14491;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Reset = 14493;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Start = 14494;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Stop = 14495;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Hold = 14496;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Unhold = 14497;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Suspend = 14498;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Unsuspend = 14499;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Abort = 14500;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_Clear = 14501;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock = 14603;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock = 14606;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock = 14608;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock = 14610;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_InitLock = 14623;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_RenewLock = 14626;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_ExitLock = 14628;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_BreakLock = 14630;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_GotoOperating = 13208;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_GotoMaintenance = 13209;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition = 13206;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Reset Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Reset = 13210;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Start Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Start = 13211;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Stop Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Stop = 13212;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Hold Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Hold = 13213;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Unhold Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Unhold = 13214;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Suspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Suspend = 13215;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Unsuspend = 13216;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Abort Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Abort = 13217;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Clear Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_Clear = 13218;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock = 14691;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock = 14694;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock = 14696;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock = 14698;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock = 14718;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock = 14721;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock = 14723;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock = 14725;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock = 14745;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock = 14748;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock = 14750;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock = 14752;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock = 14765;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock = 14768;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock = 14770;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock = 14772;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_InitLock = 14785;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_RenewLock = 14788;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_ExitLock = 14790;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_BreakLock = 14792;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_GotoOperating = 13797;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_GotoMaintenance = 13798;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition = 13795;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Reset Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Reset = 13799;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Start Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Start = 13800;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Stop Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Stop = 13801;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Hold Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Hold = 13802;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Unhold Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Unhold = 13803;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Suspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Suspend = 13804;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Unsuspend = 13805;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Abort Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Abort = 13806;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Clear Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_Clear = 13807;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock = 14853;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock = 14856;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock = 14858;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock = 14860;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock = 14880;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock = 14883;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock = 14885;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock = 14887;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock = 14907;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock = 14910;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock = 14912;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock = 14914;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock = 14927;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock = 14930;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock = 14932;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock Method.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock = 14934;
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
        /// The identifier for the FTNIR_Simulator Object.
        /// </summary>
        public const uint FTNIR_Simulator = 13012;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet Object.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet = 13014;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Identification Object.
        /// </summary>
        public const uint FTNIR_Simulator_Identification = 13015;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_NetworkAddress = 14442;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Configuration = 13080;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Status = 13081;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_FactorySettings = 13082;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_AnalyserStateMachine = 13083;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet = 14471;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Configuration = 14514;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Status = 14516;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine = 14518;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = 14530;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 14542;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_SupportedTypes Object.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_SupportedTypes = 14579;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine = 14582;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot = 13127;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_SupportedTypes Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_SupportedTypes = 13128;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine = 13131;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource = 13178;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Configuration = 13182;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Status = 13183;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_FactorySettings = 13184;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1 = 13202;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet = 13204;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Configuration = 13231;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Status = 13232;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine = 13233;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine = 14635;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 14647;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1 = 13552;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Configuration = 13642;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Status = 13643;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionSettings = 13644;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionStatus Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionStatus = 13645;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionData Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionData = 13646;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ChemometricModelSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ChemometricModelSettings = 13647;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Context Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Context = 13648;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2 = 13649;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Configuration = 13739;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Status = 13740;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionSettings = 13741;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionStatus Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionStatus = 13742;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionData Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionData = 13743;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ChemometricModelSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ChemometricModelSettings = 13744;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Context Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Context = 13745;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot = 13746;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Configuration = 13750;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Status = 13751;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_FactorySettings = 13752;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot = 13770;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Configuration = 13774;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Status = 13775;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_FactorySettings = 13776;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2 = 13791;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet = 13793;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Configuration = 13820;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Status = 13821;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine = 13822;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine = 14797;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 14809;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1 = 14141;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Configuration = 14231;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Status = 14232;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionSettings = 14233;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionStatus Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionStatus = 14234;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionData Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionData = 14235;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ChemometricModelSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ChemometricModelSettings = 14236;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Context Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Context = 14237;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2 Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2 = 14238;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Configuration = 14328;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Status = 14329;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionSettings = 14330;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionStatus Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionStatus = 14331;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionData Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionData = 14332;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ChemometricModelSettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ChemometricModelSettings = 14333;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Context Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Context = 14334;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot = 14335;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Configuration = 14339;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Status = 14340;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_FactorySettings = 14341;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot = 14359;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Configuration Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Configuration = 14363;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Status Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Status = 14364;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_FactorySettings Object.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_FactorySettings = 14365;
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
        /// The identifier for the FTNIR_Simulator_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_Locked = 14398;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_LockingClient = 14399;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_LockingUser = 14400;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_RemainingLockTime = 14401;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_InitLock_InputArguments = 14403;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_InitLock_OutputArguments = 14404;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_RenewLock_OutputArguments = 14406;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_ExitLock_OutputArguments = 14408;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Lock_BreakLock_OutputArguments = 14410;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_SerialNumber = 13016;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_RevisionCounter Variable.
        /// </summary>
        public const uint FTNIR_Simulator_RevisionCounter = 13017;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Manufacturer = 13018;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Model = 13019;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_DeviceManual Variable.
        /// </summary>
        public const uint FTNIR_Simulator_DeviceManual = 13020;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_DeviceRevision Variable.
        /// </summary>
        public const uint FTNIR_Simulator_DeviceRevision = 13021;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_SoftwareRevision Variable.
        /// </summary>
        public const uint FTNIR_Simulator_SoftwareRevision = 13022;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_HardwareRevision Variable.
        /// </summary>
        public const uint FTNIR_Simulator_HardwareRevision = 13023;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_Locked = 14429;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_LockingClient = 14430;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_LockingUser = 14431;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_RemainingLockTime = 14432;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_InitLock_InputArguments = 14434;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_InitLock_OutputArguments = 14435;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_RenewLock_OutputArguments = 14437;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_ExitLock_OutputArguments = 14439;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_CPIdentifier_Lock_BreakLock_OutputArguments = 14441;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GetConfiguration_OutputArguments = 13025;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_SetConfiguration_InputArguments = 13027;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_SetConfiguration_OutputArguments = 13028;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_GetConfigDataDigest_OutputArguments = 13030;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_CompareConfigDataDigest_InputArguments = 13032;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_MethodSet_CompareConfigDataDigest_OutputArguments = 13033;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_DiagnosticStatus = 13040;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Size = 14445;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Writeable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Writeable = 14446;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_UserWriteable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_UserWriteable = 14447;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_OpenCount = 14448;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Open_InputArguments = 14450;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Open_OutputArguments = 14451;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Close_InputArguments = 14453;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Read_InputArguments = 14455;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Read_OutputArguments = 14456;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_Write_InputArguments = 14458;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_InputArguments = 14460;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_OutputArguments = 14461;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ParameterSet_ConfigData_SetPosition_InputArguments = 14463;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AnalyserStateMachine_CurrentState = 13084;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AnalyserStateMachine_CurrentState_Id = 13085;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AnalyserStateMachine_LastTransition_Id = 13090;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_Locked = 14476;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_LockingClient = 14477;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_LockingUser = 14478;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_RemainingLockTime = 14479;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_InputArguments = 14481;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_OutputArguments = 14482;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock_OutputArguments = 14484;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock_OutputArguments = 14486;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock_OutputArguments = 14488;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = 14492;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ParameterSet_IsEnabled = 14505;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ParameterSet_DiagnosticStatus = 14508;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ParameterSet_ActiveStream = 14511;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState = 14519;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState_Id = 14520;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LastTransition_Id = 14525;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState = 14531;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = 14532;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = 14537;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = 14543;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = 14544;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = 14549;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState = 14555;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = 14556;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = 14561;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = 14567;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = 14568;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = 14573;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_IsHotSwappable = 14580;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_IsEnabled = 14581;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState = 14583;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id = 14584;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id = 14589;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IsHotSwappable = 13129;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IsEnabled = 13130;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState = 13132;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState_Id = 13133;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_LastTransition_Id = 13138;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_Locked = 14599;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingClient = 14600;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingUser = 14601;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RemainingLockTime = 14602;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_InputArguments = 14604;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_OutputArguments = 14605;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock_OutputArguments = 14607;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock_OutputArguments = 14609;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock_OutputArguments = 14611;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_IsHotSwappable = 13185;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_IsReady Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_IsReady = 13186;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Manufacturer = 13187;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Model = 13190;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_SerialNumber = 13193;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_IsEnabled = 13196;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_ActualTemperature = 13199;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_Locked = 14619;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_LockingClient = 14620;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_LockingUser = 14621;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_RemainingLockTime = 14622;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_InitLock_InputArguments = 14624;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_InitLock_OutputArguments = 14625;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_RenewLock_OutputArguments = 14627;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_ExitLock_OutputArguments = 14629;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Lock_BreakLock_OutputArguments = 14631;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition_InputArguments = 13207;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ParameterSet_IsEnabled = 13222;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ParameterSet_DiagnosticStatus = 13225;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ParameterSet_ActiveStream = 13228;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState = 13234;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState_Id = 13235;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_LastTransition_Id = 13240;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState = 14636;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = 14637;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = 14642;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = 14648;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = 14649;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = 14654;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState = 14660;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = 14661;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = 14666;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = 14672;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = 14673;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = 14678;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_Locked = 14687;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingClient = 14688;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingUser = 14689;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RemainingLockTime = 14690;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_InputArguments = 14692;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_OutputArguments = 14693;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock_OutputArguments = 14695;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock_OutputArguments = 14697;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock_OutputArguments = 14699;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsEnabled = 13556;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_DiagnosticStatus = 13562;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_LastSampleTime = 13571;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_TimeBetweenSamples_EURange = 13577;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsActive = 13580;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycle = 13583;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode = 13584;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings = 13587;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_Progress Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_Progress = 13588;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter = 13591;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter_EURange = 13594;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionResultStatus = 13597;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ScaledData = 13603;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionEndTime = 13606;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_Locked = 14714;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingClient = 14715;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingUser = 14716;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RemainingLockTime = 14717;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_InputArguments = 14719;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_OutputArguments = 14720;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock_OutputArguments = 14722;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock_OutputArguments = 14724;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock_OutputArguments = 14726;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsEnabled = 13653;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_DiagnosticStatus = 13659;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_LastSampleTime = 13668;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_TimeBetweenSamples_EURange = 13674;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsActive = 13677;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycle = 13680;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode = 13681;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings = 13684;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_Progress Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_Progress = 13685;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter = 13688;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter_EURange = 13691;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionResultStatus = 13694;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ScaledData = 13700;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionEndTime = 13703;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_Locked = 14741;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingClient = 14742;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingUser = 14743;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RemainingLockTime = 14744;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_InputArguments = 14746;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_OutputArguments = 14747;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock_OutputArguments = 14749;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock_OutputArguments = 14751;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock_OutputArguments = 14753;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsHotSwappable = 13753;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsReady Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsReady = 13754;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Manufacturer = 13755;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Model = 13758;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_SerialNumber = 13761;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Gain Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Gain = 13764;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_IsSaturated Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_IsSaturated = 13767;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_Locked = 14761;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingClient = 14762;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingUser = 14763;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RemainingLockTime = 14764;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_InputArguments = 14766;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_OutputArguments = 14767;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock_OutputArguments = 14769;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock_OutputArguments = 14771;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock_OutputArguments = 14773;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsHotSwappable = 13777;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsReady Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsReady = 13778;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Manufacturer = 13779;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Model = 13782;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_SerialNumber = 13785;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_ActualTemperature = 13788;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_Locked = 14781;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_LockingClient = 14782;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_LockingUser = 14783;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_RemainingLockTime = 14784;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_InitLock_InputArguments = 14786;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_InitLock_OutputArguments = 14787;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_RenewLock_OutputArguments = 14789;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_ExitLock_OutputArguments = 14791;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Lock_BreakLock_OutputArguments = 14793;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition_InputArguments = 13796;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ParameterSet_IsEnabled = 13811;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ParameterSet_DiagnosticStatus = 13814;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ParameterSet_ActiveStream = 13817;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState = 13823;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState_Id = 13824;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_LastTransition_Id = 13829;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState = 14798;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = 14799;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = 14804;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = 14810;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = 14811;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = 14816;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState = 14822;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = 14823;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = 14828;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = 14834;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = 14835;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = 14840;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_Locked = 14849;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingClient = 14850;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingUser = 14851;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RemainingLockTime = 14852;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_InputArguments = 14854;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_OutputArguments = 14855;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock_OutputArguments = 14857;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock_OutputArguments = 14859;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock_OutputArguments = 14861;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsEnabled = 14145;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_DiagnosticStatus = 14151;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_LastSampleTime = 14160;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_TimeBetweenSamples_EURange = 14166;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsActive = 14169;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycle = 14172;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode = 14173;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings = 14176;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_Progress Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_Progress = 14177;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter = 14180;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter_EURange = 14183;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionResultStatus = 14186;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ScaledData = 14192;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionEndTime = 14195;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_Locked = 14876;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingClient = 14877;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingUser = 14878;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RemainingLockTime = 14879;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_InputArguments = 14881;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_OutputArguments = 14882;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock_OutputArguments = 14884;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock_OutputArguments = 14886;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock_OutputArguments = 14888;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsEnabled = 14242;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_DiagnosticStatus = 14248;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_LastSampleTime = 14257;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_TimeBetweenSamples_EURange = 14263;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsActive Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsActive = 14266;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycle = 14269;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode = 14270;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings = 14273;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_Progress Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_Progress = 14274;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter = 14277;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter_EURange = 14280;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionResultStatus = 14283;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ScaledData Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ScaledData = 14289;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionEndTime = 14292;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_Locked = 14903;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingClient = 14904;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingUser = 14905;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RemainingLockTime = 14906;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_InputArguments = 14908;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_OutputArguments = 14909;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock_OutputArguments = 14911;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock_OutputArguments = 14913;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock_OutputArguments = 14915;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsHotSwappable = 14342;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsReady Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsReady = 14343;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Manufacturer = 14344;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Model = 14347;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_SerialNumber = 14350;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Gain Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Gain = 14353;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_IsSaturated Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_IsSaturated = 14356;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_Locked Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_Locked = 14923;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingClient Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingClient = 14924;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingUser Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingUser = 14925;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RemainingLockTime = 14926;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_InputArguments = 14928;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_OutputArguments = 14929;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock_OutputArguments = 14931;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock_OutputArguments = 14933;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock_OutputArguments = 14935;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsHotSwappable Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsHotSwappable = 14366;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsReady Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsReady = 14367;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Manufacturer = 14368;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Model Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Model = 14371;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_SerialNumber = 14374;

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public const uint FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_ActualTemperature = 14377;
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
        /// The identifier for the FTNIR_Simulator_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_CPIdentifier_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_CPIdentifier_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_CPIdentifier_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_CPIdentifier_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GetConfiguration = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_GetConfiguration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_SetConfiguration = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_SetConfiguration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GetConfigDataDigest = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_GetConfigDataDigest, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_CompareConfigDataDigest = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_CompareConfigDataDigest, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_ResetAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_ResetAllChannels = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_ResetAllChannels, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_StartAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_StartAllChannels = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_StartAllChannels, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_StopAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_StopAllChannels = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_StopAllChannels, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_AbortAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_AbortAllChannels = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_AbortAllChannels, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GotoOperating = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_GotoOperating, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GotoMaintenance = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_MethodSet_GotoMaintenance, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Open = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_Open, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Close = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_Close, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Read = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_Read, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Write = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_Write, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_GetPosition = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_GetPosition, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_SetPosition = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ParameterSet_ConfigData_SetPosition, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoOperating = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoOperating, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoMaintenance = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_GotoMaintenance, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Reset = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Reset, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Start = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Start, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Stop = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Stop, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Hold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Hold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Unhold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Unhold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Suspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Suspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Unsuspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Unsuspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Abort = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Abort, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_Clear = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_ChannelIdentifier_MethodSet_Clear, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_GotoOperating = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_GotoOperating, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_GotoMaintenance = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_GotoMaintenance, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Reset = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Reset, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Start = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Start, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Stop = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Stop, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Hold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Hold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Unhold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Unhold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Suspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Suspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Unsuspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Unsuspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Abort = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Abort, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_Clear = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_MethodSet_Clear, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_GotoOperating = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_GotoOperating, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_GotoMaintenance = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_GotoMaintenance, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Reset = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Reset, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Start = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Start, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Stop = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Stop, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Hold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Hold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Unhold = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Unhold, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Suspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Suspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Unsuspend = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Unsuspend, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Abort = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Abort, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_Clear = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_MethodSet_Clear, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock = new ExpandedNodeId(FTNIRInstance.Methods.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock, FTNIRInstance.Namespaces.CasFtnir);
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
        /// The identifier for the FTNIR_Simulator Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_MethodSet, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Identification = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Identification, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_NetworkAddress = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_CPIdentifier_NetworkAddress, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AnalyserStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_AnalyserStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_MethodSet, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_SupportedTypes = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_AccessorySlotIdentifier_SupportedTypes, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_SupportedTypes = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_SupportedTypes, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_IRSource, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_IRSource_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_IRSource_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_IRSourceSlot_IRSource_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_MethodSet, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_ChannelStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionStatus = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionData = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_AcquisitionData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ChemometricModelSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_ChemometricModelSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Context = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream1_Context, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionStatus = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionData = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_AcquisitionData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ChemometricModelSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_ChemometricModelSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Context = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1Stream2_Context, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1DetectorSlot, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1DetectorSlot_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_MethodSet, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_ChannelStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionStatus = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionData = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_AcquisitionData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ChemometricModelSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_ChemometricModelSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Context = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream1_Context, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2 Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2 = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionStatus = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionData Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionData = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_AcquisitionData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ChemometricModelSettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ChemometricModelSettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_ChemometricModelSettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Context Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Context = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2Stream2_Context, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2DetectorSlot, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2DetectorSlot_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Configuration = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Configuration, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Status = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Status, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_FactorySettings Object.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_FactorySettings = new ExpandedNodeId(FTNIRInstance.Objects.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_FactorySettings, FTNIRInstance.Namespaces.CasFtnir);
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
        /// The identifier for the FTNIR_Simulator_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_RevisionCounter = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_RevisionCounter, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_DeviceManual = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_DeviceManual, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_DeviceRevision = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_DeviceRevision, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_SoftwareRevision = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_SoftwareRevision, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_HardwareRevision = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_HardwareRevision, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_CPIdentifier_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GetConfiguration_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_GetConfiguration_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_SetConfiguration_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_SetConfiguration_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_SetConfiguration_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_SetConfiguration_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_GetConfigDataDigest_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_GetConfigDataDigest_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_CompareConfigDataDigest_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_CompareConfigDataDigest_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_MethodSet_CompareConfigDataDigest_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_MethodSet_CompareConfigDataDigest_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Size = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Size, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Writeable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Writeable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Writeable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_UserWriteable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_UserWriteable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_UserWriteable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_OpenCount = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_OpenCount, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Open_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Open_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Open_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Open_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Close_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Close_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Read_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Read_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Read_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Read_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_Write_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_Write_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_GetPosition_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ParameterSet_ConfigData_SetPosition_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ParameterSet_ConfigData_SetPosition_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AnalyserStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AnalyserStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AnalyserStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AnalyserStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AnalyserStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AnalyserStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AnalyserStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ParameterSet_ActiveStream = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ParameterSet_ActiveStream, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AccessorySlotIdentifier_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AccessorySlotIdentifier_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_AccessorySlotStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_IsReady = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_IsReady, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_IRSourceSlot_IRSource_ParameterSet_ActualTemperature, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_MethodSet_StartSingleAcquisition_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ParameterSet_ActiveStream = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ParameterSet_ActiveStream, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_LastSampleTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_LastSampleTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_TimeBetweenSamples_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsActive = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_IsActive, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycle = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycle, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_Progress = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_Progress, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionCounter_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionResultStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ScaledData = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_ScaledData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream1_ParameterSet_AcquisitionEndTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_LastSampleTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_LastSampleTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_TimeBetweenSamples_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsActive = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_IsActive, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycle = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycle, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_Progress = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_Progress, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionCounter_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionResultStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ScaledData = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_ScaledData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1Stream2_ParameterSet_AcquisitionEndTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsReady = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_IsReady, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Gain Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Gain = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_Gain, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_IsSaturated Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_IsSaturated = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1DetectorSlot_ParameterSet_IsSaturated, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsReady = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_IsReady, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel1_Channel1LiquidCellSlot_ParameterSet_ActualTemperature, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_MethodSet_StartSingleAcquisition_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ParameterSet_ActiveStream = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ParameterSet_ActiveStream, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_LastSampleTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_LastSampleTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_TimeBetweenSamples_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsActive = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_IsActive, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycle = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycle, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ExecutionCycleSubcode_EnumStrings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_Progress = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_Progress, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionCounter_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionResultStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ScaledData = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_ScaledData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream1_ParameterSet_AcquisitionEndTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsEnabled = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsEnabled, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_DiagnosticStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_DiagnosticStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_LastSampleTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_LastSampleTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_LastSampleTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_TimeBetweenSamples_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_TimeBetweenSamples_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_TimeBetweenSamples_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsActive = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_IsActive, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycle Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycle = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycle, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ExecutionCycleSubcode_EnumStrings, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_Progress Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_Progress = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_Progress, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter_EURange = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionCounter_EURange, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionResultStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionResultStatus = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionResultStatus, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ScaledData Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ScaledData = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_ScaledData, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionEndTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionEndTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2Stream2_ParameterSet_AcquisitionEndTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsReady = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_IsReady, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Gain Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Gain = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_Gain, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_IsSaturated Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_IsSaturated = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2DetectorSlot_ParameterSet_IsSaturated, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_Locked = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_Locked, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingClient = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingClient, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingUser = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_LockingUser, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RemainingLockTime = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RemainingLockTime, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_InputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_InputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_InitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_RenewLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_ExitLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_Lock_BreakLock_OutputArguments, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsHotSwappable = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsHotSwappable, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsReady Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsReady = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_IsReady, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Manufacturer = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Manufacturer, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Model = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_Model, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_SerialNumber = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_SerialNumber, FTNIRInstance.Namespaces.CasFtnir);

        /// <summary>
        /// The identifier for the FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_ActualTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_ActualTemperature = new ExpandedNodeId(FTNIRInstance.Variables.FTNIR_Simulator_Channel2_Channel2LiquidCellSlot_ParameterSet_ActualTemperature, FTNIRInstance.Namespaces.CasFtnir);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Channel1 component.
        /// </summary>
        public const string Channel1 = "Channel1";

        /// <summary>
        /// The BrowseName for the Channel2 component.
        /// </summary>
        public const string Channel2 = "Channel2";

        /// <summary>
        /// The BrowseName for the FTNIR_Simulator component.
        /// </summary>
        public const string FTNIR_Simulator = "Spectrometer simulator";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the CasFtnir namespace (.NET code namespace is 'FTNIRInstance').
        /// </summary>
        public const string CasFtnir = "http://cas.eu/UA/FTNIR/";

        /// <summary>
        /// The URI for the CasFtnirXsd namespace (.NET code namespace is 'FTNIRInstance').
        /// </summary>
        public const string CasFtnirXsd = "http://cas.eu/UA/FTNIR/Types.xsd";

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

        /// <summary>
        /// The URI for the OpcFtnir namespace (.NET code namespace is 'FTNIR').
        /// </summary>
        public const string OpcFtnir = "http://opcfoundation.org/UA/FTNIR/";

        /// <summary>
        /// The URI for the OpcFtnirXsd namespace (.NET code namespace is 'FTNIR').
        /// </summary>
        public const string OpcFtnirXsd = "http://opcfoundation.org/UA/FTNIR/Types.xsd";
    }
    #endregion

}