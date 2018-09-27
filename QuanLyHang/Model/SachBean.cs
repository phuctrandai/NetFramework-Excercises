namespace QuanLyHang.Model
{
    class SachBean
    {
        private string maSach;
        private string tenSach;
        private long soLuong;
        private long gia;
        private string maLoai;
        private string soTap;
        private string hinhAnh;
        private string ngayNhap;
        private string tacGia;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public long SoLuong { get => soLuong; set => soLuong = value; }
        public long Gia { get => gia; set => gia = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string SoTap { get => soTap; set => soTap = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }

        public SachBean(string maSach, string tenSach, long soLuong, long gia, string maLoai, string soTap, string hinhAnh, string ngayNhap, string tacGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            SoLuong = soLuong;
            Gia = gia;
            MaLoai = maLoai;
            SoTap = soTap;
            HinhAnh = hinhAnh;
            NgayNhap = ngayNhap;
            TacGia = tacGia;
        }
    }
}
