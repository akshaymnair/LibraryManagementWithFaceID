using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class LogRegisterService
    {
        public int NewLog(LogRegister log)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                ctx.LogRegisters.Add(log);
                rows = ctx.SaveChanges();
            }
            return rows;
        }
    }
}
