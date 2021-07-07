//<summary>
//  Title   : Node factory
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

using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Creates classes from <see cref="TargetNameSpace"/>
  /// </summary>
  internal static class NodeFactory
  {
    internal static string TargetNameSpace = "CAS.UA.Model.Designer.Wrappers.";
    /// <summary>
    /// Creates object with name as concatenation of the TargetNameSpace and the name of the specified child.
    /// </summary>
    /// <param name="child">The source object.</param>
    /// <returns></returns>
    internal static BaseModel Create( object node )
    {
      string name = TargetNameSpace + node.GetType().Name;
      return (BaseModel)Activator.CreateInstance( Type.GetType( name ), node );
    }
  }
}
