//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Helper that contains name of the instance.
  /// </summary>
  internal class NameWithEventBase<TModel>
    where TModel: IBaseModel
  {
    private void RaiseOnNameChangedEvent()
    {
      OnNameChanged?.Invoke(this, EventArgs.Empty);
    }
    private TModel m_Model;
    public NameWithEventBase(TModel model)
    {
      m_Model = model;
    }
    protected TModel ModelEntity
    {
      get { return m_Model; }
    }
    /// <summary>
    /// Gets or sets the name of the instance.
    /// </summary>
    /// <value>The name.</value>
    [DisplayName( "Name" )]
    [Category( "Input" )]
    [Description( "Project name – any text identifying the project." )]
    [NotifyParentProperty( true )]
    public string Name
    {
      get
      {
        return m_Model.Text;
      }
      set
      {
        m_Model.Text = value;
        RaiseOnNameChangedEvent();
      }
    }
    /// <summary>
    /// Occurs when the name is changed.
    /// </summary>
    public event EventHandler OnNameChanged;
  }
}
