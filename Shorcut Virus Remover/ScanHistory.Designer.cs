namespace Shorcut_Virus_Remover
{
    partial class ScanHistory
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
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortcut_Virus_RemoverDataSet = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSet();
            this.scan_HistoryTableAdapter = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.Scan_HistoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.DataSource = this.scanHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 500;
            // 
            // scanHistoryBindingSource
            // 
            this.scanHistoryBindingSource.DataMember = "Scan_History";
            this.scanHistoryBindingSource.DataSource = this.shortcut_Virus_RemoverDataSet;
            // 
            // shortcut_Virus_RemoverDataSet
            // 
            this.shortcut_Virus_RemoverDataSet.DataSetName = "Shortcut_Virus_RemoverDataSet";
            this.shortcut_Virus_RemoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scan_HistoryTableAdapter
            // 
            this.scan_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(295, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shorcut_Virus_Remover.Properties.Resources.Book_magnifying_glass_icon;
            this.pictureBox1.Location = new System.Drawing.Point(225, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScanHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanHistory";
            this.Load += new System.EventHandler(this.ScanHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Shortcut_Virus_RemoverDataSet shortcut_Virus_RemoverDataSet;
        private System.Windows.Forms.BindingSource scanHistoryBindingSource;
        private Shortcut_Virus_RemoverDataSetTableAdapters.Scan_HistoryTableAdapter scan_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}