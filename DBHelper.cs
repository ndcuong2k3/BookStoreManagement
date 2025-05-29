using System.Data;
using System.Data.SqlClient;

namespace BookStoreManagement
{
    public class DBHelper
    {
        private readonly string connectionString = "Server=CUONG\\MSSQLSERVER01;Database=BTH3;User Id=sa;Password=cuong;TrustServerCertificate=True;";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Thực thi câu lệnh SELECT trả về DataTable
        public DataTable ExecuteQuery(string sql, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }

            return dt;
        }

        // Thực thi câu lệnh INSERT/UPDATE/DELETE trả về số bản ghi ảnh hưởng
        public int ExecuteNonQuery(string sql, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi câu lệnh: " + ex.Message);
            }
        }

        // Thực thi câu lệnh trả về một giá trị duy nhất
        public object ExecuteScalar(string sql, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi câu lệnh lấy giá trị: " + ex.Message);
            }
        }
    }
}
