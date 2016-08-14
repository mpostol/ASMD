//_______________________________________________________________
//  Title   : ReferenceFactoryBase
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

using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using ModelDesign = Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class ReferenceFactoryBase : IReferenceFactory
  {

    #region IReferenceFactory
    public XmlQualifiedName ReferenceType
    {
      set;
      private get;
    }
    public XmlQualifiedName TargetId
    {
      set;
      private get;
    }
    public bool IsInverse
    {
      set;
      private get;
    }
    #endregion

    #region internal API
    internal ModelDesign.Reference Export()
    {
      return new ModelDesign.Reference()
      {
        IsInverse = this.IsInverse,
        IsOneWay = false, //Not supported
        ReferenceType = this.ReferenceType,
        TargetId = TargetId
      };
    }
    #endregion

  }
}
