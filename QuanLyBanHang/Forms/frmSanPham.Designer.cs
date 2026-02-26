namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            txtMoTa = new TextBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            txtTenSanPham = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 146);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 19;
            label6.Text = "Mô tả sản phẩm (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 75);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 18;
            label5.Text = "Đơn giá (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 37);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 16;
            label4.Text = "Số lượng (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1139, 238);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(174, 69);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(185, 28);
            cboHangSanXuat.TabIndex = 26;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(174, 35);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(185, 28);
            cboLoaiSanPham.TabIndex = 25;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(489, 73);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(178, 27);
            numDonGia.TabIndex = 24;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(489, 35);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(178, 27);
            numSoLuong.TabIndex = 23;
            numSoLuong.ThousandsSeparator = true;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(867, 37);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(99, 29);
            btnDoiAnh.TabIndex = 22;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(692, 31);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(135, 155);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 21;
            picHinhAnh.TabStop = false;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(174, 146);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(493, 27);
            txtMoTa.TabIndex = 20;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1015, 192);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(99, 29);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(910, 192);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(99, 29);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(805, 192);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 29);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(700, 192);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(595, 192);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(99, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(489, 192);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(99, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(384, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(279, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(174, 192);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 72);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 5;
            label3.Text = "Hãng sản xuất (*):";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(174, 106);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(493, 27);
            txtTenSanPham.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Phân loại (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(-3, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1139, 274);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STT, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1133, 248);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // STT
            // 
            STT.DataPropertyName = "ID";
            STT.HeaderText = "ID";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại ";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất ";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm ";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá ";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh ";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 524);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmSanPham";
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label3;
        private TextBox txtTenSanPham;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}