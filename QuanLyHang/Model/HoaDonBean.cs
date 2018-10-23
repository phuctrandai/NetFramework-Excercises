using System;
using System.Collections.Generic;

namespace QuanLyHang.Model
{
    class HoaDonBean
    {
        private int maHoaDon;
        private int maKhachHang;
        private DateTime ngayMua;
        private bool daThanhToan;
        private List<MatHangBean> danhSachMatHang;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
        public bool DaThanhToan { get => daThanhToan; set => daThanhToan = value; }
        internal List<MatHangBean> DanhSachMatHang { get => danhSachMatHang; set => danhSachMatHang = value; }

        public HoaDonBean()
        {
            this.maHoaDon = 0;
            this.maKhachHang = 0;
            this.ngayMua = DateTime.Now;
            this.daThanhToan = false;
            this.danhSachMatHang = new List<MatHangBean>();
        }

        public HoaDonBean(int maHoaDon, int maKhachHang, DateTime ngayMua, bool daThanhToan, List<MatHangBean> danhSachMatHang)
        {
            this.maHoaDon = maHoaDon;
            this.maKhachHang = maKhachHang;
            this.ngayMua = ngayMua;
            this.daThanhToan = daThanhToan;
            this.danhSachMatHang = danhSachMatHang;
        }
    }
}
