using System;
using System.Collections.Generic;

namespace APIDoanV.Models;

public partial class BillDetailBan
{
    public string Id { get; set; } = null!;

    public string IdBillBan { get; set; } = null!;

    public string Masp { get; set; } = null!;

    public string IdKh { get; set; } = null!;

    public int? Tongtien { get; set; }

    public short? Soluong { get; set; }

    public string? Chietkhau { get; set; }

    public short? Tralai { get; set; }
}
