﻿//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.Diagnostics;
using System.IO;

//TODO Removed dependency of the CAS.UA.Model.Designer.Wrappers on using System.Windows.Forms #38
using System.Windows.Forms;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;

namespace CAS.UA.Model.Designer.IO
{
  internal static class ImportNodeSet
  {
    internal static Tuple<OpcUaModelCompiler.ModelDesign, string> Import(string path, Action<TraceMessage> traceEvent)
    {
      try
      {
        using (OpenFileDialog _ofd = new OpenFileDialog()
        {
          CheckFileExists = true,
          FileName = path,
          Filter = Resources.NodeSet_FileDialogFilter,
          DefaultExt = Resources.NodeSet_FileDialogDefaultExt,
          Title = Resources.NodeSet_FileDialogTitle
        })
        {
          if (_ofd.ShowDialog() != DialogResult.OK)
            return null;
          Application.UseWaitCursor = true;
          FileInfo _fileInfo = new FileInfo(_ofd.FileName);
          Debug.Assert(_fileInfo.Exists);
          traceEvent(TraceMessage.DiagnosticTraceMessage($"Importing information model from the NodeSet file {_fileInfo.Name}"));
          return new Tuple<OpcUaModelCompiler.ModelDesign, string>(ImportUANodeSet.Import(_fileInfo, traceEvent), _fileInfo.Name);
        }
      }
      catch (Exception _ex)
      {
        ExceptionHandling(_ex, traceEvent);
      }
      finally
      {
        Application.UseWaitCursor = false;
      }
      return null;
    }

    private static void ExceptionHandling(Exception exception, Action<TraceMessage> traceEvent)
    {
      string _msg = String.Format(Resources.NodeSet_ImportErrorMessage, exception.GetMessageFromException());
      traceEvent(TraceMessage.DiagnosticTraceMessage(_msg));
      MessageBox.Show(_msg, Resources.NodeSet_ImportErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}