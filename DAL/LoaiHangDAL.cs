using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class LoaiHangDAL : DBConnection
    {
        public bool Delete(int? id)
        {
            con.Open();
            SqlCommand cmd;
            if (id != null)
            {
                string sql = "DELETE LoaiHang WHERE MaLoaiHang = @maLoaiHang";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maLoaiHang", id);
            }
            else
            {
                string sql = "DELETE LoaiHang WHERE MaLoaiHang IS NULL";
                cmd = new SqlCommand(sql, con);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            con.Close();
            return true;
        }

        public List<LoaiHangDTO> GetAll()
        {
            string sql = "SELECT * FROM LoaiHang";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable daLoaiHang = new DataTable();
            da.Fill(daLoaiHang);
            con.Close();
            List<LoaiHangDTO> listLoaiHangDTO = new List<LoaiHangDTO>();
            for (int i = 0; i < daLoaiHang.Rows.Count; i++)
            {
                int maLoaiHang = Int32.Parse(daLoaiHang.Rows[i]["MaLoaiHang"].ToString());
                string tenLoaiHang = daLoaiHang.Rows[i]["tenLoaiHang"].ToString();
                listLoaiHangDTO.Add(new LoaiHangDTO(maLoaiHang, tenLoaiHang));
            }
            return listLoaiHangDTO;
        }

        public bool Insert(string tenLoaiHang)
        {
            string sql = "INSERT INTO LoaiHang " +
                "(TenLoaiHang) " +
                "values " +
                "(@tenLoaiHang)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenLoaiHang", tenLoaiHang);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool Update(LoaiHangDTO loaiHang)
        {
            string sql = "UPDATE LoaiHang " +
                "SET TenLoaiHang = @tenLoaiHang " +
                "WHERE MaLoaiHang = @maLoaiHang ";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenLoaiHang", loaiHang.TenLoaiHang);
                cmd.Parameters.AddWithValue("@maLoaiHang", loaiHang.MaLoaiHang);
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
