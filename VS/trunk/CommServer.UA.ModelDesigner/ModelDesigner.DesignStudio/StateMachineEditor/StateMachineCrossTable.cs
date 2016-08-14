//<summary>
//  Title   : Main window of the state machine editor
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal partial class StateMachineCrossTable: Form
  {
    #region Internal
    /// <summary>
    /// Analizes the transition states and add buttons.
    /// </summary>
    /// <param name="allStates">All states.</param>
    /// <param name="allTransitions">All transitions.</param>
    /// <param name="symbolicNameNameSpace">The symbolic name name space.</param>
    /// <param name="machineObjectDesign">The machine object design.</param>
    /// <returns>
    /// True if transitions are correctly analized.
    /// </returns>
    internal static bool AddImagesOnTransitionButtons( List<string> allStates, List<Transition> allTransitions, string symbolicNameNameSpace, ObjectTypeDesign machineObjectDesign, bool isReadOnly )
    {
      StateMachineCrossTable crossTableWindow = DrawStateMachineCrossTableWindow( allStates, allTransitions, symbolicNameNameSpace, machineObjectDesign, isReadOnly );
      int toStateNumber = 0;
      int fromStateNumber = 0;
      bool fromStateExists = false;
      bool toStateExists = false;
      string fromStateFoundName = "";
      string toStateFoundName = "";
      string shortFromState;
      string shortToState;
      foreach ( Transition transitionOnList in allTransitions )
      {
        if ( transitionOnList.FromState.Contains( "_" ) )
          shortFromState = ( transitionOnList.FromState ).Substring( ( transitionOnList.FromState ).LastIndexOf( "_" ), ( transitionOnList.FromState ).Length - ( transitionOnList.FromState ).LastIndexOf( "_" ) ).Replace( "_", "" );
        else
          shortFromState = transitionOnList.FromState;
        if ( transitionOnList.ToState.Contains( "_" ) )
          shortToState = ( transitionOnList.ToState ).Substring( ( transitionOnList.ToState ).LastIndexOf( "_" ), ( transitionOnList.ToState ).Length - ( transitionOnList.ToState ).LastIndexOf( "_" ) ).Replace( "_", "" );
        else
          shortToState = transitionOnList.ToState;
        if ( shortFromState == shortToState )
        {
          for ( int statesCounter = 0; statesCounter < allStates.Count; statesCounter++ )
            if ( ( allStates[ statesCounter ] == shortFromState ) )
            {
              fromStateNumber = statesCounter + 1;
              fromStateFoundName = allStates[ statesCounter ];
              fromStateExists = true;
              toStateNumber = statesCounter + 1;
              toStateFoundName = allStates[ statesCounter ];
              toStateExists = true;
            }
        }
        else
          for ( int statesCounter = 0; statesCounter < allStates.Count; statesCounter++ )
            if ( ( allStates[ statesCounter ] == shortFromState ) )
            {
              fromStateNumber = statesCounter + 1;
              fromStateFoundName = allStates[ statesCounter ];
              fromStateExists = true;
            }
            else if ( ( allStates[ statesCounter ] == shortToState ) )
            {
              toStateNumber = statesCounter + 1;
              toStateFoundName = allStates[ statesCounter ];
              toStateExists = true;
            }
        if ( fromStateExists == true && toStateExists == true )
        {
          foreach ( Control ctrl in crossTableWindow.tableLayoutPanelCrossTable.Controls )
          {
            StateMachineControl smc = ctrl as StateMachineControl;
            if ( (smc != null) && ( smc.buttonTransition.TransitionData.FromState == fromStateFoundName ) && ( smc.buttonTransition.TransitionData.ToState == toStateFoundName ) )
            {
              smc.buttonTransition.TransitionData.Update( transitionOnList );
              smc.buttonTransition.Image = global::CAS.UA.Model.Designer.Properties.Resources.transition;
              smc.buttonTransition.FlatStyle = FlatStyle.Standard;
            }
          }
        }
        else
          if ( fromStateExists == false )
          {
            allStates.Add( shortFromState );
            crossTableWindow = DrawStateMachineCrossTableWindow( allStates, allTransitions, symbolicNameNameSpace, machineObjectDesign, isReadOnly );
            return false;
          }
          else
          {
            allStates.Add( shortToState );
            crossTableWindow = DrawStateMachineCrossTableWindow( allStates, allTransitions, symbolicNameNameSpace, machineObjectDesign, isReadOnly );
            return false;
          }
      }
      crossTableWindow.tableLayoutPanelCrossTable.SuspendLayout();
      crossTableWindow.SuspendLayout();
      crossTableWindow.Height = crossTableWindow.tableLayoutPanelCrossTable.Height + 50;
      crossTableWindow.Width = crossTableWindow.tableLayoutPanelCrossTable.Width + 50;
      crossTableWindow.tableLayoutPanelCrossTable.ResumeLayout( false );
      crossTableWindow.tableLayoutPanelCrossTable.PerformLayout();
      crossTableWindow.ResumeLayout( false );
      crossTableWindow.PerformLayout();
      crossTableWindow.Show();
      return true;
    }
    # endregion

    #region private
    /// <summary>
    /// Draws the state machine cross table window.
    /// </summary>
    /// <param name="allStates">All states.</param>
    /// <param name="allTransitions">All transitions.</param>
    /// <param name="symbolicNameNameSpace">The symbolic name name space.</param>
    /// <param name="machineObjectDesign">The machine object design.</param>
    /// <returns>Window with cross table</returns>
    private static StateMachineCrossTable DrawStateMachineCrossTableWindow( List<string> allStates, List<Transition> allTransitions, string symbolicNameNameSpace, ObjectTypeDesign machineObjectDesign, bool isReadOnly )
    {
      int maxLength = FindTheLongestStringAndReturnItsLenght( allStates );
      StateMachineCrossTable crossTableWindow = new StateMachineCrossTable();
      StateMachineControl smcToAdd = new StateMachineControl();;
      crossTableWindow.tableLayoutPanelCrossTable.SuspendLayout();
      crossTableWindow.SuspendLayout();
      crossTableWindow.tableLayoutPanelCrossTable.RowCount = allStates.Count + 1;
      crossTableWindow.tableLayoutPanelCrossTable.ColumnCount = allStates.Count + 1;
      crossTableWindow.tableLayoutPanelCrossTable.ColumnStyles.Clear();
      crossTableWindow.tableLayoutPanelCrossTable.RowStyles.Clear();
      crossTableWindow.tableLayoutPanelCrossTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 8 * maxLength + 30 ) );
      crossTableWindow.tableLayoutPanelCrossTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 8 * maxLength + 30 ) );
      for ( int ix = 1; ix < crossTableWindow.tableLayoutPanelCrossTable.RowCount; ix++ )
      {
        crossTableWindow.tableLayoutPanelCrossTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, smcToAdd.Width + 6 ) );
        crossTableWindow.tableLayoutPanelCrossTable.RowStyles.Add( new RowStyle( SizeType.Absolute, smcToAdd.Height + 6 ) );
      }
      StateMachineCornerControl smcc = new StateMachineCornerControl();
      smcc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      crossTableWindow.tableLayoutPanelCrossTable.Controls.Add( smcc, 0, 0 );
      AddLabelsToTheCrossTable( allStates, crossTableWindow );
      for ( int rx = 1; rx < crossTableWindow.tableLayoutPanelCrossTable.RowCount; rx++ )
        for ( int cx = 1; cx < crossTableWindow.tableLayoutPanelCrossTable.ColumnCount; cx++ )
        {
          smcToAdd = new StateMachineControl();
          smcToAdd.buttonTransition.SymbolicNameNameSpace = symbolicNameNameSpace;
          smcToAdd.buttonTransition.MachineObjectDesign = machineObjectDesign;
          smcToAdd.buttonTransition.TransitionData = new Transition( allStates[ rx - 1 ], allStates[ cx - 1 ], string.Empty, null );
          crossTableWindow.tableLayoutPanelCrossTable.Controls.Add( smcToAdd );
        }
      crossTableWindow.tableLayoutPanelCrossTable.ResumeLayout( false );
      crossTableWindow.tableLayoutPanelCrossTable.PerformLayout();
      crossTableWindow.Enabled = !isReadOnly;
      crossTableWindow.ResumeLayout( false );
      crossTableWindow.PerformLayout();
      return crossTableWindow;
    }

    /// <summary>
    /// Finds the longest string and return its lenght.
    /// </summary>
    /// <param name="allStates">All states.</param>
    /// <returns>Length of the longest name</returns>
    private static int FindTheLongestStringAndReturnItsLenght( List<string> allStates )
    {
      int max = 0;
      string shortStateName;
      foreach ( string stateNode in allStates )
      {
        if ( stateNode.Contains( "_" ) )
          shortStateName = stateNode.Substring( stateNode.LastIndexOf( "_" ), stateNode.Length - stateNode.LastIndexOf( "_" ) ).Replace( "_", "" );
        else
          shortStateName = stateNode;
        if ( shortStateName.Length > max )
          max = shortStateName.Length;
      }
      return max;
    }

    /// <summary>
    /// Adds the labels to the cross table.
    /// </summary>
    /// <param name="allStates">All states.</param>
    /// <param name="crossTableWindow">The cross table window.</param>
    private static void AddLabelsToTheCrossTable( List<string> allStates, StateMachineCrossTable crossTableWindow )
    {
      VerticalLabel verticalStateLabel;
      Label stateLabel;
      for ( int counter = 1; counter < crossTableWindow.tableLayoutPanelCrossTable.RowCount; counter++ )
      {
        verticalStateLabel = new VerticalLabel();
        if ( allStates[ counter - 1 ].Contains( "_" ) )
          verticalStateLabel.Text = ( allStates[ counter - 1 ] ).Substring( ( allStates[ counter - 1 ] ).LastIndexOf( "_" ), ( allStates[ counter - 1 ] ).Length - ( allStates[ counter - 1 ] ).LastIndexOf( "_" ) ).Replace( "_", "" );
        else
          verticalStateLabel.Text = allStates[ counter - 1 ];
        verticalStateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        verticalStateLabel.BackColor = Color.LimeGreen;
        verticalStateLabel.Font = new Font( "Segoe", 8F, FontStyle.Regular, GraphicsUnit.Point, ( (byte)( 238 ) ) );
        verticalStateLabel.TextAlign = ContentAlignment.TopCenter;
        crossTableWindow.tableLayoutPanelCrossTable.Controls.Add( verticalStateLabel, counter, 0 );
        stateLabel = new Label();
        if ( allStates[ counter - 1 ].Contains( "_" ) )
          stateLabel.Text = ( allStates[ counter - 1 ] ).Substring( ( allStates[ counter - 1 ] ).LastIndexOf( "_" ), ( allStates[ counter - 1 ] ).Length - ( allStates[ counter - 1 ] ).LastIndexOf( "_" ) ).Replace( "_", "" );
        else
          stateLabel.Text = allStates[ counter - 1 ];
        stateLabel.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        stateLabel.BackColor = Color.LimeGreen;
        stateLabel.Font = new Font( "Segoe", 8F, FontStyle.Regular, GraphicsUnit.Point, ( (byte)( 238 ) ) );
        stateLabel.TextAlign = ContentAlignment.MiddleCenter;
        crossTableWindow.tableLayoutPanelCrossTable.Controls.Add( stateLabel, 0, counter );
      }
    }

    #endregion

    #region constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="windowStateMachineCrossTable"/> class.
    /// </summary>
    internal StateMachineCrossTable()
    {
      InitializeComponent();
    }
    #endregion
  }
}
