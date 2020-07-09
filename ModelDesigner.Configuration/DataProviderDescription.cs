//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// Allows to get by the client all information identifying the plug-in component. Implements <see cref="IDataProviderDescription"/>
  /// </summary>
  public class DataProviderDescription : IDataProviderDescription
  {
    #region private
    private Assembly m_Fingerprint;
    #endregion

    #region IDataProviderDescription Members
    /// <summary>
    /// Gets the title custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>A string containing the assembly title.</value>
    [
    DisplayName("Title"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A string containing the assembly title.")
    ]
    public string Title
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if (dsc.Length == 0)
          return Resources.PropertyUnavailable;
        else
          return ((AssemblyTitleAttribute)dsc[0]).Title;
      }
    }
    /// <summary>
    /// Gets the full name of the assembly, also known as the display name from the <see cref="AssemblyName"/>.
    /// </summary>
    /// <value>
    /// A string that is the full name of the assembly, also known as the display name.
    /// </value>
    [
    DisplayName("Full Name"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Assembly Info"),
    DescriptionAttribute("A string that is the full name of the assembly, also known as the display name.")
    ]
    public string FullName => m_Fingerprint.GetName().FullName;
    /// <summary>
    /// Gets a company name custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>A string containing the company name.</value>
    [
    DisplayName("Company"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A string containing the company name.")
    ]
    public string Company
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (dsc.Length == 0)
          return Resources.PropertyUnavailable;
        else
          return ((AssemblyCompanyAttribute)dsc[0]).Company;
      }
    }
    /// <summary>
    /// Provides a text description for an assembly.
    /// </summary>
    /// <value>A string containing the assembly description.</value>
    [
    DisplayName("Description"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A string containing the assembly description.")
    ]
    public string Description
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (dsc.Length == 0)
          return Resources.PropertyUnavailable;
        else
          return ((AssemblyDescriptionAttribute)dsc[0]).Description;
      }
    }
    /// <summary>
    /// Gets the major, minor, build, and revision numbers of the assembly from the <see cref="AssemblyName"/>
    /// </summary>
    /// <value>
    /// A <see cref="Version"/> object representing the major, minor, build, and revision numbers of the assembly.
    /// </value>
    [
    DisplayName("Version"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Assembly Info"),
    DescriptionAttribute("A text representing the major, minor, build, and revision numbers of the assembly.")
    ]
    public Version Version => m_Fingerprint.GetName().Version;
    /// <summary>
    /// Data of last modification or release of the component.
    /// </summary>
    /// <value>
    /// A <see cref="DateTime"/> of the last modification or release of the component..
    /// </value>
    [
    DisplayName("Date"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in File Info"),
    DescriptionAttribute("Data and time of the last modification or release of the component.")
    ]
    public DateTime Date
    {
      get
      {
        FileInfo fi = new FileInfo(m_Fingerprint.Location);
        return fi.LastWriteTime;
      }
    }
    /// <summary>
    /// An unique identifier assigned to the plug-in assembly.
    /// </summary>
    /// <value>The <see cref="Guid"/> assigned to the plug-in assembly.</value>
    [
    DisplayName("Identifier"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("The guid assigned to the plug-in assembly.")
    ]
    public Guid Identifier
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(GuidAttribute), false);
        if (dsc.Length == 0)
          return Guid.Empty;
        else
          return new Guid(((GuidAttribute)dsc[0]).Value);
      }
    }
    /// <summary>
    /// Copyright custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>The copyright.</value>
    [
    DisplayName("Copyright"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A text containing the assembly copyright statement.")
    ]
    public string Copyright
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (dsc.Length == 0)
          return Resources.PropertyUnavailable;
        else
          return ((AssemblyCopyrightAttribute)dsc[0]).Copyright;
      }
    }
    /// <summary>
    /// Gets a trademark custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>The trademark.</value>
    [
    DisplayName("Trademark"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A text containing the assembly trademark.")
    ]
    public string Trademark
    {
      get
      {
        object[] dsc = m_Fingerprint.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
        if (dsc.Length == 0)
          return Resources.PropertyUnavailable;
        else
          return ((AssemblyTrademarkAttribute)dsc[0]).Trademark;
      }
    }
    /// <summary>
    /// Gets the code base.
    /// It is the location of the assembly as specified originally, for example, in
    /// an System.Reflection.AssemblyName object.
    /// </summary>
    /// <value>The location of the assembly as specified originally.</value>
    [
    DisplayName("Code Base"),
    BrowsableAttribute(true),
    CategoryAttribute("Plug-in Property"),
    DescriptionAttribute("A text containing the assembly code base,"
      + " it is the location of the assembly as specified originally,"
      + " for example, in an System.Reflection.AssemblyName object.")
    ]
    public string CodeBase => m_Fingerprint.Location;
    #endregion

    #region object override
    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString() { return FullName; }

    #endregion

    #region constructor
    internal DataProviderDescription(Assembly pAss)
    {
      m_Fingerprint = pAss;
    }
    #endregion
  }
}
