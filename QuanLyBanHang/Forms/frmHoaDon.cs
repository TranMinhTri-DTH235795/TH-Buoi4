using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyBanHang.Data.HoaDon;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa)

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
            frmHoaDon_Load(sender, e); // Tải lại dữ liệu sau khi thêm mới hóa đơn
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
            frmHoaDon_Load(sender, e); // Tải lại dữ liệu sau khi sửa hóa đơn
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên Grid chưa
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy ID hóa đơn từ dòng đang chọn
            int hoaDonId = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);

            // 3. Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này và tất cả các mặt hàng liên quan không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 4. Tìm hóa đơn trong cơ sở dữ liệu
                    var hoaDon = context.HoaDon.Find(hoaDonId);

                    if (hoaDon != null)
                    {
                        // 5. Xóa các chi tiết của hóa đơn này trước (để tránh lỗi khóa ngoại)
                        var chiTiets = context.HoaDon_ChiTiet.Where(ct => ct.HoaDonID == hoaDonId).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(chiTiets);

                        // 6. Xóa hóa đơn chính
                        context.HoaDon.Remove(hoaDon);

                        // Lưu tất cả thay đổi vào CSDL
                        context.SaveChanges();

                        MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 7. Gọi lại hàm Load để làm mới danh sách hiển thị
                        frmHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
