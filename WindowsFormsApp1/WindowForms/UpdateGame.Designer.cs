namespace WindowsFormsApp1.WindowForms
{
    partial class UpdateGame
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leagueDataSet1 = new WindowsFormsApp1.LeagueDataSet1();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new WindowsFormsApp1.LeagueDataSet1TableAdapters.GameTableAdapter();
            this.homeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeEndGamePtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayEndGamePtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winningTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeDataGridViewTextBoxColumn,
            this.homeEndGamePtsDataGridViewTextBoxColumn,
            this.awayDataGridViewTextBoxColumn,
            this.awayEndGamePtsDataGridViewTextBoxColumn,
            this.winningTeamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 564);
            this.dataGridView1.TabIndex = 26;
            // 
            // leagueDataSet1
            // 
            this.leagueDataSet1.DataSetName = "LeagueDataSet1";
            this.leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.leagueDataSet1;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // homeDataGridViewTextBoxColumn
            // 
            this.homeDataGridViewTextBoxColumn.DataPropertyName = "Home";
            this.homeDataGridViewTextBoxColumn.HeaderText = "Home";
            this.homeDataGridViewTextBoxColumn.Name = "homeDataGridViewTextBoxColumn";
            // 
            // homeEndGamePtsDataGridViewTextBoxColumn
            // 
            this.homeEndGamePtsDataGridViewTextBoxColumn.DataPropertyName = "Home End Game Pts";
            this.homeEndGamePtsDataGridViewTextBoxColumn.HeaderText = "Home End Game Pts";
            this.homeEndGamePtsDataGridViewTextBoxColumn.Name = "homeEndGamePtsDataGridViewTextBoxColumn";
            // 
            // awayDataGridViewTextBoxColumn
            // 
            this.awayDataGridViewTextBoxColumn.DataPropertyName = "Away";
            this.awayDataGridViewTextBoxColumn.HeaderText = "Away";
            this.awayDataGridViewTextBoxColumn.Name = "awayDataGridViewTextBoxColumn";
            // 
            // awayEndGamePtsDataGridViewTextBoxColumn
            // 
            this.awayEndGamePtsDataGridViewTextBoxColumn.DataPropertyName = "Away End Game Pts";
            this.awayEndGamePtsDataGridViewTextBoxColumn.HeaderText = "Away End Game Pts";
            this.awayEndGamePtsDataGridViewTextBoxColumn.Name = "awayEndGamePtsDataGridViewTextBoxColumn";
            // 
            // winningTeamDataGridViewTextBoxColumn
            // 
            this.winningTeamDataGridViewTextBoxColumn.DataPropertyName = "Winning Team";
            this.winningTeamDataGridViewTextBoxColumn.HeaderText = "Winning Team";
            this.winningTeamDataGridViewTextBoxColumn.Name = "winningTeamDataGridViewTextBoxColumn";
            // 
            // UpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(996, 730);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateGame";
            this.Load += new System.EventHandler(this.UpdateGame_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeagueDataSet1 leagueDataSet1;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private LeagueDataSet1TableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeEndGamePtsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayEndGamePtsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winningTeamDataGridViewTextBoxColumn;
    }
}
