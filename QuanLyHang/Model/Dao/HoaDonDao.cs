using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model.Dao
{
    class HoaDonDao
    {
        private static HoaDonDao instance;

        private static HoaDonDao GetInstance()
        {
            if (instance == null) instance = new HoaDonDao(); return instance;
        }

        public bool themVaoHoaDon(string maSach, int soLuongMua, DateTime ngayMua)
        {

            return false;
        }
    }
}
