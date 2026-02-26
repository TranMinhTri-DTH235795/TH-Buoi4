using QuanLyBanHang.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmKhachHang : Form
    {
        // Chỉ khai báo 1 lần duy nhất ở đây
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            // Kiểm tra an toàn nếu txtDienThoai tồn tại
            if (txtDienThoai != null) txtDienThoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                BatTatChucNang(false);
                // Load dữ liệu từ Database
                var dsKhachHang = context.KhachHang.ToList();

                BindingSource bs = new BindingSource();
                bs.DataSource = dsKhachHang;

                // Xóa và thiết lập Binding
                txtHoVaTen.DataBindings.Clear();
                txtHoVaTen.DataBindings.Add("Text", bs, "HoVaTen", true, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bs, "DiaChi", true, DataSourceUpdateMode.Never);

                if (txtDienThoai != null)
                {
                    txtDienThoai.DataBindings.Clear();
                    txtDienThoai.DataBindings.Add("Text", bs, "DienThoai", true, DataSourceUpdateMode.Never);
                }

                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDiaChi.Clear();
            if (txtDienThoai != null) txtDienThoai.Clear();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID từ dòng đang chọn trên lưới
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            if (xuLyThem)
            {
                KhachHang kh = new KhachHang
                {
                    HoVaTen = txtHoVaTen.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai?.Text
                };
                context.KhachHang.Add(kh);
            }
            else
            {
                var kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    if (txtDienThoai != null) kh.DienThoai = txtDienThoai.Text;
                }
            }

            context.SaveChanges();
            frmKhachHang_Load(sender, e); // Tải lại lưới
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var kh = context.KhachHang.Find(id);
                if (kh != null) context.KhachHang.Remove(kh);
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => frmKhachHang_Load(sender, e);

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}