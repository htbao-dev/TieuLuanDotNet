using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        private INguoiDungDAL nguoiDungDAL;

        public NguoiDungBUS()
        {
            this.nguoiDungDAL = new NguoiDungDAL();
        }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            return nguoiDungDAL.DangNhap(tenDangNhap, matKhau);
        }
        public bool CapTaiKhoan(string tenDangNhap, string matKhau, string nhapLaiMatKhau)
        {
            bool isOK;
            if (tenDangNhap == "" || matKhau == "" || !matKhau.Equals(nhapLaiMatKhau))
            {
                isOK = false;
            }
            else
            {
                isOK = nguoiDungDAL.CapTaiKhoan(tenDangNhap, matKhau);
            }
            return isOK;
        }
    }
}
