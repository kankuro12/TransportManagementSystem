using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem.ManageKeys
{
    public class Manage
    {
        public static bool checkForDatabase()
        {
            RegistryKey rkSubKey = Registry.CurrentUser.OpenSubKey(INFO.guid+"\\database", false);
            if (rkSubKey == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static RegistryKey NewDatabseKey()
        {
            return Registry.CurrentUser.CreateSubKey(INFO.guid + "\\database", true);
        }

    }
}
