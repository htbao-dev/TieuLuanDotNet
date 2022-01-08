using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface INguoiDungDAL
    {
        bool DangNhap(string tenDangNhap, string matKhau);
        bool CapTaiKhoan(string tenDangNhap, string matKhau);
    }
}
