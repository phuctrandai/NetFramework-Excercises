using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model
{
    class MatHangBean
    {
        private string maSach;
        private string tenSach;
        private int giaBan;
        private int soLuongMua;
        private string anhBia;

        public string MaSach { get => maSach; set => maSach = value; }
        public int SoLuongMua { get => soLuongMua; set => soLuongMua = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string AnhBia { get => anhBia; set => anhBia = value; }

        public MatHangBean(string maSach, string tenSach, int giaBan, int soLuongMua, string anhBia)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaBan = giaBan;
            this.soLuongMua = soLuongMua;
            this.anhBia = anhBia;
        }
    }
}
