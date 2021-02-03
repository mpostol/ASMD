//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.ComponentModel;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal class Transition
  {
    private InstanceDesign<OpcUaModelCompiler.ObjectDesign> instanceDesignNode;
    private string fromState;
    private string toState;
    private string hasCause;

    /// <summary>
    /// Gets or sets from state.
    /// </summary>
    /// <value>From state.</value>
    [CategoryAttribute("Transition data")]
    [DescriptionAttribute("Beginning state of the transition.")]
    [ReadOnlyAttribute(true)]
    public string FromState
    {
      get => fromState;
      set => fromState = value;
    }

    /// <summary>
    /// Gets or sets to state.
    /// </summary>
    /// <value>To state.</value>
    [CategoryAttribute("Transition data")]
    [DescriptionAttribute("Ending state of the transition.")]
    [ReadOnlyAttribute(true)]
    public string ToState
    {
      get => toState;
      set => toState = value;
    }

    /// <summary>
    /// Gets or sets the has cause.
    /// </summary>
    /// <value>The has cause.</value>
    [CategoryAttribute("Transition data")]
    [DescriptionAttribute("Cause of the transition.")]
    [ReadOnlyAttribute(false)]
    public string HasCause
    {
      get => hasCause;
      set => hasCause = value;
    }

    /// <summary>
    /// Gets or sets the instance design node.
    /// </summary>
    /// <value>The instance design node.</value>
    internal InstanceDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectDesign> InstanceDesignNode
    {
      get => instanceDesignNode;
      set => instanceDesignNode = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Transition"/> class.
    /// </summary>
    /// <param name="fromState">From state.</param>
    /// <param name="toState">To state.</param>
    /// <param name="hasCause">The has cause.</param>
    /// <param name="instanceDesignNode">The instance design node.</param>
    internal Transition(string fromState, string toState, string hasCause, InstanceDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectDesign> instanceDesignNode)
    {
      this.FromState = fromState;
      this.ToState = toState;
      this.HasCause = hasCause;
      this.instanceDesignNode = instanceDesignNode;
    }

    /// <summary>
    /// Updates the specified transition on list.
    /// </summary>
    /// <param name="transitionOnList">The transition on list.</param>
    internal void Update(Transition transitionOnList)
    {
      this.FromState = transitionOnList.FromState;
      this.ToState = transitionOnList.ToState;
      this.HasCause = transitionOnList.HasCause;
      this.InstanceDesignNode = transitionOnList.InstanceDesignNode;
    }
  }
}