using System;

namespace DTO
{
    public class MatHangDTO
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public long Gia { get; set; }
        public string DonVi { get; set; }
        public string HinhAnh { get; set; }
        public int? MaLoaiHang { get; set; }

        public MatHangDTO(int maMatHang, string tenMatHang, long gia, string donVi, string hinhAnh, int? maLoaiHang)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            Gia = gia;
            DonVi = donVi;
            HinhAnh = hinhAnh;
            MaLoaiHang = maLoaiHang;
        }
    }

    //public class MatHangDTOBuilder
    //{
    //    private int _maMatHang;
    //    private string _tenMatHang;
    //    private long _gia;
    //    private string _donVi;
    //    private string _hinhAnh;
    //    private int _maLoaiHang;

    //    public MatHangDTOBuilder AddMaMatHang(int maMatHang)
    //    {
    //        this._maMatHang = maMatHang;
    //        return this;
    //    }
    //    public MatHangDTOBuilder AddTenMatHang(string tenMatHang)
    //    {
    //        this._tenMatHang = tenMatHang;
    //        return this;
    //    }
    //    public MatHangDTOBuilder AddGia(long gia)
    //    {
    //        this._gia = gia;
    //        return this;
    //    }
    //    public MatHangDTOBuilder AddDonVi(string donVi)
    //    {
    //        this._donVi = donVi;
    //        return this;
    //    }
    //    public MatHangDTOBuilder AddHinhAnh(string hinhAnh)
    //    {
    //        this._hinhAnh = hinhAnh;
    //        return this;
    //    }
    //    public MatHangDTOBuilder AddMaLoaiHang(int maLoaiHang)
    //    {
    //        this._maLoaiHang = maLoaiHang;
    //        return this;
    //    }

    //    public MatHangDTO Build()
    //    {
    //        return new MatHangDTO(this._maMatHang, this._tenMatHang, this._gia, this._donVi, this._hinhAnh, this._maLoaiHang);
    //    }
    //}

}
