using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.WindowForms
{
    public partial class UpdateGame : WindowsFormsApp1.LSTemplate
    {
        public UpdateGame()
        {
            InitializeComponent();
        }

        private void UpdateGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet1.Table);

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.leagueDataSet1);
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.leagueDataSet1);
        }
    }
}
