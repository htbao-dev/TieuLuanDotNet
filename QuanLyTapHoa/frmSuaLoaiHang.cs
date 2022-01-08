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
    public partial class frmSuaLoaiHang : Form
    {
        private LoaiHangBUS loaiHangBUS;
        public frmSuaLoaiHang()
        {
            InitializeComponent();
            loaiHangBUS = new LoaiHangBUS();
        }

        private void frmSuaLoaiHang_Load(object sender, EventArgs e)
        {
            lbLoaiHang.DataSource = loaiHangBUS.GetAll();
            lbLoaiHang.DisplayMember = "TenLoaiHang";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiHangDTO loaiHang = lbLoaiHang.SelectedItem as LoaiHangDTO;
            string tenLoaiHang = txtTenLoaiHang.Text;
            if (tenLoaiHang == "")
            {
                MessageBox.Show("Tên loại hàng không được rỗng");
            }
            else
            {
                loaiHang.TenLoaiHang = tenLoaiHang;
                bool isOK = loaiHangBUS.update(loaiHang);
                if (isOK)
                {
                    MessageBox.Show("Sửa thành công");   
                    lbLoaiHang.DataSource = loaiHangBUS.GetAll();
                    lbLoaiHang.DisplayMember = "TenLoaiHang";
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau");
                }
            }
        }

        private void lbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiHangDTO loaiHang = lbLoaiHang.SelectedItem as LoaiHangDTO;
            txtTenLoaiHang.Text = loaiHang.TenLoaiHang;
        }
    }
}
