
using Shorcut_Virus_Remover.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorcut_Virus_Remover
{
    public class Shortcut : IShortcut
    {
        private ShortcutBLL bll = new ShortcutDAL();


        public Shortcut()
        {
        }

        public bool RetrieveData(ShortcutInfo shortcutinfo)
        {
            return bll.RetrieveData(shortcutinfo);
        }
        public void SaveLogHistory (ShortcutInfo shortcutinfo)
        {
            bll.SaveLogHistory(shortcutinfo);
        }
      
    }
}

