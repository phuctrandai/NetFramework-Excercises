using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;
using System.Collections.Generic;

namespace QuanLyHang.Bo
{
    class LoaiBo
    {
        private List<LoaiBean> listLoai;

        public LoaiBo()
        {
            listLoai = LoaiDao.GetInstance().GetListLoai();
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
                result = LoaiDao.GetInstance().AddLoai(maLoai, tenLoai);
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
                result = LoaiDao.GetInstance().DeleteLoai(maLoai);
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
                result = LoaiDao.GetInstance().UpdateLoai(maLoai, newTenLoai);
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
