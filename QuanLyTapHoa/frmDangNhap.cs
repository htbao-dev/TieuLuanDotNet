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
    public partial class frmDangNhap : Form
    {
        private NguoiDungBUS nguoiDungBUS;
        public frmDangNhap()
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            bool isOK = nguoiDungBUS.DangNhap(tenDangNhap, matKhau);
            if (isOK)
            {
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                this.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng hoặc mật khẩu không hợp lệ");
            }
        }
    }
}
