﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBanque.DAL
{
    class Fabrique
    {
        private static string providerMysql = "localhost";

        private static string dataBaseMysql = "bd_zicmu";

        private static string uidMysql = "root";

        private static string mdpMysql = "";
       

        public static string ProviderMysql { get => providerMysql; }
        public static string DataBaseMysql { get => dataBaseMysql; }
        public static string UidMysql { get => uidMysql; }
        public static string MdpMysql { get => mdpMysql; }
  
    }
}
