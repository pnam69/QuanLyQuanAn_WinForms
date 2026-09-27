using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmThemBan : Form
    {
        public FrmThemBan()
        {
            InitializeComponent();

            Load += FrmThemBan_Load;
        }

        private async void FrmThemBan_Load(
            object? sender,
            EventArgs e)
        {
            using var db = DbContextFactory.Create();

            var danhSachTang = await db.Tangs
                .OrderBy(x => x.MaTang)
                .AsNoTracking()
                .ToListAsync();

            cboTang.DataSource = danhSachTang;
            cboTang.DisplayMember = "TenTang";
            cboTang.ValueMember = "MaTang";

            numSoGhe.Value = 4;
        }

        private async void btnThem_Click(
            object sender,
            EventArgs e)
        {
            string soBan = txtSoBan.Text.Trim();

            if (string.IsNullOrWhiteSpace(soBan))
            {
                MessageBox.Show(
                    "Số bàn không được để trống.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboTang.SelectedItem is not Tang tang)
            {
                MessageBox.Show(
                    "Vui lòng chọn tầng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int soGhe = Convert.ToInt32(numSoGhe.Value);

            using var db = DbContextFactory.Create();

            bool daTonTai = await db.Bans.AnyAsync(
                x => x.MaTang == tang.MaTang &&
                     x.SoBan == soBan);

            if (daTonTai)
            {
                MessageBox.Show(
                    $"Bàn {soBan} đã tồn tại ở {tang.TenTang}.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var ban = new Ban
            {
                SoBan = soBan,
                MaTang = tang.MaTang,
                SoGhe = soGhe,
                TrangThai = "Trống",
                ViTriX = 20,
                ViTriY = 20
            };

            db.Bans.Add(ban);

            await db.SaveChangesAsync();

            MessageBox.Show(
                $"Đã thêm Bàn {soBan} vào {tang.TenTang}.",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}