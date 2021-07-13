
//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Runtime.Serialization;

namespace UAOOI.OPCUA.CoreDefinitions
{
  /// <summary>
  /// The set of built-in data types for UA type descriptions - see Part 6 5.1.2.
  /// </summary>
  /// <remarks>
  /// An enumeration that lists all of the built-in data types for OPC UA Type Descriptions.
  /// </remarks>
  public enum BuiltInType : int
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
    /// An data type Guid.
    /// </summary>
    [EnumMemberAttribute()]
    Guid,
    /// <summary>
    /// An data type ByteString.
    /// </summary>
    [EnumMemberAttribute()]
    ByteString,
    /// <summary>
    /// An data type XmlElement.
    /// </summary>
    [EnumMemberAttribute()]
    XmlElement,
    /// <summary>
    /// An data type NodeId.
    /// </summary>
    [EnumMemberAttribute()]
    NodeId,
    /// <summary>
    /// An data type ExpandedNodeId.
    /// </summary>
    [EnumMemberAttribute()]
    ExpandedNodeId,
    /// <summary>
    /// An data type StatusCode.
    /// </summary>
    [EnumMemberAttribute()]
    StatusCode,
    /// <summary>
    /// An data type DiagnosticInfo.
    /// </summary>
    [EnumMemberAttribute()]
    DiagnosticInfo,
    /// <summary>
    /// An data type QualifiedName.
    /// </summary>
    [EnumMemberAttribute()]
    QualifiedName,
    /// <summary>
    /// An data type LocalizedText.
    /// </summary>
    [EnumMemberAttribute()]
    LocalizedText,
    /// <summary>
    /// An data type ExtensionObject.
    /// </summary>
    [EnumMemberAttribute()]
    ExtensionObject,
    /// <summary>
    /// An data type DataValue.
    /// </summary>
    [EnumMemberAttribute()]
    DataValue,
    /// <summary>
    /// An data type Variant.
    /// </summary>
    [EnumMemberAttribute()]
    Variant,
  }
}