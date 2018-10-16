using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;
using System.Collections.Generic;

namespace QuanLyHang.Bo
{
    class LoaiBo
    {
        private LoaiDao loaiDao;
        private List<LoaiBean> listLoai;

        public LoaiBo()
        {
            loaiDao = new LoaiDao();
            listLoai = loaiDao.GetListLoai();
        }

        public List<LoaiBean> GetListLoai()
        {
            return listLoai;
        }

        public bool AddLoai(string maLoai, string tenLoai)
        {
            LoaiBean loaiBean = new LoaiBean(maLoai, tenLoai);
            listLoai.Add(loaiBean);
            bool result = false;
            try
            {
                result = loaiDao.AddLoai(maLoai, tenLoai);
            } catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool DeleteLoai(string maLoai)
        {
            listLoai.Remove(listLoai.Find(x => x.MaLoai.Equals(maLoai)));
            bool result = false;
            try
            {
                result = loaiDao.DeleteLoai(maLoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool UpdateLoai(string maLoai, string newTenLoai)
        {
            int index = listLoai.FindIndex(x => x.MaLoai.Equals(maLoai));
            listLoai[index].TenLoai = newTenLoai;
            bool result = false;
            try
            {
                result = loaiDao.UpdateLoai(maLoai, newTenLoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<LoaiBean> FindLoai(string key)
        {
            List<LoaiBean> result = new List<LoaiBean>();
            foreach(LoaiBean l in listLoai)
            {
                if(l.MaLoai.ToLower().Contains(key.ToLower()) || l.TenLoai.ToLower().Contains(key.ToLower()))
                {
                    result.Add(l);
                }
            }
            return result;
        }
    }
}
