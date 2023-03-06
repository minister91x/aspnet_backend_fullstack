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

        public static List<ClassStudent> ClassStudentGetAll()
        {
            var lst = new List<ClassStudent>();
            try
            {
                // Bước 1: gọi connectionString
                var connnectstr = ConnectSQLServerDB.GetSqlConnection();
                //Bước 2: dùng SQLCOMMAND để gọi storeprocedure 
                var cmd = new SqlCommand("SP_StudentClassGetAll", connnectstr);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //bước 3: dùng SQLReader để đọc dữ liệu từ database trả về
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new ClassStudent
                    {
                        ClassId = reader["ClassId"] != null ? Convert.ToInt32(reader["ClassId"].ToString()):0
                        ,
                        ClassName = reader["ClassName"] != null ? reader["ClassName"].ToString():""
                    });
                }

                return lst;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<Student> GetStudentByClassId(int ClassID)
        {
            var lst = new List<Student>();
            try
            {
                // Bước 1: gọi connectionString
                var connnectstr = ConnectSQLServerDB.GetSqlConnection();
                //Bước 2: dùng SQLCOMMAND để gọi storeprocedure 
                var cmd = new SqlCommand("SP_Student_GetByClassID", connnectstr);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               
                
                cmd.Parameters.Add(new SqlParameter("@_ClassID", ClassID));


                //bước 3: dùng SQLReader để đọc dữ liệu từ database trả về
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Student
                    {
                        id = reader["id"] != null ? Convert.ToInt32(reader["id"].ToString()) : 0
                        ,
                        StudentName = reader["StudentName"] != null ? reader["StudentName"].ToString() : ""
                         ,
                        StudentCode = reader["StudentCode"] != null ? reader["StudentCode"].ToString() : ""
                         ,
                        StudentAddress = reader["StudentAddress"] != null ? reader["StudentAddress"].ToString() : ""
                        ,
                        StudentClassID = reader["StudentClassID"] != null ? Convert.ToInt32(reader["StudentClassID"].ToString()) : 0
                    });
                }

                return lst;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
