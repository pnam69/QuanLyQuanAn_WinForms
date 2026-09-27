using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private int maDM = 0;
        public FrmDanhMuc()
        {
            InitializeComponent();
            LoadTrangThai();
            LoadDanhMuc();

        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Ngừng hoạt động");

            cboTrangThai.SelectedIndex = 0;
        }

        private async void LoadDanhMuc()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.DanhMucs
                .AsNoTracking()
                .OrderBy(x => x.MaDM)
                .ToListAsync();

            dgvDanhMuc.DataSource = danhSach;

            if (dgvDanhMuc.Columns["MonAns"] != null)
            {
                dgvDanhMuc.Columns["MonAns"].Visible = false;
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenDM = txtTenDM.Text.Trim();
            string trangThai = cboTrangThai.Text;

            if (string.IsNullOrWhiteSpace(tenDM))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên danh mục.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            var danhMuc = new DanhMuc
            {
                TenDM = tenDM,
                TrangThai = trangThai
            };

            db.DanhMucs.Add(danhMuc);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Thêm danh mục thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadDanhMuc();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (maDM == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tenDM = txtTenDM.Text.Trim();
            string trangThai = cboTrangThai.Text;

            if (string.IsNullOrWhiteSpace(tenDM))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên danh mục.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            var danhMuc = await db.DanhMucs
                .FirstOrDefaultAsync(x => x.MaDM == maDM);

            if (danhMuc == null)
            {
                MessageBox.Show(
                    "Không tìm thấy danh mục.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            danhMuc.TenDM = tenDM;
            danhMuc.TrangThai = trangThai;

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật danh mục thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadDanhMuc();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDM == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa danh mục này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = DbContextFactory.Create();

            bool dangDuocSuDung = await db.MonAns
                .AnyAsync(x => x.MaDM == maDM);

            if (dangDuocSuDung)
            {
                MessageBox.Show(
                    "Không thể xóa danh mục vì đang có món ăn sử dụng danh mục này.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var danhMuc = await db.DanhMucs
                .FirstOrDefaultAsync(x => x.MaDM == maDM);

            if (danhMuc == null)
            {
                return;
            }

            db.DanhMucs.Remove(danhMuc);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Xóa danh mục thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadDanhMuc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhMuc();
        }

        private void ClearForm()
        {
            maDM = 0;

            txtTenDM.Clear();

            if (cboTrangThai.Items.Count > 0)
            {
                cboTrangThai.SelectedIndex = 0;
            }

            dgvDanhMuc.ClearSelection();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvDanhMuc.Rows[e.RowIndex];

            maDM = Convert.ToInt32(row.Cells["MaDM"].Value);
            txtTenDM.Text = row.Cells["TenDM"].Value?.ToString() ?? "";
            cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";
        }
    }
}
