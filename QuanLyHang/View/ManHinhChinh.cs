using QuanLyHang.Bo;
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
    public partial class form_ManHinhChinh : Form
    {
        public form_ManHinhChinh()
        {
            InitializeComponent();

            hangBo = new HangBo();
            chiNhanhBo = new ChiNhanhBo();

            bindingSource = new BindingSource();
            bindingSource.DataSource = hangBo.TaoDanhSach();
        }

        private HangBo hangBo;
        private ChiNhanhBo chiNhanhBo;
        private BindingSource bindingSource;

        private void button_Them_Click(object sender, EventArgs e)
        {

        }

        private void button_In_Click(object sender, EventArgs e)
        {

        }

        private void button_Tim_Click(object sender, EventArgs e)
        {

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_ManHinhChinh_Load(object sender, EventArgs e)
        {
            dataGridView_DSHang.DataSource = bindingSource;
            Binding();

            comboBox_ChiNhanh.DataSource = chiNhanhBo.TaoDanhSach();
            comboBox_ChiNhanh.DisplayMember = "TenChiNhanh";
            comboBox_ChiNhanh.ValueMember = "MaChiNhanh";
        }

        private void Binding()
        {
            textBox_MaHang.DataBindings.Add("Text", bindingSource, "MaHang");
            textBox_TenHang.DataBindings.Add("Text", bindingSource, "TenHang");
            textBox_GiaBan.DataBindings.Add("Text", bindingSource, "GiaBan");
            textBox_SoLuong.DataBindings.Add("Text", bindingSource, "SoLuongHienCo");
        }
    }
}
