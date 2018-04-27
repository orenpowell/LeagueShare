namespace WindowsFormsApp1.WindowForms
{
    partial class UpdateTeam
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
            this.components = new System.ComponentModel.Container();
            this.tieLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.tieBox = new System.Windows.Forms.TextBox();
            this.lossBox = new System.Windows.Forms.TextBox();
            this.winBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDataSet1 = new WindowsFormsApp1.Database.LeagueDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApp1.Database.LeagueDataSet1TableAdapters.TableTableAdapter();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tieLabel
            // 
            this.tieLabel.AutoSize = true;
            this.tieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.tieLabel.Location = new System.Drawing.Point(11, 222);
            this.tieLabel.Name = "tieLabel";
            this.tieLabel.Size = new System.Drawing.Size(91, 20);
            this.tieLabel.TabIndex = 43;
            this.tieLabel.Text = "Tie Count:";
            this.tieLabel.Click += new System.EventHandler(this.tieLabel_Click);
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.lossLabel.Location = new System.Drawing.Point(11, 190);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(105, 20);
            this.lossLabel.TabIndex = 42;
            this.lossLabel.Text = "Loss Count:";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.winLabel.Location = new System.Drawing.Point(11, 158);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(97, 20);
            this.winLabel.TabIndex = 41;
            this.winLabel.Text = "Win Count:";
            this.winLabel.Click += new System.EventHandler(this.winLabel_Click);
            // 
            // tieBox
            // 
            this.tieBox.Location = new System.Drawing.Point(129, 219);
            this.tieBox.Name = "tieBox";
            this.tieBox.Size = new System.Drawing.Size(148, 26);
            this.tieBox.TabIndex = 40;
            // 
            // lossBox
            // 
            this.lossBox.Location = new System.Drawing.Point(128, 187);
            this.lossBox.Name = "lossBox";
            this.lossBox.Size = new System.Drawing.Size(148, 26);
            this.lossBox.TabIndex = 39;
            // 
            // winBox
            // 
            this.winBox.Location = new System.Drawing.Point(128, 155);
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(148, 26);
            this.winBox.TabIndex = 38;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.nameLabel.Location = new System.Drawing.Point(12, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(109, 20);
            this.nameLabel.TabIndex = 37;
            this.nameLabel.Text = "Team Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(128, 123);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 26);
            this.nameBox.TabIndex = 36;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(287, 219);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(83, 26);
            this.enterButton.TabIndex = 35;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDataGridViewTextBoxColumn,
            this.winsDataGridViewTextBoxColumn,
            this.lossesDataGridViewTextBoxColumn,
            this.tiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 467);
            this.dataGridView1.TabIndex = 44;
            // 
            // leagueDataSet1
            // 
            this.leagueDataSet1.DataSetName = "LeagueDataSet1";
            this.leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.leagueDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // winsDataGridViewTextBoxColumn
            // 
            this.winsDataGridViewTextBoxColumn.DataPropertyName = "Wins";
            this.winsDataGridViewTextBoxColumn.HeaderText = "Wins";
            this.winsDataGridViewTextBoxColumn.Name = "winsDataGridViewTextBoxColumn";
            // 
            // lossesDataGridViewTextBoxColumn
            // 
            this.lossesDataGridViewTextBoxColumn.DataPropertyName = "Losses";
            this.lossesDataGridViewTextBoxColumn.HeaderText = "Losses";
            this.lossesDataGridViewTextBoxColumn.Name = "lossesDataGridViewTextBoxColumn";
            // 
            // tiesDataGridViewTextBoxColumn
            // 
            this.tiesDataGridViewTextBoxColumn.DataPropertyName = "Ties";
            this.tiesDataGridViewTextBoxColumn.HeaderText = "Ties";
            this.tiesDataGridViewTextBoxColumn.Name = "tiesDataGridViewTextBoxColumn";
            // 
            // UpdateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(996, 730);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tieLabel);
            this.Controls.Add(this.lossLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.tieBox);
            this.Controls.Add(this.lossBox);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.enterButton);
            this.Name = "UpdateTeam";
            this.Load += new System.EventHandler(this.UpdateTeam_Load);
            this.Controls.SetChildIndex(this.enterButton, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.winBox, 0);
            this.Controls.SetChildIndex(this.lossBox, 0);
            this.Controls.SetChildIndex(this.tieBox, 0);
            this.Controls.SetChildIndex(this.winLabel, 0);
            this.Controls.SetChildIndex(this.lossLabel, 0);
            this.Controls.SetChildIndex(this.tieLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tieLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.TextBox tieBox;
        private System.Windows.Forms.TextBox lossBox;
        private System.Windows.Forms.TextBox winBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource4;
        private Database.LeagueDataSet1 leagueDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database.LeagueDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiesDataGridViewTextBoxColumn;
    }
}
