using QuanLyHang.Bo;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace QuanLyHang.View
{
    public partial class form_QuanLyNhanVien : Form
    {
        private NhanVienBo nhanVienBo;

        public form_QuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienBo = new NhanVienBo();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> nhanVienInfo = new Dictionary<string, object>();
            nhanVienInfo.Add("hoTen", textBox_HoTen.Text);
            nhanVienInfo.Add("gioiTinh", comboBox_GioiTinh.Text);
            nhanVienInfo.Add("ngaySinh", dateTimePicker_NgaySinh.Value);
            nhanVienInfo.Add("diaChi", textBox_DiaChi.Text);
            nhanVienInfo.Add("heSoLuong", textBox_HeSoLuong.Text);

            try
            {
                nhanVienBo.InsertNhanVien(nhanVienInfo);
                button_Show_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> nhanVienInfo = new Dictionary<string, object>();
            nhanVienInfo.Add("maNhanVien", label_MaNhanVien.Text);
            nhanVienInfo.Add("hoTen", textBox_HoTen.Text);
            nhanVienInfo.Add("gioiTinh", comboBox_GioiTinh.Text);
            nhanVienInfo.Add("ngaySinh", dateTimePicker_NgaySinh.Value);
            nhanVienInfo.Add("diaChi", textBox_DiaChi.Text);
            nhanVienInfo.Add("heSoLuong", textBox_HeSoLuong.Text);

            try
            {
                nhanVienBo.UpdateNhanVien(nhanVienInfo);
                button_Show_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string maNhanVien = label_MaNhanVien.Text;
            try
            {
                nhanVienBo.DeleteNhanVien(maNhanVien);
                button_Show_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            string keyWord = Interaction.InputBox("Find: ");
            dataGridView_NhanVien.DataSource = nhanVienBo.FindNhanVien(keyWord);
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_NhanVien.DataSource = null;
                dataGridView_NhanVien.DataSource = nhanVienBo.List;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_MaNhanVien.Text = dataGridView_NhanVien[0, e.RowIndex].Value.ToString();
            textBox_HoTen.Text = dataGridView_NhanVien[1, e.RowIndex].Value.ToString();
            dateTimePicker_NgaySinh.Value = DateTime.Parse(dataGridView_NhanVien[2, e.RowIndex].Value.ToString());
            bool gioiTinh = bool.Parse(dataGridView_NhanVien[3, e.RowIndex].Value.ToString());
            if (gioiTinh)
                comboBox_GioiTinh.SelectedIndex = 0;
            else
                comboBox_GioiTinh.SelectedIndex = 1;
            textBox_DiaChi.Text = dataGridView_NhanVien[4, e.RowIndex].Value.ToString();
            textBox_HeSoLuong.Text = dataGridView_NhanVien[5, e.RowIndex].Value.ToString();
        }

        private void dataGridView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
