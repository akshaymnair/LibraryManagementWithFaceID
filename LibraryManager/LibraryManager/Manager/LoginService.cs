using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class LoginService
    {
        public int NewLogin(Login login)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                ctx.Logins.Add(login);
                rows = ctx.SaveChanges();
            }
            return rows;
        }

        public Login FindByUserName(String userName)
        {
            Login login = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var adminLogin = ctx.Logins.Where(l => l.UserName == userName);
                if (adminLogin != null)
                {
                    login = (Login)adminLogin.ToList().FirstOrDefault();
                }
            }
            return login;
        }
    }
}
