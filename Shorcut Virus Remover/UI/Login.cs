using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
                Password = textBox2.Text

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
    }
}
