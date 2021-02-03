//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System.IO;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Wrapper base class - it is to be used as a base for all ModelDesign wrapped classes
  /// </summary>
  /// <typeparam name="OPCType">The OPCType of the wrapped class</typeparam>
  internal abstract class WrapperBase<type, OPCType> : ValidableTreeNode
    where type : Wrappers4ProperyGrid.Design<OPCType>
    where OPCType : class, new()
  {
    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="WrapperBase&lt;OPCType&gt;"/> class.
    /// </summary>
    /// <param name="child">The child (wrapped) object .</param>
    public WrapperBase(type child)
      : base(child)
    {
      Wrapper.Parent = this;
      Validate();
    }

    #endregion constructors

    #region IParent

    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>
    /// The model designer node derived from <see cref="OpcUaModelCompiler.NodeDesign"/>.
    /// </value>
    public override object ModelDesignerNode => Wrapper.Update();

    #endregion IParent

    #region public

    internal new type Wrapper => (type)base.Wrapper;
    public string ClipboardText { get; private set; }

    #endregion public

    #region private

    public override void MenuItemCopy_Action()
    {
      base.MenuItemCopy_Action();
      System.Windows.Forms.Clipboard.SetText(this.ModelDesignerNodeStringRepresentation);
    }

    protected string ModelDesignerNodeStringRepresentation
    {
      get
      {
        StringWriter sw = new System.IO.StringWriter();
        XmlSerializer serializer = new XmlSerializer(this.ModelDesignerNode.GetType());
        serializer.Serialize(sw, this.ModelDesignerNode);
        return sw.ToString();
      }
    }

    #endregion private
  }
}