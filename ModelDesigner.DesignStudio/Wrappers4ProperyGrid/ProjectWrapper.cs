//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Class that represents the UA Model Designer project.
  /// </summary>
  /// <remarks>Project wrapper to provide information about the project to the user.</remarks>
  [DefaultProperty("FilePath")]
  internal class ProjectWrapper : NameWithEventBase<IProjectModel>, IViewModel
  {
    #region constructors

    internal ProjectWrapper(IProjectModel projectModel) : base(projectModel)
    {
    }

    #endregion constructors

    #region brows-able properties

    /// <summary>
    /// Gets the project file path.
    /// </summary>
    /// <value>The project file path.</value>
    [DisplayName("Model file path")]
    [Category("Input")]
    [Description("Path of an xml file containing the model.")]
    public string FilePath => string.Empty;//ModelEntity.CalculateEffectiveAbsoluteModelFilePath();

    /// <summary>
    /// Gets or sets the name of the CSV file.
    /// </summary>
    /// <value>The name of the CSV file.</value>
    [DisplayName("CSV file name")]
    [Category("Output")]
    [Description("CSV file contains details about objects created by the UA server at start-up. \r\n" +
      "The value indicates the file name of the coupled CSV file.\r\n" +
      "Set the name to particular name or combine the name with one of the following macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n")]
    [NotifyParentProperty(true)]
    public string CSVFileName => string.Empty; //ModelEntity.CSVFileName;

    /// <summary>
    /// Gets the CSV file path.
    /// </summary>
    /// <value>The CSV file path.</value>
    [DisplayName("CSV file path")]
    [Category("Output")]
    [Description("CSV file contains details about objects created by the UA server at start-up")]
    public string CSVFilePath => string.Empty;// ModelEntity.CSVFilePath;

    [DisplayName("Build output directory")]
    [Category("Output")]
    [Description("The value indicates the directory where saves output files after model build.\r\n" +
      "Set the name to particular name or combine the name with one of the following macros: \r\n" +
      "$(ProjectFileName) – project file name (without extension) \r\n")]
    [NotifyParentProperty(true)]
    public string BuildOutputDirectoryName => string.Empty;// ModelEntity.BuildOutputDirectoryName;

    /// <summary>
    /// Gets the build output directory path.
    /// </summary>
    /// <value>The build output directory path.</value>
    [DisplayName("Build output directory path")]
    [Category("Output")]
    [Description("It locates a default place where all output files created during the build will be created.")]
    public string BuildOutputDirectoryPath => string.Empty; // ModelEntity.BuildOutputDirectoryPath;

    #endregion brows-able properties

    #region override Object

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return $"Project:{Name} TBD"; // ({ModelEntity.FileName})";
    }

    #endregion override Object
  }
}