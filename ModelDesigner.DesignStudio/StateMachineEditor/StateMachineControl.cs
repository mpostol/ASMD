//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using System;
using System.Windows.Forms;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.Lib.ControlLibrary;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal partial class StateMachineControl: UserControl
  {

    #region constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="StateMachineControl"/> class.
    /// </summary>
    /// 
    internal StateMachineControl()
    {
      InitializeComponent();
    }
    #endregion

    #region private
    #region constants
    private TransitionButton selectedTransitionButton;
    private const string newTransitionString = "New transition";
    private const string transitionDataString = "Transition data";
    private const string hasCauseString = "HasCause";
    private const string transitionTypeString = "TransitionType";
    private const string fromStateString = "FromState";
    private const string toStateString = "ToState";
    private const string uaNamesaceString = "http://opcfoundation.org/UA/";
    #endregion constants
    /// <summary>
    /// Handles the Click event of the buttonTransition control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void buttonTransition_Click( object sender, EventArgs e )
    {
      selectedTransitionButton = sender as TransitionButton;
      if ( ( (TransitionButton)sender ).Image == null ) //add new transition
      {
        OKCancelForm newTransitionForm = new OKCancelForm( newTransitionString );
        newTransitionForm.CanBeAccepted( true );
        PropertyGrid propertyGridTransition = new PropertyGrid();
        propertyGridTransition.Anchor = ( AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top );
        propertyGridTransition.SelectedObject = selectedTransitionButton.TransitionData;
        UserControl uc = new UserControl();
        uc.Controls.Add(propertyGridTransition);
        newTransitionForm.SetUserControl = uc;
        if ( newTransitionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK )
          OnAddTransition();
        else
          newTransitionForm.Close();
      }
      else //show or delete transition
      {
        OKCancelForm showOrDeleteTransitionDataForm = new OKCancelForm( transitionDataString );
        showOrDeleteTransitionDataForm.CanBeAccepted( true );
        showOrDeleteTransitionDataForm.AddButton( "Delete", System.Windows.Forms.DialogResult.Ignore );
        PropertyGrid propertyGridTransition = new PropertyGrid();
        propertyGridTransition.Anchor = ( AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top );
        propertyGridTransition.SelectedObject = selectedTransitionButton.TransitionData;
        UserControl uc = new UserControl();
        uc.Controls.Add( propertyGridTransition );
        showOrDeleteTransitionDataForm.SetUserControl = uc;
        System.Windows.Forms.DialogResult dr = showOrDeleteTransitionDataForm.ShowDialog();
        if ( dr == System.Windows.Forms.DialogResult.OK )
          OnOk();
        else if ( dr == System.Windows.Forms.DialogResult.Cancel )
          Properties.Settings.Default.Reload();
        else if ( dr == System.Windows.Forms.DialogResult.Ignore )
          OnDelete();
      }
    }

    /// <summary>
    /// Called when [delete].
    /// </summary>
    private void OnDelete()
    {
      if ( selectedTransitionButton.TransitionData != null )
      {
        ( (BaseTreeNode)selectedTransitionButton.TransitionData.InstanceDesignNode.Parent ).Parent.Remove( (BaseTreeNode)selectedTransitionButton.TransitionData.InstanceDesignNode.Parent );
        selectedTransitionButton.Image = null;
        selectedTransitionButton.FlatStyle = FlatStyle.Flat;
      }
    }

    /// <summary>
    /// Called when [ok].
    /// </summary>
    private void OnOk()
    {
      if ( selectedTransitionButton.TransitionData != null )
      {
        ObjectDesign myObjectDesign = selectedTransitionButton.TransitionData.InstanceDesignNode.Parent as ObjectDesign;
        if ( myObjectDesign != null )
        {
          if ( myObjectDesign.References.Count > 2 )
          {
            foreach ( Reference referenceAsBaseTreeNode in myObjectDesign.References )
            {
              Reference reference = referenceAsBaseTreeNode as Reference;
              if ( reference != null && reference.Wrapper.ReferenceType.Name == hasCauseString )
              {
                string referenceNameOriginal;
                if ( reference.Wrapper.TargetId.Name.Contains( "_" ) == true )
                  referenceNameOriginal = ( reference.Wrapper.TargetId.Name ).Substring( ( reference.Wrapper.TargetId.Name ).LastIndexOf( "_" ), ( reference.Wrapper.TargetId.Name ).Length - ( reference.Wrapper.TargetId.Name ).LastIndexOf( "_" ) ).Replace( "_", "" );
                else
                  referenceNameOriginal = reference.Wrapper.TargetId.Name;
                if ( ( referenceNameOriginal != selectedTransitionButton.TransitionData.HasCause ) && ( string.IsNullOrEmpty( selectedTransitionButton.TransitionData.HasCause ) != true ) && ( string.IsNullOrEmpty( referenceNameOriginal ) != true ) )
                {
                  ( referenceAsBaseTreeNode as Reference ).Wrapper.TargetId.Name = selectedTransitionButton.TransitionData.HasCause;
                  return;
                }
                else if ( ( referenceNameOriginal != selectedTransitionButton.TransitionData.HasCause ) && ( string.IsNullOrEmpty( selectedTransitionButton.TransitionData.HasCause ) == true ) )
                {
                  ( (BaseTreeNode)( referenceAsBaseTreeNode as Reference ).Wrapper.Parent ).Parent.Remove( (BaseTreeNode)( referenceAsBaseTreeNode as Reference ).Wrapper.Parent );
                  reference = null;
                  return;
                }
              }
            }
          }
          else if ( ( myObjectDesign.References.Count <= 2 ) && ( string.IsNullOrEmpty( selectedTransitionButton.TransitionData.HasCause ) != true ) )
          {
            Reference reference = new Reference();
            reference.Wrapper.IsOneWay = false;
            reference.Wrapper.IsInverse = false;
            reference.Wrapper.ReferenceType.Name = hasCauseString;
            reference.Wrapper.ReferenceType.NameSpace = myObjectDesign.References.References[ 0 ].ReferenceType.Namespace;
            reference.Wrapper.TargetId.Name =  selectedTransitionButton.TransitionData.HasCause;
            reference.Wrapper.TargetId.NameSpace = myObjectDesign.References.References[ 0 ].TargetId.Namespace;
            reference.Wrapper.Validate();
            myObjectDesign.References.Add( reference );
            myObjectDesign.Wrapper.Validate();
            return;
          }
        }
      }
    }

    /// <summary>
    /// Called when [add transition].
    /// </summary>
    private void OnAddTransition()
    {
      ObjectDesign newTransitionObjectDesign = new ObjectDesign();
      newTransitionObjectDesign.Wrapper.MaxCardinality = 0;
      newTransitionObjectDesign.Wrapper.MinCardinality = 0;
      newTransitionObjectDesign.Wrapper.PreserveDefaultAttributes = false;
      newTransitionObjectDesign.Wrapper.TypeDefinition.Name = transitionTypeString;
      newTransitionObjectDesign.Wrapper.TypeDefinition.NameSpace = uaNamesaceString;
      newTransitionObjectDesign.Wrapper.SymbolicName.Name = "From" + selectedTransitionButton.TransitionData.FromState + "To" + selectedTransitionButton.TransitionData.ToState;
      newTransitionObjectDesign.Wrapper.SymbolicName.NameSpace = selectedTransitionButton.SymbolicNameNameSpace;
      newTransitionObjectDesign.Wrapper.WriteAccess = 0;
      newTransitionObjectDesign.Wrapper.IsDeclaration = false;
      Reference fromStateReference = new Reference();
      fromStateReference.Wrapper.IsOneWay = false;
      fromStateReference.Wrapper.IsInverse = false;
      fromStateReference.Wrapper.ReferenceType.Name = fromStateString;
      fromStateReference.Wrapper.ReferenceType.NameSpace = uaNamesaceString;
      fromStateReference.Wrapper.TargetId.Name = selectedTransitionButton.TransitionData.FromState;
      fromStateReference.Wrapper.TargetId.NameSpace = selectedTransitionButton.SymbolicNameNameSpace;
      fromStateReference.Wrapper.Validate();
      Reference toStateReference = new Reference();
      toStateReference.Wrapper.IsOneWay = false;
      toStateReference.Wrapper.IsInverse = false;
      toStateReference.Wrapper.ReferenceType.Name = toStateString;
      toStateReference.Wrapper.ReferenceType.NameSpace = uaNamesaceString;
      toStateReference.Wrapper.TargetId.Name = selectedTransitionButton.TransitionData.ToState;
      toStateReference.Wrapper.TargetId.NameSpace = selectedTransitionButton.SymbolicNameNameSpace;
      toStateReference.Wrapper.Validate();
      Reference hasCauseReference = new Reference();
      if ( selectedTransitionButton.TransitionData.HasCause != null )
      {
        hasCauseReference.Wrapper.IsOneWay = false;
        hasCauseReference.Wrapper.IsInverse = false;
        hasCauseReference.Wrapper.ReferenceType.Name = hasCauseString;
        hasCauseReference.Wrapper.ReferenceType.NameSpace = uaNamesaceString;
        hasCauseReference.Wrapper.TargetId.Name = selectedTransitionButton.TransitionData.HasCause;
        hasCauseReference.Wrapper.TargetId.NameSpace = selectedTransitionButton.SymbolicNameNameSpace;
        hasCauseReference.Wrapper.Validate();
      }
      newTransitionObjectDesign.References.Add(  fromStateReference  );
      newTransitionObjectDesign.References.Add( toStateReference  );
      newTransitionObjectDesign.Wrapper.Validate();
      if ( !string.IsNullOrEmpty(hasCauseReference.Wrapper.TargetId.Name))
        newTransitionObjectDesign.References.Add( hasCauseReference );
      selectedTransitionButton.MachineObjectDesign.Children.Add( newTransitionObjectDesign );
      selectedTransitionButton.TransitionData = new Transition( selectedTransitionButton.TransitionData.FromState, selectedTransitionButton.TransitionData.ToState, selectedTransitionButton.TransitionData.HasCause, newTransitionObjectDesign.Wrapper );
      selectedTransitionButton.Image = Resources.transition;
      selectedTransitionButton.FlatStyle = FlatStyle.Standard;
    }
    #endregion
  }
}
