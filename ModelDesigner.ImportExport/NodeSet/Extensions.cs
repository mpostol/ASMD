//_______________________________________________________________
//  Title   : Extensions
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using System;
using System.Collections.Generic;
using UAOOI.SemanticData.BuildingErrorsHandling;
using UAOOI.SemanticData.InformationModelFactory;
using ModelDesign = Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  /// <summary>
  /// Class Extensions - provides helper extension functions
  /// </summary>
  internal static class Extensions
  {

    /// <summary>
    /// Creates symbolics the name joining symbolic names on the path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    internal static string SymbolicName(this List<string> path)
    {
      path.Reverse();
      return String.Join("_", path.ToArray());
    }
    internal static void AddLocalizedText(string keyField, string valueField, ref ModelDesign.LocalizedText description, Action<TraceMessage> traceEvent)
    {
      if (description != null)
      {
        traceEvent(TraceMessage.BuildErrorTraceMessage(BuildError.NotSupportedFeature, "Parameter.Description does not supports array. The description is skipped."));
        return;
      }
      description = new ModelDesign.LocalizedText()
      {
        Key = keyField,
        Value = valueField,
      };
    }
    /// <summary>
    /// Gets the value rank.
    /// </summary>
    /// <param name="valueRank">The value rank.</param>
    /// <param name="specified">if set to <c>true</c> the parameter is specified.</param>
    /// <param name="traceEvent">An <see cref="Action"/> delegate is used to trace event as the <see cref="TraceMessage"/>.</param>
    /// <returns>Returns value of <see cref="ModelDesign.ValueRank" />.</returns>
    internal static ModelDesign.ValueRank GetValueRank(this int? valueRank, Action<bool> specified, Action<TraceMessage> traceEvent)
    {
      ModelDesign.ValueRank _vr = ModelDesign.ValueRank.Scalar;
      if (!valueRank.HasValue)
      {
        specified(false);
        return _vr;
      }
      specified(true);
      if (valueRank < -2)
        traceEvent(TraceMessage.BuildErrorTraceMessage(BuildError.WrongValueRank, String.Format("The value {0} is not supported", valueRank)));
      else if (valueRank == -3)
        traceEvent(TraceMessage.BuildErrorTraceMessage(BuildError.WrongValueRank, String.Format("The value {0} is not supported", valueRank)));
      //_vr = ModelDesign.ValueRank.ScalarOrOneDimension;
      else if (valueRank == -2)
        _vr = ModelDesign.ValueRank.ScalarOrArray;
      else if (valueRank == -1)
      {
        _vr = ModelDesign.ValueRank.Scalar;
        specified(false);
      }
      else if (valueRank == 0)
        _vr = ModelDesign.ValueRank.OneOrMoreDimensions;
      else if (valueRank == 1)
        _vr = ModelDesign.ValueRank.Array;
      else
        _vr = ModelDesign.ValueRank.OneOrMoreDimensions;
      return _vr;
    }
    internal static ModelDesign.AccessLevel GetAccessLevel(this byte? accessLevel, Action<bool> accessLevelSpecified, Action<TraceMessage> traceEvent)
    {
      ModelDesign.AccessLevel _ret = ModelDesign.AccessLevel.None;
      if (!accessLevel.HasValue)
      {
        accessLevelSpecified(false);
        return _ret;
      }
      if (accessLevel == Opc.Ua.AccessLevels.CurrentReadOrWrite)
        _ret = ModelDesign.AccessLevel.ReadWrite;
      else if (accessLevel == Opc.Ua.AccessLevels.CurrentRead)
        _ret = ModelDesign.AccessLevel.Read;
      else if (accessLevel == Opc.Ua.AccessLevels.CurrentWrite)
        _ret = ModelDesign.AccessLevel.Write;
      else
        traceEvent(TraceMessage.BuildErrorTraceMessage(BuildError.NotSupportedFeature, String.Format("The AccessLevel value {0:X} is not supported", accessLevel)));
      accessLevelSpecified((int)_ret != 1);
      return _ret;
    }
    internal static string Key(this ModelDesign.Reference value)
    {
      return value.ReferenceType.ToString() + " " + value.TargetId.ToString();
    }
    //Extensions for UAOOI
    internal static ModelDesign.Parameter ExportArgument(this Parameter argument, Action<TraceMessage> traceEvent)
    {
      bool _ValueRankSpecified = false;
      ModelDesign.ValueRank _ValueRank = argument.ValueRank.GetValueRank(x => _ValueRankSpecified = x, traceEvent);
      return new ModelDesign.Parameter()
      {
        DataType = argument.DataType,
        Description = argument.Descriptions == null || argument.Descriptions.Count == 0 ? null : new ModelDesign.LocalizedText() { Key = argument.Descriptions[0].Locale, Value = argument.Descriptions[0].Text },
        Identifier = 0,
        IdentifierSpecified = false,
        Name = argument.Name,
        ValueRank = _ValueRank,
      };
    }
    internal static ModelDesign.ModellingRule ConvertModellingRule(this ModelingRules? modellingRule, Action<bool> isSpecified)
    {
      ModelDesign.ModellingRule _ret = default(ModelDesign.ModellingRule);
      if (!modellingRule.HasValue)
      {
        isSpecified(false);
        return _ret;
      }
      switch (modellingRule)
      {
        case ModelingRules.Mandatory:
          _ret = ModelDesign.ModellingRule.Mandatory;
          break;
        case ModelingRules.Optional:
          _ret = ModelDesign.ModellingRule.Optional;
          break;
        case ModelingRules.MandatoryPlaceholder:
          _ret = ModelDesign.ModellingRule.MandatoryPlaceholder;
          break;
        case ModelingRules.OptionalPlaceholder:
          _ret = ModelDesign.ModellingRule.OptionalPlaceholder;
          break;
        case ModelingRules.ExposesItsArray:
          _ret = ModelDesign.ModellingRule.ExposesItsArray;
          break;
      }
      isSpecified(true);
      return _ret;
    }

  }

}
