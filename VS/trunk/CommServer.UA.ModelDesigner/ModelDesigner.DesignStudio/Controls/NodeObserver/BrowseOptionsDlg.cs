//<summary>
//  Title   : Browse options dialog
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


using CAS.UA.Common.Types;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
    public partial class BrowseOptionsDlg : Form
    {
        #region Constructors
        public BrowseOptionsDlg()
        {
            InitializeComponent();

            foreach (object value in Enum.GetValues(typeof(BrowseDirection)))
            {
                browseDirection_ComboBox.Items.Add(value);
            }
            browseDirection_ComboBox.SelectedIndex = 0;
        }
        #endregion
        
        #region Event Handlers

        private void NodeClassMask_CheckedChanged(object sender, EventArgs e)
        {            
            nodeClassList.Enabled = nodeClassMask_CheckBox.Checked;     
        }

        private void OkBTN_Click(object sender, EventArgs e)
        {
         DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
