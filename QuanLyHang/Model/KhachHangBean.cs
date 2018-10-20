namespace QuanLyHang.Model
{
    public class KhachHangBean
    {
        private int maKhachHang;
        private string hoVaTen;
        private string vaiTro;

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }

        public KhachHangBean(int maKhachHang, string hoVaTen, string vaiTro)
        {
            MaKhachHang = maKhachHang;
            HoVaTen = hoVaTen;
            VaiTro = vaiTro;
        }

        
    }
}
