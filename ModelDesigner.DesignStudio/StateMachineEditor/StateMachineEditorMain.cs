//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

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
    private static void FindStatesAndTransitionsInStateMachine(InstanceDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectDesign> instanceDesignNode, List<string> allStates, List<Transition> allTransitions)
    {
      string fromState = "";
      string toState = "";
      string hasCause = "";
      NodeDesign<OpcUaModelCompiler.ObjectDesign> nd = (NodeDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectDesign>)instanceDesignNode;
      if ((instanceDesignNode.TypeDefinition.Name.ToString() == initialStateTypeString)
        || (instanceDesignNode.TypeDefinition.Name.ToString() == stateTypeString)
        || (instanceDesignNode.TypeDefinition.Name.ToString().Contains(stateTypeString)))
        allStates.Add(nd.SymbolicName.Name);
      else if (instanceDesignNode.TypeDefinition.Name.ToString() == transitionTypeString)
      {
        foreach (OpcUaModelCompiler.Reference reference in ((ObjectDesign)nd.Parent).References.References)
        {
          if (reference.ReferenceType.Name == fromStateString)
            fromState = reference.TargetId.Name;
          else if (reference.ReferenceType.Name == toStateString)
            toState = reference.TargetId.Name;
          else if (reference.ReferenceType.Name == hasCauseString)
            hasCause = reference.TargetId.Name;
        }
        allTransitions.Add(new Transition(fromState, toState, hasCause, instanceDesignNode));
      }
      return;
    }

    #endregion private

    #region internal

    /// <summary>
    /// Analizes the state machine from tree.
    /// </summary>
    /// <param name="imna">The analized node.</param>
    internal static void AnalizeStateMachine(IModelNodeAdvance imna)
    {
      if ((((TypeDesign<OpcUaModelCompiler.ObjectTypeDesign>)imna.Wrapper4PropertyGrid).BaseType.ToString() == finiteStateMachineTypeString))
      {
        TypeDesign<OpcUaModelCompiler.ObjectTypeDesign> selectedNodeObjectTypeDesign = (TypeDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectTypeDesign>)imna.Wrapper4PropertyGrid;
        try
        {
          string symbolicNameNameSpace = selectedNodeObjectTypeDesign.SymbolicName.NameSpace;
          ObjectTypeDesign machineObjectDesign = (ObjectTypeDesign)selectedNodeObjectTypeDesign.Parent;
          List<string> allStates = new List<string>();
          List<Transition> allTransitions = new List<Transition>();
          Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> folders = imna.GetFolders();
          foreach (Folder folder in folders.Values)
          {
            if (folder is ChildrenFolder)
              foreach (IModelNode machineIModelNode in folder)
                if (machineIModelNode.NodeClass == NodeClassesEnum.Object)
                  FindStatesAndTransitionsInStateMachine((InstanceDesign<UAOOI.SemanticData.UAModelDesignExport.XML.ObjectDesign>)machineIModelNode.Wrapper4PropertyGrid, allStates, allTransitions);
          }
          bool transitionAnalized = false;
          while (transitionAnalized == false)
            transitionAnalized = StateMachineCrossTable.AddImagesOnTransitionButtons(allStates, allTransitions, symbolicNameNameSpace, machineObjectDesign, imna.IsReadOnly);
        }
        catch (Exception)
        {
          MessageBox.Show(Resources.ProblemWithStateMachine_Header, Resources.ProblemwithDisplayingStateMachine_Info, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
          return;
        }
      }
      else
      {
        MessageBox.Show(Resources.ProblemWithStateMachine_Header, Resources.ProblemWithStateMachine_Info, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        return;
      }
    }

    #endregion internal
  }
}