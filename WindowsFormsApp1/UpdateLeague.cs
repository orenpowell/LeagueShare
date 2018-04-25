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

namespace WindowsFormsApp1
{
    public partial class UpdateLeague : WindowsFormsApp1.LSTemplate
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataTable dt;

        public UpdateLeague()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String team = nameBox.Text;
            String win = winBox.Text;
            String loss = lossBox.Text;
            String tie = tieBox.Text;

            // Need to update Pathway "C:\Users\oap1\Desktop\LeagueShare" to whatever pathway it needs to be
            
            String sql = "INSERT INTO [dbo].[League] ([Team], [Wins], [Losses], [Ties]) " +
                         "VALUES ('" + team + "', '" + win + "', '" + loss + "', '" + tie + "')";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
