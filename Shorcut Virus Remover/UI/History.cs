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

        private void LogHistorybutton1_Click(object sender, EventArgs e)
        {
            LogHistory logHistoryform = new LogHistory();

            this.Hide();
            logHistoryform.Show();
        }

        private void ScanHistorybutton2_Click(object sender, EventArgs e)
        {
            ScanHistory scanHistoryform = new ScanHistory();

            this.Hide();
            scanHistoryform.Show();
        }
    }
}
