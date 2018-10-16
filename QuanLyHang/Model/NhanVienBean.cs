using System;
using System.Data.SqlTypes;

namespace QuanLyHang.Model
{
    public class NhanVienBean
    {
        private Int32 maNhanVien;
        private String hoVaTen;
        private DateTime ngaySinh;
        private Boolean gioiTinh;
        private String diaChi;
        private Double heSoLuong;
            
        public NhanVienBean(int maNhanVien, string hoVaTen, DateTime ngaySinh, bool gioiTinh, string diaChi, double heSoLuong)
        {
            this.MaNhanVien = maNhanVien;
            this.HoVaTen = hoVaTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.HeSoLuong = heSoLuong;
        }

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
    }
}
