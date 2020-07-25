using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace TransportManagementSystem.Model
{
   public partial class TransportManagementEntities:DbContext
    {
        public TransportManagementEntities(string ConnectionString) : base(ConnectionString)
        {

        }
    }
}
