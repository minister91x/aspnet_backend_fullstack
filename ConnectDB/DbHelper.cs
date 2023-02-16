using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class DbHelper
    {
        public List<DanhMuc> GetAll_DanhMuc()
        {
            var list = new List<DanhMuc>();
            try
            {
                // Bước 1: Lấy connectionstring vừa viết ở bên class ConnectSQLServerDB
               var getconnectionString = ConnectSQLServerDB.GetSqlConnection();
             
                //Bước 2: khởi tạo class Sqlcommand 
                SqlCommand cmd = new SqlCommand("TêN_STORE_PROCEDURE", getconnectionString);
                //Bước 3: chỉ cho command biết là đang dùng store hay text
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ///Bước 4: tạo sqlReader để đọc dữ liêu
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Đưa data vào list DanhMuc
                    DanhMuc dm = new DanhMuc();
                    dm.Name = reader["Name"].ToString();
                    list.Add(dm);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return list;
        }


        public List<DanhMuc> GetAll_DanhMuc()
        {
            var list = new List<DanhMuc>();
            try
            {
                // Bước 1: Lấy connectionstring vừa viết ở bên class ConnectSQLServerDB
                var getconnectionString = ConnectSQLServerDB.GetSqlConnection();

                //Bước 2: khởi tạo class Sqlcommand 
                SqlCommand cmd = new SqlCommand("TêN_STORE_PROCEDURE", getconnectionString);
                //Bước 3: chỉ cho command biết là đang dùng store hay text
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ///Bước 4: tạo sqlReader để đọc dữ liêu
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Đưa data vào list DanhMuc
                    DanhMuc dm = new DanhMuc();
                    dm.Name = reader["Name"].ToString();
                    list.Add(dm);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return list;
        }
    }
}
