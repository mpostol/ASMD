//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________
using System;
using System.Windows.Forms;
using UAOOI.OPCUA.Common.Types;

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

        #endregion Constructors

        #region Event Handlers

        private void NodeClassMask_CheckedChanged(object sender, EventArgs e)
        {
            nodeClassList.Enabled = nodeClassMask_CheckBox.Checked;
        }

        private void OkBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        #endregion Event Handlers
    }
}