using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    class Functions
    {
        private static string serverName = @"(LocalDB)\MSSQLLocalDB";

        // Đối tượng kết nối
        public static SqlConnection Con;
        public static void Connect()
        {
            Con = new SqlConnection();

            // gán database
           
            Con.ConnectionString = "Data Source=DESKTOP-6H9DVEJ\\SQLEXPRESS;Initial Catalog=DB_DO_AN;Integrated Security=True";

            // Mở kết nối
            Con.Open();

            // Kiểm tra
            if (Con.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công !");
            }
            else
            {
                MessageBox.Show("Kết nối DB thất bại !");
            }
        }
        public static void Connect(string connectString)
        {
            Con = new SqlConnection();

            // gán database
            Con.ConnectionString = connectString;
            Con.ConnectionString = "Data Source=DESKTOP-6H9DVEJ\\SQLEXPRESS;Initial Catalog=DB_DO_AN;Integrated Security=True";

            // Mở kết nối
            Con.Open();

            // Kiểm tra
            if (Con.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công !");
            }
            else
            {
                MessageBox.Show("Kết nối DB thất bại !");
            }
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                // Đóng kết nối
                Con.Close();

                //Giải phóng bộ nhớ
                Con.Dispose();
                Con = null;
            }
        }

        public static string get_ConnectString(int userType)
        {
            string str = string.Empty;
            switch (userType)
            {
                case -1:
                    {
                        str = @"Data Source=" + serverName + ";Initial Catalog=DB_DO_AN;Persist Security Info=True;User ID=DB_DO_AN_NGUOILA;Password=12345";
                        break;
                    }
                case 0:
                    {
                        str = @"Data Source=" + serverName + ";Initial Catalog=DB_DO_AN;Persist Security Info=True;User ID=DB_DO_AN_ADMIN;Password=admin";
                        break;
                    }
                case 1:
                    {
                        str = @"Data Source=" + serverName + ";Initial Catalog=DB_DO_AN;Persist Security Info=True;User ID=DB_DO_AN_DOITAC;Password=123456";
                        break;
                    }
                case 2:
                    { 
                        str = @"Data Source=" + serverName + ";Initial Catalog=DBD_DO_AN;Persist Security Info=True;User ID=DB_DO_AN_KHACHHANG;Password=12345";
                        break;
                    }
                case 3:
                    {
                        str = @"Data Source=" + serverName + ";Initial Catalog=DB_DO_AN;Persist Security Info=True;User ID=DB_DO_AN_TAIXE;Password=12345";
                        break;
                    }
                case 4:
                    {
                        str = @"Data Source=" + serverName + ";Initial Catalog=DB_DO_AN;Persist Security Info=True;User ID=Db_Do_AN_NHANVIEN;Password=12345";
                        break;
                    }
            }
            return str;
        }

        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            dap.SelectCommand.Connection = Functions.Con;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql) // kiểm tra xem có trùng khóa hay không
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Functions.Con;
            command.CommandText = sql;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            command.Dispose();
            command = null;
        }

        public static string GetFieldValues(string sql)
        {
            string str = string.Empty;
            SqlCommand command = new SqlCommand(sql, Con);

            SqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                str = reader.GetValue(0).ToString();
            }

            reader.Close();
            return str;
        }
    }
}