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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDataSet = new WindowsFormsApp1.Database.LeagueDataSet();
            this.tableTableAdapter = new WindowsFormsApp1.Database.LeagueDataSetTableAdapters.TableTableAdapter();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Losses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
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
            // tableDataGridView
            // 
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
            this.Wins,
            this.Losses,
            this.Ties});
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
            this.tableDataGridView.Location = new System.Drawing.Point(27, 173);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.tableDataGridView.MultiSelect = false;
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.Size = new System.Drawing.Size(462, 427);
            this.tableDataGridView.TabIndex = 29;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Wins
            // 
            this.Wins.DataPropertyName = "Wins";
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            // 
            // Losses
            // 
            this.Losses.DataPropertyName = "Losses";
            this.Losses.HeaderText = "Losses";
            this.Losses.Name = "Losses";
            // 
            // Ties
            // 
            this.Ties.DataPropertyName = "Ties";
            this.Ties.HeaderText = "Ties";
            this.Ties.Name = "Ties";
            // 
            // UpdateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(996, 730);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button enterButton;
        private Database.LeagueDataSet leagueDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database.LeagueDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ties;
    }
}
