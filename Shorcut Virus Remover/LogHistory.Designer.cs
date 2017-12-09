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
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortcut_Virus_RemoverDataSet = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSet();
            this.log_HistoryTableAdapter = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.Log_HistoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(99, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 500;
            // 
            // logHistoryBindingSource
            // 
            this.logHistoryBindingSource.DataMember = "Log_History";
            this.logHistoryBindingSource.DataSource = this.shortcut_Virus_RemoverDataSet;
            // 
            // shortcut_Virus_RemoverDataSet
            // 
            this.shortcut_Virus_RemoverDataSet.DataSetName = "Shortcut_Virus_RemoverDataSet";
            this.shortcut_Virus_RemoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // log_HistoryTableAdapter
            // 
            this.log_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(301, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log History";
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.BackgroundImage = global::Shorcut_Virus_Remover.Properties.Resources.Back;
            this.Loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginbutton1.Location = new System.Drawing.Point(12, 83);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(97, 39);
            this.Loginbutton1.TabIndex = 6;
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shorcut_Virus_Remover.Properties.Resources.loghistory2;
            this.pictureBox1.Location = new System.Drawing.Point(248, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shorcut_Virus_Remover.Properties.Resources._24321799_1844964838879432_1540883326_o;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(750, 449);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "LogHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogHistory";
            this.Load += new System.EventHandler(this.LogHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Shortcut_Virus_RemoverDataSet shortcut_Virus_RemoverDataSet;
        private System.Windows.Forms.BindingSource logHistoryBindingSource;
        private Shortcut_Virus_RemoverDataSetTableAdapters.Log_HistoryTableAdapter log_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Loginbutton1;
    }
}