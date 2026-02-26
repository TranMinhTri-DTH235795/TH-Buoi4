namespace QuanLyBanHang.Forms
{
    partial class frmNhanhVien
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
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtMatKhau = new TextBox();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            txtDienThoai = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(916, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(99, 29);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(916, 63);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(99, 29);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(916, 28);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 29);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(787, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(787, 63);
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
            btnLuu.Location = new Point(787, 28);
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
            btnXoa.Location = new Point(672, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(672, 63);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(-3, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1030, 373);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1024, 347);
            dataGridView.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(672, 28);
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
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(131, 106);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(214, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và tên (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(131, 31);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(214, 27);
            txtHoVaTen.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenDangNhap);
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
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Location = new Point(-3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 139);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(500, 106);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(151, 28);
            cboQuyenHan.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 109);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 19;
            label6.Text = "Quyền hạn (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 75);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 18;
            label5.Text = "Mật khẩu (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(501, 72);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(150, 27);
            txtMatKhau.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 37);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 16;
            label4.Text = "Tên đăng nhập (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(501, 34);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(150, 27);
            txtTenDangNhap.TabIndex = 15;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(131, 69);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(214, 27);
            txtDienThoai.TabIndex = 4;
            // 
            // frmNhanhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 524);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanhVien";
            Text = "Nhân Viên";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnThem;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private Label label1;
        private TextBox txtHoVaTen;
        private GroupBox groupBox1;
        private TextBox txtDienThoai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private Label label4;
        private TextBox txtTenDangNhap;
        private ComboBox cboQuyenHan;
        private Label label6;
        private Label label5;
        private TextBox txtMatKhau;
    }
}