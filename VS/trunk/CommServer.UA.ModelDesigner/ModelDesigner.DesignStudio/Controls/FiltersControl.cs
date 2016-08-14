//<summary>
//  Title   : Model designer User Interface: Filter Control
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Controls
{
  /// <summary>
  /// Model designer User Interface: Filter Control
  /// </summary>
  internal partial class FiltersControl: UserControl
  {
    private void button_remove_all_filters_Click( object sender, EventArgs e )
    {
      this.MyFilterSettings = new FilterSettings();
    }
    private void checkBox_AllDataTypes_CheckedChanged( object sender, EventArgs e )
    {
      checkedListBox_datatypes.Enabled = !checkBox_AllDataTypes.Checked;
      checkBox_customfilter.Checked = false;
    }
    private void checkBox_customfilter_CheckedChanged( object sender, EventArgs e )
    {
      checkBox_customfilter.Enabled = checkBox_customfilter.Checked;
    }
    /// <summary>
    /// Filter Settings class
    /// </summary>
    internal class FilterSettings
    {
      internal bool AllTypes { get; private set; }
      internal IEnumerable<NodeClassesEnum> SelectedTypes { get; private set; }
      internal bool CustomFilterIsEnabled { get; set; }
      internal FilterSettings( bool allTypes, IEnumerable<NodeClassesEnum> selectedTypes, bool customFilterIsEnabled )
      {
        AllTypes = allTypes;
        SelectedTypes = new List<NodeClassesEnum>();
        foreach ( NodeClassesEnum type in selectedTypes )
        {
          if ( type == NodeClassesEnum.None )
            continue;
          ( (List<NodeClassesEnum>)SelectedTypes ).Add( type );
        }
        CustomFilterIsEnabled = customFilterIsEnabled;
      }
      internal FilterSettings()
      {
        AllTypes = true;
        SelectedTypes = new List<NodeClassesEnum>();
        foreach ( NodeClassesEnum type in Enum.GetValues( typeof( NodeClassesEnum ) ) )
        {
          if ( type == NodeClassesEnum.None )
            continue;
          ( (List<NodeClassesEnum>)SelectedTypes ).Add( type );
        }
        CustomFilterIsEnabled = false;
      }
    }
    /// <summary>
    /// Gets or sets filter settings.
    /// </summary>
    /// <value>filter settings.</value>
    internal FilterSettings MyFilterSettings
    {
      get
      {
        List<NodeClassesEnum> selectedtypes = new List<NodeClassesEnum>();
        for ( int idx = 0; idx < checkedListBox_datatypes.Items.Count; idx++ )
          if ( checkedListBox_datatypes.GetItemChecked( idx ) )
            selectedtypes.Add( (NodeClassesEnum)checkedListBox_datatypes.Items[ idx ] );
        return new FilterSettings( checkBox_AllDataTypes.Checked, selectedtypes, checkBox_customfilter.Checked );
      }
      set
      {
        checkBox_AllDataTypes.Checked = value.AllTypes;
        checkBox_customfilter.Checked = value.CustomFilterIsEnabled;
        checkedListBox_datatypes.SelectedItems.Clear();
        for ( int idx = 0; idx < checkedListBox_datatypes.Items.Count; idx++ )
        {
          checkedListBox_datatypes.SetItemChecked( idx, false );
          foreach ( NodeClassesEnum type in value.SelectedTypes )
          {
            if ( type == (NodeClassesEnum)checkedListBox_datatypes.Items[ idx ] )
            {
              checkedListBox_datatypes.SetItemChecked( idx, true );
              break;
            }
          }
        }
      }
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="FiltersControl"/> class.
    /// </summary>
    internal FiltersControl()
    {
      InitializeComponent();
      foreach ( NodeClassesEnum type in Enum.GetValues( typeof( NodeClassesEnum ) ) )
        if ( type != NodeClassesEnum.None )
          checkedListBox_datatypes.Items.Add( type );
      this.MyFilterSettings = new FilterSettings();
    }

  }
}
