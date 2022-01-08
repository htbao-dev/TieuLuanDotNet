using BUS;
using DTO;
using QuanLyTapHoa.Properties;
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
    public partial class frmMain : Form
    {
        private LoaiHangBUS loaiHangBUS;
        private MatHangBUS matHangBUS;
        private LoHangBUS loHangBUS;
        public frmMain()
        {
            InitializeComponent();
            loaiHangBUS = new LoaiHangBUS();
            matHangBUS = new MatHangBUS();
            loHangBUS = new LoHangBUS();
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            frmThemMatHang _frmThemMatHang = new frmThemMatHang();
            _frmThemMatHang.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadLoaiHang();
        }

        private void cbbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiHangDTO loaiHang = cbbLoaiHang.SelectedItem as LoaiHangDTO;
            int? maLoaihang = loaiHang.MaLoaiHang;

            resetThongTin();

            reloadMatHang(maLoaihang);
        }

        private void lbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatHangDTO matHang = lbMatHang.SelectedItem as MatHangDTO;

            txtTenMatHang.Text = matHang.TenMatHang;
            txtMaMatHang.Text = matHang.MaMatHang.ToString();
            txtGia.Text = matHang.Gia.ToString();
            txtDonViTinh.Text = matHang.DonVi;

            fileName_tam = "Resources\\" + matHang.HinhAnh;
            pcbHinhAnh.Image = new Bitmap(fileName_tam);

            List<LoHangDTO> listDTO = loHangBUS.getByMaMatHang(matHang.MaMatHang);
            int sum = 0;

            listDTO.ForEach((item) => sum += item.SoLuong);
            txtTongSoLuong.Text = sum.ToString();

            dgvLoHang.DataSource = listDTO;

        }
        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang frmThemLoaiHang = new frmThemLoaiHang();
            frmThemLoaiHang.ShowDialog();
            reloadLoaiHang();
        }

        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHangDTO loaiHang = cbbLoaiHang.SelectedItem as LoaiHangDTO;
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn xoá loại hàng " + loaiHang.TenLoaiHang,
                "Xác nhận xoá", 
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                bool isOK = loaiHangBUS.delete(loaiHang.MaLoaiHang);
                if (isOK)
                {
                    MessageBox.Show("Xoá thành công");
                    reloadLoaiHang();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
                }
            }
            
        }

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            frmSuaLoaiHang _frmSuaLoaiHang = new frmSuaLoaiHang();
            _frmSuaLoaiHang.ShowDialog();
            reloadLoaiHang();
        }
        private void resetThongTin()
        {
            txtTenMatHang.Text = "";
            txtMaMatHang.Text = "";
            txtGia.Text = "";
            txtDonViTinh.Text = "";
            txtTongSoLuong.Text = "";
            pcbHinhAnh.Image = null;
        }

        private void reloadLoaiHang()
        {
            cbbLoaiHang.DataSource = loaiHangBUS.GetAll();
            cbbLoaiHang.DisplayMember = "TenLoaiHang";

            cbbLoaiHang_ThongTin.DataSource = loaiHangBUS.GetAll();
            cbbLoaiHang_ThongTin.DisplayMember = "TenLoaiHang";
        }

        private void reloadMatHang(int? maLoaihang)
        {
            lbMatHang.DataSource = matHangBUS.GetMatHangByMaLoaiHang(maLoaihang);
            lbMatHang.DisplayMember = "TenMatHang";
        }

        private void btnSuaMatHang_Click(object sender, EventArgs e)
        {
            lock_unlock(true);
        }

        private void lock_unlock(bool isLook)
        {
            groupLoaiHang.Enabled = !isLook;
            groupMatHang.Enabled = !isLook;

            btnHinhAnh.Visible = isLook;
            btnXacNhan.Visible = isLook;
            btnHuy.Visible = isLook;
            pnlLoaiHang_ThongTin.Visible = isLook;

            txtTenMatHang.ReadOnly = !isLook;
            txtGia.ReadOnly = !isLook;
            txtDonViTinh.ReadOnly = !isLook;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lock_unlock(false);
        }

        private string fileName_tam;
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName_tam = openFileDialog1.FileName;
            pcbHinhAnh.Image = new Bitmap(fileName_tam);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int maMatHang = Int32.Parse(txtMaMatHang.Text);
            string tenMatHang = txtTenMatHang.Text;
            long gia = long.Parse(txtGia.Text);
            string donVi = txtDonViTinh.Text;
            string hinhAnh = fileName_tam;
            LoaiHangDTO loaiHang = cbbLoaiHang_ThongTin.SelectedItem as LoaiHangDTO;
            int? maLoaiHang = loaiHang.MaLoaiHang;
            MatHangDTO matHang = new MatHangDTO(maMatHang, tenMatHang, gia, donVi, hinhAnh, maLoaiHang);

            bool isOK = matHangBUS.update(matHang);
            if (isOK)
            {
                MessageBox.Show("Cập nhật thành công");
                reloadMatHang(maLoaiHang);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }

        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            MatHangDTO matHang = lbMatHang.SelectedItem as MatHangDTO;
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn xoá loại hàng " + matHang.TenMatHang,
                "Xác nhận xoá",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                matHangBUS.delete(matHang);
            }
        }

        private void txtTimKiemMatHang_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            LoaiHangDTO loaiHang = cbbLoaiHang.SelectedItem as LoaiHangDTO;
            lbMatHang.DataSource = matHangBUS.SearchByName(loaiHang.MaLoaiHang, tb.Text);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCapTaiKhoan_Click(object sender, EventArgs e)
        {
            frmCapTaiKhoan _frmCapTaiKhoan = new frmCapTaiKhoan();
            _frmCapTaiKhoan.ShowDialog();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            viewReport view = new viewReport();
            view.Show();
        }
    }
}
