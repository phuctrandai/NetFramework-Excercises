using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    public class LoaiDao
    {
        private LoaiDao() { }

        private static LoaiDao instance;

        public static LoaiDao GetInstance()
        {
            if (instance == null) instance = new LoaiDao(); return instance;
        }

        public List<LoaiBean> GetListLoai()
        {
            List<LoaiBean> list = new List<LoaiBean>();

            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM loai", sqlConnection);
            
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while(dataReader.Read())
            {
                string maLoai = dataReader["maloai"].ToString();
                string tenLoai = dataReader["tenloai"].ToString();
                LoaiBean loai = new LoaiBean(maLoai, tenLoai);
                list.Add(loai);
            }
            dataReader.Close();
            return list;
        }

        public bool AddLoai(string maLoai, string tenLoai)
        {
            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO loai VALUES(@maLoai, @tenLoai)";
            sqlCommand.Parameters.AddWithValue("@maLoai", maLoai);
            sqlCommand.Parameters.AddWithValue("@tenLoai", tenLoai);
            sqlCommand.Connection = sqlConnection;

            int rowEffect = 0;
            try
            {
                rowEffect = sqlCommand.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Load loai sach");
            return (rowEffect > 0);
        }

        public bool DeleteLoai(string maLoai)
        {
            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM loai WHERE maloai = @maLoai";
            sqlCommand.Parameters.AddWithValue("@maLoai", maLoai);
            sqlCommand.Connection = sqlConnection;

            int rowEffect = 0;
            try
            {
                rowEffect = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (rowEffect > 0);

        }

        public bool UpdateLoai(string maLoai, string newTenLoai)
        {
            SqlConnection sqlConnection = ConnectSqlServer.GetInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE loai SET tenloai = @newTenLoai WHERE maloai = @maLoai";
            sqlCommand.Parameters.AddWithValue("@maLoai", maLoai);
            sqlCommand.Parameters.AddWithValue("@newTenLoai", newTenLoai);
            sqlCommand.Connection = sqlConnection;

            int rowEffect = 0;
            try
            {
                rowEffect = sqlCommand.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw ex;
            }
            return rowEffect > 0;

        }

        //public List<LoaiBean> FindLoai(string keyWord)
        //{
        //    SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandText = "SELECT * FROM loai WHERE maloai like @keyWord OR tenloai like";
        //    sqlCommand.Parameters.AddWithValue("@maLoai", keyWord);
        //    sqlCommand.Connection = sqlConnection;
        //}
    }
}
