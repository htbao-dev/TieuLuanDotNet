using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        public int MaNguoiDung { get; set; }
        public string TenDangNhap { get; set; }

        public NguoiDungDTO(int maNguoiDung, string tenDangNhap)
        {
            MaNguoiDung = maNguoiDung;
            TenDangNhap = tenDangNhap;
        }
    }
}
