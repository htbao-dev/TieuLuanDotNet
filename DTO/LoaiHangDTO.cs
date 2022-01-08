using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiHangDTO
    {
        public int? MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }

        public LoaiHangDTO(int? maLoaiHang, string tenLoaiHang)
        {
            MaLoaiHang = maLoaiHang;
            TenLoaiHang = tenLoaiHang;
        }
    }
}
