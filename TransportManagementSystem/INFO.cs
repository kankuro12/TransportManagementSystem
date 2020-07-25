using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CustomControls;

namespace TransportManagementSystem
{
    public static class INFO
    {
        public static string version = "1.0.0.0";
        public static string guid = "SDFGMSDFG-SDSD-d56e65";
        public static bool hasrole(int currentrole)
        {
            return Role.role <= currentrole;
        }
        public static RoleManagement.Roles Role
        {
            get
            {
                return RoleManagement.CurrentRole.instance.roles;
            }
        }

        public static int admin_id
        {
            get
            {
                return Role.admin_id;
            }
        }

        public static Model.fiscalyear currentFiscalYear
        {
            get
            {
                var db = Model.DatabaseConfigure.getConfigure();
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    return setting.fiscalyear;
                }
                else
                {
                    INFO.ShowAlert("", "Default Fiscal Year Not Set", 3000);
                    return null;


                }
            }
        }

        public static int currentdate
        {
            get
            {
                var db = Model.DatabaseConfigure.getConfigure();
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    return setting.currentdate;
                }
                else
                {

                    return 0;
                }
            }
        }

        public static void ShowAlert(string title, string msg, int duration)
        {
            CustomControls.Alert.show(title, msg, duration);
        }
    }
}
