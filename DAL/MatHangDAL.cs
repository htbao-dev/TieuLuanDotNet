using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class MatHangDAL : DBConnection
    {
        public bool Delete(int id)
        {
            string sql = "DELETE MatHang WHERE MaMatHang = @maMatHang";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maMatHang", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public List<MatHangDTO> GetMatHangByMaLoaiHang(int? maLoaiHang)
        {
            SqlDataAdapter da;
            con.Open();
            if (maLoaiHang != null)
            {
                string sql =
                "SELECT * FROM MatHang WHERE MaLoaiHang = @maLoaiHang";
                da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maLoaiHang", maLoaiHang);
            }
            else
            {
                string sql =
                "SELECT * FROM MatHang WHERE MaLoaiHang IS NULL";
                da = new SqlDataAdapter(sql, con);
            }
            
            DataTable daMatHang = new DataTable();
            da.Fill(daMatHang);
            con.Close();
            List<MatHangDTO> listMatHang = _DataTableToListMatHangDTO(daMatHang);
            return listMatHang;
        }
        public bool Insert(MatHangDTO matHang)
        {
            string sql = "INSERT INTO MatHang " +
                "(TenMatHang, Gia, DonViTinh, HinhAnh, MaLoaiHang) " +
                "values (@tenMatHang, @Gia, @donVi, @HinhAnh, @maLoaiHang)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenMatHang", matHang.TenMatHang);
                cmd.Parameters.AddWithValue("@Gia", matHang.Gia);
                cmd.Parameters.AddWithValue("@donVi", matHang.DonVi);
                cmd.Parameters.AddWithValue("@HinhAnh", matHang.HinhAnh);
                cmd.Parameters.AddWithValue("@maLoaiHang", matHang.MaLoaiHang);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            con.Close();
            return true;
        }

        public List<MatHangDTO> searchByName(int? maLoaiHang, string name)
        {
            SqlDataAdapter da;
            con.Open();
            if (maLoaiHang != null)
            {
                string sql =
                "SELECT * FROM MatHang WHERE MaLoaiHang = @maLoaiHang AND TenMatHang like @tenMatHang";
                da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maLoaiHang", maLoaiHang);
                da.SelectCommand.Parameters.AddWithValue("@tenMatHang", "%" + name + "%");
            }
            else
            {
                string sql =
                "SELECT * FROM MatHang WHERE MaLoaiHang IS NULL AND TenMatHang like @tenMatHang";
                da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@tenMatHang", "%" + name + "%");
            }

            DataTable daMatHang = new DataTable();
            da.Fill(daMatHang);
            con.Close();
            List<MatHangDTO> listMatHang = _DataTableToListMatHangDTO(daMatHang);
            return listMatHang;
        }

        public bool Update(MatHangDTO matHang)
        {
            string sql = "UPDATE MatHang " +
                "SET TenMatHang = @tenMatHang, Gia = @gia, DonViTinh = @donViTinh, HinhAnh = @hinhAnh, MaLoaiHang = @maLoaiHang WHERE MaMatHang = @maMatHang";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenMatHang", matHang.TenMatHang);
                cmd.Parameters.AddWithValue("@Gia", matHang.Gia);
                cmd.Parameters.AddWithValue("@donViTinh", matHang.DonVi);
                cmd.Parameters.AddWithValue("@hinhAnh", matHang.HinhAnh);
                cmd.Parameters.AddWithValue("@maMatHang", matHang.MaMatHang);
                object maLoaiHang;
                if (matHang.MaLoaiHang == null)
                {
                    maLoaiHang = DBNull.Value;
                }
                else
                {
                    maLoaiHang = matHang.MaLoaiHang;
                }

                cmd.Parameters.AddWithValue("@maLoaiHang", maLoaiHang);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            con.Close();
            return true;
        }

        private List<MatHangDTO> _DataTableToListMatHangDTO(DataTable dataTable)
        {
            List<MatHangDTO> listMatHangDTO = new List<MatHangDTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int maMatHang = Int32.Parse(dataTable.Rows[i]["MaMatHang"].ToString());

                string tenMatHang = dataTable.Rows[i]["TenMatHang"].ToString();
                long gia = long.Parse(dataTable.Rows[i]["Gia"].ToString());
                string donVi = dataTable.Rows[i]["DonViTinh"].ToString();
                string hinhAnh = dataTable.Rows[i]["HinhAnh"].ToString();

                object _maLoaiHang = dataTable.Rows[i]["MaLoaiHang"];
                Console.WriteLine(_maLoaiHang);
                int? maLoaiHang;
                if (_maLoaiHang == DBNull.Value) 
                    maLoaiHang = null;
                else 
                    maLoaiHang = Int32.Parse(_maLoaiHang.ToString());

                MatHangDTO item = new MatHangDTO(maMatHang, tenMatHang, gia, donVi, hinhAnh, maLoaiHang);
                listMatHangDTO.Add(item);
            }
            return listMatHangDTO;
        }
    }
}
