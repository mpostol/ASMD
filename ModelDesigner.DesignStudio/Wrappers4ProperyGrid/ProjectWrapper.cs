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

using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Class that represents the UA Model Designer project. 
  /// </summary>
  /// <remarks>Project wrapper for <see cref="System.Windows.Forms.PropertyGrid"/> to provide information about the project to the user.</remarks>
  [DefaultProperty("FilePath")]
  internal class ProjectWrapper : NameWithEventBase<ProjectTreeNode>, IViewModel
  {

    #region constructors
    internal ProjectWrapper(ProjectTreeNode projecModel) : base(projecModel) { }
    #endregion initialisation

    #region browsable properties
    /// <summary>
    /// Gets the project file path.
    /// </summary>
    /// <value>The project file path.</value>
    [DisplayName("Model file path")]
    [Category("Input")]
    [Description("Path of an xml file containing the model.")]
    public string FilePath
    {
      get { return ModelEntity.FilePath; }
    }
    /// <summary>
    /// Gets or sets the name of the CSV file.
    /// </summary>
    /// <value>The name of the CSV file.</value>
    [DisplayName("CSV file name")]
    [Category("Output")]
    [Description("CSV file contains details about objects created by the UA server at start-up. \r\n" +
      "The value indicates the file name of the coupled CSV file.\r\n" +
      "Set the name to particular name or combine the name with one of the folowing macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n")]
    [NotifyParentProperty(true)]
    public string CSVFileName
    {
      get
      {
        return ModelEntity.CSVFileName;
      }
      set
      {
        ModelEntity.CSVFileName = value;
      }
    }
    /// <summary>
    /// Gets the CSV file path.
    /// </summary>
    /// <value>The CSV file path.</value>
    [DisplayName("CSV file path")]
    [Category("Output")]
    [Description("CSV file contains details about objects created by the UA server at start-up")]
    public string CSVFilePath
    {
      get
      {
        return ModelEntity.CSVFilePath;
      }
    }
    [DisplayName("Build output directory")]
    [Category("Output")]
    [Description("The value indicates the directory where goes output files after model build.\r\n" +
      "Set the name to particular name or combine the name with one of the folowing macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n")]
    [NotifyParentProperty(true)]
    public string BuildOutputDirectoryName
    {
      get
      {
        return ModelEntity.BuildOutputDirectoryName;
      }
      set
      {
        ModelEntity.BuildOutputDirectoryName = value;
      }
    }
    /// <summary>
    /// Gets the build output directory path.
    /// </summary>
    /// <value>The build output directory path.</value>
    [DisplayName("Build output directory path")]
    [Category("Output")]
    [Description("It locates a default place where all output files created during the build will be created.")]
    public string BuildOutputDirectoryPath
    {
      get
      {
        return ModelEntity.BuildOutputDirectoryPath;
      }
    }
    #endregion

    #region override Object
    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return $"Project:{Name} ({ModelEntity.FileName})";
    }
    #endregion
  }
}
