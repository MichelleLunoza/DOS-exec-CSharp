using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shorcut_Virus_Remover
{
    public interface IShortcut
    {
        bool RetrieveData(ShortcutInfo shortcutinfo);
        void SaveLogHistory(ShortcutInfo shortcutinfo);
        void SaveScanHistory(ShortcutInfo shortcutinfo);
        

    }

}
