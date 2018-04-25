using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewLeague : WindowsFormsApp1.LSTemplate
    {
        public ViewLeague()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.leagueDataSet);

        }

        private void ViewLeague_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
