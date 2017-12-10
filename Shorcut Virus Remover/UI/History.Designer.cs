namespace Shorcut_Virus_Remover.UI
{
    partial class History
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
            this.LHlabel16 = new System.Windows.Forms.Label();
            this.SHlabel1 = new System.Windows.Forms.Label();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LHlabel16
            // 
            this.LHlabel16.AutoSize = true;
            this.LHlabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LHlabel16.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHlabel16.ForeColor = System.Drawing.Color.Firebrick;
            this.LHlabel16.Location = new System.Drawing.Point(159, 210);
            this.LHlabel16.Name = "LHlabel16";
            this.LHlabel16.Padding = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.LHlabel16.Size = new System.Drawing.Size(181, 37);
            this.LHlabel16.TabIndex = 35;
            this.LHlabel16.Text = "Log History";
            this.LHlabel16.Click += new System.EventHandler(this.LHlabel16_Click);
            // 
            // SHlabel1
            // 
            this.SHlabel1.AutoSize = true;
            this.SHlabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SHlabel1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHlabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.SHlabel1.Location = new System.Drawing.Point(387, 210);
            this.SHlabel1.Name = "SHlabel1";
            this.SHlabel1.Padding = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.SHlabel1.Size = new System.Drawing.Size(191, 37);
            this.SHlabel1.TabIndex = 36;
            this.SHlabel1.Text = "Scan History";
            this.SHlabel1.Click += new System.EventHandler(this.SHlabel1_Click);
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.BackgroundImage = global::Shorcut_Virus_Remover.Properties.Resources.Back;
            this.Loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginbutton1.Location = new System.Drawing.Point(12, 80);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(97, 39);
            this.Loginbutton1.TabIndex = 37;
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shorcut_Virus_Remover.Properties.Resources._24321799_1844964838879432_1540883326_o;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.SHlabel1);
            this.Controls.Add(this.LHlabel16);
            this.Controls.Add(this.pictureBox1);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LHlabel16;
        private System.Windows.Forms.Label SHlabel1;
        private System.Windows.Forms.Button Loginbutton1;

    }
}