using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem
{
    public class DB
    {
        public static Model.TransportManagementEntities Instance;

        public DB()
        {
            Instance = Model.DatabaseConfigure.getConfigure();
        }

        public static void init()
        {
            new DB();
        }
    }
}
