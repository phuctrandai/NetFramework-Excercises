namespace QuanLyHang.Model
{
    public class LoaiBean
    {
        private string maLoai;
        private string tenLoai;

        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }

        public LoaiBean(string maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
    }
}
