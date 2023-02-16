using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public static class ConnectSQLServerDB
    {
        public static SqlConnection GetSqlConnection()
        {
           SqlConnection connection = null;
            string connectionString_TEXT = "Server=DESKTOP-IFRSV3F;Database=DemoDatabase;User Id=sa;Password=123456;";
            
            connection = new SqlConnection(connectionString_TEXT);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
