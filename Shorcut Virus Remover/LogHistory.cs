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
    }
}
