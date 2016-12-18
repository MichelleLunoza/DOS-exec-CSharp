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
                textBox2.Text = "NZXXZN \n";
                //Delete Link Files
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.lnk*");
                textBox2.Text = "\n :|";
                cmd.StandardInput.WriteLine("cd" + directory + "\autorun.inf");
                textBox2.Text = "\n :|";
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.inf*");
                textBox2.Text = "\n :|";
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.trj*");
                textBox2.Text = "\n :|";
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.wrm*");
                textBox2.Text = "\n :|";
                cmd.StandardInput.WriteLine("DEL /F /Q /A " + directory + ":" + @"\*.bts*");
                textBox2.Text = "\n :|";

                MessageBox.Show("No more shortcut files.");
               
            }
            catch
            {
                Console.WriteLine("Error");
            }
                
            
        }
    }
}
