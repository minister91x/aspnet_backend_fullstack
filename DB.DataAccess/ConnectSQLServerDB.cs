using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.DataAccess
{
    public static class ConnectSQLServerDB
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = null;
            var connectionString = "Server=DESKTOP-IFRSV3F;Database=DemoDatabase;User Id=sa;Password=123456;";
            conn= new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
    }
}
