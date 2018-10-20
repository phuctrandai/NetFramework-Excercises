using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    class KhachHangDao
    {
        public KhachHangBean GetKhachHang(string tenDangNhap, string matKhau)
        {
            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @tenDangNhap AND MatKhau = @matKhau";
            sqlCommand.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
            sqlCommand.Parameters.AddWithValue("@matKhau", matKhau);
            sqlCommand.Connection = sqlConnection;

            SqlDataReader sqlData = sqlCommand.ExecuteReader();

            if (sqlData.Read())
            {
                KhachHangBean khachHang = new KhachHangBean(int.Parse(sqlData["MaKhachHang"].ToString()), sqlData["TenDangNhap"].ToString(), sqlData["VaiTro"].ToString());
                sqlData.Close();
                return khachHang;
            }
            else
                return null;
        }
    }
}
