using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model
{
    class HangBean
    {
        string maHang;
        string tenHang;
        int giaBan;
        int soLuongHienCo;
        string maChiNhanh;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuongHienCo { get => soLuongHienCo; set => soLuongHienCo = value; }
        public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }

        public HangBean(string maHang, string tenHang, int giaBan, int soLuongHienCo, string maChiNhanh)
        {
            MaHang = maHang; TenHang = tenHang; GiaBan = giaBan; SoLuongHienCo = soLuongHienCo; MaChiNhanh = maChiNhanh;
        }
    }
}
