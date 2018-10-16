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

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            tenDangNhap = textBox_TenTaiKhoan.Text;
            string matKhau = textBox_MatKhau.Text;

            if (DangNhap(tenDangNhap, matKhau))
            {
                this.Hide();
                new form_KetNoiDatabase().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private bool DangNhap(string userName, string password)
        {
            if (userName.Equals("admin") && password.Equals("123"))
                return true;
            return false;
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
