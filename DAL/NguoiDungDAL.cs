using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL : DBConnection, INguoiDungDAL
    {
        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string sql = "SELECT * FROM NguoiDung WHERE TenDangNhap = @tenDangNhap AND MatKhau = @matKhau";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
            da.SelectCommand.Parameters.AddWithValue("@matKhau", matKhau);
            DataTable daNguoiDung = new DataTable();
            da.Fill(daNguoiDung);
            con.Close();
            bool isOK = false;
            if (daNguoiDung.Rows.Count > 0)
            {
                isOK = true;
            }
            return isOK;
        }

        public bool CapTaiKhoan(string tenDangNhap, string matKhau)
        {
            string sql = "INSERT INTO NguoiDung " +
                    "(TenDangNhap, MatKhau) " +
                    "values (@tenDangNhap, @matKhau)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
