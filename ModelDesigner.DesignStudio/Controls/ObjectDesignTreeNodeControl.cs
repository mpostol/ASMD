//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{

  internal class ObjectDesignTreeNodeControl : InstanceDesignTreeNodeControl<ObjectDesign, Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>
  {

    public ObjectDesignTreeNodeControl(ObjectDesign parent) : base(parent) { }
    public override DictionaryTreeNode CreateCopy()
    {
      return new ObjectDesignTreeNodeControl(ModelEntity);
    }
  }

}
