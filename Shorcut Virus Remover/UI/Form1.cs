using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Shorcut_Virus_Remover.UI;
using System.IO;


namespace Shorcut_Virus_Remover
{
    public partial class Form1 : Form
{
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Show();
            textBox1.Enabled = false;



            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter drive letter.","Failed To Scan",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox1.Focus();
                textBox2.Visible = false;
                textBox1.Enabled = true;

                return;
            }

            else if (textBox1.Text == "C")
            {
                MessageBox.Show("Youve entered local disk drive letter. Please enter a valid drive letter of external memory.","Failed To Scan");
                textBox1.Clear();
                textBox1.Focus();
                textBox2.Visible = false;
                textBox1.Enabled = true;

                return;
            }


            string drive = Path.GetPathRoot(textBox1.Text + ":");   // e.g. K:\

            if (!Directory.Exists(drive))
            {
                MessageBox.Show("Drive " + drive + " not found or inaccessible",
                                "Error", MessageBoxButtons.OK);
             

                textBox1.Enabled = true;
                textBox1.Clear();
                textBox2.Hide();

                return;
            }

              

          
          
            else
            {


                ShortcutInfo info = new ShortcutInfo()
                {

                    ScanHistory = DateTime.Now

                };


                IShortcut app = new Shortcut();
                app.SaveScanHistory(info);


                Process cmd = new Process();

                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

    
                string directory = textBox1.Text;
                try
                {
                    //This is the Part to exwecute DOS commands . . . . 
                    cmd.StandardInput.WriteLine("attrib -s -h /s /d " + directory + ":" + @"\*.*");
                    textBox2.Text = "Changing files attributes . . . ";
                    //Delete Link Files
                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.lnk*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing shortcut files . . .";

                    cmd.StandardInput.WriteLine("cd" + directory + "\autorun.inf");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing autorun files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.inf*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing information files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.trj*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing trojan files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.wrm*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing worm  files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.pif*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing program information files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.hta*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing program HTML application files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.bat*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  batch script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.vbs*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  vb script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.js*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing js script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.jse*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  js ecnrypted script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.ws*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  window script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.scf*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  scf script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.reg*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing  malicious reg script files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.capxml*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing capxml files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.lpaq5*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing lpaq5 files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.pr*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing capxml files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.capxml*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing capxml files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.pr*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing pr files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.xnt*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing xnt files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.aut*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing aut files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.let*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing let files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.mcq*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing mcq files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.cry*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing cry files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.crypto*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing crypto files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.enc*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing enc files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.darkness*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing darkness files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.kb15*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing kb15 files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.kraken*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing kraken files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.locked*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing locked files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.nochance*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing nochance files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.obleep*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing obleep files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.exx*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing exx files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.@gmail_com_*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing @gmail_com_ files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.@india.com*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing @india.com files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.decipher*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing decipher files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.@india.com*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing @india.com files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.keemail.me*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing keemail.me files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.qq_com*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing qq_com files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.ukr.net*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing ukr.net files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.restore_fi*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing restore_fi files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.restore_fi*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing restore_fi files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.help_restore*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing help_restore files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.ecc*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing ecc files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.exx*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing ezz files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.frtss*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing frtss files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.vault*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing vault files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.enc_files*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing enc_files files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.vault.hta*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing vault.hta files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.message.txt*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing message.txt files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.aaa*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing aaa files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.vault.key*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing vault.key files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.vault.txt*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing vault.txt files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.zzz*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing zzz files . . .";

                    cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.abc*");
                    textBox2.Text = textBox2.Text + "\r\n" + "Removing abc files . . .";

                        
                        textBox1.Enabled = true;
                     

                        textBox2.Text = textBox2.Text + "\r\n" + "No more shortcut files . . .";
                        textBox2.SelectionStart = textBox2.Text.Length;
                        textBox2.ScrollToCaret();

                        MessageBox.Show("No more shortcut files.");

                        textBox1.Clear();
                        textBox2.Clear();
                  
                  
               
               
                }



                catch
                {
                    Console.WriteLine("Error");
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shortcut_Virus_RemoverDataSet.Users_Table' table. You can move, or remove it, as needed.
            this.users_TableTableAdapter.Fill(this.shortcut_Virus_RemoverDataSet.Users_Table);
            ProgressBar pBar = new ProgressBar();
            textBox2.Hide();
            textBox1.Enabled = true;
            Scanpanel1.Visible = false;
            Accountpanel1.Visible = false;

            //buttons
            Cancellabel16.Enabled = false;
            Updatelabel17.Enabled= false;
            checkBox1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ProgressBar pBar = new ProgressBar();
            pBar.Location = new System.Drawing.Point(200, 300);
            pBar.Name = "progressBar1";
            pBar.Width = 200;
            pBar.Height = 20;
            Controls.Add(pBar);
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value = 100;
        }

        private void Logoutbutton2_Click(object sender, EventArgs e)
        {
            ShortcutInfo info = new ShortcutInfo()
            {

                LogHistory = DateTime.Now

            };


            IShortcut app = new Shortcut();
            app.SaveLogHistory(info);
            MessageBox.Show("Successfully Logout");

            //Changing form
            Login loginform = new Login();

            this.Hide();
            loginform.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Scanlabel3_Click(object sender, EventArgs e)
        {

            //Changing panel
            Scanpanel1.Visible = true;
            Dashboardpanel1.Visible = false;
            Accountpanel1.Visible = false;
        }

        private void Accountlabel3_Click(object sender, EventArgs e)
        {
            Accountpanel1.Visible = true;
            Dashboardpanel1.Visible = false;
            Scanpanel1.Visible = false;
        }
        private void Dashboardlabel3_Click(object sender, EventArgs e)
        {
            Dashboardpanel1.Visible = true;
            Scanpanel1.Visible = false;
            Accountpanel1.Visible = false;
        }

        private void Helplabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the Scan Button and put the drive letter of your external storage/drive. Then click the remove shortcut virus button in order to perform its task.","Help");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Historylabel4_Click(object sender, EventArgs e)
        {
            //Changing form
            History Historyform = new History();

            this.Hide();
            Historyform.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update is not available this time. Please try again later.","Update Failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        
        }

        private void Editlabel16_Click(object sender, EventArgs e)
        {
            firstnameTextBox.ReadOnly = false;
            lastnameTextBox.ReadOnly = false;
            usernameTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            contact_NumberTextBox.ReadOnly = false;

            Editlabel16.Enabled = false;
            Updatelabel17.Enabled = true;
            Cancellabel16.Enabled = true;
            checkBox1.Enabled = true;
        }


          

        private void users_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shortcut_Virus_RemoverDataSet);

        }

        private void Updatelabel17_Click(object sender, EventArgs e)
        {
           
            this.Validate();
            this.users_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shortcut_Virus_RemoverDataSet);

            MessageBox.Show("Successfully Update Information","Update Sucess");

            Editlabel16.Enabled = true;
            Updatelabel17.Enabled = false;
            Cancellabel16.Enabled = false;
            checkBox1.Enabled = false;

            firstnameTextBox.ReadOnly = true;
            lastnameTextBox.ReadOnly = true;
            usernameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            passwordTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            contact_NumberTextBox.ReadOnly = true;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                passwordTextBox.PasswordChar = '\0';
            else
                passwordTextBox.PasswordChar = '*';
        }

        private void Cancellabel16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Editlabel16.Enabled = true;
                Updatelabel17.Enabled = false;
                Cancellabel16.Enabled = false;
                checkBox1.Enabled = false;

                firstnameTextBox.ReadOnly = true;
                lastnameTextBox.ReadOnly = true;
                usernameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                passwordTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                contact_NumberTextBox.ReadOnly = true;
            }
            else
            {
            }

            


        }

        private void Aboutlabel19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BitArmor is a shortcut antivirus software originally developed to detect and remove computer viruses or malicious software specifically in external storage. \n\n\n Developed By: \n\n Michelle S. Lunoza \n Katleen May D. Culla \n Jeremy Binuya \n\n\n For Educational Purpose, here's the link for the source code. \n https://github.com/MichelleLunoza/DOS-exec-CSharp", "BitArmor - ABOUT", MessageBoxButtons.OK);
        }
    }
}
    