using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MatHangBUS
    {
        private MatHangDAL matHangDAL;

        public MatHangBUS()
        {
            matHangDAL = new MatHangDAL();
        }

        public bool delete(MatHangDTO matHang)
        {
            string filePath = "Resources\\" + matHang.HinhAnh;
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }

            return matHangDAL.Delete(matHang.MaMatHang);
        }

        public List<MatHangDTO> GetMatHangByMaLoaiHang(int? maLoaiHang)
        {
            return matHangDAL.GetMatHangByMaLoaiHang(maLoaiHang);
        }

        public bool insert(MatHangDTO matHang)
        {
            if (matHang.HinhAnh != null)
            {
                string extension = Path.GetExtension(matHang.HinhAnh);
                string fileName = matHang.MaMatHang + extension;
                //string targetFiile = 
                File.Copy(matHang.HinhAnh, "Resources\\" + fileName, true);
                matHang.HinhAnh = fileName;
            }
            
            return matHangDAL.Insert(matHang);
        }

        public List<MatHangDTO> SearchByName(int? maLoaiHang, string name)
        {
            return matHangDAL.searchByName(maLoaiHang, name);
        }

        public bool update(MatHangDTO matHang)
        {
            string extension = Path.GetExtension(matHang.HinhAnh);
            string fileName = matHang.MaMatHang + extension;
            //string targetFiile = 
            File.Copy(matHang.HinhAnh, "Resources\\" + fileName, true);

            matHang.HinhAnh = fileName;
            return matHangDAL.Update(matHang);
        }
    }
}
