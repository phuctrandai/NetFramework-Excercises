using QuanLyHang.Bo;
using QuanLyHang.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_ManHinhChinh : Form
    {
        public form_ManHinhChinh()
        {
            InitializeComponent();

            chiNhanhBo = new ChiNhanhBo();

            list = HangBo.getInstance().TaoDanhSach();

            bindingSource = new BindingSource();
            bindingSource.DataSource = list;
        }

        public static List<HangBean> list = null;

        private ChiNhanhBo chiNhanhBo;
        public static BindingSource bindingSource = null;

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (ThemHang())
            {
                MessageBox.Show("Thêm hàng thành công!");
                comboBox_ChiNhanh_SelectedIndexChanged(sender, e);
            }
            else MessageBox.Show("Mã hàng đã tồn tại!");
        }
        public bool ThemHang()
        {
            string maHang = textBox_MaHang.Text,
                tenHang = textBox_TenHang.Text,
                maChiNhanh = comboBox_ChiNhanh.SelectedValue.ToString();
            int soLuong, giaBan;

            if (int.TryParse(textBox_GiaBan.Text, out giaBan) && int.TryParse(textBox_SoLuong.Text, out soLuong))
            {
                return HangBo.getInstance().Them(maHang, tenHang, giaBan, soLuong, maChiNhanh);
            }
            else return false;
        }

        private void button_In_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_InBaoCao().ShowDialog(this);
            this.Show();
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string maHang = textBox_MaHang.Text;
            string newTenHang = textBox_TenHang.Text;
            int newGiaBan, newSoLuong;

            if(!int.TryParse(textBox_GiaBan.Text,out newGiaBan))
            {
                MessageBox.Show("Giá bán không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox_SoLuong.Text, out newSoLuong))
            {
                MessageBox.Show("Số lượng không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SuaHang(maHang, newTenHang, newGiaBan, newSoLuong))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox_ChiNhanh_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool SuaHang(string maHang, string newTenHang, int newGiaBan, int newSoLuong)
        {
            return HangBo.getInstance().Sua(maHang, newTenHang, newGiaBan, newSoLuong);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (XoaHang())
            {
                MessageBox.Show("Xóa mặt hàng thành công!");
                comboBox_ChiNhanh_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể xóa mặt hàng đã chọn!");
            }
        }
        public bool XoaHang()
        {
            string maHang = textBox_MaHang.Text;
            return HangBo.getInstance().Xoa(maHang);
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isLoaded = false;
        private void form_ManHinhChinh_Load(object sender, EventArgs e)
        {
            dataGridView_DSHang.DataSource = bindingSource;
            Binding();

            comboBox_ChiNhanh.DataSource = chiNhanhBo.TaoDanhSach();
            comboBox_ChiNhanh.DisplayMember = "TenChiNhanh";
            comboBox_ChiNhanh.ValueMember = "MaChiNhanh";
            isLoaded = true;
            comboBox_ChiNhanh_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void Binding()
        {
            textBox_MaHang.DataBindings.Add("Text", dataGridView_DSHang.DataSource, "MaHang", false, DataSourceUpdateMode.Never);
            textBox_TenHang.DataBindings.Add("Text", dataGridView_DSHang.DataSource, "TenHang", false, DataSourceUpdateMode.Never);
            textBox_GiaBan.DataBindings.Add("Text", dataGridView_DSHang.DataSource, "GiaBan", false, DataSourceUpdateMode.Never);
            textBox_SoLuong.DataBindings.Add("Text", dataGridView_DSHang.DataSource, "SoLuongHienCo", false, DataSourceUpdateMode.Never);
        }

        private void comboBox_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded) /*dataGridView_DSHang.DataSource = */bindingSource.DataSource = HangBo.getInstance().TimTheoMaChiNhanh(comboBox_ChiNhanh.SelectedValue.ToString());
        }
    }
}
