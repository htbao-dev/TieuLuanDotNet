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
    public partial class frmThemLoaiHang : Form
    {
        private LoaiHangBUS loaiHangBUS;
        public frmThemLoaiHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenLoaiHang = txtThemLoaiHang.Text;
            if (txtThemLoaiHang.Text == "")
            {
                MessageBox.Show("Tên loại hàng không được rỗng");
            }
            else
            {
                loaiHangBUS = new LoaiHangBUS();
                loaiHangBUS.insert(tenLoaiHang);
                txtThemLoaiHang.Text = "";
                MessageBox.Show("Thêm thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
