using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiHangBUS
    {
        private MatHangDAL matHangDAL;
        private LoaiHangDAL loaiHangDAL;

        public LoaiHangBUS()
        {
            loaiHangDAL = new LoaiHangDAL();
            matHangDAL = new MatHangDAL();
        }

        public bool delete(int? maLoaiHang)
        {
            List<MatHangDTO> listMatHang = matHangDAL.GetMatHangByMaLoaiHang(maLoaiHang);
            Console.WriteLine(listMatHang.Count);
            for (int i = 0; i < listMatHang.Count; i++) 
            {
                listMatHang[i].MaLoaiHang = null;
                matHangDAL.Update(listMatHang[i]);
            }
            return loaiHangDAL.Delete(maLoaiHang);
        }

        public List<LoaiHangDTO> GetAll()
        {
            List <LoaiHangDTO> listLoaiHang = loaiHangDAL.GetAll();
            listLoaiHang.Add(new LoaiHangDTO(null, "Chưa xếp loại"));
            return listLoaiHang;
        }

        public bool insert(string tenLoaiHang)
        {
            return loaiHangDAL.Insert(tenLoaiHang);
        }

        public bool update(LoaiHangDTO loaiHang)
        {
            return loaiHangDAL.Update(loaiHang);
        }
    }
}
