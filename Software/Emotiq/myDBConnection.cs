using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Emotiq
{
    class myDBConnection
    {
        public MySqlConnection cn;
        public void Connect()
        {
            string ConnString = "Server=studmysql01.fhict.local;Uid=dbi484020;Database=dbi484020;Pwd=Adm1n!Adm1n!;";
            cn = new MySqlConnection(ConnString);
        }
    }
}
