using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyHang.Model;

namespace QuanLyHang.Bo
{
    class ChiNhanhBo
    {
        private static ChiNhanhBo instance;

        public static ChiNhanhBo getInstance() { if (instance == null) instance = new ChiNhanhBo(); return instance; }

        private List<ChiNhanhBean> list;

        private ChiNhanhBo() => list = new List<ChiNhanhBean>();

        public List<ChiNhanhBean> TaoDanhSach()
        {
            ChiNhanhBean c = new ChiNhanhBean("CN1", "Chi nhánh 1");
            list.Add(c);

            c = new ChiNhanhBean("CN2", "Chi nhánh 2");
            list.Add(c);

            c = new ChiNhanhBean("CN3", "Chi nhánh 3");
            list.Add(c);

            return list;
        }
    }
}
