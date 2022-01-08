
namespace QuanLyTapHoa
{
    partial class frmThemMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiHang_ThongTin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHinhAnh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbLoaiHang_ThongTin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 371);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mặt hàng";
            // 
            // cbbLoaiHang_ThongTin
            // 
            this.cbbLoaiHang_ThongTin.AllowDrop = true;
            this.cbbLoaiHang_ThongTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHang_ThongTin.FormattingEnabled = true;
            this.cbbLoaiHang_ThongTin.Location = new System.Drawing.Point(177, 201);
            this.cbbLoaiHang_ThongTin.Name = "cbbLoaiHang_ThongTin";
            this.cbbLoaiHang_ThongTin.Size = new System.Drawing.Size(230, 28);
            this.cbbLoaiHang_ThongTin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại hàng";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(372, 294);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 36);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(192, 294);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 36);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên mặt hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHinhAnh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pcbHinhAnh);
            this.panel3.Location = new System.Drawing.Point(456, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 262);
            this.panel3.TabIndex = 6;
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinhAnh.Location = new System.Drawing.Point(44, 225);
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.Size = new System.Drawing.Size(131, 29);
            this.btnHinhAnh.TabIndex = 2;
            this.btnHinhAnh.Text = "Chọn hình ảnh";
            this.btnHinhAnh.UseVisualStyleBackColor = true;
            this.btnHinhAnh.Click += new System.EventHandler(this.btnHinhAnh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hình ảnh";
            // 
            // pcbHinhAnh
            // 
            this.pcbHinhAnh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbHinhAnh.Location = new System.Drawing.Point(9, 27);
            this.pcbHinhAnh.Name = "pcbHinhAnh";
            this.pcbHinhAnh.Size = new System.Drawing.Size(200, 192);
            this.pcbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHinhAnh.TabIndex = 0;
            this.pcbHinhAnh.TabStop = false;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(177, 109);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(233, 28);
            this.txtGia.TabIndex = 5;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(177, 63);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(233, 28);
            this.txtTenMatHang.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(177, 155);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(233, 28);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmThemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 371);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemMatHang";
            this.Text = "Thêm mặt hàng";
            this.Load += new System.EventHandler(this.frmThemMat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbLoaiHang_ThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHinhAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbHinhAnh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}