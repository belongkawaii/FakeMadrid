using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeMadrid.Controllers
{
    public static class SessionManager
    {
        public static string LoggedUser { get; set; } = "";
        public static int LoggedLevel { get; set; } = -1; // -1 = chưa đăng nhập

        public static bool IsLoggedIn => !string.IsNullOrEmpty(LoggedUser);

        public static void Logout()
        {
            LoggedUser = "";
            LoggedLevel = -1;
        }
    }

}
