using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_TrangChinh : Form
    {
        public form_TrangChinh()
        {
            InitializeComponent();
        }

        private void form_TrangChinh_Load(object sender, EventArgs e)
        {
            string vaiTro = form_DangNhap.vaiTro;
            if (vaiTro.Equals("Nhân viên"))
            {
                button_QuanLyLoaiSach.Visible = false;
                button_QuanLyNhanVien.Visible = false;
                button_QuanLySach.Visible = false;

                tlStrMnItem_QuanLy.Visible = false;
                tlStrMnItem_ThongKe.Visible = false;
            }
        }

        #region Button Click

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new form_QuanLyNhanVien()).ShowDialog();
            this.Show();
        }

        private void button_QuanLySach_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new form_QuanLySach()).ShowDialog();
            this.Show();
        }

        private void button_QuanLyLoaiSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new form_QuanLyLoaiSach()).ShowDialog();
            this.Show();
        }

        private void button_BanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_BanHang().ShowDialog();
            this.Show();
        }

        #endregion

        #region Tool Strip Menu Item Click

        private void tlStrMnItem_DangXuat_Click(object sender, EventArgs e)
        {
            button_DangXuat_Click(sender, e);
        }

        private void tlStrMnItem_Thoat_Click(object sender, EventArgs e)
        {
            button_Thoat_Click(sender, e);
        }

        private void tlStrMnItem_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            button_QuanLyNhanVien_Click(sender, e);
        }

        private void tlStrMnItem_QuanLySach_Click(object sender, EventArgs e)
        {
            button_QuanLySach_Click(sender, e);
        }

        private void tlStrMnItem_QuanLyLoaiSach_Click(object sender, EventArgs e)
        {
            button_QuanLyLoaiSach_Click(sender, e);
        }

        private void tlStrMnItem_BanHang_Click(object sender, EventArgs e)
        {
            button_BanHang_Click(sender, e);
        }

        private void tlStrMnItem_ThongKe_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
