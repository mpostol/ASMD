//_______________________________________________________________
//  Title   : ImportNodeSet
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

using CAS.UA.Model.Designer.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.UA.Model.Designer.IO
{
  internal static class ImportNodeSet
  {
    internal static Tuple<Opc.Ua.ModelCompiler.ModelDesign, string> Import(string path, Action<TraceMessage> traceEvent)
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
          traceEvent(TraceMessage.DiagnosticTraceMessage($"Importing information model from the NodeSetfile {_fileInfo.Name}"));
          return new Tuple<Opc.Ua.ModelCompiler.ModelDesign, string>(ImportExport.NodeSet.AddressSpaceContextService.CreateInstance(_fileInfo, traceEvent), _fileInfo.Name);
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
