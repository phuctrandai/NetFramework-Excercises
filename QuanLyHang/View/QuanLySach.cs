using QuanLyHang.Bo;
using System;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_QuanLySach : Form
    {
        public form_QuanLySach()
        {
            InitializeComponent();
        }

        private void form_QuanLySach_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {

            dataGridView_Sach.DataSource = SachBo.getInstance().GetSach();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
