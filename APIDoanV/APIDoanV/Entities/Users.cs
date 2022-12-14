namespace APIDoanV.Entities
{
    public class Users
    {
        public string MaNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Role { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        internal Users WithoutPassword()
        {
            throw new NotImplementedException();
        }

        public string DienThoai { get; set; }
        public string Token { get; set; }
    }
}
