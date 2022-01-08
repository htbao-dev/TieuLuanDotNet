using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class LoHangDAL : DBConnection
    {
        public List<LoHangDTO> GetByMaMatHang(int maMatHang)
        {
            string sql = "SELECT * FROM LoHang as lh " +
                            "JOIN NhaCungCap as ncc " +
                            "ON lh.MaNhaCungCap = ncc.MaNhaCungCap " +
                            "WHERE MaMatHang = @maMatHang";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@maMatHang", maMatHang);
            DataTable daLoHang = new DataTable();
            da.Fill(daLoHang);
            con.Close();
            List<LoHangDTO> listDTO = new List<LoHangDTO>();
            for (int i = 0; i < daLoHang.Rows.Count; i++) {
                int maLoHang = Int32.Parse(daLoHang.Rows[i]["MaLoHang"].ToString());
                int soLuong = Int32.Parse(daLoHang.Rows[i]["SoLuong"].ToString());
                string _hanSuDung = daLoHang.Rows[i]["HanSuDung"].ToString();

                DateTime hanSuDung = DateTime.Parse(_hanSuDung);
                int maNhaCungCap = Int32.Parse(daLoHang.Rows[i]["MaNhaCungCap"].ToString());
                string tenNhaCungCap = daLoHang.Rows[i]["TenNhaCungCap"].ToString();

                listDTO.Add(new LoHangDTO(maLoHang,maMatHang, soLuong, hanSuDung, maNhaCungCap, tenNhaCungCap));
            }
            return listDTO;
        }
    }
}
