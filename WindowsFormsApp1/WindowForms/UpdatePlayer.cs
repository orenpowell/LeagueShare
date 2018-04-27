using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.WindowForms
{
    public partial class UpdatePlayer : WindowsFormsApp1.LSTemplate
    {
        public UpdatePlayer()
        {
            InitializeComponent();
        }

        private void UpdatePlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.leagueDataSet1.Player);
            // TODO: This line of code loads data into the 'leagueDataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.leagueDataSet1.Player);

        }
    }
}
