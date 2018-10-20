using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    class TaiKhoanDao
    {
        private TaiKhoanDao() { }

        private static TaiKhoanDao instance;

        public static TaiKhoanDao GetInstance()
        {
            if (instance == null) instance = new TaiKhoanDao(); return instance;
        }

        public TaiKhoanBean GetTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;

            string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @tenTaiKhoan AND MatKhau = @matKhau";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
            sqlCommand.Parameters.AddWithValue("@matKhau", matKhau);

            TaiKhoanBean taiKhoanBean = null;
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    taiKhoanBean = new TaiKhoanBean(tenTaiKhoan, matKhau, dataReader["VaiTro"].ToString());
                }
                dataReader.Close();
            } catch (SqlException ex)
            {
                throw ex;
            }
            return taiKhoanBean;
        }
    }
}
