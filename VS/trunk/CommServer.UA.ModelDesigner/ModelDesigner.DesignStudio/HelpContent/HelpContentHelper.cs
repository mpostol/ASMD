//<summary>
//  Title   : Helper to generate URL for documentation
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TopicsLibrary;

namespace CAS.UA.Model.Designer.HelpContent
{
  class HelpContentHelper
  {
    #region private
    private static SortedDictionary<string, TopicNode> urls;
    /// <summary>
    /// Initializes the <see cref="HelpContentHelper"/> class.
    /// </summary>
    static HelpContentHelper()
    {
      if ( !System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() )
        return;
      System.Net.WebClient Client = new System.Net.WebClient();
      Stream stream;
      try
      {
        using ( stream = Client.OpenRead( Properties.Settings.Default.HelpDocumentationAllTopicsWebAddress ) )
        {
          if ( stream == null )
            return;
          urls = Topics.FromXmlStream( stream );
        }
      }
      catch ( Exception ) { urls = null; }
      if ( urls == null )
        urls = new SortedDictionary<string, TopicNode>();
    }
    #endregion

    #region public
    public enum SelectedTopicName
    {
      None,
      Primary,
      Secondary
    }
    /// <summary>
    /// Gets the help URL.
    /// </summary>
    /// <param name="TopicName">Name of the topic.</param>
    /// <returns>Complete Url to the proper site of help.</returns>
    public static string GetHelpUrl( string PrimaryTopicName, string SecondaryTopicName, out SelectedTopicName selectedTopicName )
    {
      string ret = string.Empty;
      selectedTopicName = SelectedTopicName.None;
      if ( ( urls != null ) && ( urls.ContainsKey( PrimaryTopicName ) ) )
      {
        ret = Properties.Settings.Default.HelpDocumentationURLsuffix + urls[ PrimaryTopicName ].Url;
        selectedTopicName = SelectedTopicName.Primary;
      }
      if ( ( urls != null ) && string.IsNullOrEmpty( ret ) && urls.ContainsKey( SecondaryTopicName ) )
      {
        ret = Properties.Settings.Default.HelpDocumentationURLsuffix + urls[ SecondaryTopicName ].Url;
        selectedTopicName = SelectedTopicName.Secondary;
      }
      return Properties.Settings.Default.HelpDocumentationOpcUaEbookURL + ret;
    }
    public static void Initialize()
    { }
    #endregion

    #region static
    /// <summary>
    /// Deserializes objects from XML file
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <returns>Deserialized object</returns>
    internal static SortedDictionary<string, TopicNode> FromXmlStream( Stream stream )
    {
      try
      {
        StreamReader reader = new StreamReader( stream );
        Topics tpcs = null;
        using ( reader )
        {
          XmlSerializer xmlSerializer = new XmlSerializer( typeof( Topics ) );
          tpcs = (Topics)xmlSerializer.Deserialize( reader );
        }
        if ( tpcs == null )
          return null;
        return tpcs.CreateDictionary();
      }
      catch ( Exception )
      {
        return null;
      }
    }
    #endregion static
  }
}
