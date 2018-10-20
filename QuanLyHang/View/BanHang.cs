using QuanLyHang.Bo;
using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_BanHang : Form
    {
        public form_BanHang()
        {
            InitializeComponent();
        }

        #region Event
        private void form_BanHang_Load(object sender, EventArgs e)
        {
            ShowLoaiSach();
        }

        private void comboBox_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SachBean sachBean = (SachBean)comboBox_Sach.SelectedItem;
            if (sachBean != null)
            {
                textBox_MaSach.Text = sachBean.MaSach;
                textBox_SoLuong.Text = sachBean.SoLuong.ToString();
                textBox_Gia.Text = sachBean.Gia.ToString();
            }
        }

        private void listBox_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoai = listBox_LoaiSach.SelectedValue.ToString();
            ShowSachTheoLoai(maLoai);
        }
        #endregion

        #region Function
        private void ShowLoaiSach()
        {
            List<LoaiBean> loaiList = LoaiDao.GetInstance().GetListLoai();
            listBox_LoaiSach.DataSource = loaiList;
            listBox_LoaiSach.DisplayMember = "TenLoai";
            listBox_LoaiSach.ValueMember = "MaLoai";

            ShowSachTheoLoai(loaiList[0].MaLoai);
        }

        private void ShowSachTheoLoai(string maLoai)
        {
            List<SachBean> sachList = SachBo.getInstance().GetSachTheoLoai(maLoai);
            if (sachList.Count == 0)
            {
                comboBox_Sach.DataSource = null;
                comboBox_Sach.Items.Clear();
                comboBox_Sach.SelectedText = "";

                textBox_MaSach.Text = "";
                textBox_SoLuong.Text = "";
                textBox_Gia.Text = "";
            }
            else
                comboBox_Sach.DataSource = sachList;

            comboBox_Sach.DisplayMember = "TenSach";
            comboBox_Sach.ValueMember = "MaSach";
        }

        #endregion

    }
}
