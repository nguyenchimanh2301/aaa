using System;
using System.Collections.Generic;

namespace APIDoanV.Models;

public partial class ChiTietDonHang
{
    public int MaChiTietDonHang { get; set; }

    public string MaDonHang { get; set; } = null!;

    public string MaSanPham { get; set; } = null!;

    public int SoLuong { get; set; }

    public double GiaMua { get; set; }

    public virtual Donhang MaDonHangNavigation { get; set; } = null!;
}
