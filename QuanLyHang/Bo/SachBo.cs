using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System.Collections.Generic;

namespace QuanLyHang.Bo
{
    class SachBo
    {
        private static SachBo instance;
        public static SachBo getInstance()
        {
            if (instance == null) instance = new SachBo(); return instance;
        }

        public List<SachBean> GetSach()
        {
            return SachDao.getInstance().GetSach();
        }

        public List<SachBean> GetSachTheoLoai(string maLoai)
        {
            return SachDao.getInstance().GetSachByLoai(maLoai);
        }
    }
}
