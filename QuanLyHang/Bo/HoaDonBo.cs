using QuanLyHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Bo
{
    class HoaDonBo
    {
        private static HoaDonBo instance;

        public static HoaDonBo GetInstance()
        {
            if (instance == null) instance = new HoaDonBo(); return instance;
        }

        private HoaDonBean hoaDon;

        public HoaDonBean HoaDon { get => hoaDon; set => hoaDon = value; }

        private HoaDonBo() { hoaDon = new HoaDonBean(); }

        public void ThemVaoHoaDon(Dictionary<String, object> matHangInfo)
        {
            string maSach = matHangInfo["maSach"].ToString();
            string tenSach = matHangInfo["tenSach"].ToString();
            int giaBan = int.Parse(matHangInfo["giaBan"].ToString(), System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("vie-VN"));
            
            if(!int.TryParse(matHangInfo["soLuongMua"].ToString(), out int soLuongMua))
            {
                throw new Exception("Số lượng mua không đúng!");
            }
            string anhBia = matHangInfo["anhBia"].ToString();

            var exist = hoaDon.DanhSachMatHang.FirstOrDefault(mh => mh.MaSach == maSach);
            if (exist == null) {
                MatHangBean matHang = new MatHangBean(maSach, tenSach, giaBan, soLuongMua, anhBia);
                hoaDon.DanhSachMatHang.Add(matHang);
            }
            else
            {
                exist.SoLuongMua += soLuongMua;
            }
        }

        public long TongSoTien()
        {
            return 0;
        }
    }
}
