using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model
{
    class ChiNhanhBean
    {
        private string maChiNhanh;
        private string tenChiNhanh;

        public string TenChiNhanh { get => tenChiNhanh; set => tenChiNhanh = value; }
        public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }

        public ChiNhanhBean(string maChiNhanh, string tenChiNhanh)
        {
            TenChiNhanh = tenChiNhanh; MaChiNhanh = maChiNhanh;
        }
    }
}
