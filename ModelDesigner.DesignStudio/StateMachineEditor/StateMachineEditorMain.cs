//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal class StateMachineEditorMain
  {
    #region private
    #region constants
    private const string initialStateTypeString = "InitialStateType";
    private const string stateTypeString = "StateType";
    private const string transitionTypeString = "TransitionType";
    private const string fromStateString = "FromState";
    private const string toStateString = "ToState";
    private const string hasCauseString = "HasCause";
    private const string finiteStateMachineTypeString = "http://opcfoundation.org/UA/:FiniteStateMachineType";
    #endregion constants

    /// <summary>
    /// Finds the states and transitions in state machine.
    /// </summary>
    /// <param name="instanceDesignNode">The instance design node.</param>
    /// <param name="allStates">All states.</param>
    /// <param name="allTransitions">All transitions.</param>
    private static void FindStatesAndTransitionsInStateMachine( InstanceDesign<Opc.Ua.ModelCompiler.ObjectDesign> instanceDesignNode, List<string> allStates, List<Transition> allTransitions )
    {
      string fromState = "";
      string toState = "";
      string hasCause = "";
      NodeDesign<Opc.Ua.ModelCompiler.ObjectDesign> nd = (NodeDesign<Opc.Ua.ModelCompiler.ObjectDesign>)instanceDesignNode;
      if ( ( instanceDesignNode.TypeDefinition.Name.ToString() == initialStateTypeString )
        || ( instanceDesignNode.TypeDefinition.Name.ToString() == stateTypeString )
        || ( instanceDesignNode.TypeDefinition.Name.ToString().Contains( stateTypeString ) ) )
        allStates.Add( nd.SymbolicName.Name );
      else if ( instanceDesignNode.TypeDefinition.Name.ToString() == transitionTypeString )
      {
        foreach ( var reference in ( (ObjectDesign)nd.Parent ).References.References )
        {
          if ( reference.ReferenceType.Name == fromStateString )
            fromState = reference.TargetId.Name;
          else if ( reference.ReferenceType.Name == toStateString )
            toState = reference.TargetId.Name;
          else if ( reference.ReferenceType.Name == hasCauseString )
            hasCause = reference.TargetId.Name;
        }
        allTransitions.Add( new Transition( fromState, toState, hasCause, instanceDesignNode ) );
      }
      return;
    }
    #endregion

    #region internal
    /// <summary>
    /// Analizes the state machine from tree.
    /// </summary>
    /// <param name="imna">The analized node.</param>
    internal static void AnalizeStateMachine( IModelNodeAdvance imna )
    {
      if ( CustomEditors.IsLicensed )
      {
        if ( ( ( (TypeDesign<Opc.Ua.ModelCompiler.ObjectTypeDesign>)imna.Wrapper4PropertyGrid ).BaseType.ToString() == finiteStateMachineTypeString ) )
        {
          TypeDesign<Opc.Ua.ModelCompiler.ObjectTypeDesign> selectedNodeObjectTypeDesign = (TypeDesign<Opc.Ua.ModelCompiler.ObjectTypeDesign>)imna.Wrapper4PropertyGrid;
          try
          {
            string symbolicNameNameSpace = selectedNodeObjectTypeDesign.SymbolicName.NameSpace;
            ObjectTypeDesign machineObjectDesign = (ObjectTypeDesign)selectedNodeObjectTypeDesign.Parent;
            List<string> allStates = new List<string>();
            List<Transition> allTransitions = new List<Transition>();
            Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> folders = imna.GetFolders();
            foreach ( Folder folder in folders.Values )
            {
              if ( folder is ChildrenFolder )
                foreach ( IModelNode machineIModelNode in folder )
                  if ( machineIModelNode.NodeClass == NodeClassesEnum.Object )
                    FindStatesAndTransitionsInStateMachine( (InstanceDesign<Opc.Ua.ModelCompiler.ObjectDesign>)machineIModelNode.Wrapper4PropertyGrid, allStates, allTransitions );
            }
            bool transitionAnalized = false;
            while ( transitionAnalized == false )
              transitionAnalized = StateMachineCrossTable.AddImagesOnTransitionButtons( allStates, allTransitions, symbolicNameNameSpace, machineObjectDesign, imna.IsReadOnly );
          }
          catch ( Exception )
          {
            MessageBox.Show( Resources.ProblemWithStateMachine_Header, Resources.ProblemwithDisplayingStateMachine_Info, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            return;
          }
        }
        else
        {
          MessageBox.Show( Resources.ProblemWithStateMachine_Header, Resources.ProblemWithStateMachine_Info, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
          return;
        }
      }
      else
      {
        MessageBox.Show( Resources.ModelDesignerProLicenseWarning );
      }
    }
    #endregion


  }
}
