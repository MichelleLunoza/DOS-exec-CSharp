using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shorcut_Virus_Remover
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        

        private void Clearbutton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            //Login Purpose
            ShortcutInfo info = new ShortcutInfo()
            {

                Username = textBox1.Text,
                Password = CalculateMD5Hash(textBox2.Text)

            };


            IShortcut app = new Shortcut();
            app.RetrieveData(info);

            var found = app.RetrieveData(info);
            if (found)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Successfully Account Retrieved", "Login Successful", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Changing form
                Form1 ShortcutForm = new Form1();

                this.Hide();
                ShortcutForm.Show();

            }
            else
            {

                MessageBox.Show("Acces is Denied. Attempt to login.","Login Failed", System.Windows.Forms.MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }

        }


        private void Login_Load(object sender, EventArgs e)
        {
          

        }

        private void Forgotbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator","Forgot Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
