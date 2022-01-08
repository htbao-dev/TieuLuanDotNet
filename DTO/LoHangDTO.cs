using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DTO
{
    public class LoHangDTO
    {
        public int MaLoHang { get; set; }

        [Browsable(false)]
        public int MaMatHang { get; set; }
        public int SoLuong { get; set; }
        public DateTime HanSuDung { get; set;}

        [Browsable(false)]
        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }

        public LoHangDTO(int maLoHang, int maMatHang, int soLuong, DateTime hanSuDung, int maNhaCungCap, string tenNhaCungCap)
        {
            MaLoHang = maLoHang;
            MaMatHang = maMatHang;
            SoLuong = soLuong;
            HanSuDung = hanSuDung;
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
        }
    }
}
