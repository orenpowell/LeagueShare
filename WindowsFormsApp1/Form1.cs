﻿using System;
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
            this.Close();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            string User = txtbxUser.Text;
            string Password = txtbxPWD.Text;
            if (User == AdminUser && Password == AdminPWD)
            {
                //Validate Valid = new Validate();//testing Database
                Home next = new Home();
                next.Show();
                next.name(User);
                //Valid.ConnectDB(User, Password);//testing Database
                this.Hide();
            }
            else
            {
                txtError.Visible = true;
            }
            
            
          
        }
        public string FullName
        {
            get
            {
                return txtbxUser.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
