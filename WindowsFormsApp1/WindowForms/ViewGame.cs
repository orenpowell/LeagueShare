﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewGame : WindowsFormsApp1.LSTemplate
    {
        public ViewGame()
        {
            InitializeComponent();
        }

        private void ViewGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDataSet1.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.leagueDataSet1.Game);

        }
    }
}
