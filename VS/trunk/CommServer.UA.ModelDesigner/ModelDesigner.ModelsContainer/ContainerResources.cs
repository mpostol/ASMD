//_______________________________________________________________
//  Title   : Resources
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
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ConfigurationEditor.ModelsContainer
{
  /// <summary>
  /// Class Resources - contains helpers to manage resources in the module
  /// </summary>
  public static class ContainerResources
  {
    /// <summary>
    /// Installation of the examples.
    /// </summary>
    /// <param name="destinationFolder">The destination folder.</param>
    /// <param name="trace">The trace.</param>
    public static void ExampleSolutionInstallation(string destinationFolder, Action<string, TraceEventType> trace)
    {
      //creating the directory
      string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), destinationFolder);
      string _destinationPath = _path;
      DirectoryInfo _destinationDirectoryInfo = new DirectoryInfo(_destinationPath);
      int _cnt = 0;
      while (_destinationDirectoryInfo.Exists)
      {
        _destinationPath = _path + String.Format("{0}", _cnt++);
        _destinationDirectoryInfo = new DirectoryInfo(_destinationPath);
      }
      _destinationDirectoryInfo.Create();
      //copying of example files from assembly embedded resources
      Assembly myAssembly = Assembly.GetExecutingAssembly();
      string currentNamespace = typeof(ContainerResources).Namespace + EmbeddedExampleFolder;
      foreach (string _name in myAssembly.GetManifestResourceNames())
      {
        if (!_name.Contains(EmbeddedExampleFolder))
          continue;
        string _relPath = _name.Replace(currentNamespace, "");
        foreach (string _folder in m_ProjectFolders)
          if (_relPath.StartsWith(_folder))
          {
            _relPath = _relPath.Replace(_folder + ".", "");
            _relPath = Path.Combine(_folder, _relPath);
          }
        FileInfo _fi = new FileInfo(Path.Combine(_destinationPath, _relPath));
        DirectoryInfo _di = _fi.Directory;
        if (!_di.Exists)
          _di.Create();
        trace(String.Format("Installing the example file: {0}", _fi.FullName), TraceEventType.Verbose);
        using (Stream _res = myAssembly.GetManifestResourceStream(_name))
          CopyStream(_res, _fi);
      }
    }
    private static string[] m_ProjectFolders = new string[] { "ADISampleConfiguration", "DemoConfiguration" };
    private const string EmbeddedExampleFolder = ".EmbeddedExample."; // it is the name of the folder in the project that contains all demo files 
    /// <summary>
    /// Copies the contents of input to output. Doesn't close either stream.
    /// </summary>
    /// <param name="input">The input <see cref="Stream"/>.</param>
    /// <param name="outputFileName">Name of the output file <see cref="FileInfo"/>.</param>
    private static void CopyStream(Stream input, FileInfo outputFileName)
    {
      using (Stream file = outputFileName.OpenWrite())
      {
        byte[] buffer = new byte[8 * 1024];
        int len;
        while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
        {
          file.Write(buffer, 0, len);
        }
      }
    }

  }
}
