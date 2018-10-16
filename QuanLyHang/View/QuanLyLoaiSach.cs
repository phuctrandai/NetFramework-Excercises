using QuanLyHang.Bo;
using QuanLyHang.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QuanLyHang.View
{
    public partial class form_QuanLyLoaiSach : Form
    {
        public form_QuanLyLoaiSach()
        {
            InitializeComponent();
        }

        private LoaiBo loaiBo = new LoaiBo();
        List<LoaiBean> list;

        private void form_QuanLyLoaiSach_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_HienThi_Click(object sender, EventArgs e)
        {

            list = loaiBo.GetListLoai();
            dataGridView_Sach.DataSource = list;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaiBo.AddLoai(textBox_MaLoai.Text, textBox_TenLoai.Text))
                {
                    dataGridView_Sach.DataSource = null;
                    dataGridView_Sach.DataSource = list;
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaiBo.DeleteLoai(textBox_MaLoai.Text))
                {
                    dataGridView_Sach.DataSource = null;
                    dataGridView_Sach.DataSource = list;
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaiBo.UpdateLoai(textBox_MaLoai.Text, textBox_TenLoai.Text))
                {
                    dataGridView_Sach.DataSource = null;
                    dataGridView_Sach.DataSource = list;
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string keyWord = Interaction.InputBox("Nhập thông tin về loại sách:");
            dataGridView_Sach.DataSource = loaiBo.FindLoai(keyWord);
        }

        private void dataGridView_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaLoai.Text = dataGridView_Sach[1, e.RowIndex].Value.ToString();
            textBox_TenLoai.Text = dataGridView_Sach[0, e.RowIndex].Value.ToString();
        }

        private void button_In_Click(object sender, EventArgs e)
        {
            form_InBaoCao frmInBaoCao = new form_InBaoCao();

            frmInBaoCao.dataSource = dataGridView_Sach.DataSource;
            frmInBaoCao.ShowDialog();
        }
    }
}
