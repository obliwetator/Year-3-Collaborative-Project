using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Classes
{
    static class clsUser
    {
        private static string sUsername;
        private static string sPassword;
        private static string sUser_type;
        private static int ID;

        public static string SUsername { get => sUsername; set => sUsername = value; }
        public static string SPassowrd { get => sPassword; set => sPassword = value; }
        public static string SUser_type { get => sUser_type; set => sUser_type = value; }
        public static int ID1 { get => ID; set => ID = value; }
    }
}
