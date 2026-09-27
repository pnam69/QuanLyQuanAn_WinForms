using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmMonAn : Form
    {
        private int maMon = 0;
        public FrmMonAn()
        {
            InitializeComponent();

            LoadTrangThai();
            LoadDanhMuc();
            LoadMonAn();

            dgvMonAn.CellClick += dgvMonAn_CellClick;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Đang bán");
            cboTrangThai.Items.Add("Ngừng bán");

            cboTrangThai.SelectedIndex = 0;
        }

        private async void LoadDanhMuc()
        {
            using var db = DbContextFactory.Create();

            var danhMucList = await db.DanhMucs
                .AsNoTracking()
                .Where(x => x.TrangThai == "Hoạt động")
                .OrderBy(x => x.TenDM)
                .ToListAsync();

            cboDanhMuc.DataSource = danhMucList;
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
        }

        private async void LoadMonAn()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.MonAns
                .AsNoTracking()
                .Include(x => x.DanhMuc)
                .OrderBy(x => x.MaMon)
                .Select(x => new
                {
                    x.MaMon,
                    x.TenMon,
                    x.DonGia,
                    TenDanhMuc = x.DanhMuc != null
                        ? x.DanhMuc.TenDM
                        : "",
                    x.TrangThai
                })
                .ToListAsync();

            dgvMonAn.DataSource = danhSach;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên món.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maDM = Convert.ToInt32(cboDanhMuc.SelectedValue);

            using var db = DbContextFactory.Create();

            var monAn = new MonAn
            {
                TenMon = tenMon,
                DonGia = numDonGia.Value,
                MaDM = maDM,
                TrangThai = cboTrangThai.Text
            };

            db.MonAns.Add(monAn);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Thêm món ăn thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadMonAn();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (maMon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn món ăn cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tenMon = txtTenMon.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên món.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maDM = Convert.ToInt32(cboDanhMuc.SelectedValue);

            using var db = DbContextFactory.Create();

            var monAn = await db.MonAns
                .FirstOrDefaultAsync(x => x.MaMon == maMon);

            if (monAn == null)
            {
                MessageBox.Show(
                    "Không tìm thấy món ăn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            monAn.TenMon = tenMon;
            monAn.DonGia = numDonGia.Value;
            monAn.MaDM = maDM;
            monAn.TrangThai = cboTrangThai.Text;

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật món ăn thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadMonAn();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (maMon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn món ăn cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa món ăn này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = DbContextFactory.Create();

            bool daDuocDat = await db.ChiTietDonHangs
                .AnyAsync(x => x.MaMon == maMon);

            if (daDuocDat)
            {
                MessageBox.Show(
                    "Không thể xóa món ăn vì món này đã xuất hiện trong đơn hàng.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var monAn = await db.MonAns
                .FirstOrDefaultAsync(x => x.MaMon == maMon);

            if (monAn == null)
            {
                return;
            }

            db.MonAns.Remove(monAn);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Xóa món ăn thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadMonAn();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhMuc();
            LoadMonAn();
        }

        private void ClearForm()
        {
            maMon = 0;

            txtTenMon.Clear();
            numDonGia.Value = 0;

            if (cboDanhMuc.Items.Count > 0)
            {
                cboDanhMuc.SelectedIndex = 0;
            }

            if (cboTrangThai.Items.Count > 0)
            {
                cboTrangThai.SelectedIndex = 0;
            }

            dgvMonAn.ClearSelection();
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvMonAn.Rows[e.RowIndex];

            maMon = Convert.ToInt32(row.Cells["MaMon"].Value);

            txtTenMon.Text =
                row.Cells["TenMon"].Value?.ToString() ?? "";

            if (row.Cells["DonGia"].Value != null)
            {
                numDonGia.Value =
                    Convert.ToDecimal(row.Cells["DonGia"].Value);
            }

            cboTrangThai.Text =
                row.Cells["TrangThai"].Value?.ToString() ?? "";

            using var db = DbContextFactory.Create();

            var monAn = db.MonAns
                .AsNoTracking()
                .FirstOrDefault(x => x.MaMon == maMon);

            if (monAn != null)
            {
                cboDanhMuc.SelectedValue = monAn.MaDM;
            }
        }
    }
}
