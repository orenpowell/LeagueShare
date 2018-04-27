namespace WindowsFormsApp1
{
    partial class ViewGame
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDataSet1 = new WindowsFormsApp1.LeagueDataSet1();
            this.gameTableAdapter = new WindowsFormsApp1.LeagueDataSet1TableAdapters.GameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeDataGridViewTextBoxColumn,
            this.awayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 434);
            this.dataGridView1.TabIndex = 26;
            // 
            // homeDataGridViewTextBoxColumn
            // 
            this.homeDataGridViewTextBoxColumn.DataPropertyName = "Home";
            this.homeDataGridViewTextBoxColumn.HeaderText = "Home";
            this.homeDataGridViewTextBoxColumn.Name = "homeDataGridViewTextBoxColumn";
            this.homeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // awayDataGridViewTextBoxColumn
            // 
            this.awayDataGridViewTextBoxColumn.DataPropertyName = "Away";
            this.awayDataGridViewTextBoxColumn.HeaderText = "Away";
            this.awayDataGridViewTextBoxColumn.Name = "awayDataGridViewTextBoxColumn";
            this.awayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.leagueDataSet1;
            // 
            // leagueDataSet1
            // 
            this.leagueDataSet1.DataSetName = "LeagueDataSet1";
            this.leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // ViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(766, 558);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(782, 597);
            this.Name = "ViewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewGame_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeagueDataSet1 leagueDataSet1;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private LeagueDataSet1TableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayDataGridViewTextBoxColumn;
    }
}
