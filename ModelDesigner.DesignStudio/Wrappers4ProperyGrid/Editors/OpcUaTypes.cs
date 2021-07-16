//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Runtime.Serialization;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// The set of built-in data types for UA type descriptions - see Part 6 5.1.2.
  /// </summary>
  /// <remarks>
  /// An enumeration that lists all of the built-in data types for OPC UA Type Descriptions.
  /// </remarks>
  public enum OpcUaTypesList : int
  {
    /// <summary>
    /// An data type Boolean.
    /// </summary>
    [EnumMemberAttribute()]
    Boolean,

    /// <summary>
    /// An data type SByte.
    /// </summary>
    [EnumMemberAttribute()]
    SByte,

    /// <summary>
    /// An data type Byte.
    /// </summary>
    [EnumMemberAttribute()]
    Byte,

    /// <summary>
    /// An data type Int16.
    /// </summary>
    [EnumMemberAttribute()]
    Int16,

    /// <summary>
    /// An data type UInt16.
    /// </summary>
    [EnumMemberAttribute()]
    UInt16,

    /// <summary>
    /// An data type Int32.
    /// </summary>
    [EnumMemberAttribute()]
    Int32,

    /// <summary>
    /// An data type UInt32.
    /// </summary>
    [EnumMemberAttribute()]
    UInt32,

    /// <summary>
    /// An data type Int64.
    /// </summary>
    [EnumMemberAttribute()]
    Int64,

    /// <summary>
    /// An data type UInt64.
    /// </summary>
    [EnumMemberAttribute()]
    UInt64,

    /// <summary>
    /// An data type Float.
    /// </summary>
    [EnumMemberAttribute()]
    Float,

    /// <summary>
    /// An data type Double.
    /// </summary>
    [EnumMemberAttribute()]
    Double,

    /// <summary>
    /// An data type String.
    /// </summary>
    [EnumMemberAttribute()]
    String,

    /// <summary>
    /// An data type DateTime.
    /// </summary>
    [EnumMemberAttribute()]
    DateTime,

    /// <summary>
    /// An data type ByteString.
    /// </summary>
    [EnumMemberAttribute()]
    ByteString,

    /// <summary>
    /// An data type InvokeServiceRequest.
    /// </summary>
    [EnumMemberAttribute()]
    InvokeServiceRequest,

    /// <summary>
    /// An data type InvokeServiceResponse.
    /// </summary>
    [EnumMemberAttribute()]
    InvokeServiceResponse,

    /// <summary>
    /// An data type ImageBMP.
    /// </summary>
    [EnumMemberAttribute()]
    ImageBMP,

    /// <summary>
    /// An data type ImageGIF.
    /// </summary>
    [EnumMemberAttribute()]
    ImageGIF,

    /// <summary>
    /// An data type ImageJPG.
    /// </summary>
    [EnumMemberAttribute()]
    ImageJPG,

    /// <summary>
    /// An data type ImagePNG.
    /// </summary>
    [EnumMemberAttribute()]
    ImagePNG,

    /// <summary>
    /// An data type AudioDataType.
    /// </summary>
    [EnumMemberAttribute()]
    AudioDataType,

    /// <summary>
    /// An data type BitFieldMaskDataType.
    /// </summary>
    [EnumMemberAttribute()]
    BitFieldMaskDataType,

    /// <summary>
    /// An data type OpenFileMode.
    /// </summary>
    [EnumMemberAttribute()]
    OpenFileMode,

    /// <summary>
    /// An data type IdentityCriteriaType.
    /// </summary>
    [EnumMemberAttribute()]
    IdentityCriteriaType,

    /// <summary>
    /// An data type TrustListMasks.
    /// </summary>
    [EnumMemberAttribute()]
    TrustListMasks,

    /// <summary>
    /// An data type PubSubState.
    /// </summary>
    [EnumMemberAttribute()]
    PubSubState,

    /// <summary>
    /// An data type DataSetFieldFlags.
    /// </summary>
    [EnumMemberAttribute()]
    DataSetFieldFlags,

    /// <summary>
    /// An data type DataSetFieldContentMask.
    /// </summary>
    [EnumMemberAttribute()]
    DataSetFieldContentMask,

    /// <summary>
    /// An data type OverrideValueHandling.
    /// </summary>
    [EnumMemberAttribute()]
    OverrideValueHandling,

    /// <summary>
    /// An data type DataSetOrderingType.
    /// </summary>
    [EnumMemberAttribute()]
    DataSetOrderingType,

    /// <summary>
    /// An data type UadpNetworkMessageContentMask.
    /// </summary>
    [EnumMemberAttribute()]
    UadpNetworkMessageContentMask,

    /// <summary>
    /// An data type UadpDataSetMessageContentMask.
    /// </summary>
    [EnumMemberAttribute()]
    UadpDataSetMessageContentMask,

    /// <summary>
    /// An data type JsonNetworkMessageContentMask.
    /// </summary>
    [EnumMemberAttribute()]
    JsonNetworkMessageContentMask,

    /// <summary>
    /// An data type JsonDataSetMessageContentMask.
    /// </summary>
    [EnumMemberAttribute()]
    JsonDataSetMessageContentMask,

    /// <summary>
    /// An data type BrokerTransportQualityOfService.
    /// </summary>
    [EnumMemberAttribute()]
    BrokerTransportQualityOfService,

    /// <summary>
    /// An data type DiagnosticsLevel.
    /// </summary>
    [EnumMemberAttribute()]
    DiagnosticsLevel,

    /// <summary>
    /// An data type PubSubDiagnosticsCounterClassification.
    /// </summary>
    [EnumMemberAttribute()]
    PubSubDiagnosticsCounterClassification,

    /// <summary>
    /// An data type IdType.
    /// </summary>
    [EnumMemberAttribute()]
    IdType,

    /// <summary>
    /// An data type NodeClass.
    /// </summary>
    [EnumMemberAttribute()]
    NodeClass,

    /// <summary>
    /// An data type PermissionType.
    /// </summary>
    [EnumMemberAttribute()]
    PermissionType,

    /// <summary>
    /// An data type AccessLevelType.
    /// </summary>
    [EnumMemberAttribute()]
    AccessLevelType,

    /// <summary>
    /// An data type AccessLevelExType.
    /// </summary>
    [EnumMemberAttribute()]
    AccessLevelExType,

    /// <summary>
    /// An data type EventNotifierType.
    /// </summary>
    [EnumMemberAttribute()]
    EventNotifierType,

    /// <summary>
    /// An data type StructureType.
    /// </summary>
    [EnumMemberAttribute()]
    StructureType,

    /// <summary>
    /// An data type NormalizedString.
    /// </summary>
    [EnumMemberAttribute()]
    NormalizedString,

    /// <summary>
    /// An data type DecimalString.
    /// </summary>
    [EnumMemberAttribute()]
    DecimalString,

    /// <summary>
    /// An data type DurationString.
    /// </summary>
    [EnumMemberAttribute()]
    DurationString,

    /// <summary>
    /// An data type TimeString.
    /// </summary>
    [EnumMemberAttribute()]
    TimeString,

    /// <summary>
    /// An data type DateString.
    /// </summary>
    [EnumMemberAttribute()]
    DateString,

    /// <summary>
    /// An data type Duration.
    /// </summary>
    [EnumMemberAttribute()]
    Duration,

    /// <summary>
    /// An data type UtcTime.
    /// </summary>
    [EnumMemberAttribute()]
    UtcTime,

    /// <summary>
    /// An data type LocaleId.
    /// </summary>
    [EnumMemberAttribute()]
    LocaleId,

    /// <summary>
    /// An data type Index.
    /// </summary>
    [EnumMemberAttribute()]
    Index,

    /// <summary>
    /// An data type IntegerId.
    /// </summary>
    [EnumMemberAttribute()]
    IntegerId,

    /// <summary>
    /// An data type ApplicationType.
    /// </summary>
    [EnumMemberAttribute()]
    ApplicationType,

    /// <summary>
    /// An data type VersionTime.
    /// </summary>
    [EnumMemberAttribute()]
    VersionTime,

    /// <summary>
    /// An data type ApplicationInstanceCertificate.
    /// </summary>
    [EnumMemberAttribute()]
    ApplicationInstanceCertificate,

    /// <summary>
    /// An data type MessageSecurityMode.
    /// </summary>
    [EnumMemberAttribute()]
    MessageSecurityMode,

    /// <summary>
    /// An data type UserTokenType.
    /// </summary>
    [EnumMemberAttribute()]
    UserTokenType,

    /// <summary>
    /// An data type SecurityTokenRequestType.
    /// </summary>
    [EnumMemberAttribute()]
    SecurityTokenRequestType,

    /// <summary>
    /// An data type NodeAttributesMask.
    /// </summary>
    [EnumMemberAttribute()]
    NodeAttributesMask,

    /// <summary>
    /// An data type AttributeWriteMask.
    /// </summary>
    [EnumMemberAttribute()]
    AttributeWriteMask,

    /// <summary>
    /// An data type BrowseDirection.
    /// </summary>
    [EnumMemberAttribute()]
    BrowseDirection,

    /// <summary>
    /// An data type BrowseResultMask.
    /// </summary>
    [EnumMemberAttribute()]
    BrowseResultMask,

    /// <summary>
    /// An data type ContinuationPoint.
    /// </summary>
    [EnumMemberAttribute()]
    ContinuationPoint,

    /// <summary>
    /// An data type Counter.
    /// </summary>
    [EnumMemberAttribute()]
    Counter,

    /// <summary>
    /// An data type NumericRange.
    /// </summary>
    [EnumMemberAttribute()]
    NumericRange,

    /// <summary>
    /// An data type FilterOperator.
    /// </summary>
    [EnumMemberAttribute()]
    FilterOperator,

    /// <summary>
    /// An data type TimestampsToReturn.
    /// </summary>
    [EnumMemberAttribute()]
    TimestampsToReturn,

    /// <summary>
    /// An data type HistoryUpdateType.
    /// </summary>
    [EnumMemberAttribute()]
    HistoryUpdateType,

    /// <summary>
    /// An data type PerformUpdateType.
    /// </summary>
    [EnumMemberAttribute()]
    PerformUpdateType,

    /// <summary>
    /// An data type MonitoringMode.
    /// </summary>
    [EnumMemberAttribute()]
    MonitoringMode,

    /// <summary>
    /// An data type DataChangeTrigger.
    /// </summary>
    [EnumMemberAttribute()]
    DataChangeTrigger,

    /// <summary>
    /// An data type DeadbandType.
    /// </summary>
    [EnumMemberAttribute()]
    DeadbandType,

    /// <summary>
    /// An data type RedundancySupport.
    /// </summary>
    [EnumMemberAttribute()]
    RedundancySupport,

    /// <summary>
    /// An data type ServerState.
    /// </summary>
    [EnumMemberAttribute()]
    ServerState,

    /// <summary>
    /// An data type ModelChangeStructureVerbMask.
    /// </summary>
    [EnumMemberAttribute()]
    ModelChangeStructureVerbMask,

    /// <summary>
    /// An data type AxisScaleEnumeration.
    /// </summary>
    [EnumMemberAttribute()]
    AxisScaleEnumeration,

    /// <summary>
    /// An data type ExceptionDeviationFormat.
    /// </summary>
    [EnumMemberAttribute()]
    ExceptionDeviationFormat,
  }
}