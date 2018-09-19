using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyHang.Model;

namespace QuanLyHang.Bo
{
    class HangBo
    {
        private List<HangBean> list;
        
        public HangBo()
        {
            list = new List<HangBean>();
        }

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
    }
}
