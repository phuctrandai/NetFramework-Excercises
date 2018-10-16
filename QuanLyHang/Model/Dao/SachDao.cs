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
            sqlCommand.Connection = ConnectSqlServer.getInstance().SqlConnection;
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
            ConnectSqlServer.getInstance().Disconnect();
            return list;
        }
    }
}
