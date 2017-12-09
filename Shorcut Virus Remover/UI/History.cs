using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorcut_Virus_Remover.UI
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LHlabel16_Click(object sender, EventArgs e)
        {
            //Changing form
            LogHistory  logform = new LogHistory();

            this.Hide();
            logform.Show();
        }

        private void SHlabel1_Click(object sender, EventArgs e)
        {
            //Changing form
            ScanHistory scanform = new ScanHistory();

            this.Hide();
            scanform.Show();
        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            //Changing form
            Form1 form = new Form1();

            this.Hide();
            form.Show();
        }
    }
}
