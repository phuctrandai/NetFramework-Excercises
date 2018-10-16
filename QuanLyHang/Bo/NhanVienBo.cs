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
        }

        public List<NhanVienBean> List { get { if(list == null) list = nhanVienDao.GetListNhanVien(); return list; } }

        public List<NhanVienBean> GetListNhanVien()
        {
            try
            {
                list = nhanVienDao.GetListNhanVien();
            } catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public bool InsertNhanVien(Dictionary<String, Object> nhanVienInfo)
        {
            string hoTen = nhanVienInfo["hoTen"].ToString();

            bool gioiTinh;
            if (nhanVienInfo["gioiTinh"].Equals("Nam")) gioiTinh = true;
            else gioiTinh = false;

            DateTime ngaySinh = DateTime.Parse(nhanVienInfo["ngaySinh"].ToString());
            string diaChi = nhanVienInfo["diaChi"].ToString();

            double heSoLuong;
            if (!double.TryParse(nhanVienInfo["heSoLuong"].ToString(), out heSoLuong))
            {
                throw (new Exception("He so luong khong dung!"));
            }

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

        public bool UpdateNhanVien(Dictionary<String, Object> nhanVienInfo)
        {
            int maNhanVien = Int32.Parse(nhanVienInfo["maNhanVien"].ToString());
            string hoTen = nhanVienInfo["hoTen"].ToString();

            bool gioiTinh;
            if (nhanVienInfo["gioiTinh"].Equals("Nam")) gioiTinh = true;
            else gioiTinh = false;

            DateTime ngaySinh = DateTime.Parse(nhanVienInfo["ngaySinh"].ToString());
            string diaChi = nhanVienInfo["diaChi"].ToString();

            double heSoLuong;
            if (!double.TryParse(nhanVienInfo["heSoLuong"].ToString(), out heSoLuong))
            {
                throw (new Exception("He so luong khong dung!"));
            }

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

        public bool DeleteNhanVien(object maNhanVien)
        {
            bool result = false;

            try
            {
                int index = list.FindIndex(x => x.MaNhanVien.Equals(int.Parse(maNhanVien.ToString())));
                list.RemoveAt(index);
                result = nhanVienDao.DeleteNhanVien(Int32.Parse(maNhanVien.ToString()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<NhanVienBean> FindNhanVien(string keyWord)
        {
            List<NhanVienBean> result = new List<NhanVienBean>();

            foreach(NhanVienBean nv in list)
            {
                if (nv.HoVaTen.ToLower().Trim().Contains(keyWord.ToLower().Trim()))
                    result.Add(nv);
            }

            return result;
        }
    }
}
