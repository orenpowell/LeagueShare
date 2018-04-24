namespace WindowsFormsApp1
{
    partial class LSTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSTemplate));
            this.txtName = new System.Windows.Forms.Label();
            this.txtVPlayer = new System.Windows.Forms.Label();
            this.txtVTeam = new System.Windows.Forms.Label();
            this.txtVGame = new System.Windows.Forms.Label();
            this.txtVLeague = new System.Windows.Forms.Label();
            this.txtULeague = new System.Windows.Forms.Label();
            this.txtUGame = new System.Windows.Forms.Label();
            this.txtUTeam = new System.Windows.Forms.Label();
            this.txtUPlayer = new System.Windows.Forms.Label();
            this.picProfilePic = new System.Windows.Forms.PictureBox();
            this.leagueButton = new System.Windows.Forms.Button();
            this.teamButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(566, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "FName LName";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtVPlayer
            // 
            this.txtVPlayer.AutoSize = true;
            this.txtVPlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtVPlayer.Location = new System.Drawing.Point(8, 22);
            this.txtVPlayer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtVPlayer.Name = "txtVPlayer";
            this.txtVPlayer.Size = new System.Drawing.Size(101, 20);
            this.txtVPlayer.TabIndex = 2;
            this.txtVPlayer.Text = "View Player";
            this.txtVPlayer.Click += new System.EventHandler(this.txtVPlayer_Click);
            // 
            // txtVTeam
            // 
            this.txtVTeam.AutoSize = true;
            this.txtVTeam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtVTeam.Location = new System.Drawing.Point(8, 22);
            this.txtVTeam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtVTeam.Name = "txtVTeam";
            this.txtVTeam.Size = new System.Drawing.Size(96, 20);
            this.txtVTeam.TabIndex = 3;
            this.txtVTeam.Text = "View Team";
            this.txtVTeam.Click += new System.EventHandler(this.txtVTeam_Click);
            // 
            // txtVGame
            // 
            this.txtVGame.AutoSize = true;
            this.txtVGame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtVGame.Location = new System.Drawing.Point(8, 22);
            this.txtVGame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtVGame.Name = "txtVGame";
            this.txtVGame.Size = new System.Drawing.Size(100, 20);
            this.txtVGame.TabIndex = 4;
            this.txtVGame.Text = "View Game";
            this.txtVGame.Click += new System.EventHandler(this.txtVGame_Click);
            // 
            // txtVLeague
            // 
            this.txtVLeague.AutoSize = true;
            this.txtVLeague.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtVLeague.Location = new System.Drawing.Point(8, 22);
            this.txtVLeague.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtVLeague.Name = "txtVLeague";
            this.txtVLeague.Size = new System.Drawing.Size(112, 20);
            this.txtVLeague.TabIndex = 5;
            this.txtVLeague.Text = "View League";
            this.txtVLeague.Click += new System.EventHandler(this.txtVLeague_Click);
            // 
            // txtULeague
            // 
            this.txtULeague.AutoSize = true;
            this.txtULeague.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtULeague.Location = new System.Drawing.Point(172, 22);
            this.txtULeague.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtULeague.Name = "txtULeague";
            this.txtULeague.Size = new System.Drawing.Size(133, 20);
            this.txtULeague.TabIndex = 12;
            this.txtULeague.Text = "Update League";
            this.txtULeague.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtUGame
            // 
            this.txtUGame.AutoSize = true;
            this.txtUGame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUGame.Location = new System.Drawing.Point(172, 22);
            this.txtUGame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUGame.Name = "txtUGame";
            this.txtUGame.Size = new System.Drawing.Size(121, 20);
            this.txtUGame.TabIndex = 11;
            this.txtUGame.Text = "Update Game";
            this.txtUGame.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtUTeam
            // 
            this.txtUTeam.AutoSize = true;
            this.txtUTeam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUTeam.Location = new System.Drawing.Point(172, 22);
            this.txtUTeam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUTeam.Name = "txtUTeam";
            this.txtUTeam.Size = new System.Drawing.Size(117, 20);
            this.txtUTeam.TabIndex = 10;
            this.txtUTeam.Text = "Update Team";
            this.txtUTeam.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtUPlayer
            // 
            this.txtUPlayer.AutoSize = true;
            this.txtUPlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUPlayer.Location = new System.Drawing.Point(172, 22);
            this.txtUPlayer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUPlayer.Name = "txtUPlayer";
            this.txtUPlayer.Size = new System.Drawing.Size(122, 20);
            this.txtUPlayer.TabIndex = 9;
            this.txtUPlayer.Text = "Update Player";
            this.txtUPlayer.Click += new System.EventHandler(this.label15_Click);
            // 
            // picProfilePic
            // 
            this.picProfilePic.Image = global::WindowsFormsApp1.Properties.Resources.male_portrait_silhouette_small;
            this.picProfilePic.Location = new System.Drawing.Point(703, 11);
            this.picProfilePic.Margin = new System.Windows.Forms.Padding(5);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(50, 46);
            this.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePic.TabIndex = 0;
            this.picProfilePic.TabStop = false;
            // 
            // leagueButton
            // 
            this.leagueButton.Location = new System.Drawing.Point(15, 12);
            this.leagueButton.Name = "leagueButton";
            this.leagueButton.Size = new System.Drawing.Size(126, 29);
            this.leagueButton.TabIndex = 20;
            this.leagueButton.Text = "League";
            this.leagueButton.UseVisualStyleBackColor = true;
            this.leagueButton.Click += new System.EventHandler(this.leagueButton_Click);
            // 
            // teamButton
            // 
            this.teamButton.Location = new System.Drawing.Point(150, 12);
            this.teamButton.Name = "teamButton";
            this.teamButton.Size = new System.Drawing.Size(126, 29);
            this.teamButton.TabIndex = 21;
            this.teamButton.Text = "Team";
            this.teamButton.UseVisualStyleBackColor = true;
            this.teamButton.Click += new System.EventHandler(this.teamButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.Location = new System.Drawing.Point(421, 12);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(126, 29);
            this.gameButton.TabIndex = 22;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // playerButton
            // 
            this.playerButton.Location = new System.Drawing.Point(286, 12);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(126, 29);
            this.playerButton.TabIndex = 23;
            this.playerButton.Text = "Player";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUPlayer);
            this.groupBox1.Controls.Add(this.txtVLeague);
            this.groupBox1.Controls.Add(this.txtULeague);
            this.groupBox1.Controls.Add(this.txtUGame);
            this.groupBox1.Controls.Add(this.txtVPlayer);
            this.groupBox1.Controls.Add(this.txtUTeam);
            this.groupBox1.Controls.Add(this.txtVTeam);
            this.groupBox1.Controls.Add(this.txtVGame);
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 57);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LSTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(767, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.teamButton);
            this.Controls.Add(this.leagueButton);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picProfilePic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LSTemplate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "League Share";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfilePic;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtVPlayer;
        private System.Windows.Forms.Label txtVTeam;
        private System.Windows.Forms.Label txtVGame;
        private System.Windows.Forms.Label txtVLeague;
        private System.Windows.Forms.Label txtULeague;
        private System.Windows.Forms.Label txtUGame;
        private System.Windows.Forms.Label txtUTeam;
        private System.Windows.Forms.Label txtUPlayer;
        private System.Windows.Forms.Button leagueButton;
        private System.Windows.Forms.Button teamButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}