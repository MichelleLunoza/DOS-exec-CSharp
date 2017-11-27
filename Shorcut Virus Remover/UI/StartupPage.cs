using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorcut_Virus_Remover
{
    public partial class StartupPage : Form
    {
        public StartupPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signup is not available right now. Please connect to the internet","Error Signup",System.Windows.Forms.MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();

            this.Hide();
            loginform.Show();
        }
    }
}
