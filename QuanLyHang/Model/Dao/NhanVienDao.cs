using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    public class NhanVienDao
{
        private List<NhanVienBean> list;

        public NhanVienDao()
        {
            list = new List<NhanVienBean>();
        }

        public List<NhanVienBean> GetListNhanVien()
        {
            SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NhanVien";
            SqlDataReader data = sqlCommand.ExecuteReader();

            while (data.Read())
            {
                NhanVienBean n = new NhanVienBean(int.Parse(data[0].ToString()), data[1].ToString(), data.GetDateTime(2), Boolean.Parse(data[3].ToString()), data[4].ToString(), float.Parse(data[5].ToString()));
                list.Add(n);
            }
            data.Close();
            return list;
        }

        public bool InsertNhanVien(string hoTen, bool gioiTinh, DateTime ngaySinh, string diaChi, float heSoLuong)
        {
            SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "INSERT INTO NhanVien VALUES(@hoVaTen, @ngaySinh, @gioiTinh, @diaChi, @heSoLuong)";
            sqlCommand.Parameters.AddWithValue("@hoVaTen", hoTen);
            sqlCommand.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            sqlCommand.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            sqlCommand.Parameters.AddWithValue("@diaChi", diaChi);
            sqlCommand.Parameters.AddWithValue("@heSoLuong", heSoLuong);

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

        public bool UpdateNhanVien(string maNhanVien, string hoTen, bool gioiTinh, DateTime ngaySinh, string diaChi, float heSoLuong)
        {
            SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "UPDATE NhanVien SET HoVaTen = @hoVaTen, NgaySinh = @ngaySinh, GioiTinh = @gioiTinh, DiaChi =  @diaChi, HeSoLuong = @heSoLuong WHERE MaNhanVien = @maNhanVien";
            sqlCommand.Parameters.AddWithValue("@hoVaTen", hoTen);
            sqlCommand.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            sqlCommand.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            sqlCommand.Parameters.AddWithValue("@diaChi", diaChi);
            sqlCommand.Parameters.AddWithValue("@heSoLuong", heSoLuong);
            sqlCommand.Parameters.AddWithValue("@maNhanVien", maNhanVien);

            int rowEffect = 0;
            try
            {
                rowEffect = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rowEffect > 0;
        }

        public bool DeleteNhanVien(string maNhanVien)
        {
            SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "DELETE FROM NhanVien WHERE MaNhanVien = @maNhanVien";
           
            sqlCommand.Parameters.AddWithValue("@maNhanVien", maNhanVien);

            int rowEffect = 0;
            try
            {
                rowEffect = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rowEffect > 0;
        }

        public List<NhanVienBean> FindNhanVien(string keyWord)
        {
            SqlConnection sqlConnection = ConnectSqlServer.getInstance().SqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NhanVien HoVaTen LIKE @hoTen";
            sqlCommand.Parameters.AddWithValue("@hoTen", keyWord);
            SqlDataReader data = sqlCommand.ExecuteReader();
            List<NhanVienBean> list = new List<NhanVienBean>();
            while (data.Read())
            {
                NhanVienBean n = new NhanVienBean(int.Parse(data[0].ToString()), data[1].ToString(), DateTime.Parse(data[2].ToString()), Boolean.Parse(data[3].ToString()), data[4].ToString(), float.Parse(data[5].ToString()));
                list.Add(n);
            }
            data.Close();
            return list;
        }
    }
}
