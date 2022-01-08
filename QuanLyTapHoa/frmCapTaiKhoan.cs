using BUS;
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
    public partial class frmCapTaiKhoan : Form
    {
        private NguoiDungBUS nguoiDungBUS;
        public frmCapTaiKhoan()
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;

            bool isOK = nguoiDungBUS.CapTaiKhoan(tenDangNhap, matKhau, nhapLaiMatKhau);
            if (isOK)
            {
                MessageBox.Show("Tạo tài khoản thành công");
                txtMatKhau.Text = "";
                txtNhapLaiMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Tạo tài khoản không thành công");
            }
        }
    }
}
