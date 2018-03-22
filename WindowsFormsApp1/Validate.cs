using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Validate
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public void ConnectDB(string UN, string PW)
        {
            // Need to update Pathway "C:\Users\oap1\Desktop\LeagueShare" to whatever pathway it needs to be
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oap1\Desktop\LeagueShare\WindowsFormsApp1\Users.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO [dbo].[Table] (, [Username], [Password]) VALUES (N'"+ UN + "', N'"+ PW +"')");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

    }
}
