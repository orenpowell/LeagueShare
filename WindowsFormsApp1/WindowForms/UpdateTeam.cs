using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.WindowForms
{
    public partial class UpdateTeam : WindowsFormsApp1.LSTemplate
    {
        private SqlConnection con;
        public UpdateTeam()
        {
            InitializeComponent();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            String team = nameBox.Text;
            String win = winBox.Text;
            String loss = lossBox.Text;
            String tie = tieBox.Text;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + @"Users.mdf;Integrated Security=True");

            // Need to update Pathway "C:\Users\oap1\Desktop\LeagueShare" to whatever pathway it needs to be

            String sql = "INSERT INTO [dbo].[League] ([Team], [Wins], [Losses], [Ties]) " +
                         "VALUES ('" + team + "', '" + win + "', '" + loss + "', '" + tie + "')";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void winLabel_Click(object sender, EventArgs e)
        {

        }

        private void tieLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet1.Table);
            // TODO: This line of code loads data into the 'leagueDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet1.Table);

        }
    }
}
