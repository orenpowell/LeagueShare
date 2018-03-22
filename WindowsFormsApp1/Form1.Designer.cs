namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLoginScrn = new System.Windows.Forms.Label();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.txtbxUser = new System.Windows.Forms.TextBox();
            this.txtbxPWD = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.Label();
            this.cbRemPass = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginScrn
            // 
            this.txtLoginScrn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtLoginScrn.Location = new System.Drawing.Point(71, 115);
            this.txtLoginScrn.Name = "txtLoginScrn";
            this.txtLoginScrn.Size = new System.Drawing.Size(77, 26);
            this.txtLoginScrn.TabIndex = 1;
            this.txtLoginScrn.Text = "Login Screen";
            this.txtLoginScrn.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(37, 220);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(75, 23);
            this.bttnSubmit.TabIndex = 2;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(119, 220);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // txtbxUser
            // 
            this.txtbxUser.Location = new System.Drawing.Point(74, 144);
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(120, 20);
            this.txtbxUser.TabIndex = 4;
            // 
            // txtbxPWD
            // 
            this.txtbxPWD.Location = new System.Drawing.Point(74, 170);
            this.txtbxPWD.Name = "txtbxPWD";
            this.txtbxPWD.PasswordChar = '*';
            this.txtbxPWD.Size = new System.Drawing.Size(120, 20);
            this.txtbxPWD.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUser.Location = new System.Drawing.Point(13, 147);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(55, 13);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "Username";
            // 
            // txtPWD
            // 
            this.txtPWD.AutoSize = true;
            this.txtPWD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtPWD.Location = new System.Drawing.Point(15, 173);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(53, 13);
            this.txtPWD.TabIndex = 7;
            this.txtPWD.Text = "Password";
            // 
            // cbRemPass
            // 
            this.cbRemPass.AutoSize = true;
            this.cbRemPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbRemPass.Location = new System.Drawing.Point(53, 197);
            this.cbRemPass.Name = "cbRemPass";
            this.cbRemPass.Size = new System.Drawing.Size(132, 17);
            this.cbRemPass.TabIndex = 9;
            this.cbRemPass.Text = "Remember Password?";
            this.cbRemPass.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.League_Share_small;
            this.picLogo.Location = new System.Drawing.Point(53, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtError.Location = new System.Drawing.Point(50, 246);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(137, 13);
            this.txtError.TabIndex = 11;
            this.txtError.Text = "Incorrect Logins. Try Again.";
            this.txtError.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.bttnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.bttnCancel;
            this.ClientSize = new System.Drawing.Size(223, 286);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.cbRemPass);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtbxPWD);
            this.Controls.Add(this.txtbxUser);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtLoginScrn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(239, 325);
            this.MinimumSize = new System.Drawing.Size(239, 325);
            this.Name = "Form1";
            this.Text = "League Share";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtLoginScrn;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TextBox txtbxPWD;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label txtPWD;
        private System.Windows.Forms.CheckBox cbRemPass;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.Button bttnSubmit;
    }
}

