using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.DataAccess
{
    public static class SqlDbHelper
    {
        public static List<Student> GetStudents()
        {
            var list = new List<Student>();
            try
            {
                //Bước 1: Mở connectionString đến SqlServer
                var connection = ConnectSQLServerDB.GetSqlConnection();
                //Bước 2: Dùng SqlCommand để gọi storeprocedure hoặc command text
                var command = new SqlCommand("SP_Student_GetList", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_StudentId", 2);

                //var command = new SqlCommand("Select * from Student", connection);
                //command.CommandType = System.Data.CommandType.Text;

                //Bước 3: Sẽ dùng SqlReader để thực hiện lấy dữ liệu trong database 
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"].ToString()) : 0,
                        StudentName = reader["StudentName"] != DBNull.Value ? reader["StudentName"].ToString() : string.Empty,
                        StudentCode = reader["StudentCode"] != DBNull.Value ? reader["StudentCode"].ToString() : string.Empty
                    });
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
