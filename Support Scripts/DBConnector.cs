using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleProgram.Universal
{
    class DBConnector
    {
        public static string Server = "localhost";
        public static string Database = "client_schedule";
        public static string Uid = "root";
        public static string Password = "root";

        public static string ConnectionString => $"SERVER={Server}; DATABASE={Database}; Uid ={Uid}; Pwd={Password}; SslMode=None; Convert Zero Datetime = true";
    }
}
