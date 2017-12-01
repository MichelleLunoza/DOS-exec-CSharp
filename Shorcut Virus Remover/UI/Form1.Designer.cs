namespace Shorcut_Virus_Remover
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Logoutbutton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Scanpanel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dashboardlabel3 = new System.Windows.Forms.Label();
            this.Scanlabel3 = new System.Windows.Forms.Label();
            this.Accountlabel3 = new System.Windows.Forms.Label();
            this.Helplabel3 = new System.Windows.Forms.Label();
            this.Feedbacklabel4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Scanpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(129, 90);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(112, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove Shortcut Virus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(49, 137);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 64);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drive Letter:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Logoutbutton2
            // 
            this.Logoutbutton2.Location = new System.Drawing.Point(618, 12);
            this.Logoutbutton2.Name = "Logoutbutton2";
            this.Logoutbutton2.Size = new System.Drawing.Size(111, 32);
            this.Logoutbutton2.TabIndex = 6;
            this.Logoutbutton2.Text = "Logout";
            this.Logoutbutton2.UseVisualStyleBackColor = true;
            this.Logoutbutton2.Click += new System.EventHandler(this.Logoutbutton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shorcut_Virus_Remover.Properties.Resources._24321799_1844964838879432_1540883326_o;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Scanpanel1
            // 
            this.Scanpanel1.Controls.Add(this.pictureBox2);
            this.Scanpanel1.Controls.Add(this.label1);
            this.Scanpanel1.Controls.Add(this.textBox2);
            this.Scanpanel1.Controls.Add(this.textBox1);
            this.Scanpanel1.Controls.Add(this.label2);
            this.Scanpanel1.Controls.Add(this.button1);
            this.Scanpanel1.Location = new System.Drawing.Point(186, 152);
            this.Scanpanel1.Name = "Scanpanel1";
            this.Scanpanel1.Size = new System.Drawing.Size(384, 277);
            this.Scanpanel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shorcut_Virus_Remover.Properties.Resources.Book_magnifying_glass_icon;
            this.pictureBox2.Location = new System.Drawing.Point(112, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(160, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboardlabel3
            // 
            this.Dashboardlabel3.AutoSize = true;
            this.Dashboardlabel3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Dashboardlabel3.Location = new System.Drawing.Point(12, 87);
            this.Dashboardlabel3.Name = "Dashboardlabel3";
            this.Dashboardlabel3.Size = new System.Drawing.Size(145, 27);
            this.Dashboardlabel3.TabIndex = 10;
            this.Dashboardlabel3.Text = "Dashboard";
            // 
            // Scanlabel3
            // 
            this.Scanlabel3.AutoSize = true;
            this.Scanlabel3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Scanlabel3.Location = new System.Drawing.Point(184, 88);
            this.Scanlabel3.Name = "Scanlabel3";
            this.Scanlabel3.Size = new System.Drawing.Size(69, 27);
            this.Scanlabel3.TabIndex = 11;
            this.Scanlabel3.Text = "Scan";
            // 
            // Accountlabel3
            // 
            this.Accountlabel3.AutoSize = true;
            this.Accountlabel3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Accountlabel3.Location = new System.Drawing.Point(287, 88);
            this.Accountlabel3.Name = "Accountlabel3";
            this.Accountlabel3.Size = new System.Drawing.Size(160, 27);
            this.Accountlabel3.TabIndex = 12;
            this.Accountlabel3.Text = "My Account";
            // 
            // Helplabel3
            // 
            this.Helplabel3.AutoSize = true;
            this.Helplabel3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helplabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Helplabel3.Location = new System.Drawing.Point(649, 88);
            this.Helplabel3.Name = "Helplabel3";
            this.Helplabel3.Size = new System.Drawing.Size(69, 27);
            this.Helplabel3.TabIndex = 13;
            this.Helplabel3.Text = "Help";
            // 
            // Feedbacklabel4
            // 
            this.Feedbacklabel4.AutoSize = true;
            this.Feedbacklabel4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedbacklabel4.ForeColor = System.Drawing.Color.Firebrick;
            this.Feedbacklabel4.Location = new System.Drawing.Point(478, 88);
            this.Feedbacklabel4.Name = "Feedbacklabel4";
            this.Feedbacklabel4.Size = new System.Drawing.Size(129, 27);
            this.Feedbacklabel4.TabIndex = 14;
            this.Feedbacklabel4.Text = "Feedback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(157, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(258, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "|";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(453, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(616, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Feedbacklabel4);
            this.Controls.Add(this.Helplabel3);
            this.Controls.Add(this.Accountlabel3);
            this.Controls.Add(this.Scanlabel3);
            this.Controls.Add(this.Dashboardlabel3);
            this.Controls.Add(this.Scanpanel1);
            this.Controls.Add(this.Logoutbutton2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortcut Virus Remover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Scanpanel1.ResumeLayout(false);
            this.Scanpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Logoutbutton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Scanpanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dashboardlabel3;
        private System.Windows.Forms.Label Scanlabel3;
        private System.Windows.Forms.Label Accountlabel3;
        private System.Windows.Forms.Label Helplabel3;
        private System.Windows.Forms.Label Feedbacklabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

