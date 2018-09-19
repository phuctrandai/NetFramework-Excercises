using QuanLyHang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHang
{
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_ManHinhChinh f = new form_ManHinhChinh();
            f.ShowDialog();
            this.Show();
        }
    }
}
