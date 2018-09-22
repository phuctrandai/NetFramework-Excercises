using System.Collections.Generic;
using QuanLyHang.Model;

namespace QuanLyHang.Bo
{
    public class HangBo
    {
        private static HangBo instance;

        public static HangBo getInstance()
        {
            if (instance == null) instance = new HangBo();
            return instance;
        }

        private List<HangBean> list;

        private HangBo() => list = new List<HangBean>();

        public List<HangBean> TaoDanhSach()
        {
            HangBean h = new HangBean("MH1", "Mặt hàng 1", 30000, 200, "CN1");
            list.Add(h);

            h = new HangBean("MH2", "Mặt hàng 2", 35000, 100, "CN2");
            list.Add(h);

            h = new HangBean("MH3", "Mặt hàng 3", 35000, 100, "CN3");
            list.Add(h);

            h = new HangBean("MH4", "Mặt hàng 4", 35000, 100, "CN1");
            list.Add(h);

            h = new HangBean("MH5", "Mặt hàng 5", 35000, 100, "CN2");
            list.Add(h);

            h = new HangBean("MH6", "Mặt hàng 6", 35000, 100, "CN3");
            list.Add(h);

            h = new HangBean("MH7", "Mặt hàng 7", 35000, 100, "CN1");
            list.Add(h);

            h = new HangBean("MH8", "Mặt hàng 8", 35000, 100, "CN3");
            list.Add(h);

            return list;
        }

        public List<HangBean> TimTheoMaChiNhanh(string key)
        {
            List<HangBean> result = new List<HangBean>();
            foreach(HangBean item in list)
            {
                if (item.MaChiNhanh.ToLower().Trim().Equals(key.ToLower().Trim()))
                    result.Add(item);
            }
            return result;
        }

        public int LayChiSo(string maHang)
        {
            return list.FindIndex((h) => { return h.MaHang.ToLower().Trim().Equals(maHang.ToLower().Trim()); });
        }

        public bool Them(string maHang, string tenHang, int giaBan, int soLuong, string maChiNhanh)
        {
            if(LayChiSo(maHang) < 0)
            {
                list.Add(new HangBean(maHang, tenHang, giaBan, soLuong, maChiNhanh));
                return true;
            }
            return false;
        }

        public bool Xoa(string maHang)
        {
            int index = LayChiSo(maHang);
            if(index >= 0)
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool Sua(string maHang, string newTenHang = "", int newGiaBan = 0, int newSoLuong = 0)
        {
            int index = LayChiSo(maHang);
            if (index >= 0)
            {
                if (newTenHang != null)
                {
                    list[index].TenHang = newTenHang;
                }
                if(newGiaBan > 0)
                {
                    list[index].GiaBan = newGiaBan;
                }
                if(newSoLuong > 0)
                {
                    list[index].SoLuongHienCo = newSoLuong;
                }
                return true;
            }
            return false;
        }
    }
}
