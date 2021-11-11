//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Collections.Generic;
using System.Xml;
using UAOOI.Common.Infrastructure.Serializers;

namespace CAS.UA.Model.Designer.ImportExport.ExportingStructures
{
    public partial class topic : INamespaces
    {
        /// <summary>
        ///   Get  Namespace
        /// </summary>
        public IEnumerable<XmlQualifiedName> GetNamespaces()
        {
            List<XmlQualifiedName> nsList = new List<XmlQualifiedName> { new XmlQualifiedName("", "http://ddue.schemas.microsoft.com/authoring/2003/5") };
            return nsList;
        }
    }
}