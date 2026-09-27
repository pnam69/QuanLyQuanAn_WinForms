using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmBan : Form
    {
        private readonly Color MauTrong = Color.LightGreen;
        private readonly Color MauDangPhucVu = Color.LightCoral;
        private readonly Color MauDaDat = Color.LightBlue;
        private const int KichThuocBanRong = 170;
        private const int KichThuocBanCao = 120;

        private const int KhoangCachBan = 20;
        private const int LeTrai = 20;
        private const int LeTren = 20;
        private const int KichThuocLuoi = 10;
        private bool dangKeo = false;
        private Point viTriKeo;
        private Point viTriBanTruocKhiKeo;
        private bool dangTaiTang = false;
        private bool dangTaiBan = false;
        private Panel? banDangKeo;
        private Panel? banDangChon;
        private Ban? banDangChonData;

        public FrmBan()
        {
            InitializeComponent();

            // Không gọi async trực tiếp trong constructor
            Shown += async (_, _) => await LoadTang();
        }

        private async Task LoadTang()
        {
            if (dangTaiTang)
                return;

            dangTaiTang = true;

            try
            {
                using var db = DbContextFactory.Create();

                var danhSachTang = await db.Tangs
                    .OrderBy(x => x.MaTang)
                    .AsNoTracking()
                    .ToListAsync();

                cboTang.DataSource = null;
                cboTang.DisplayMember = "TenTang";
                cboTang.ValueMember = "MaTang";
                cboTang.DataSource = danhSachTang;

                if (danhSachTang.Count > 0)
                {
                    cboTang.SelectedIndex = 0;
                }
            }
            finally
            {
                dangTaiTang = false;
            }

            await LoadBan();
        }

        private async void cboTang_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (dangTaiTang)
                return;
            await LoadBan();
        }

        private async Task LoadBan()
        {
            if (dangTaiBan)
                return;

            if (cboTang.SelectedItem is not Tang tang)
                return;

            dangTaiBan = true;

            try
            {
                pnlBan.Controls.Clear();

                banDangChon = null;
                banDangChonData = null;

                lblTieuDe.Text =
                    $"SƠ ĐỒ {tang.TenTang.ToUpper()}";

                using var db = DbContextFactory.Create();

                var danhSachBan = await db.Bans
                    .Where(x => x.MaTang == tang.MaTang)
                    .OrderBy(x => x.SoBan)
                    .AsNoTracking()
                    .ToListAsync();

                foreach (var ban in danhSachBan)
                {
                    Panel pnl = TaoPanelBan(ban);

                    pnlBan.Controls.Add(pnl);
                }

                CapNhatThongKe(danhSachBan);
            }
            finally
            {
                dangTaiBan = false;
            }
        }

        private Panel TaoPanelBan(Ban ban)
        {
            Panel pnl = new Panel
            {
                Width = KichThuocBanRong,
                Height = KichThuocBanCao,

                Left = ban.ViTriX,
                Top = ban.ViTriY,

                Tag = ban,

                BorderStyle = BorderStyle.FixedSingle,

                Cursor = chkChinhSua.Checked
                    ? Cursors.SizeAll
                    : Cursors.Hand
            };

            Label lblSoBan = new Label
            {
                Text = $"BÀN {ban.SoBan}",
                Dock = DockStyle.Top,
                Height = 35,

                TextAlign = ContentAlignment.MiddleCenter,

                Font = new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold),

                BackColor = Color.Transparent
            };

            Label lblSoGhe = new Label
            {
                Text = $"🪑 {ban.SoGhe} ghế",
                Dock = DockStyle.Top,
                Height = 25,

                TextAlign = ContentAlignment.MiddleCenter,

                BackColor = Color.Transparent
            };

            Label lblTrangThai = new Label
            {
                Text = ban.TrangThai,
                Dock = DockStyle.Fill,

                TextAlign = ContentAlignment.MiddleCenter,

                BackColor = Color.Transparent
            };

            pnl.Controls.Add(lblTrangThai);
            pnl.Controls.Add(lblSoGhe);
            pnl.Controls.Add(lblSoBan);

            DoiMauBan(pnl, ban);

            pnl.MouseDown += Ban_MouseDown;
            pnl.MouseMove += Ban_MouseMove;
            pnl.MouseUp += Ban_MouseUp;
            pnl.MouseClick += Ban_MouseClick;
            pnl.DoubleClick += Ban_DoubleClick;

            lblSoBan.MouseDown += Ban_MouseDown;
            lblSoBan.MouseMove += Ban_MouseMove;
            lblSoBan.MouseUp += Ban_MouseUp;
            lblSoBan.MouseClick += Ban_MouseClick;
            lblSoBan.DoubleClick += Ban_DoubleClick;

            lblSoGhe.MouseDown += Ban_MouseDown;
            lblSoGhe.MouseMove += Ban_MouseMove;
            lblSoGhe.MouseUp += Ban_MouseUp;
            lblSoGhe.MouseClick += Ban_MouseClick;
            lblSoGhe.DoubleClick += Ban_DoubleClick;

            lblTrangThai.MouseDown += Ban_MouseDown;
            lblTrangThai.MouseMove += Ban_MouseMove;
            lblTrangThai.MouseUp += Ban_MouseUp;
            lblTrangThai.MouseClick += Ban_MouseClick;
            lblTrangThai.DoubleClick += Ban_DoubleClick;

            return pnl;
        }
        private async void Ban_DoubleClick(
            object? sender,
            EventArgs e)
        {
            if (chkChinhSua.Checked)
                return;

            if (sender is not Control control)
                return;

            Panel? panel = control as Panel;

            if (panel == null)
                panel = control.Parent as Panel;

            if (panel?.Tag is not Ban ban)
                return;

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .AsNoTracking()
                .Where(x =>
                    x.MaBan == ban.MaBan &&
                    x.TrangThai == "Đang phục vụ")
                .OrderByDescending(x => x.MaDon)
                .FirstOrDefaultAsync();

            if (donHang != null)
            {
                using var frm =
                    new FrmChiTietDonHang(
                        donHang.MaDon);

                frm.ShowDialog();

                await LoadBan();
            }
            else
            {
                MessageBox.Show(
                    $"Bàn {ban.SoBan}\n\n" +
                    $"Số ghế: {ban.SoGhe}\n" +
                    $"Trạng thái: {ban.TrangThai}",
                    "Thông tin bàn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void DoiMauBan(Panel pnl, Ban ban)
        {
            if (banDangChon == pnl)
            {
                pnl.BackColor = Color.Gold;
                return;
            }

            pnl.BackColor = LayMauTrangThai(ban.TrangThai);
        }

        private Color LayMauTrangThai(string trangThai)
        {
            return trangThai switch
            {
                "Trống" => MauTrong,
                "Đang phục vụ" => MauDangPhucVu,
                "Đã đặt" => MauDaDat,
                _ => Color.LightGray
            };
        }

        private bool BanBiTrungViTri(Panel banDangKiemTra)
        {
            Rectangle viTriBan = new Rectangle(
                banDangKiemTra.Left,
                banDangKiemTra.Top,
                banDangKiemTra.Width,
                banDangKiemTra.Height);

            foreach (Control control in pnlBan.Controls)
            {
                if (control is not Panel panel)
                    continue;

                // Bỏ qua chính bàn đang kéo
                if (panel == banDangKiemTra)
                    continue;

                Rectangle viTriBanKhac = new Rectangle(
                    panel.Left,
                    panel.Top,
                    panel.Width,
                    panel.Height);

                if (viTriBan.IntersectsWith(viTriBanKhac))
                {
                    return true;
                }
            }

            return false;
        }

        private void ChonBan(Panel pnl, Ban ban)
        {
            // Bỏ chọn bàn cũ
            if (banDangChon != null &&
                banDangChon.Tag is Ban oldBan)
            {
                banDangChon.BorderStyle =
                    BorderStyle.FixedSingle;

                DoiMauBan(
                    banDangChon,
                    oldBan);
            }

            // Chọn bàn mới
            banDangChon = pnl;
            banDangChonData = ban;

            pnl.BorderStyle =
                BorderStyle.Fixed3D;

            pnl.BackColor = Color.Gold;
        }

        private void Ban_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is not Control control)
                return;

            Panel? pnl = control as Panel;

            if (pnl == null)
                pnl = control.Parent as Panel;

            if (pnl == null)
                return;

            if (pnl.Tag is not Ban ban)
                return;

            ChonBan(pnl, ban);
        }

        private Point TimViTriBanMoi()
        {
            int panelWidth = pnlBan.ClientSize.Width;
            int panelHeight = pnlBan.ClientSize.Height;

            for (int y = LeTren;
                 y + KichThuocBanCao <= panelHeight;
                 y += KichThuocBanCao + KhoangCachBan)
            {
                for (int x = LeTrai;
                     x + KichThuocBanRong <= panelWidth;
                     x += KichThuocBanRong + KhoangCachBan)
                {
                    Rectangle viTriMoi = new Rectangle(
                        x,
                        y,
                        KichThuocBanRong,
                        KichThuocBanCao);

                    if (ViTriKhongBiTrung(viTriMoi))
                    {
                        return new Point(x, y);
                    }
                }
            }

            // Không còn chỗ trống
            return new Point(-1, -1);
        }

        private bool ViTriKhongBiTrung(Rectangle viTriMoi)
        {
            foreach (Control control in pnlBan.Controls)
            {
                if (control is not Panel panel)
                    continue;

                Rectangle viTriBanHienTai = new Rectangle(
                    panel.Left,
                    panel.Top,
                    panel.Width,
                    panel.Height);

                if (viTriMoi.IntersectsWith(viTriBanHienTai))
                {
                    return false;
                }
            }

            return true;
        }

        private void Ban_MouseDown(
            object? sender,
            MouseEventArgs e)
        {
            if (!chkChinhSua.Checked)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            if (sender is not Control control)
                return;

            Panel? panel = control as Panel;

            if (panel == null)
                panel = control.Parent as Panel;

            if (panel == null)
                return;

            if (panel.Tag is not Ban ban)
                return;

            ChonBan(panel, ban);

            banDangKeo = panel;
            dangKeo = true;

            // Lưu vị trí cũ
            viTriBanTruocKhiKeo = new Point(
                panel.Left,
                panel.Top);

            // Vị trí chuột bên trong panel
            Point mouseOnPanel =
                pnlBan.PointToClient(
                    Control.MousePosition);

            viTriKeo = new Point(
                mouseOnPanel.X - panel.Left,
                mouseOnPanel.Y - panel.Top);

            panel.BringToFront();
        }

        private void Ban_MouseMove(
            object? sender,
            MouseEventArgs e)
        {
            if (!dangKeo ||
                banDangKeo == null ||
                !chkChinhSua.Checked)
            {
                return;
            }

            Point mouseOnPanel =
                pnlBan.PointToClient(
                    Control.MousePosition);

            int x =
                mouseOnPanel.X -
                viTriKeo.X;

            int y =
                mouseOnPanel.Y -
                viTriKeo.Y;

            // Snap vào grid
            x = SnapToGrid(x);
            y = SnapToGrid(y);

            // Không cho bàn ra ngoài panel
            int maxX =
                pnlBan.ClientSize.Width -
                banDangKeo.Width;

            int maxY =
                pnlBan.ClientSize.Height -
                banDangKeo.Height;

            x = Math.Max(0, Math.Min(x, maxX));
            y = Math.Max(0, Math.Min(y, maxY));

            banDangKeo.Left = x;
            banDangKeo.Top = y;
        }

        private void Ban_MouseUp(
            object? sender,
            MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (!dangKeo || banDangKeo == null)
            {
                dangKeo = false;
                banDangKeo = null;
                return;
            }

            Panel panel = banDangKeo;

            // Snap lần cuối
            int x = SnapToGrid(panel.Left);
            int y = SnapToGrid(panel.Top);

            // Đảm bảo không vượt khỏi panel
            int maxX =
                pnlBan.ClientSize.Width -
                panel.Width;

            int maxY =
                pnlBan.ClientSize.Height -
                panel.Height;

            x = Math.Max(0, Math.Min(x, maxX));
            y = Math.Max(0, Math.Min(y, maxY));

            panel.Left = x;
            panel.Top = y;

            // Kiểm tra chồng bàn
            if (BanBiTrungViTri(panel))
            {
                panel.Left = viTriBanTruocKhiKeo.X;
                panel.Top = viTriBanTruocKhiKeo.Y;

                MessageBox.Show(
                    "Không thể đặt bàn chồng lên bàn khác.",
                    "Vị trí không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            dangKeo = false;
            banDangKeo = null;
        }

        private async void btnLuuViTri_Click(
            object? sender,
            EventArgs e)
        {
            using var db = DbContextFactory.Create();

            foreach (Control control in pnlBan.Controls)
            {
                if (control is not Panel panel)
                    continue;

                if (panel.Tag is not Ban ban)
                    continue;

                var banDb = await db.Bans
                    .FirstOrDefaultAsync(
                        x => x.MaBan == ban.MaBan);

                if (banDb == null)
                    continue;

                banDb.ViTriX = panel.Left;
                banDb.ViTriY = panel.Top;
            }

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Đã lưu vị trí các bàn.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private int SnapToGrid(int value)
        {
            return (int)Math.Round(
                (double)value / KichThuocLuoi) * KichThuocLuoi;
        }
        private async void btnThemBan_Click(object? sender, EventArgs e)
        {
            if (cboTang.SelectedItem is not Tang tang)
                return;

            using var frm = new FrmThemBan();

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            // Tìm vị trí trống trước khi LoadBan()
            Point viTriMoi = TimViTriBanMoi();

            if (viTriMoi.X < 0 || viTriMoi.Y < 0)
            {
                MessageBox.Show(
                    "Không còn đủ chỗ trống để đặt bàn mới.",
                    "Không thể đặt bàn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            // Lấy bàn vừa được tạo
            var banMoi = await db.Bans
                .Where(x => x.MaTang == tang.MaTang)
                .OrderByDescending(x => x.MaBan)
                .FirstOrDefaultAsync();

            if (banMoi == null)
                return;

            banMoi.ViTriX = viTriMoi.X;
            banMoi.ViTriY = viTriMoi.Y;

            await db.SaveChangesAsync();

            await LoadBan();
        }

        private async void btnXoaBan_Click(
            object? sender,
            EventArgs e)
        {
            if (banDangChonData == null)
            {
                MessageBox.Show(
                    "Hãy chọn một bàn trước khi xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Ban ban = banDangChonData;

            using var db = DbContextFactory.Create();

            DialogResult result =
                MessageBox.Show(
                    $"Bạn có chắc muốn xóa Bàn {ban.SoBan}?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            var banDb =
                await db.Bans.FindAsync(ban.MaBan);

            if (banDb == null)
                return;

            db.Bans.Remove(banDb);

            await db.SaveChangesAsync();

            banDangChon = null;
            banDangChonData = null;

            await LoadBan();
        }

        private async void btnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            await LoadBan();
        }

        private void chkChinhSua_CheckedChanged(object? sender, EventArgs e)
        {
            bool choPhepKeo = chkChinhSua.Checked;

            foreach (Control control in pnlBan.Controls)
            {
                control.Cursor = choPhepKeo
                    ? Cursors.SizeAll
                    : Cursors.Hand;
            }
        }



        private void CapNhatThongKe(
            List<Ban> danhSachBan)
        {
            int trong =
                danhSachBan.Count(
                    x => x.TrangThai == "Trống");

            int dangPhucVu =
                danhSachBan.Count(
                    x => x.TrangThai == "Đang phục vụ");

            int daDat =
                danhSachBan.Count(
                    x => x.TrangThai == "Đã đặt");

            lblThongKe.Text =
                $"Trống: {trong}    |    " +
                $"Đang phục vụ: {dangPhucVu}    |    " +
                $"Đã đặt: {daDat}";
        }

        private async void btnThemTang_Click(object sender, EventArgs e)
        {
            using var frm = new FrmThemTang();

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            await LoadTang();
        }

        private async void btnSuaTang_Click(object? sender, EventArgs e)
        {
            if (cboTang.SelectedItem is not Tang tang)
            {
                MessageBox.Show(
                    "Vui lòng chọn tầng cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var frm = new FrmThemTang(tang.MaTang);

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            await LoadTang();
        }

        private async void btnXoaTang_Click(object? sender, EventArgs e)
        {
            if (cboTang.SelectedItem is not Tang tang)
            {
                MessageBox.Show(
                    "Vui lòng chọn tầng cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            bool coBan = await db.Bans
                .AnyAsync(x => x.MaTang == tang.MaTang);

            if (coBan)
            {
                MessageBox.Show(
                    $"Không thể xóa {tang.TenTang} vì tầng này vẫn còn bàn.\n\n" +
                    "Hãy xóa các bàn thuộc tầng này trước.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa {tang.TenTang}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            var tangDb = await db.Tangs
                .FirstOrDefaultAsync(x => x.MaTang == tang.MaTang);

            if (tangDb == null)
                return;

            db.Tangs.Remove(tangDb);
            await db.SaveChangesAsync();

            await LoadTang();
        }
    }
}