namespace WindowsFormsApp1.WindowForms
{
    partial class UpdatePlayer
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
            this.leagueDataSet1 = new WindowsFormsApp1.Database.LeagueDataSet1();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new WindowsFormsApp1.Database.LeagueDataSet1TableAdapters.PlayerTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passingYardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passingTouchdownsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interceptionThrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fumblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushingYardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushingTouchdownsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fumblesRecoveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingYardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingTouchdownsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTouchdownsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longestPuntsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPuntingYardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interceptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.gamePlayedDataGridViewTextBoxColumn,
            this.passingYardsDataGridViewTextBoxColumn,
            this.passingTouchdownsDataGridViewTextBoxColumn,
            this.interceptionThrownDataGridViewTextBoxColumn,
            this.fumblesDataGridViewTextBoxColumn,
            this.rushingYardsDataGridViewTextBoxColumn,
            this.rushingTouchdownsDataGridViewTextBoxColumn,
            this.fumblesRecoveryDataGridViewTextBoxColumn,
            this.receptionsDataGridViewTextBoxColumn,
            this.receivingYardsDataGridViewTextBoxColumn,
            this.receivingTouchdownsDataGridViewTextBoxColumn,
            this.returnTouchdownsDataGridViewTextBoxColumn,
            this.pTDataGridViewTextBoxColumn,
            this.pATDataGridViewTextBoxColumn,
            this.fGDataGridViewTextBoxColumn,
            this.puntsDataGridViewTextBoxColumn,
            this.longestPuntsDataGridViewTextBoxColumn,
            this.totalPuntingYardsDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.sacksDataGridViewTextBoxColumn,
            this.interceptionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 557);
            this.dataGridView1.TabIndex = 26;
            // 
            // leagueDataSet1
            // 
            this.leagueDataSet1.DataSetName = "LeagueDataSet1";
            this.leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.leagueDataSet1;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // gamePlayedDataGridViewTextBoxColumn
            // 
            this.gamePlayedDataGridViewTextBoxColumn.DataPropertyName = "Game Played";
            this.gamePlayedDataGridViewTextBoxColumn.HeaderText = "Game Played";
            this.gamePlayedDataGridViewTextBoxColumn.Name = "gamePlayedDataGridViewTextBoxColumn";
            // 
            // passingYardsDataGridViewTextBoxColumn
            // 
            this.passingYardsDataGridViewTextBoxColumn.DataPropertyName = "Passing Yards";
            this.passingYardsDataGridViewTextBoxColumn.HeaderText = "Passing Yards";
            this.passingYardsDataGridViewTextBoxColumn.Name = "passingYardsDataGridViewTextBoxColumn";
            // 
            // passingTouchdownsDataGridViewTextBoxColumn
            // 
            this.passingTouchdownsDataGridViewTextBoxColumn.DataPropertyName = "Passing Touchdowns";
            this.passingTouchdownsDataGridViewTextBoxColumn.HeaderText = "Passing Touchdowns";
            this.passingTouchdownsDataGridViewTextBoxColumn.Name = "passingTouchdownsDataGridViewTextBoxColumn";
            // 
            // interceptionThrownDataGridViewTextBoxColumn
            // 
            this.interceptionThrownDataGridViewTextBoxColumn.DataPropertyName = "Interception Thrown";
            this.interceptionThrownDataGridViewTextBoxColumn.HeaderText = "Interception Thrown";
            this.interceptionThrownDataGridViewTextBoxColumn.Name = "interceptionThrownDataGridViewTextBoxColumn";
            // 
            // fumblesDataGridViewTextBoxColumn
            // 
            this.fumblesDataGridViewTextBoxColumn.DataPropertyName = "Fumbles";
            this.fumblesDataGridViewTextBoxColumn.HeaderText = "Fumbles";
            this.fumblesDataGridViewTextBoxColumn.Name = "fumblesDataGridViewTextBoxColumn";
            // 
            // rushingYardsDataGridViewTextBoxColumn
            // 
            this.rushingYardsDataGridViewTextBoxColumn.DataPropertyName = "Rushing Yards";
            this.rushingYardsDataGridViewTextBoxColumn.HeaderText = "Rushing Yards";
            this.rushingYardsDataGridViewTextBoxColumn.Name = "rushingYardsDataGridViewTextBoxColumn";
            // 
            // rushingTouchdownsDataGridViewTextBoxColumn
            // 
            this.rushingTouchdownsDataGridViewTextBoxColumn.DataPropertyName = "Rushing Touchdowns";
            this.rushingTouchdownsDataGridViewTextBoxColumn.HeaderText = "Rushing Touchdowns";
            this.rushingTouchdownsDataGridViewTextBoxColumn.Name = "rushingTouchdownsDataGridViewTextBoxColumn";
            // 
            // fumblesRecoveryDataGridViewTextBoxColumn
            // 
            this.fumblesRecoveryDataGridViewTextBoxColumn.DataPropertyName = "Fumbles Recovery";
            this.fumblesRecoveryDataGridViewTextBoxColumn.HeaderText = "Fumbles Recovery";
            this.fumblesRecoveryDataGridViewTextBoxColumn.Name = "fumblesRecoveryDataGridViewTextBoxColumn";
            // 
            // receptionsDataGridViewTextBoxColumn
            // 
            this.receptionsDataGridViewTextBoxColumn.DataPropertyName = "Receptions";
            this.receptionsDataGridViewTextBoxColumn.HeaderText = "Receptions";
            this.receptionsDataGridViewTextBoxColumn.Name = "receptionsDataGridViewTextBoxColumn";
            // 
            // receivingYardsDataGridViewTextBoxColumn
            // 
            this.receivingYardsDataGridViewTextBoxColumn.DataPropertyName = "Receiving Yards";
            this.receivingYardsDataGridViewTextBoxColumn.HeaderText = "Receiving Yards";
            this.receivingYardsDataGridViewTextBoxColumn.Name = "receivingYardsDataGridViewTextBoxColumn";
            // 
            // receivingTouchdownsDataGridViewTextBoxColumn
            // 
            this.receivingTouchdownsDataGridViewTextBoxColumn.DataPropertyName = "Receiving Touchdowns";
            this.receivingTouchdownsDataGridViewTextBoxColumn.HeaderText = "Receiving Touchdowns";
            this.receivingTouchdownsDataGridViewTextBoxColumn.Name = "receivingTouchdownsDataGridViewTextBoxColumn";
            // 
            // returnTouchdownsDataGridViewTextBoxColumn
            // 
            this.returnTouchdownsDataGridViewTextBoxColumn.DataPropertyName = "Return Touchdowns";
            this.returnTouchdownsDataGridViewTextBoxColumn.HeaderText = "Return Touchdowns";
            this.returnTouchdownsDataGridViewTextBoxColumn.Name = "returnTouchdownsDataGridViewTextBoxColumn";
            // 
            // pTDataGridViewTextBoxColumn
            // 
            this.pTDataGridViewTextBoxColumn.DataPropertyName = "2PT";
            this.pTDataGridViewTextBoxColumn.HeaderText = "2PT";
            this.pTDataGridViewTextBoxColumn.Name = "pTDataGridViewTextBoxColumn";
            // 
            // pATDataGridViewTextBoxColumn
            // 
            this.pATDataGridViewTextBoxColumn.DataPropertyName = "PAT";
            this.pATDataGridViewTextBoxColumn.HeaderText = "PAT";
            this.pATDataGridViewTextBoxColumn.Name = "pATDataGridViewTextBoxColumn";
            // 
            // fGDataGridViewTextBoxColumn
            // 
            this.fGDataGridViewTextBoxColumn.DataPropertyName = "FG";
            this.fGDataGridViewTextBoxColumn.HeaderText = "FG";
            this.fGDataGridViewTextBoxColumn.Name = "fGDataGridViewTextBoxColumn";
            // 
            // puntsDataGridViewTextBoxColumn
            // 
            this.puntsDataGridViewTextBoxColumn.DataPropertyName = "Punts";
            this.puntsDataGridViewTextBoxColumn.HeaderText = "Punts";
            this.puntsDataGridViewTextBoxColumn.Name = "puntsDataGridViewTextBoxColumn";
            // 
            // longestPuntsDataGridViewTextBoxColumn
            // 
            this.longestPuntsDataGridViewTextBoxColumn.DataPropertyName = "Longest Punts";
            this.longestPuntsDataGridViewTextBoxColumn.HeaderText = "Longest Punts";
            this.longestPuntsDataGridViewTextBoxColumn.Name = "longestPuntsDataGridViewTextBoxColumn";
            // 
            // totalPuntingYardsDataGridViewTextBoxColumn
            // 
            this.totalPuntingYardsDataGridViewTextBoxColumn.DataPropertyName = "Total Punting Yards";
            this.totalPuntingYardsDataGridViewTextBoxColumn.HeaderText = "Total Punting Yards";
            this.totalPuntingYardsDataGridViewTextBoxColumn.Name = "totalPuntingYardsDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // sacksDataGridViewTextBoxColumn
            // 
            this.sacksDataGridViewTextBoxColumn.DataPropertyName = "Sacks";
            this.sacksDataGridViewTextBoxColumn.HeaderText = "Sacks";
            this.sacksDataGridViewTextBoxColumn.Name = "sacksDataGridViewTextBoxColumn";
            // 
            // interceptionsDataGridViewTextBoxColumn
            // 
            this.interceptionsDataGridViewTextBoxColumn.DataPropertyName = "Interceptions";
            this.interceptionsDataGridViewTextBoxColumn.HeaderText = "Interceptions";
            this.interceptionsDataGridViewTextBoxColumn.Name = "interceptionsDataGridViewTextBoxColumn";
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(996, 730);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdatePlayer";
            this.Load += new System.EventHandler(this.UpdatePlayer_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database.LeagueDataSet1 leagueDataSet1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private Database.LeagueDataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passingYardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passingTouchdownsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interceptionThrownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fumblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushingYardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushingTouchdownsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fumblesRecoveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingYardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingTouchdownsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTouchdownsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longestPuntsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPuntingYardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interceptionsDataGridViewTextBoxColumn;
    }
}
