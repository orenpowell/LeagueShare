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
    public partial class Form1 : Form
    {
        public String AdminUser = "Oren";
        public String AdminPWD = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            string User = txtbxUser.Text;
            string Password = txtbxPWD.Text;
            if (User == AdminUser && Password == AdminPWD)
            {
                Home next = new Home();
                next.Show();
                next.name(User);
                this.Hide();
                
            }
            else
            {
                txtError.Visible = true;
            }
        }
        
    }
}
