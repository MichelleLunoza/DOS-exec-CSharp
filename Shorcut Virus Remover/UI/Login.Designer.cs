namespace Shorcut_Virus_Remover
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Clearbutton2 = new System.Windows.Forms.Button();
            this.Forgotbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shortcut_Virus_RemoverDataSet = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSet();
            this.retrieveDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retrieveDataTableAdapter = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.RetrieveDataTableAdapter();
            this.tableAdapterManager = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrieveDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(288, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(288, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(243, 30);
            this.textBox2.TabIndex = 3;
            // 
            // Clearbutton2
            // 
            this.Clearbutton2.Location = new System.Drawing.Point(372, 310);
            this.Clearbutton2.Name = "Clearbutton2";
            this.Clearbutton2.Size = new System.Drawing.Size(127, 27);
            this.Clearbutton2.TabIndex = 5;
            this.Clearbutton2.Text = "Clear";
            this.Clearbutton2.UseVisualStyleBackColor = true;
            this.Clearbutton2.Click += new System.EventHandler(this.Clearbutton2_Click);
            // 
            // Forgotbutton1
            // 
            this.Forgotbutton1.Location = new System.Drawing.Point(288, 361);
            this.Forgotbutton1.Name = "Forgotbutton1";
            this.Forgotbutton1.Size = new System.Drawing.Size(127, 27);
            this.Forgotbutton1.TabIndex = 6;
            this.Forgotbutton1.Text = "Forgot Password";
            this.Forgotbutton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(146, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(151, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(293, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shorcut_Virus_Remover.Properties.Resources.red_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(223, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.BackgroundImage = global::Shorcut_Virus_Remover.Properties.Resources._24282216_1846556342053615_1067765364_n1;
            this.Loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginbutton1.Location = new System.Drawing.Point(212, 297);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(113, 40);
            this.Loginbutton1.TabIndex = 4;
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.retrieveDataBindingSource, "Username", true));
            this.pictureBox2.Image = global::Shorcut_Virus_Remover.Properties.Resources._24321799_1844964838879432_1540883326_o;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(750, 449);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // shortcut_Virus_RemoverDataSet
            // 
            this.shortcut_Virus_RemoverDataSet.DataSetName = "Shortcut_Virus_RemoverDataSet";
            this.shortcut_Virus_RemoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retrieveDataBindingSource
            // 
            this.retrieveDataBindingSource.DataMember = "RetrieveData";
            this.retrieveDataBindingSource.DataSource = this.shortcut_Virus_RemoverDataSet;
            // 
            // retrieveDataTableAdapter
            // 
            this.retrieveDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Log_HistoryTableAdapter = null;
            this.tableAdapterManager.Scan_HistoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forgotbutton1);
            this.Controls.Add(this.Clearbutton2);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrieveDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.Button Clearbutton2;
        private System.Windows.Forms.Button Forgotbutton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Shortcut_Virus_RemoverDataSet shortcut_Virus_RemoverDataSet;
        private System.Windows.Forms.BindingSource retrieveDataBindingSource;
        private Shortcut_Virus_RemoverDataSetTableAdapters.RetrieveDataTableAdapter retrieveDataTableAdapter;
        private Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}