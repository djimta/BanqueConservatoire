using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBanque.DAL
{
    class Fabrique
    {
        private static string providerMysql = "localhost";

        private static string dataBaseMysql = "db_zicmu";

        private static string uidMysql = "IntraAdmin";

        private static string mdpMysql = "6syf4R_4";

        public static string ProviderMysql { get => providerMysql; }
        public static string DataBaseMysql { get => dataBaseMysql; }
        public static string UidMysql { get => uidMysql; }
        public static string MdpMysql { get => mdpMysql; }
    }
}
