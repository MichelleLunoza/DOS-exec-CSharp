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
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "1")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "2")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "3")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "4")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "5")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "6")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            if (textBox1.Text == "7")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "8")
            {
                MessageBox.Show("Integer is not allowed.");
            }
            else if (textBox1.Text == "9")
            {
                MessageBox.Show("Integer is not allowed.");
            }


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

                MessageBox.Show("No more shortcut files.");
               
            }
            catch
            {
                Console.WriteLine("Error");
            }
                
            
        }
    }
}
