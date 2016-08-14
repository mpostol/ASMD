namespace CAS.UA.Model.Designer.StateMachineEditor
{
  partial class TransitionButton
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
    }

    private Transition transitionData;
    private string symbolicNameNameSpace;
    private CAS.UA.Model.Designer.Wrappers.ObjectTypeDesign machineObjectDesign;

    /// <summary>
    /// Gets or sets the transition.
    /// </summary>
    /// <value>The transition.</value>
    internal Transition TransitionData
    {
      get { return transitionData; }
      set { transitionData = value; }
    }

    public string SymbolicNameNameSpace
    {
      get { return symbolicNameNameSpace; }
      set { symbolicNameNameSpace = value; }
    }

    /// <summary>
    /// Gets or sets the machine object design.
    /// </summary>
    /// <value>The machine object design.</value>
    internal CAS.UA.Model.Designer.Wrappers.ObjectTypeDesign MachineObjectDesign
    {
      get { return machineObjectDesign; }
      set { machineObjectDesign = value; }
    }


    #endregion
  }
}
