using QuanLyHang.Bo;
using QuanLyHang.Model;
using QuanLyHang.View;
using System;
using System.Windows.Forms;

namespace QuanLyHang
{
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        public static string tenDangNhap = "";
        public static string matKhau = "";
        public static string vaiTro = "";

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            tenDangNhap = textBox_TenTaiKhoan.Text;
            matKhau = textBox_MatKhau.Text;

            if (DangNhap(tenDangNhap, matKhau))
            {
                this.Hide();
                new form_TrangChinh().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private bool DangNhap(string userName, string password)
        {
            TaiKhoanBo taiKhoanBo = new TaiKhoanBo();
            TaiKhoanBean taiKhoan = null;
            try
            {
                taiKhoan = taiKhoanBo.GetTaiKhoan(userName, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(taiKhoan != null)
            {
                vaiTro = taiKhoan.VaiTro;
                return true;
            }
            return false;
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
