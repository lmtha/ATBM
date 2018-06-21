using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
namespace QuanLyBenhVien
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "10.211.55.4";
            int port = 1521;
            string sid = "orcl3";
            string user = "X";
            string password = "1";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
