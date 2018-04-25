using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.WindowFowms;

namespace WindowsFormsApp1
{
    public partial class LSTemplate : Form
    {
        public LSTemplate()
        {
            InitializeComponent();
            // no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void name (string a)
        {
            txtName.Text = a;
        }

        public void logName(string a)
        {
            button1.Text = a;
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

        private void leagueButton_Click(object sender, EventArgs e)
        {
            txtULeague.Visible = true;
            txtVLeague.Visible = true;
            txtUGame.Visible = false;
            txtVGame.Visible = false;
            txtUPlayer.Visible = false;
            txtVPlayer.Visible = false;
            txtUTeam.Visible = false;
            txtVTeam.Visible = false;
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            txtUPlayer.Visible = true;
            txtVPlayer.Visible = true;
            txtULeague.Visible = false;
            txtVLeague.Visible = false;
            txtUGame.Visible = false;
            txtVGame.Visible = false;
            txtUTeam.Visible = false;
            txtVTeam.Visible = false;

        }
        private void teamButton_Click(object sender, EventArgs e)
        {
            txtUTeam.Visible = true;
            txtVTeam.Visible = true;
            txtULeague.Visible = false;
            txtVLeague.Visible = false;
            txtUGame.Visible = false;
            txtVGame.Visible = false;
            txtUPlayer.Visible = false;
            txtVPlayer.Visible = false;
        }
        private void gameButton_Click(object sender, EventArgs e)
        {
            txtUGame.Visible = true;
            txtVGame.Visible = true;
            txtULeague.Visible = false;
            txtVLeague.Visible = false;
            txtUPlayer.Visible = false;
            txtVPlayer.Visible = false;
            txtUTeam.Visible = false;
            txtVTeam.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (button1.Text == "logout")
            {
                txtName.Text = "Anonymous";
                button1.Text = "login";
            }
            else
            {
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }
    }
}
