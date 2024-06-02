using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_service.DBStorrage
{
    public static class DBStorrage
    {
        public static RepairServiceEntities DB_s { get; set; } = new RepairServiceEntities();
    }
}
