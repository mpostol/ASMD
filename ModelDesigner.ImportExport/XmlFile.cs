//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Provides static methods for serialization objects into XML documents and writing the XML document to a file.
  /// </summary>
  public static class XmlFile
  {
    #region public

    /// <summary>
    /// Reads an XML document from the file <paramref name="path"/> and deserializes its content to returned object.
    /// </summary>
    /// <typeparam name="type">The type of the object to be deserialized and saved in the file.</typeparam>
    /// <param name="path">A relative or absolute path for the file containing the serialized object.</param>
    /// <returns>An object containing working data retrieved from an XML file.</returns>
    /// <exception cref="System.ArgumentNullException">path</exception>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
    public static type ReadXmlFile<type>(string path)
    {
      if (string.IsNullOrEmpty(path))
        throw new ArgumentNullException("path");
      return UAOOI.Common.Infrastructure.Serializers.XmlFile.ReadXmlFile<type>(path);
      //type _content = default(type);
      ////TODO Use Common XML serializer to manage xml documents #228
      //XmlSerializer _srlzr = new XmlSerializer(typeof(type));
      //using (FileStream _docStrm = new FileStream(path, FileMode.Open, FileAccess.Read))
      //using (XmlReader _writer = XmlReader.Create(_docStrm))
      //  _content = (type)_srlzr.Deserialize(_writer);
      //return _content;
    }

    #endregion public
  }
}