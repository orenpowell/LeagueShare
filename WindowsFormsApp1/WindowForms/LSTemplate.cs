using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.WindowForms;
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

        private void txtULeague_Click(object sender, EventArgs e)
        {
            UpdateLeague uLeague = new UpdateLeague();
            uLeague.Show();
            uLeague.name(txtName.Text);
            uLeague.logName(button1.Text);
            this.Close();
        }

        private void txtUGame_Click(object sender, EventArgs e)
        {
            UpdateGame uGame = new UpdateGame();
            uGame.Show();
            uGame.name(txtName.Text);
            uGame.logName(button1.Text);
            this.Close();
        }

        private void txtUTeam_Click(object sender, EventArgs e)
        {
            UpdateTeam uTeam = new UpdateTeam();
            uTeam.Show();
            uTeam.name(txtName.Text);
            uTeam.logName(button1.Text);
            this.Close();
        }

        private void txtUPlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayer uPlayer = new UpdatePlayer();
            uPlayer.Show();
            uPlayer.name(txtName.Text);
            uPlayer.logName(button1.Text);
            this.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
         
        }

        private void txtVLeague_Click(object sender, EventArgs e)
        {
            ViewLeague vLeague = new ViewLeague();
            vLeague.Show();
            vLeague.name(txtName.Text);
            vLeague.logName(button1.Text);
            this.Close();
        }

        private void txtVGame_Click(object sender, EventArgs e)
        {
            ViewGame vGame = new ViewGame();
            vGame.Show();
            vGame.name(txtName.Text);
            vGame.logName(button1.Text);
            this.Close();
        }

        private void txtVTeam_Click(object sender, EventArgs e)
        {
            ViewTeam vTeam = new ViewTeam();
            vTeam.Show();
            vTeam.name(txtName.Text);
            vTeam.logName(button1.Text);
            this.Close();
        }

        private void txtVPlayer_Click(object sender, EventArgs e)
        {
            ViewPlayer vPlayer = new ViewPlayer();
            vPlayer.Show();
            vPlayer.name(txtName.Text);
            vPlayer.logName(button1.Text);
            this.Close();
        }

        private void leagueButton_Click(object sender, EventArgs e)
        {
            if(button1.Text == "logout") {txtULeague.Visible = true;}
            else{txtULeague.Visible = false;}
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
            if(button1.Text == "logout") {txtUPlayer.Visible = true;}
            else{txtUPlayer.Visible = false;}
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
            if(button1.Text == "logout") {txtUTeam.Visible = true;}
            else {txtUTeam.Visible = false;}
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
            if(button1.Text == "logout"){txtUGame.Visible = true;}
            else{txtUGame.Visible = false;}
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
                name("anonymous");
                logName("login");
            }
            else
            {
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }

        private void picProfilePic_Click(object sender, EventArgs e)
        {
            Home next = new Home();
            next.name(txtName.Text);
            next.logName(button1.Text);
            next.Show();
            this.Hide();
            
        }
    }
}
