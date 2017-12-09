using Shorcut_Virus_Remover.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Shorcut_Virus_Remover
{
    public partial class LogHistory : Form
    {
        public LogHistory()
        {
            InitializeComponent();
        }

        private void LogHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shortcut_Virus_RemoverDataSet.Log_History' table. You can move, or remove it, as needed.
            this.log_HistoryTableAdapter.Fill(this.shortcut_Virus_RemoverDataSet.Log_History);
            

        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            //Changing form
            History Hform = new History();

            this.Hide();
            Hform.Show();
        }

  
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
