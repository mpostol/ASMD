//_______________________________________________________________
//  Title   : Extensions for CAS.UA.Model.Designer
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS.UA.Model.Designer
{
  internal static class Extensions
  {
    internal static string GetMessageFromException(this Exception ex)
    {
      string message_from_ex = ex.Message;
      if (ex.InnerException != null)
        message_from_ex += "(" + ex.InnerException.Message + ")";
      return message_from_ex;
    }
  }
}
