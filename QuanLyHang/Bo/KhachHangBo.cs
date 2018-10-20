using QuanLyHang.Model;
using QuanLyHang.Model.Dao;

namespace QuanLyHang.Bo
{
    class KhachHangBo
    {
        private KhachHangDao khachHangDao;

        public KhachHangBo() => khachHangDao = new KhachHangDao();

        public KhachHangBean GetKhachHang(string tenDangNhap, string matKhau)
        {
            return khachHangDao.GetKhachHang(tenDangNhap, matKhau);
        }
    }
}
