namespace Shorcut_Virus_Remover
{
    partial class LogHistory
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
            this.shortcut_Virus_RemoverDataSet = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSet();
            this.logHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.log_HistoryTableAdapter = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.Log_HistoryTableAdapter();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(95, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // shortcut_Virus_RemoverDataSet
            // 
            this.shortcut_Virus_RemoverDataSet.DataSetName = "Shortcut_Virus_RemoverDataSet";
            this.shortcut_Virus_RemoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logHistoryBindingSource
            // 
            this.logHistoryBindingSource.DataMember = "Log_History";
            this.logHistoryBindingSource.DataSource = this.shortcut_Virus_RemoverDataSet;
            // 
            // log_HistoryTableAdapter
            // 
            this.log_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log History";
            // 
            // LogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LogHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogHistory";
            this.Load += new System.EventHandler(this.LogHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Shortcut_Virus_RemoverDataSet shortcut_Virus_RemoverDataSet;
        private System.Windows.Forms.BindingSource logHistoryBindingSource;
        private Shortcut_Virus_RemoverDataSetTableAdapters.Log_HistoryTableAdapter log_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}