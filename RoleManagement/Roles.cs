using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement
{
    public class Roles
    {
        public string username { get; set; }
        public string session_id { get; set; }
        public int role { get; set; }
        public string rolename { get; set; }
        public DateTime SessionStarted { get; set; }
        public int admin_id { get; set; }

    }
}
