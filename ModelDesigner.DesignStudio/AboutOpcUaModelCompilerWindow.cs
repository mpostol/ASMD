//<summary>
//  Title   : About ModelCompiler window
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer
{
  partial class AboutOpcUaModelCompilerWindow : Form
  {

    public AboutOpcUaModelCompilerWindow()
    {
      InitializeComponent();
      this.Text = c_CAption;
      this.labelProductName.Text = "OPC.UA.Model.Compiler";
      this.labelVersion.Text = "xx.xx.xx";
      this.labelCopyright.Text = "CAS (c) 2015";
      this.labelCompanyName.Text = "Company name: CAS";
    }

    protected override void OnLoad(EventArgs e)
    {
      string _fileName = String.Empty;
      try
      {
        _fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Properties.Settings.Default.ProjectCompilationExecutable);
        Assembly _mc = Assembly.LoadFrom(_fileName);
        Dictionary<string, Attribute> _ats = _mc.GetCustomAttributes(false).Cast<Attribute>().ToDictionary<Attribute, string>(x => x.GetType().Name);
        this.labelProductName.Text = ((AssemblyDescriptionAttribute)_ats[typeof(AssemblyDescriptionAttribute).Name]).Description;
        this.labelVersion.Text = _mc.GetName().Version.ToString();
        this.labelCopyright.Text = ((AssemblyCopyrightAttribute)_ats[typeof(AssemblyCopyrightAttribute).Name]).Copyright;
        this.labelCompanyName.Text = ((AssemblyCompanyAttribute)_ats[typeof(AssemblyCompanyAttribute).Name]).Company;
      }
      catch (Exception _ex)
      {
        MessageBox.Show(String.Format("Cannot load the {0} because of error {1}", _fileName, _ex.Message), c_CAption, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      base.OnLoad(e);
    }
    private const string c_CAption = "About OPC UA Model Compiler";
  }
}
