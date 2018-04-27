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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePlayer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDataSet1 = new WindowsFormsApp1.Database.LeagueDataSet1();
            this.playerTableAdapter = new WindowsFormsApp1.Database.LeagueDataSet1TableAdapters.PlayerTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.leagueDataSet1;
            // 
            // leagueDataSet1
            // 
            this.leagueDataSet1.DataSetName = "LeagueDataSet1";
            this.leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(996, 25);
            this.bindingNavigator1.TabIndex = 27;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(996, 730);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdatePlayer";
            this.Load += new System.EventHandler(this.UpdatePlayer_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.bindingNavigator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}
