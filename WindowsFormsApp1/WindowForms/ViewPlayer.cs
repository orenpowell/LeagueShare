using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewPlayer : WindowsFormsApp1.LSTemplate
    {
        public ViewPlayer()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void ViewPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.leagueDataSet.Player);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
