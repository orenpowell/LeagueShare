using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewTeam : WindowsFormsApp1.LSTemplate
    {
        public ViewTeam()
        {
            InitializeComponent();
        }

        private void ViewTeam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet.Table);

        }
    }
}
