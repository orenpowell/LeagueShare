namespace WindowsFormsApp1
{
    partial class UpdateLeague
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.leagueDataSet = new WindowsFormsApp1.Database.LeagueDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApp1.Database.LeagueDataSetTableAdapters.TableTableAdapter();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(142, 139);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 26);
            this.nameBox.TabIndex = 27;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.nameLabel.Location = new System.Drawing.Point(11, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 20);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "League Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(305, 139);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(83, 26);
            this.enterButton.TabIndex = 26;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AllowUserToOrderColumns = true;
            this.tableDataGridView.AllowUserToResizeColumns = false;
            this.tableDataGridView.AllowUserToResizeRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDataGridViewTextBoxColumn,
            this.winsDataGridViewTextBoxColumn,
            this.lossesDataGridViewTextBoxColumn,
            this.tiesDataGridViewTextBoxColumn});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableDataGridView.Location = new System.Drawing.Point(14, 173);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.tableDataGridView.MultiSelect = false;
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(778, 436);
            this.tableDataGridView.TabIndex = 29;
            // 
            // leagueDataSet
            // 
            this.leagueDataSet.DataSetName = "LeagueDataSet";
            this.leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.leagueDataSet;
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
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // winsDataGridViewTextBoxColumn
            // 
            this.winsDataGridViewTextBoxColumn.DataPropertyName = "Wins";
            this.winsDataGridViewTextBoxColumn.HeaderText = "Wins";
            this.winsDataGridViewTextBoxColumn.Name = "winsDataGridViewTextBoxColumn";
            this.winsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lossesDataGridViewTextBoxColumn
            // 
            this.lossesDataGridViewTextBoxColumn.DataPropertyName = "Losses";
            this.lossesDataGridViewTextBoxColumn.HeaderText = "Losses";
            this.lossesDataGridViewTextBoxColumn.Name = "lossesDataGridViewTextBoxColumn";
            this.lossesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiesDataGridViewTextBoxColumn
            // 
            this.tiesDataGridViewTextBoxColumn.DataPropertyName = "Ties";
            this.tiesDataGridViewTextBoxColumn.HeaderText = "Ties";
            this.tiesDataGridViewTextBoxColumn.Name = "tiesDataGridViewTextBoxColumn";
            this.tiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UpdateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(996, 697);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.enterButton);
            this.Name = "UpdateLeague";
            this.Load += new System.EventHandler(this.UpdateLeague_Load);
            this.Controls.SetChildIndex(this.enterButton, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.tableDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private Database.LeagueDataSet leagueDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database.LeagueDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiesDataGridViewTextBoxColumn;
    }
}
