using System.Collections.Generic;
using System.Data.SqlClient;
using QuanLyHang.Model;

namespace QuanLyHang.Model.Dao
{
    class SachDao
    {
        private static SachDao instance;
        public static SachDao getInstance()
        {
            if (instance == null) instance = new SachDao(); return instance;
        }

        public List<SachBean> GetSach()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [QLSach].[dbo].[sach]";
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = ConnectSqlServer.GetInstance().SqlConnection;
            SqlDataReader sqlData;

            try
            {
                sqlData = sqlCommand.ExecuteReader();
            } catch (SqlException e)
            {
                throw e;
            }
            List<SachBean> list = new List<SachBean>();
            while (sqlData.Read())
            {
                SachBean sach = new SachBean(sqlData["masach"].ToString(), sqlData["tensach"].ToString(), (long)sqlData["soluong"], (long)sqlData["gia"], sqlData["maloai"].ToString(), sqlData["sotap"].ToString(), sqlData["anh"].ToString(), sqlData["NgayNhap"].ToString(), sqlData["tacgia"].ToString());
                list.Add(sach);
            }
            sqlData.Close();
            //ConnectSqlServer.getInstance().Disconnect();
            return list;
        }

        public List<SachBean> GetSachByLoai(string maLoai)
        {
            List<SachBean> result = new List<SachBean>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [QLSach].[dbo].[sach] WHERE MaLoai = @maLoai";
            sqlCommand.Parameters.AddWithValue("@maLoai", maLoai);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = ConnectSqlServer.GetInstance().SqlConnection;
            SqlDataReader sqlData;

            try
            {
                sqlData = sqlCommand.ExecuteReader();
            }
            catch (SqlException e)
            {
                throw e;
            }

            while (sqlData.Read())
            {
                SachBean sach = new SachBean(sqlData["MaSach"].ToString(), sqlData["TenSach"].ToString(), (long)sqlData["SoLuong"], (long)sqlData["Gia"], sqlData["MaLoai"].ToString(), sqlData["SoTap"].ToString(), sqlData["Anh"].ToString(), sqlData["NgayNhap"].ToString(), sqlData["TacGia"].ToString());
                result.Add(sach);
            }
            sqlData.Close();
            //ConnectSqlServer.getInstance().Disconnect();

            return result;
        }
    }
}
