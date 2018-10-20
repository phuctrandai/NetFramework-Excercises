using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;

namespace QuanLyHang.Bo
{
    class TaiKhoanBo
    {
        public TaiKhoanBean GetTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            TaiKhoanBean taiKhoan = null;
            try
            {
                taiKhoan = TaiKhoanDao.GetInstance().GetTaiKhoan(tenTaiKhoan, matKhau);
            } catch (Exception ex)
            {
                throw ex;
            }
            return taiKhoan;
        }
    }
}
