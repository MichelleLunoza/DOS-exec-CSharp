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
    public partial class ScanHistory : Form
    {
        public ScanHistory()
        {
            InitializeComponent();
        }

        private void scan_HistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scan_HistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shortcut_Virus_RemoverDataSet);

        }

        private void ScanHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shortcut_Virus_RemoverDataSet.Scan_History' table. You can move, or remove it, as needed.
            this.scan_HistoryTableAdapter.Fill(this.shortcut_Virus_RemoverDataSet.Scan_History);

        }
    }
}
