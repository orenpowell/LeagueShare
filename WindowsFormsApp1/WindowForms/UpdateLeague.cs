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
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public UpdateLeague()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + @"Users.mdf;Integrated Security=True");

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();

            command = new SqlCommand(
            "INSERT INTO Table (Team) " +
            "VALUES (" + nameBox.Text + ")", conn);

            // Add the parameters for the InsertCommand.
            command.Parameters.Add("@Team", "Team");

            adapter.InsertCommand = command;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateLeague_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.leagueDataSet.Table);

        }
    }
}
