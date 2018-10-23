using QuanLyHang.Bo;
using QuanLyHang.Model;
using QuanLyHang.Model.Dao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_BanHang : Form
    {
        public form_BanHang()
        {
            InitializeComponent();
            danhSachMatHang = new BindingSource();
        }

        private BindingSource danhSachMatHang;

        #region Event
        private void form_BanHang_Load(object sender, EventArgs e)
        {
            ShowLoaiSach();

            danhSachMatHang.DataSource = HoaDonBo.GetInstance().HoaDon.DanhSachMatHang;

            dgv_hoaDonThanhToan.DataSource = danhSachMatHang;
        }

        private void comboBox_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SachBean sachBean = (SachBean)comboBox_Sach.SelectedItem;
            ShowSach(sachBean);
        }

        private void listBox_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoai = listBox_LoaiSach.SelectedValue.ToString();
            ShowSachTheoLoai(maLoai);
        }

        private void numUpDwn_SoLuongMua_ValueChanged(object sender, EventArgs e)
        {
            decimal giaBan = decimal.Parse(textBox_Gia.Text, NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("vie-VN"));
            decimal soLuongMua = numUpDwn_SoLuongMua.Value;                            
            textBox_ThanhTien.Text = (soLuongMua * giaBan).ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vie-VN"));
        }

        private void button_BanHang_Click(object sender, EventArgs e)
        {
            BanHang();
        }

        private void button_InHoaDon_Click(object sender, EventArgs e)
        {
            danhSachMatHang.Clear();
            HoaDonBo.GetInstance().HoaDon.DanhSachMatHang.Clear();
        }

        private void dgv_hoaDonThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SachBean sach = new SachBean();
                sach.MaSach = (String)dgv_hoaDonThanhToan["MaSach", e.RowIndex].Value;
                sach.Gia = (int)dgv_hoaDonThanhToan["GiaBan", e.RowIndex].Value;
                sach.HinhAnh = (String)dgv_hoaDonThanhToan["AnhBia", e.RowIndex].Value;

                ShowSach(sach);
                numUpDwn_SoLuongMua.Value = decimal.Parse(dgv_hoaDonThanhToan["SoLuongMua", e.RowIndex].Value.ToString());
            }
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
                numUpDwn_SoLuongMua.Value = 1;
                textBox_ThanhTien.Text = "đ 0";
            }
            else
                comboBox_Sach.DataSource = sachList;

            comboBox_Sach.DisplayMember = "TenSach";
            comboBox_Sach.ValueMember = "MaSach";
        }

        private void ShowSach(SachBean sachBean)
        {
            if (sachBean != null)
            {
                textBox_MaSach.Text = sachBean.MaSach;
                textBox_SoLuong.Text = sachBean.SoLuong.ToString();
                textBox_Gia.Text = sachBean.Gia.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vie-VN"));
                textBox_ThanhTien.Text = sachBean.Gia.ToString("C0",System.Globalization.CultureInfo.GetCultureInfo("vie-VN"));

                string curr = Environment.CurrentDirectory;
                string imagePath = Path.Combine(curr.Substring(0, curr.Length - 9), @"Resources/", sachBean.HinhAnh);

                pictureBox_Anh.ImageLocation = imagePath;
            }
        }

        private void BanHang()
        {
            Dictionary<String, object> matHangInfo = new Dictionary<string, object>();
            matHangInfo.Add("maSach", textBox_MaSach.Text);
            matHangInfo.Add("tenSach", comboBox_Sach.Text);
            matHangInfo.Add("soLuongMua", numUpDwn_SoLuongMua.Value);
            matHangInfo.Add("giaBan", textBox_Gia.Text);
            matHangInfo.Add("anhBia", pictureBox_Anh.ImageLocation);

            try
            {
                HoaDonBo.GetInstance().ThemVaoHoaDon(matHangInfo);
                danhSachMatHang.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
