
namespace QuanLyTapHoa
{
    partial class frmMain
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
            this.lbMatHang = new System.Windows.Forms.ListBox();
            this.cbbLoaiHang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiemMatHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlLoaiHang_ThongTin = new System.Windows.Forms.Panel();
            this.cbbLoaiHang_ThongTin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHinhAnh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoHang = new System.Windows.Forms.DataGridView();
            this.clmMaLoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.btnXoaMatHang = new System.Windows.Forms.Button();
            this.btnSuaMatHang = new System.Windows.Forms.Button();
            this.groupMatHang = new System.Windows.Forms.GroupBox();
            this.groupLoaiHang = new System.Windows.Forms.GroupBox();
            this.btnSuaLoaiHang = new System.Windows.Forms.Button();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.btnXoaLoaiHang = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tuỳChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlLoaiHang_ThongTin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoHang)).BeginInit();
            this.groupMatHang.SuspendLayout();
            this.groupLoaiHang.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMatHang
            // 
            this.lbMatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatHang.FormattingEnabled = true;
            this.lbMatHang.ItemHeight = 22;
            this.lbMatHang.Location = new System.Drawing.Point(0, 82);
            this.lbMatHang.Name = "lbMatHang";
            this.lbMatHang.Size = new System.Drawing.Size(206, 180);
            this.lbMatHang.TabIndex = 1;
            this.lbMatHang.SelectedIndexChanged += new System.EventHandler(this.lbMatHang_SelectedIndexChanged);
            // 
            // cbbLoaiHang
            // 
            this.cbbLoaiHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiHang.FormattingEnabled = true;
            this.cbbLoaiHang.Location = new System.Drawing.Point(0, 26);
            this.cbbLoaiHang.Name = "cbbLoaiHang";
            this.cbbLoaiHang.Size = new System.Drawing.Size(205, 30);
            this.cbbLoaiHang.TabIndex = 2;
            this.cbbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiHang_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbLoaiHang);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 56);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimKiemMatHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbMatHang);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 262);
            this.panel2.TabIndex = 4;
            // 
            // txtTimKiemMatHang
            // 
            this.txtTimKiemMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMatHang.Location = new System.Drawing.Point(3, 40);
            this.txtTimKiemMatHang.Name = "txtTimKiemMatHang";
            this.txtTimKiemMatHang.Size = new System.Drawing.Size(202, 28);
            this.txtTimKiemMatHang.TabIndex = 3;
            this.txtTimKiemMatHang.TextChanged += new System.EventHandler(this.txtTimKiemMatHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm mặt hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlLoaiHang_ThongTin);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtTongSoLuong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.txtMaMatHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(481, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 339);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // pnlLoaiHang_ThongTin
            // 
            this.pnlLoaiHang_ThongTin.Controls.Add(this.cbbLoaiHang_ThongTin);
            this.pnlLoaiHang_ThongTin.Controls.Add(this.label6);
            this.pnlLoaiHang_ThongTin.Location = new System.Drawing.Point(6, 239);
            this.pnlLoaiHang_ThongTin.Name = "pnlLoaiHang_ThongTin";
            this.pnlLoaiHang_ThongTin.Size = new System.Drawing.Size(342, 51);
            this.pnlLoaiHang_ThongTin.TabIndex = 16;
            this.pnlLoaiHang_ThongTin.Visible = false;
            // 
            // cbbLoaiHang_ThongTin
            // 
            this.cbbLoaiHang_ThongTin.AllowDrop = true;
            this.cbbLoaiHang_ThongTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHang_ThongTin.FormattingEnabled = true;
            this.cbbLoaiHang_ThongTin.Location = new System.Drawing.Point(130, 9);
            this.cbbLoaiHang_ThongTin.Name = "cbbLoaiHang_ThongTin";
            this.cbbLoaiHang_ThongTin.Size = new System.Drawing.Size(198, 28);
            this.cbbLoaiHang_ThongTin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
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
            this.btnXacNhan.Location = new System.Drawing.Point(286, 296);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 29);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Visible = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(106, 296);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 29);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuong.Location = new System.Drawing.Point(139, 202);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.ReadOnly = true;
            this.txtTongSoLuong.Size = new System.Drawing.Size(201, 28);
            this.txtTongSoLuong.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tổng số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã mặt hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHinhAnh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pcbHinhAnh);
            this.panel3.Location = new System.Drawing.Point(345, 23);
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
            this.btnHinhAnh.Visible = false;
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
            this.txtGia.Location = new System.Drawing.Point(136, 116);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(201, 28);
            this.txtGia.TabIndex = 5;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(136, 71);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.ReadOnly = true;
            this.txtTenMatHang.Size = new System.Drawing.Size(201, 28);
            this.txtTenMatHang.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(136, 159);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(201, 28);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatHang.Location = new System.Drawing.Point(136, 28);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.ReadOnly = true;
            this.txtMaMatHang.Size = new System.Drawing.Size(201, 28);
            this.txtMaMatHang.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvLoHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 270);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lô hàng";
            // 
            // dgvLoHang
            // 
            this.dgvLoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaLoHang,
            this.clmSoLuong,
            this.clmHanSuDung,
            this.clmNhaCungCap});
            this.dgvLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoHang.Location = new System.Drawing.Point(3, 23);
            this.dgvLoHang.Name = "dgvLoHang";
            this.dgvLoHang.RowHeadersWidth = 51;
            this.dgvLoHang.RowTemplate.Height = 24;
            this.dgvLoHang.Size = new System.Drawing.Size(1025, 244);
            this.dgvLoHang.TabIndex = 0;
            // 
            // clmMaLoHang
            // 
            this.clmMaLoHang.DataPropertyName = "MaLoHang";
            this.clmMaLoHang.HeaderText = "Mã Lô Hàng";
            this.clmMaLoHang.MinimumWidth = 6;
            this.clmMaLoHang.Name = "clmMaLoHang";
            this.clmMaLoHang.ReadOnly = true;
            // 
            // clmSoLuong
            // 
            this.clmSoLuong.DataPropertyName = "SoLuong";
            this.clmSoLuong.HeaderText = "Số Lượng";
            this.clmSoLuong.MinimumWidth = 6;
            this.clmSoLuong.Name = "clmSoLuong";
            this.clmSoLuong.ReadOnly = true;
            // 
            // clmHanSuDung
            // 
            this.clmHanSuDung.DataPropertyName = "HanSuDung";
            this.clmHanSuDung.HeaderText = "Hạn Sử Dụng";
            this.clmHanSuDung.MinimumWidth = 6;
            this.clmHanSuDung.Name = "clmHanSuDung";
            this.clmHanSuDung.ReadOnly = true;
            // 
            // clmNhaCungCap
            // 
            this.clmNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.clmNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.clmNhaCungCap.MinimumWidth = 6;
            this.clmNhaCungCap.Name = "clmNhaCungCap";
            this.clmNhaCungCap.ReadOnly = true;
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHang.Location = new System.Drawing.Point(6, 28);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(168, 34);
            this.btnThemMatHang.TabIndex = 0;
            this.btnThemMatHang.Text = "Thêm mặt hàng";
            this.btnThemMatHang.UseVisualStyleBackColor = false;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // btnXoaMatHang
            // 
            this.btnXoaMatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMatHang.Location = new System.Drawing.Point(6, 110);
            this.btnXoaMatHang.Name = "btnXoaMatHang";
            this.btnXoaMatHang.Size = new System.Drawing.Size(168, 36);
            this.btnXoaMatHang.TabIndex = 1;
            this.btnXoaMatHang.Text = "Xoá mặt hàng";
            this.btnXoaMatHang.UseVisualStyleBackColor = false;
            this.btnXoaMatHang.Click += new System.EventHandler(this.btnXoaMatHang_Click);
            // 
            // btnSuaMatHang
            // 
            this.btnSuaMatHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuaMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMatHang.Location = new System.Drawing.Point(6, 68);
            this.btnSuaMatHang.Name = "btnSuaMatHang";
            this.btnSuaMatHang.Size = new System.Drawing.Size(168, 36);
            this.btnSuaMatHang.TabIndex = 2;
            this.btnSuaMatHang.Text = "Chỉnh sửa mặt hàng";
            this.btnSuaMatHang.UseVisualStyleBackColor = false;
            this.btnSuaMatHang.Click += new System.EventHandler(this.btnSuaMatHang_Click);
            // 
            // groupMatHang
            // 
            this.groupMatHang.Controls.Add(this.btnSuaMatHang);
            this.groupMatHang.Controls.Add(this.btnThemMatHang);
            this.groupMatHang.Controls.Add(this.btnXoaMatHang);
            this.groupMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatHang.Location = new System.Drawing.Point(253, 211);
            this.groupMatHang.Name = "groupMatHang";
            this.groupMatHang.Size = new System.Drawing.Size(198, 152);
            this.groupMatHang.TabIndex = 3;
            this.groupMatHang.TabStop = false;
            this.groupMatHang.Text = "Thao tác mặt hàng";
            // 
            // groupLoaiHang
            // 
            this.groupLoaiHang.Controls.Add(this.btnSuaLoaiHang);
            this.groupLoaiHang.Controls.Add(this.btnThemLoaiHang);
            this.groupLoaiHang.Controls.Add(this.btnXoaLoaiHang);
            this.groupLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLoaiHang.Location = new System.Drawing.Point(253, 39);
            this.groupLoaiHang.Name = "groupLoaiHang";
            this.groupLoaiHang.Size = new System.Drawing.Size(198, 149);
            this.groupLoaiHang.TabIndex = 4;
            this.groupLoaiHang.TabStop = false;
            this.groupLoaiHang.Text = "Thao tác loại hàng";
            // 
            // btnSuaLoaiHang
            // 
            this.btnSuaLoaiHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuaLoaiHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiHang.Location = new System.Drawing.Point(6, 66);
            this.btnSuaLoaiHang.Name = "btnSuaLoaiHang";
            this.btnSuaLoaiHang.Size = new System.Drawing.Size(168, 36);
            this.btnSuaLoaiHang.TabIndex = 5;
            this.btnSuaLoaiHang.Text = "Chỉnh sửa loại hàng";
            this.btnSuaLoaiHang.UseVisualStyleBackColor = false;
            this.btnSuaLoaiHang.Click += new System.EventHandler(this.btnSuaLoaiHang_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemLoaiHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiHang.Location = new System.Drawing.Point(6, 26);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(168, 34);
            this.btnThemLoaiHang.TabIndex = 3;
            this.btnThemLoaiHang.Text = "Thêm loại hàng";
            this.btnThemLoaiHang.UseVisualStyleBackColor = false;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // btnXoaLoaiHang
            // 
            this.btnXoaLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaLoaiHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiHang.Location = new System.Drawing.Point(6, 108);
            this.btnXoaLoaiHang.Name = "btnXoaLoaiHang";
            this.btnXoaLoaiHang.Size = new System.Drawing.Size(168, 36);
            this.btnXoaLoaiHang.TabIndex = 4;
            this.btnXoaLoaiHang.Text = "Xoá loại hàng";
            this.btnXoaLoaiHang.UseVisualStyleBackColor = false;
            this.btnXoaLoaiHang.Click += new System.EventHandler(this.btnXoaLoaiHang_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.tuỳChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapTaiKhoan,
            this.toolStripSeparator1,
            this.mnuDangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // mnuCapTaiKhoan
            // 
            this.mnuCapTaiKhoan.Name = "mnuCapTaiKhoan";
            this.mnuCapTaiKhoan.Size = new System.Drawing.Size(213, 26);
            this.mnuCapTaiKhoan.Text = "Cấp tài khoản mới";
            this.mnuCapTaiKhoan.Click += new System.EventHandler(this.mnuCapTaiKhoan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(213, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // tuỳChọnToolStripMenuItem
            // 
            this.tuỳChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReport});
            this.tuỳChọnToolStripMenuItem.Name = "tuỳChọnToolStripMenuItem";
            this.tuỳChọnToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tuỳChọnToolStripMenuItem.Text = "Tuỳ chọn";
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(146, 26);
            this.mnuReport.Text = "Báo cáo";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1056, 665);
            this.Controls.Add(this.groupLoaiHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupMatHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý tạp hoá";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLoaiHang_ThongTin.ResumeLayout(false);
            this.pnlLoaiHang_ThongTin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoHang)).EndInit();
            this.groupMatHang.ResumeLayout(false);
            this.groupLoaiHang.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMatHang;
        private System.Windows.Forms.ComboBox cbbLoaiHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.PictureBox pcbHinhAnh;
        private System.Windows.Forms.DataGridView dgvLoHang;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHinhAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemMatHang;
        private System.Windows.Forms.ComboBox cbbLoaiHang_ThongTin;
        private System.Windows.Forms.Button btnSuaMatHang;
        private System.Windows.Forms.Button btnXoaMatHang;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.GroupBox groupMatHang;
        private System.Windows.Forms.GroupBox groupLoaiHang;
        private System.Windows.Forms.Button btnSuaLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.Button btnXoaLoaiHang;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlLoaiHang_ThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNhaCungCap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tuỳChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCapTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
    }
}

