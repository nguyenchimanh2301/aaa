using System;
using System.Collections.Generic;

namespace APIDoanV.Models;

public partial class Donhang
{
    public string MaDonHang { get; set; } = null!;

    public string MaKhachHang { get; set; } = null!;

    public DateTime Ngaydat { get; set; }

    public string? Trangthai { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; } = new List<ChiTietDonHang>();
}
