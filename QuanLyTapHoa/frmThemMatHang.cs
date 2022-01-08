using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTapHoa
{
    public partial class frmThemMatHang : Form
    {
        private LoaiHangBUS loaiHangBUS;
        private MatHangBUS matHangBUS;
        public frmThemMatHang()
        {
            InitializeComponent();
            loaiHangBUS = new LoaiHangBUS();
            matHangBUS = new MatHangBUS();
        }
        private void frmThemMat_Load(object sender, EventArgs e)
        {
            cbbLoaiHang_ThongTin.DataSource = loaiHangBUS.GetAll();
            cbbLoaiHang_ThongTin.DisplayMember = "TenLoaiHang";
        }

        string fileName_tam;
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName_tam = openFileDialog1.FileName;
            pcbHinhAnh.Image = new Bitmap(fileName_tam);
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenMatHang = txtTenMatHang.Text;
            long gia = long.Parse(txtGia.Text);
            string donVi = txtDonViTinh.Text;
            string hinhAnh = fileName_tam;
            LoaiHangDTO loaiHang = cbbLoaiHang_ThongTin.SelectedItem as LoaiHangDTO;
            int? maLoaiHang = loaiHang.MaLoaiHang;
            MatHangDTO matHang = new MatHangDTO(-1, tenMatHang, gia, donVi, hinhAnh, maLoaiHang);

            bool isOK = matHangBUS.insert(matHang);
            if (isOK)
            {
                MessageBox.Show("thêm thành công thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
