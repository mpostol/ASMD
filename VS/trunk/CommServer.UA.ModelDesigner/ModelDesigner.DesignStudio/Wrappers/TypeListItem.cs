//<summary>
//  Title   : TypeListItem
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


namespace CAS.UA.Model.Designer.Wrappers
{
  internal class TypeListItem<wrapper>: INodeFactory
    where wrapper: ValidableTreeNode, new()
    //where design: Nodes.NodeDesign<OPCType>, new()
    //where OPCType: Opc.Ua.ModelCompiler.NodeDesign, new()
  {
    #region creator
    public TypeListItem() { }
    #endregion

    #region  INodeFactory
    public ValidableTreeNode Node
    {
      get { return new wrapper(); }
    }
    #endregion

    #region public
    public override string ToString()
    {
      return typeof( wrapper ).Name;
    }
    #endregion

  }
}
