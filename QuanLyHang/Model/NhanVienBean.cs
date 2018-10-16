using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model
{
    public class NhanVienBean
    {
        private int maNhanVien;
        private string hoVaTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private float heSoLuong;

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public NhanVienBean(int maNhanVien, string hoVaTen, DateTime ngaySinh, bool gioiTinh, string diaChi, float heSoLuong)
        {
            this.maNhanVien = maNhanVien;
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.heSoLuong = heSoLuong;
        }
    }
}
