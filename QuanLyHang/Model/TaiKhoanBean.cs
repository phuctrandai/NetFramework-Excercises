namespace QuanLyHang.Model
{
    class TaiKhoanBean
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string vaiTro;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }

        public TaiKhoanBean(string tenTaiKhoan, string matKhau, string vaiTro)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.vaiTro = vaiTro;
        }
    }
}
