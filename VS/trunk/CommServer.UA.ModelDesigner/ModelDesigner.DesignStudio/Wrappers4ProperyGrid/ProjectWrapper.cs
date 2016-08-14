//<summary>
//  Title   : Class that represents the UA Model Designer project
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

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.Lib.RTLib.Utils;
using CAS.UA.Model.Designer.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Class that represents the UA Model Designer project. 
  /// </summary>
  /// <remarks>Project wrapper for <see cref="System.Windows.Forms.PropertyGrid"/> to provide information about the project to the user.</remarks>
  [XmlType( "UAModelDesignerProject" )]
  [DefaultProperty( "FilePath" )]
  public class ProjectWrapper: NameWithEventBase
  {
    #region private
    private string m_filename = "";
    private string GetRelativePath( string filename )
    {
      if ( !string.IsNullOrEmpty( this.m_SolutionHomeDirectory ) && !string.IsNullOrEmpty( filename ) )
      {
        Directory.SetCurrentDirectory( this.m_SolutionHomeDirectory );
        string fullpath = Path.GetFullPath( filename );
        filename = RelativeFilePathsCalculator.TryComputeRelativePath( this.m_SolutionHomeDirectory, fullpath );
      }
      return filename;
    }
    private static UniqueNameGenerator m_UniqueNameGenerator = new UniqueNameGenerator( Resources.DefaultProjectName );
    private string m_SolutionHomeDirectory = "";
    private string m_BuildOutputDirectory = "";
    private string m_CSVFileName = "";
    private string ReplaceTokenAndReturnFullPath( string nameToBeReturned )
    {
      string myName = nameToBeReturned.Replace( Resources.Token_ProjectFileName, Path.GetFileNameWithoutExtension( FileName ) );
      if ( RelativeFilePathsCalculator.TestIfPathIsAbsolute( myName ) )
        return myName;
      string directory = Path.GetDirectoryName( FilePath );
      return Path.Combine( directory, myName );
    }
    private ServerSelector m_Server = new ServerSelector();
    #endregion private

    #region constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="UAModelDesignerProject"/> class.
    /// </summary>
    /// <remarks>It is to be used only by the serializer</remarks>
    [Obsolete( "This constructor should be only used by XML serializer" )]
    internal ProjectWrapper()
    {
      ProjectIdentifier = Guid.NewGuid();
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="UAModelDesignerProject"/> class.
    /// </summary>
    /// <param name="model">The cloned model.</param>
    /// <param name="solutionPath">The solution path.</param>
    /// <remarks>It is used to clone the object. We should remove it or replace by an implementation of the IClonable interface.</remarks>
    internal ProjectWrapper( ProjectWrapper model, string solutionPath )
    {
      m_SolutionHomeDirectory = solutionPath;
      //now we have to assign all the get/set properties
      this.FileName = model.FileName;
      this.Name = model.Name;
      this.CSVFileName = model.CSVFileName;
      this.BuildOutputDirectoryName = model.BuildOutputDirectoryName;
      this.ProjectIdentifier = model.ProjectIdentifier;
      //this.Server = model.Server;
    }
    internal ProjectWrapper( string solutionPath, string fileName )      
    {
      m_SolutionHomeDirectory = solutionPath;
      this.FileName = fileName;
      this.Name = Path.GetFileNameWithoutExtension( fileName );
      ProjectIdentifier = Guid.NewGuid();
    }
    #endregion initialisation

    #region property for property grid
    /// <summary>
    /// Gets the project file path.
    /// </summary>
    /// <value>The project file path.</value>
    [DisplayName( "Model file path" )]
    [Category( "Input" )]
    [Description( "Path of an xml file containing the model." )]
    [XmlIgnore()]
    public string FilePath
    {
      get
      {
        if ( string.IsNullOrEmpty( this.FileName ) )
          return "";
        if ( RelativeFilePathsCalculator.TestIfPathIsAbsolute( FileName ) )
          return FileName;
        StringBuilder sb = new StringBuilder();
        if ( !string.IsNullOrEmpty( this.m_SolutionHomeDirectory ) )
        {
          sb.Append( this.m_SolutionHomeDirectory );
          sb.Append( Path.DirectorySeparatorChar );
        }
        else
          return FileName;
        sb.Append( this.FileName );
        string path = Path.GetFullPath( sb.ToString() );
        return path;
      }
    }
    /// <summary>
    /// Gets or sets the name of the CSV file.
    /// </summary>
    /// <value>The name of the CSV file.</value>
    [DisplayName( "CSV file name" )]
    [Category( "Output" )]
    [Description( "CSV file contains details about objects created by the UA server at start-up. \r\n" +
      "The value indicates the file name of the coupled CSV file.\r\n" +
      "Set the name to particular name or combine the name with one of the folowing macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n" )]
    [NotifyParentProperty( true )]
    public string CSVFileName
    {
      get
      {
        if ( string.IsNullOrEmpty( m_CSVFileName ) )
          m_CSVFileName = Resources.DefaultCSVFileName;
        return m_CSVFileName;
      }
      set
      {
        m_CSVFileName = value;
      }
    }
    /// <summary>
    /// Gets the CSV file path.
    /// </summary>
    /// <value>The CSV file path.</value>
    [DisplayName( "CSV file path" )]
    [Category( "Output" )]
    [Description( "CSV file contains details about objects created by the UA server at start-up" )]
    public string CSVFilePath
    {
      get
      {
        return ReplaceTokenAndReturnFullPath( CSVFileName );
      }
    }
    [DisplayName( "Build output directory" )]
    [Category( "Output" )]
    [Description( "The value indicates the directory where goes output files after model build.\r\n" +
      "Set the name to particular name or combine the name with one of the folowing macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n" )]
    [NotifyParentProperty( true )]
    public string BuildOutputDirectoryName
    {
      get
      {
        if ( string.IsNullOrEmpty( m_BuildOutputDirectory ) )
          m_BuildOutputDirectory = Resources.DefaultOutputBuildDirectory;
        return m_BuildOutputDirectory;
      }
      set
      {
        m_BuildOutputDirectory = value;
      }
    }
    /// <summary>
    /// Gets the build output directory path.
    /// </summary>
    /// <value>The build output directory path.</value>
    [DisplayName( "Build output directory path" )]
    [Category( "Output" )]
    [Description( "It locates a default place where all output files created during the build will be created." )]
    public string BuildOutputDirectoryPath
    {
      get
      {
        return ReplaceTokenAndReturnFullPath( BuildOutputDirectoryName );
      }
    }

    #endregion

    #region XMLSerialise properties
    /// <summary>
    /// Gets or sets the name of the file.
    /// </summary>
    /// <value>The name of the file.</value>
    [Browsable( false )]
    public string FileName
    {
      get
      {
        return GetRelativePath( m_filename );
      }
      set
      {
        m_filename = value;
      }
    }
    [Browsable( false )]
    [XmlAttribute()]
    public Guid ProjectIdentifier { get; set; }
    #endregion

    #region public
    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return string.Format( "Project:{0} ({1})", Name, FileName );
    }
    internal void SetNewSolutionHomeDirectory( string newPath )
    {
      string currentFilePath = this.FilePath;
      m_SolutionHomeDirectory = newPath;
      FileName = currentFilePath;
    }
    internal void ChangeFilenameToAbsolutePath()
    {
      FileName = FilePath;
    }
    #endregion

    #region static
    internal static string UniqueProjectName { get { return m_UniqueNameGenerator.GenerateNewName(); } }
    #endregion

  }
}
