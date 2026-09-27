using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmThemTang : Form
    {
        private readonly int? maTang;

        public FrmThemTang(int? maTang = null)
        {
            InitializeComponent();

            this.maTang = maTang;

            if (maTang.HasValue)
            {
                Text = "Sửa tầng";
                btnThem.Text = "Lưu";
            }
        }

        private async void FrmThemTang_Load(object? sender, EventArgs e)
        {
            if (!maTang.HasValue)
                return;

            using var db = DbContextFactory.Create();

            var tang = await db.Tangs
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.MaTang == maTang.Value);

            if (tang != null)
            {
                txtTenTang.Text = tang.TenTang;
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTang = txtTenTang.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenTang))
            {
                MessageBox.Show(
                    "Tên tầng không được để trống.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            bool daTonTai = await db.Tangs
                .AnyAsync(x =>
                    x.TenTang.ToLower() == tenTang.ToLower() &&
                    (!maTang.HasValue || x.MaTang != maTang.Value));

            if (daTonTai)
            {
                MessageBox.Show(
                    "Tên tầng này đã tồn tại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (maTang.HasValue)
            {
                var tang = await db.Tangs
                    .FirstOrDefaultAsync(x => x.MaTang == maTang.Value);

                if (tang == null)
                    return;

                tang.TenTang = tenTang;
            }
            else
            {
                db.Tangs.Add(new Tang
                {
                    TenTang = tenTang
                });
            }

            await db.SaveChangesAsync();

            MessageBox.Show(
                maTang.HasValue
                    ? "Đã cập nhật tên tầng."
                    : "Đã thêm tầng.",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}