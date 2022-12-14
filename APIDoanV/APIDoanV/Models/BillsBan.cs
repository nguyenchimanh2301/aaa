using System;
using System.Collections.Generic;

namespace APIDoanV.Models;

public partial class BillsBan
{
    public string Id { get; set; } = null!;

    public string? IdKh { get; set; }

    public DateTime? NgayBan { get; set; }

    public double? TongTien { get; set; }

    public string Trangthai { get; set; } = null!;

    public string? Ghichu { get; set; }

    public string TenKh { get; set; } = null!;
}
