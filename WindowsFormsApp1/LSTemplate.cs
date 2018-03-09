using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LSTemplate : Form
    {
        Form1 frm1 = new Form1();
        public LSTemplate()
        {
            InitializeComponent();
        }

        public void name (string a)
        {
            txtName.Text = a;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
         
        }

        private void txtVLeague_Click(object sender, EventArgs e)
        {
            ViewLeague vLeague = new ViewLeague();
            vLeague.Show();
            vLeague.name(txtName.Text);
            this.Close();
        }

        private void txtVGame_Click(object sender, EventArgs e)
        {
            ViewGame vGame = new ViewGame();
            vGame.Show();
            vGame.name(txtName.Text);
            this.Close();
        }

        private void txtVTeam_Click(object sender, EventArgs e)
        {
            ViewTeam vTeam = new ViewTeam();
            vTeam.Show();
            vTeam.name(txtName.Text);
            this.Close();
        }

        private void txtVPlayer_Click(object sender, EventArgs e)
        {
            ViewPlayer vPlayer = new ViewPlayer();
            vPlayer.Show();
            vPlayer.name(txtName.Text);
            this.Close();
        }
    }
}
