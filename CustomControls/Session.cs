using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls
{
    public static class Session
    {
        public static User CurrentUser;

        public static void setUser(int ID,string USERNAME,List<int> ROLES)
        {
            CurrentUser = new User()
            {
                id = ID,
                roles = ROLES,
                Username = USERNAME
            };
        }
    }
}
