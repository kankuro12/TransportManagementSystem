using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement
{
    public class CurrentRole
    {
        public static string[] rolename = { "SuperAdmin", "Manager", "SuperVisor", "Pos Handler" };
        public static CurrentRole instance;
        public  Roles roles { get; set; }

        public static void addRole(Roles c_role)
        {
            if (instance == null)
            {
                instance = new CurrentRole();
            }

            instance.roles = c_role; 
        }

        public void removeRole()
        {
            instance = null;
        }

        public static string checkRoll()
        {
            return rolename[instance.roles.role];
        }

        public static void RunDefault()
        {
            addRole(new Roles()
            {
                role = 0,
                rolename = "Superadmin",
                session_id = "afasdfdsa",
                username = "chhatraman",
                SessionStarted = DateTime.Now
            });
        }
    }
}
