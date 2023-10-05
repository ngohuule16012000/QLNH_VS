using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    // kết nối đến database và trả về data
    public class DataProvider
    {
        // singleton, chỉ truy cập đến DataProvider thông qua instance
        private static DataProvider instance; // đóng gói Ctrl + R + E

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            set => instance = value;    
        }

        private DataProvider() { }

        //Tools -> Connect to Database ->
        //DataSource là Microsoft SQL Server(SqlClient)
        //Server name là .\sqlexpress
        //Chọn tên Database strong select or enter a datasbase name
        //-> Advance -> copy code và gán vào biến connectionStr
        private string connectionStr = "Data Source=YURI-SOKOLA;Initial Catalog=QLNH;Integrated Security=True";

        // Trả về DataTable sau khi truy vấn query
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // Tạo data table
            DataTable data = new DataTable();

            // tạo kết nối đến database, connect tự giải phóng sau khi đóng kết nối
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // mở kết nối
                connection.Open();

                // thực thi query để truy vấn trong sql từ kết nối connection
                SqlCommand command = new SqlCommand(query, connection);

                // đưa thêm parameter nếu có vào command
                if(parameter != null)
                {
                    object[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // Lấy dữ liệu từ command vào adapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // đổ dữ liệu vào data
                adapter.Fill(data);

                // đóng connection
                connection.Close();
            }

            return data;
        }
        
        // trả về số dòng thành công, sử dụng cho insert, update, delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    object[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        
        // trả về ô đầu của dòng đẩu trong bảng kết quả nếu dùng count
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    object[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
