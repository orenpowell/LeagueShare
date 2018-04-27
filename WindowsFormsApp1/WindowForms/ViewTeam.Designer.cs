namespace WindowsFormsApp1
{
    partial class ViewTeam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDataSet = new WindowsFormsApp1.Database.LeagueDataSet();
            this.tableTableAdapter = new WindowsFormsApp1.Database.LeagueDataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AllowUserToOrderColumns = true;
            this.tableDataGridView.AllowUserToResizeColumns = false;
            this.tableDataGridView.AllowUserToResizeRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDataGridViewTextBoxColumn,
            this.winsDataGridViewTextBoxColumn,
            this.lossesDataGridViewTextBoxColumn,
            this.tiesDataGridViewTextBoxColumn});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableDataGridView.Location = new System.Drawing.Point(27, 116);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.tableDataGridView.MultiSelect = false;
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.Size = new System.Drawing.Size(591, 431);
            this.tableDataGridView.TabIndex = 30;
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
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.leagueDataSet;
            // 
            // leagueDataSet
            // 
            this.leagueDataSet.DataSetName = "LeagueDataSet";
            this.leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(766, 558);
            this.Controls.Add(this.tableDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(782, 597);
            this.Name = "ViewTeam";
            this.Load += new System.EventHandler(this.ViewTeam_Load);
            this.Controls.SetChildIndex(this.tableDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
