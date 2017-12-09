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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Scanpanel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dashboardlabel3 = new System.Windows.Forms.Label();
            this.Scanlabel3 = new System.Windows.Forms.Label();
            this.Accountlabel3 = new System.Windows.Forms.Label();
            this.Helplabel3 = new System.Windows.Forms.Label();
            this.Historylabel4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dashboardpanel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Accountpanel1 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.users_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortcut_Virus_RemoverDataSet = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.contact_NumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Cancellabel16 = new System.Windows.Forms.Label();
            this.Updatelabel17 = new System.Windows.Forms.Label();
            this.Editlabel16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Logoutbutton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.users_TableTableAdapter = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.Users_TableTableAdapter();
            this.tableAdapterManager = new Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager();
            this.label17 = new System.Windows.Forms.Label();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Scanpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Dashboardpanel1.SuspendLayout();
            this.Accountpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(123, 97);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(41, 138);
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
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drive Letter:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scanpanel1
            // 
            this.Scanpanel1.Controls.Add(this.pictureBox2);
            this.Scanpanel1.Controls.Add(this.label1);
            this.Scanpanel1.Controls.Add(this.textBox2);
            this.Scanpanel1.Controls.Add(this.textBox1);
            this.Scanpanel1.Controls.Add(this.label2);
            this.Scanpanel1.Controls.Add(this.button1);
            this.Scanpanel1.Location = new System.Drawing.Point(190, 125);
            this.Scanpanel1.Name = "Scanpanel1";
            this.Scanpanel1.Size = new System.Drawing.Size(384, 287);
            this.Scanpanel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shorcut_Virus_Remover.Properties.Resources.Book_magnifying_glass_icon;
            this.pictureBox2.Location = new System.Drawing.Point(134, 19);
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
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Shorcut_Virus_Remover.Properties.Resources.remove_shortcut;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(98, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboardlabel3
            // 
            this.Dashboardlabel3.AutoSize = true;
            this.Dashboardlabel3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Dashboardlabel3.Location = new System.Drawing.Point(21, 88);
            this.Dashboardlabel3.Name = "Dashboardlabel3";
            this.Dashboardlabel3.Size = new System.Drawing.Size(130, 23);
            this.Dashboardlabel3.TabIndex = 10;
            this.Dashboardlabel3.Text = "Dashboard";
            this.Dashboardlabel3.Click += new System.EventHandler(this.Dashboardlabel3_Click);
            // 
            // Scanlabel3
            // 
            this.Scanlabel3.AutoSize = true;
            this.Scanlabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scanlabel3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Scanlabel3.Location = new System.Drawing.Point(187, 88);
            this.Scanlabel3.Name = "Scanlabel3";
            this.Scanlabel3.Size = new System.Drawing.Size(60, 23);
            this.Scanlabel3.TabIndex = 11;
            this.Scanlabel3.Text = "Scan";
            this.Scanlabel3.Click += new System.EventHandler(this.Scanlabel3_Click);
            // 
            // Accountlabel3
            // 
            this.Accountlabel3.AutoSize = true;
            this.Accountlabel3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountlabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Accountlabel3.Location = new System.Drawing.Point(295, 88);
            this.Accountlabel3.Name = "Accountlabel3";
            this.Accountlabel3.Size = new System.Drawing.Size(140, 23);
            this.Accountlabel3.TabIndex = 12;
            this.Accountlabel3.Text = "My Account";
            this.Accountlabel3.Click += new System.EventHandler(this.Accountlabel3_Click);
            // 
            // Helplabel3
            // 
            this.Helplabel3.AutoSize = true;
            this.Helplabel3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helplabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.Helplabel3.Location = new System.Drawing.Point(649, 88);
            this.Helplabel3.Name = "Helplabel3";
            this.Helplabel3.Size = new System.Drawing.Size(60, 23);
            this.Helplabel3.TabIndex = 13;
            this.Helplabel3.Text = "Help";
            this.Helplabel3.Click += new System.EventHandler(this.Helplabel3_Click);
            // 
            // Historylabel4
            // 
            this.Historylabel4.AutoSize = true;
            this.Historylabel4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historylabel4.ForeColor = System.Drawing.Color.Firebrick;
            this.Historylabel4.Location = new System.Drawing.Point(488, 89);
            this.Historylabel4.Name = "Historylabel4";
            this.Historylabel4.Size = new System.Drawing.Size(92, 23);
            this.Historylabel4.TabIndex = 14;
            this.Historylabel4.Text = "History";
            this.Historylabel4.Click += new System.EventHandler(this.Historylabel4_Click);
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
            this.label6.Location = new System.Drawing.Point(613, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "|";
            // 
            // Dashboardpanel1
            // 
            this.Dashboardpanel1.Controls.Add(this.label8);
            this.Dashboardpanel1.Controls.Add(this.label7);
            this.Dashboardpanel1.Location = new System.Drawing.Point(25, 138);
            this.Dashboardpanel1.Name = "Dashboardpanel1";
            this.Dashboardpanel1.Size = new System.Drawing.Size(704, 288);
            this.Dashboardpanel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(435, 12);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Update";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status: Your Antivirus is not updated. Please update now. ";
            // 
            // Accountpanel1
            // 
            this.Accountpanel1.Controls.Add(this.checkBox1);
            this.Accountpanel1.Controls.Add(this.iDTextBox);
            this.Accountpanel1.Controls.Add(this.label17);
            this.Accountpanel1.Controls.Add(this.usernameTextBox);
            this.Accountpanel1.Controls.Add(this.passwordTextBox);
            this.Accountpanel1.Controls.Add(this.firstnameTextBox);
            this.Accountpanel1.Controls.Add(this.lastnameTextBox);
            this.Accountpanel1.Controls.Add(this.contact_NumberTextBox);
            this.Accountpanel1.Controls.Add(this.addressTextBox);
            this.Accountpanel1.Controls.Add(this.emailTextBox);
            this.Accountpanel1.Controls.Add(this.label16);
            this.Accountpanel1.Controls.Add(this.Cancellabel16);
            this.Accountpanel1.Controls.Add(this.Updatelabel17);
            this.Accountpanel1.Controls.Add(this.Editlabel16);
            this.Accountpanel1.Controls.Add(this.label15);
            this.Accountpanel1.Controls.Add(this.label14);
            this.Accountpanel1.Controls.Add(this.label13);
            this.Accountpanel1.Controls.Add(this.pictureBox3);
            this.Accountpanel1.Controls.Add(this.label12);
            this.Accountpanel1.Controls.Add(this.label11);
            this.Accountpanel1.Controls.Add(this.label10);
            this.Accountpanel1.Controls.Add(this.label9);
            this.Accountpanel1.Location = new System.Drawing.Point(89, 127);
            this.Accountpanel1.Name = "Accountpanel1";
            this.Accountpanel1.Size = new System.Drawing.Size(631, 319);
            this.Accountpanel1.TabIndex = 20;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(154, 160);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(243, 23);
            this.usernameTextBox.TabIndex = 41;
            // 
            // users_TableBindingSource
            // 
            this.users_TableBindingSource.DataMember = "Users_Table";
            this.users_TableBindingSource.DataSource = this.shortcut_Virus_RemoverDataSet;
            // 
            // shortcut_Virus_RemoverDataSet
            // 
            this.shortcut_Virus_RemoverDataSet.DataSetName = "Shortcut_Virus_RemoverDataSet";
            this.shortcut_Virus_RemoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(156, 189);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(243, 23);
            this.passwordTextBox.TabIndex = 43;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Firstname", true));
            this.firstnameTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextBox.Location = new System.Drawing.Point(154, 99);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.ReadOnly = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(243, 23);
            this.firstnameTextBox.TabIndex = 45;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Lastname", true));
            this.lastnameTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.Location = new System.Drawing.Point(156, 131);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.ReadOnly = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(241, 23);
            this.lastnameTextBox.TabIndex = 49;
            // 
            // contact_NumberTextBox
            // 
            this.contact_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Contact_Number", true));
            this.contact_NumberTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_NumberTextBox.Location = new System.Drawing.Point(156, 276);
            this.contact_NumberTextBox.Name = "contact_NumberTextBox";
            this.contact_NumberTextBox.ReadOnly = true;
            this.contact_NumberTextBox.Size = new System.Drawing.Size(241, 23);
            this.contact_NumberTextBox.TabIndex = 51;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(154, 218);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(243, 23);
            this.addressTextBox.TabIndex = 53;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(154, 247);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(243, 23);
            this.emailTextBox.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(22, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Password:";
            // 
            // Cancellabel16
            // 
            this.Cancellabel16.AutoSize = true;
            this.Cancellabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cancellabel16.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancellabel16.ForeColor = System.Drawing.Color.Firebrick;
            this.Cancellabel16.Location = new System.Drawing.Point(512, 196);
            this.Cancellabel16.Name = "Cancellabel16";
            this.Cancellabel16.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Cancellabel16.Size = new System.Drawing.Size(96, 31);
            this.Cancellabel16.TabIndex = 36;
            this.Cancellabel16.Text = "Cancel";
            this.Cancellabel16.Click += new System.EventHandler(this.Cancellabel16_Click);
            // 
            // Updatelabel17
            // 
            this.Updatelabel17.AutoSize = true;
            this.Updatelabel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Updatelabel17.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatelabel17.ForeColor = System.Drawing.Color.Firebrick;
            this.Updatelabel17.Location = new System.Drawing.Point(512, 152);
            this.Updatelabel17.Name = "Updatelabel17";
            this.Updatelabel17.Padding = new System.Windows.Forms.Padding(3);
            this.Updatelabel17.Size = new System.Drawing.Size(96, 31);
            this.Updatelabel17.TabIndex = 35;
            this.Updatelabel17.Text = "Update";
            this.Updatelabel17.Click += new System.EventHandler(this.Updatelabel17_Click);
            // 
            // Editlabel16
            // 
            this.Editlabel16.AutoSize = true;
            this.Editlabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Editlabel16.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editlabel16.ForeColor = System.Drawing.Color.Firebrick;
            this.Editlabel16.Location = new System.Drawing.Point(512, 108);
            this.Editlabel16.Name = "Editlabel16";
            this.Editlabel16.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.Editlabel16.Size = new System.Drawing.Size(95, 31);
            this.Editlabel16.TabIndex = 34;
            this.Editlabel16.Text = "Edit";
            this.Editlabel16.Click += new System.EventHandler(this.Editlabel16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(21, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Contact Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Firebrick;
            this.label14.Location = new System.Drawing.Point(22, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(22, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Address:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Shorcut_Virus_Remover.Properties.Resources.red_user_icon;
            this.pictureBox3.Location = new System.Drawing.Point(215, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(22, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Username:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(22, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lastname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(22, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Firstname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(266, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Account";
            // 
            // Logoutbutton2
            // 
            this.Logoutbutton2.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbutton2.BackgroundImage = global::Shorcut_Virus_Remover.Properties.Resources.logout;
            this.Logoutbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoutbutton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logoutbutton2.Location = new System.Drawing.Point(629, 18);
            this.Logoutbutton2.Name = "Logoutbutton2";
            this.Logoutbutton2.Size = new System.Drawing.Size(91, 32);
            this.Logoutbutton2.TabIndex = 6;
            this.Logoutbutton2.UseVisualStyleBackColor = false;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // users_TableTableAdapter
            // 
            this.users_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Log_HistoryTableAdapter = null;
            this.tableAdapterManager.Scan_HistoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shorcut_Virus_Remover.Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = this.users_TableTableAdapter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Firebrick;
            this.label17.Location = new System.Drawing.Point(22, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 17);
            this.label17.TabIndex = 56;
            this.label17.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(156, 70);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(243, 23);
            this.iDTextBox.TabIndex = 57;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(405, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Visible Pass";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 452);
            this.Controls.Add(this.Scanpanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Historylabel4);
            this.Controls.Add(this.Helplabel3);
            this.Controls.Add(this.Accountlabel3);
            this.Controls.Add(this.Scanlabel3);
            this.Controls.Add(this.Dashboardlabel3);
            this.Controls.Add(this.Logoutbutton2);
            this.Controls.Add(this.Accountpanel1);
            this.Controls.Add(this.Dashboardpanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortcut Virus Remover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scanpanel1.ResumeLayout(false);
            this.Scanpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Dashboardpanel1.ResumeLayout(false);
            this.Dashboardpanel1.PerformLayout();
            this.Accountpanel1.ResumeLayout(false);
            this.Accountpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcut_Virus_RemoverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label Historylabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Dashboardpanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Accountpanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Cancellabel16;
        private System.Windows.Forms.Label Updatelabel17;
        private System.Windows.Forms.Label Editlabel16;
        private System.Windows.Forms.Label label16;
        private Shortcut_Virus_RemoverDataSet shortcut_Virus_RemoverDataSet;
        private System.Windows.Forms.BindingSource users_TableBindingSource;
        private Shortcut_Virus_RemoverDataSetTableAdapters.Users_TableTableAdapter users_TableTableAdapter;
        private Shortcut_Virus_RemoverDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox contact_NumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

