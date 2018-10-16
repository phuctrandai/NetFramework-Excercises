using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;
using System.Collections.Generic;

namespace QuanLyHang.Bo
{
    class NhanVienBo
    {
        private NhanVienDao nhanVienDao;
        private List<NhanVienBean> list;

        public NhanVienBo()
        {
            nhanVienDao = new NhanVienDao();
            list = new List<NhanVienBean>();
        }

        public List<NhanVienBean> LoadListNhanVien()
        {
            list = nhanVienDao.GetListNhanVien();
            return list;
        }

        public List<NhanVienBean> GetListNhanVien()
        {
            return list;
        }

        public bool InsertNhanVien(string hoTen, bool gioiTinh, DateTime ngaySinh, string diaChi, float heSoLuong)
        {
            bool result = false;

            try
            {
                int maNhanVien = 1;
                if(list.Count != 0)
                {
                    maNhanVien = list[list.Count - 1].MaNhanVien + 1;
                }
                list.Add(new NhanVienBean(maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, heSoLuong));
                result = nhanVienDao.InsertNhanVien(hoTen, gioiTinh, ngaySinh, diaChi, heSoLuong);
            } catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool UpdateNhanVien(string maNhanVien, string hoTen, bool gioiTinh, DateTime ngaySinh, string diaChi, float heSoLuong)
        {
            bool result = false;

            try
            {
                NhanVienBean nv = list.Find(x => x.MaNhanVien.Equals(maNhanVien));
                nv.HoVaTen = hoTen;
                nv.GioiTinh = gioiTinh;
                nv.NgaySinh = ngaySinh;
                nv.DiaChi = diaChi;
                nv.HeSoLuong = heSoLuong;
                result = nhanVienDao.UpdateNhanVien(maNhanVien, hoTen, gioiTinh, ngaySinh, diaChi, heSoLuong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool DeleteNhanVien(string maNhanVien)
        {
            bool result = false;

            try
            {
                int index = list.FindIndex(x => x.MaNhanVien.Equals(maNhanVien));
                list.RemoveAt(index);
                result = nhanVienDao.DeleteNhanVien(maNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<NhanVienBean> FindNhanVien(string keyWord)
        {
            return nhanVienDao.FindNhanVien(keyWord);
        }
    }
}
