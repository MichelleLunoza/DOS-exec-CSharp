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
//using System.Threading;


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
   				
               	//Removing Autorun
                cmd.StandardInput.WriteLine("cd" + directory + "\autorun.inf"); 
               	textBox2.Text = textBox2.Text + "\r\n" + "Removing autorun files . . .";            	
                
                //Delete Link Files
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.lnk*");
				textBox2.Text = textBox2.Text + "\r\n" + "Removing shortcut files . . .";

				//Removing Virus Files
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
                
                /*
                    add this mom  kulang pa kasi
					*.*cry
					*.*crypto
					*.*darkness
					*.*enc*
					*.*kb15
					*.*kraken
					*.*locked
					*.*nochance
					*.*obleep
					*.*exx
					*@gmail_com_*
					*@india.com*
					*cpyt*
					*crypt*
					*decipher*
					*install_tor*.*
					*keemail.me*
					*qq_com*
					*ukr.net*
					*restore_fi*.*
					*help_restore*.*
					*how_to_recover*.*
					*.ecc
					*.exx
					*.ezz
					*.frtrss
					*.vault
					*want your files back.*
					confirmation.key
					enc_files.txt
					last_chance.txt
					message.txt
					recovery_file.txt
					recovery_key.txt
					vault.hta
					vault.key
					vault.txt
					*.aaa
					*.zzz
					*.abc 
                  
                */
                
                
                textBox2.Text = textBox2.Text + "\r\n" + "No more shortcut files . . .";   
				textBox2.SelectionStart = textBox2.Text.Length;
				textBox2.ScrollToCaret();
				
                MessageBox.Show("No more shortcut files.");
               
            }
            catch
            {
                Console.WriteLine("Error");
            }
                
            
        }
    }
}
