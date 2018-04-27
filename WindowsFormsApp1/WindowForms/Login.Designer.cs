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
            this.txtError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoginScrn
            // 
            this.txtLoginScrn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtLoginScrn.Location = new System.Drawing.Point(281, 181);
            this.txtLoginScrn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtLoginScrn.Name = "txtLoginScrn";
            this.txtLoginScrn.Size = new System.Drawing.Size(128, 40);
            this.txtLoginScrn.TabIndex = 1;
            this.txtLoginScrn.Text = "Login Screen";
            this.txtLoginScrn.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(225, 342);
            this.bttnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(125, 35);
            this.bttnSubmit.TabIndex = 2;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(361, 342);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(125, 35);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // txtbxUser
            // 
            this.txtbxUser.Location = new System.Drawing.Point(286, 226);
            this.txtbxUser.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(197, 26);
            this.txtbxUser.TabIndex = 4;
            // 
            // txtbxPWD
            // 
            this.txtbxPWD.Location = new System.Drawing.Point(286, 266);
            this.txtbxPWD.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPWD.Name = "txtbxPWD";
            this.txtbxPWD.PasswordChar = '*';
            this.txtbxPWD.Size = new System.Drawing.Size(197, 26);
            this.txtbxPWD.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUser.Location = new System.Drawing.Point(185, 230);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(91, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "Username";
            // 
            // txtPWD
            // 
            this.txtPWD.AutoSize = true;
            this.txtPWD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtPWD.Location = new System.Drawing.Point(188, 270);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(86, 20);
            this.txtPWD.TabIndex = 7;
            this.txtPWD.Text = "Password";
            // 
            // cbRemPass
            // 
            this.cbRemPass.AutoSize = true;
            this.cbRemPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbRemPass.Location = new System.Drawing.Point(251, 307);
            this.cbRemPass.Margin = new System.Windows.Forms.Padding(5);
            this.cbRemPass.Name = "cbRemPass";
            this.cbRemPass.Size = new System.Drawing.Size(207, 24);
            this.cbRemPass.TabIndex = 9;
            this.cbRemPass.Text = "Remember Password?";
            this.cbRemPass.UseVisualStyleBackColor = true;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtError.Location = new System.Drawing.Point(246, 382);
            this.txtError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(229, 20);
            this.txtError.TabIndex = 11;
            this.txtError.Text = "Incorrect Logins. Try Again.";
            this.txtError.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.bttnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.bttnCancel;
            this.ClientSize = new System.Drawing.Size(766, 558);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.cbRemPass);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtbxPWD);
            this.Controls.Add(this.txtbxUser);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtLoginScrn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.txtLoginScrn, 0);
            this.Controls.SetChildIndex(this.bttnSubmit, 0);
            this.Controls.SetChildIndex(this.bttnCancel, 0);
            this.Controls.SetChildIndex(this.txtbxUser, 0);
            this.Controls.SetChildIndex(this.txtbxPWD, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.txtPWD, 0);
            this.Controls.SetChildIndex(this.cbRemPass, 0);
            this.Controls.SetChildIndex(this.txtError, 0);
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
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.Button bttnSubmit;
    }
}

