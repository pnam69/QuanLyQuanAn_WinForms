using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using System.Diagnostics;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();

            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtpDenNgay.Value = DateTime.Today;

            Shown += async (_, _) => await TaiThongKe();
        }



        private async void btnHomNay_Click(object? sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today;
            dtpDenNgay.Value = DateTime.Today;
            await TaiThongKe();
        }

        private async void btnThangNay_Click(object? sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtpDenNgay.Value = DateTime.Today;
            await TaiThongKe();
        }

        private async void btnNamNay_Click(object? sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year, 1, 1);

            dtpDenNgay.Value = DateTime.Today;
            await TaiThongKe();
        }

        private async void btnThongKe_Click(object? sender, EventArgs e)
        {
            await TaiThongKe();
        }



        private async Task TaiThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

            if (tuNgay >= denNgay)
            {
                MessageBox.Show(
                    "Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using var db = DbContextFactory.Create();

                // 1. Lấy các khoản thanh toán thành công
                var thanhToans = await db.ThanhToans
                    .AsNoTracking()
                    .Where(x =>
                        x.TrangThai == "Đã thanh toán" &&
                        x.NgayThanhToan >= tuNgay &&
                        x.NgayThanhToan < denNgay)
                    .ToListAsync();

                decimal doanhThu = thanhToans.Sum(x => x.SoTien);

                var maDon = thanhToans
                    .Select(x => x.MaDon)
                    .Distinct()
                    .ToList();

                int soDon = maDon.Count;

                lblDoanhThu.Text = doanhThu.ToString("N0") + " ₫";
                lblSoDon.Text = soDon.ToString("N0");

                lblTrungBinh.Text = (soDon == 0
                    ? 0
                    : doanhThu / soDon).ToString("N0") + " ₫";

                // 2. Đơn đang phục vụ
                int donDangPhucVu = await db.DonHangs
                    .CountAsync(x =>
                        x.TrangThai == "Đang phục vụ" &&
                        x.NgayLap >= tuNgay &&
                        x.NgayLap < denNgay);

                lblDonDangPhucVu.Text =
                    donDangPhucVu.ToString("N0");

                // 3. Doanh thu theo ngày thanh toán
                var doanhThuTheoNgay = thanhToans
                    .GroupBy(x => x.NgayThanhToan.Date)
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        DoanhThu = g.Sum(x => x.SoTien)
                    })
                    .OrderBy(x => x.Ngay)
                    .Select(x => new
                    {
                        Ngay = x.Ngay.ToString("dd/MM/yyyy"),
                        DoanhThu = x.DoanhThu
                    })
                    .ToList();

                dgvDoanhThu.DataSource = doanhThuTheoNgay;

                // 4. Món ăn bán chạy
                var chiTiet = await db.ChiTietDonHangs
                    .AsNoTracking()
                    .Include(x => x.MonAn)
                    .Where(x => maDon.Contains(x.MaDon))
                    .ToListAsync();

                var monBanChay = chiTiet
                    .Where(x => x.MonAn != null)
                    .GroupBy(x => x.MonAn!.TenMon)
                    .Select(g => new
                    {
                        TenMon = g.Key,
                        SoLuong = g.Sum(x => x.SoLuong),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.SoLuong)
                    .Take(10)
                    .Select(x => new
                    {
                        TenMon = x.TenMon,
                        SoLuong = x.SoLuong,
                        DoanhThu = x.DoanhThu
                    })
                    .ToList();

                dgvMonBanChay.DataSource = monBanChay;

                // 5. Doanh thu theo nhân viên
                var donDaThanhToan = await db.DonHangs
                    .AsNoTracking()
                    .Include(x => x.NhanVien)
                    .Where(x => maDon.Contains(x.MaDon))
                    .ToListAsync();

                var nhanVienThongKe = donDaThanhToan
                    .GroupBy(x => new
                    {
                        x.MaNV,
                        TenNV = x.NhanVien != null
                            ? x.NhanVien.HoTen
                            : "Không xác định"
                    })
                    .Select(g => new
                    {
                        MaNV = g.Key.MaNV,
                        NhanVien = g.Key.TenNV,
                        SoDon = g.Select(x => x.MaDon).Distinct().Count(),
                        DoanhThu = g.Sum(x => x.TongTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                dgvNhanVien.DataSource = nhanVienThongKe;

                // 6. Thống kê trạng thái đơn hàng
                var trangThai = await db.DonHangs
                    .AsNoTracking()
                    .Where(x =>
                        x.NgayLap >= tuNgay &&
                        x.NgayLap < denNgay)
                    .GroupBy(x => x.TrangThai)
                    .Select(g => new
                    {
                        TrangThai = g.Key,
                        SoLuong = g.Count()
                    })
                    .OrderByDescending(x => x.SoLuong)
                    .ToListAsync();

                dgvTrangThai.DataSource = trangThai;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải thống kê.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            await XuatExcelAsync();
        }

        private async Task XuatExcelAsync()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

            if (tuNgay >= denNgay)
            {
                MessageBox.Show("Khoảng ngày không hợp lệ.");
                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                Title = "Xuất báo cáo nhà hàng",
                FileName = $"BaoCaoNhaHang_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using var db = DbContextFactory.Create();

                // 1. Thanh toán thành công trong kỳ
                var thanhToans = await db.ThanhToans
                    .AsNoTracking()
                    .Where(x =>
                        x.TrangThai == "Đã thanh toán" &&
                        x.NgayThanhToan >= tuNgay &&
                        x.NgayThanhToan < denNgay)
                    .ToListAsync();

                var maDonDaThanhToan = thanhToans
                    .Select(x => x.MaDon)
                    .Distinct()
                    .ToHashSet();

                decimal tongDoanhThu = thanhToans.Sum(x => x.SoTien);
                int tongSoDon = maDonDaThanhToan.Count;

                // 2. Tất cả đơn được tạo trong kỳ
                var donTrongKy = await db.DonHangs
                    .AsNoTracking()
                    .Include(x => x.Ban)
                    .Include(x => x.NhanVien)
                    .Include(x => x.ThanhToan)
                    .Where(x =>
                        x.NgayLap >= tuNgay &&
                        x.NgayLap < denNgay)
                    .OrderBy(x => x.NgayLap)
                    .ToListAsync();

                // 3. Thông tin đơn đã thanh toán trong kỳ
                // Có thể bao gồm đơn được tạo trước kỳ nhưng thanh toán trong kỳ.
                var donDaThanhToan = await db.DonHangs
                    .AsNoTracking()
                    .Include(x => x.NhanVien)
                    .Where(x => maDonDaThanhToan.Contains(x.MaDon))
                    .ToListAsync();

                // 4. Chi tiết món ăn của các đơn đã thanh toán
                var chiTiet = await db.ChiTietDonHangs
                    .AsNoTracking()
                    .Include(x => x.MonAn)
                        .ThenInclude(x => x!.DanhMuc)
                    .Where(x => maDonDaThanhToan.Contains(x.MaDon))
                    .ToListAsync();

                // 5. Tổng hợp món ăn
                var monThongKe = chiTiet
                    .Where(x => x.MonAn != null)
                    .GroupBy(x => new
                    {
                        x.MaMon,
                        TenMon = x.MonAn!.TenMon,
                        DanhMuc = x.MonAn.DanhMuc != null
                            ? x.MonAn.DanhMuc.TenDM
                            : "Không xác định"
                    })
                    .Select(g => new
                    {
                        g.Key.MaMon,
                        g.Key.TenMon,
                        g.Key.DanhMuc,
                        SoLuong = g.Sum(x => x.SoLuong),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.SoLuong)
                    .ToList();

                decimal tongDoanhThuMon = monThongKe.Sum(x => x.DoanhThu);

                // 6. Doanh thu theo nhân viên
                var nhanVienThongKe = donDaThanhToan
                    .GroupBy(x => new
                    {
                        x.MaNV,
                        TenNV = x.NhanVien != null
                            ? x.NhanVien.HoTen
                            : "Không xác định"
                    })
                    .Select(g =>
                    {
                        var paymentIds = g.Select(x => x.MaDon).ToHashSet();

                        decimal doanhThuNV = thanhToans
                            .Where(x => paymentIds.Contains(x.MaDon))
                            .Sum(x => x.SoTien);

                        return new
                        {
                            g.Key.MaNV,
                            NhanVien = g.Key.TenNV,
                            SoDon = paymentIds.Count,
                            DoanhThu = doanhThuNV,
                            TrungBinh = paymentIds.Count == 0
                                ? 0
                                : doanhThuNV / paymentIds.Count
                        };
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                // 7. Doanh thu theo ngày
                var doanhThuNgay = thanhToans
                    .GroupBy(x => x.NgayThanhToan.Date)
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        SoDon = g.Select(x => x.MaDon).Distinct().Count(),
                        DoanhThu = g.Sum(x => x.SoTien)
                    })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                // 8. Phương thức thanh toán
                var phuongThuc = thanhToans
                    .GroupBy(x => x.PhuongThuc)
                    .Select(g => new
                    {
                        PhuongThuc = g.Key,
                        SoGiaoDich = g.Count(),
                        DoanhThu = g.Sum(x => x.SoTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                // 9. Trạng thái đơn hàng
                var trangThai = donTrongKy
                    .GroupBy(x => x.TrangThai)
                    .Select(g => new
                    {
                        TrangThai = g.Key,
                        SoLuong = g.Count()
                    })
                    .OrderByDescending(x => x.SoLuong)
                    .ToList();

                // 10. Tạo Excel
                using var workbook = new XLWorkbook();

                // SHEET 1: Tổng quan
                string monBanChay = monThongKe.FirstOrDefault()?.TenMon
                    ?? "Chưa có dữ liệu";

                string nhanVienTotNhat = nhanVienThongKe.FirstOrDefault()?.NhanVien
                    ?? "Chưa có dữ liệu";

                int donDangPhucVu = donTrongKy.Count(
                    x => x.TrangThai == "Đang phục vụ");

                AddExcelSheet(workbook, "TongQuan",
                    new[]
                    {
                "Chỉ tiêu",
                "Giá trị"
                    },
                    new[]
                    {
                new object?[] { "Từ ngày", tuNgay },
                new object?[] { "Đến ngày", denNgay.AddDays(-1) },
                new object?[] { "Tổng doanh thu", tongDoanhThu },
                new object?[] { "Số đơn đã thanh toán", tongSoDon },
                new object?[] { "Giá trị trung bình/đơn",
                    tongSoDon == 0 ? 0 : tongDoanhThu / tongSoDon },
                new object?[] { "Đơn đang phục vụ", donDangPhucVu },
                new object?[] { "Món bán chạy nhất", monBanChay },
                new object?[] { "Nhân viên doanh thu cao nhất", nhanVienTotNhat }
                    });

                // SHEET 2: Chi tiết đơn hàng
                AddExcelSheet(workbook, "ChiTietDonHang",
                    new[]
                    {
                "Mã đơn", "Ngày lập", "Số bàn", "Nhân viên",
                "Trạng thái đơn", "Tổng tiền đơn",
                "Số tiền thanh toán", "Phương thức",
                "Ngày thanh toán", "Trạng thái thanh toán"
                    },
                    donTrongKy.Select(x => new object?[]
                    {
                x.MaDon,
                x.NgayLap,
                x.Ban?.SoBan ?? "Đã xóa bàn",
                x.NhanVien?.HoTen ?? "Không xác định",
                x.TrangThai,
                x.TongTien,
                x.ThanhToan?.SoTien,
                x.ThanhToan?.PhuongThuc ?? "Chưa thanh toán",
                x.ThanhToan?.NgayThanhToan,
                x.ThanhToan?.TrangThai ?? "Chưa thanh toán"
                    }));

                // SHEET 3: Chi tiết món ăn đã bán
                AddExcelSheet(workbook, "ChiTietMonDaBan",
                    new[]
                    {
                "Mã đơn", "Mã món", "Tên món", "Danh mục",
                "Số lượng", "Đơn giá", "Thành tiền"
                    },
                    chiTiet
                        .Where(x => x.MonAn != null)
                        .OrderBy(x => x.MaDon)
                        .Select(x => new object?[]
                        {
                    x.MaDon,
                    x.MaMon,
                    x.MonAn!.TenMon,
                    x.MonAn.DanhMuc?.TenDM ?? "Không xác định",
                    x.SoLuong,
                    x.DonGia,
                    x.ThanhTien
                        }));

                // SHEET 4: Xếp hạng món ăn
                AddExcelSheet(workbook, "XepHangMonAn",
                    new[]
                    {
                "Mã món", "Tên món", "Danh mục",
                "Số lượng bán", "Doanh thu", "Tỷ trọng doanh thu (%)"
                    },
                    monThongKe.Select(x => new object?[]
                    {
                x.MaMon,
                x.TenMon,
                x.DanhMuc,
                x.SoLuong,
                x.DoanhThu,
                tongDoanhThuMon == 0
                    ? 0
                    : x.DoanhThu / tongDoanhThuMon * 100
                    }));

                // SHEET 5: Hiệu suất nhân viên
                AddExcelSheet(workbook, "HieuSuatNhanVien",
                    new[]
                    {
                "Mã nhân viên", "Nhân viên", "Số đơn",
                "Doanh thu", "Trung bình/đơn"
                    },
                    nhanVienThongKe.Select(x => new object?[]
                    {
                x.MaNV,
                x.NhanVien,
                x.SoDon,
                x.DoanhThu,
                x.TrungBinh
                    }));

                // SHEET 6: Doanh thu theo ngày
                AddExcelSheet(workbook, "DoanhThuTheoNgay",
                    new[]
                    {
                "Ngày thanh toán", "Số đơn", "Doanh thu"
                    },
                    doanhThuNgay.Select(x => new object?[]
                    {
                x.Ngay,
                x.SoDon,
                x.DoanhThu
                    }));

                // SHEET 7: Phương thức thanh toán
                AddExcelSheet(workbook, "PhuongThucThanhToan",
                    new[]
                    {
                "Phương thức", "Số giao dịch", "Tổng tiền"
                    },
                    phuongThuc.Select(x => new object?[]
                    {
                x.PhuongThuc,
                x.SoGiaoDich,
                x.DoanhThu
                    }));

                // SHEET 8: Trạng thái đơn hàng
                AddExcelSheet(workbook, "TrangThaiDonHang",
                    new[]
                    {
                "Trạng thái", "Số lượng đơn"
                    },
                    trangThai.Select(x => new object?[]
                    {
                x.TrangThai,
                x.SoLuong
                    }));

                workbook.SaveAs(dialog.FileName);

                MessageBox.Show(
                    "Xuất báo cáo Excel thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Process.Start(new ProcessStartInfo
                {
                    FileName = dialog.FileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất báo cáo Excel.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Hàm dùng chung để tạo worksheet
        private static void AddExcelSheet(
            XLWorkbook workbook,
            string sheetName,
            string[] headers,
            IEnumerable<object?[]> rows)
        {
            var sheet = workbook.Worksheets.Add(sheetName);

            // Tiêu đề cột
            for (int col = 0; col < headers.Length; col++)
            {
                sheet.Cell(1, col + 1).Value = headers[col];
            }

            var headerRange = sheet.Range(
                1, 1, 1, headers.Length);

            headerRange.Style.Font.Bold = true;
            headerRange.Style.Font.FontColor = XLColor.White;
            headerRange.Style.Fill.BackgroundColor = XLColor.DarkBlue;
            headerRange.Style.Alignment.Horizontal =
                XLAlignmentHorizontalValues.Center;

            int rowIndex = 2;

            foreach (var row in rows)
            {
                for (int col = 0; col < row.Length; col++)
                {
                    SetExcelCellValue(
                        sheet.Cell(rowIndex, col + 1),
                        row[col]);
                }

                rowIndex++;
            }

            sheet.SheetView.FreezeRows(1);
            sheet.Columns().AdjustToContents();

            if (rowIndex > 2)
            {
                sheet.Range(
                    1, 1,
                    rowIndex - 1,
                    headers.Length).SetAutoFilter();
            }
        }

        // Giữ kiểu dữ liệu số và ngày tháng trong Excel
        private static void SetExcelCellValue(
            IXLCell cell,
            object? value)
        {
            switch (value)
            {
                case null:
                    cell.Value = "";
                    break;

                case decimal d:
                    cell.Value = d;
                    break;

                case int i:
                    cell.Value = i;
                    break;

                case long l:
                    cell.Value = l;
                    break;

                case double db:
                    cell.Value = db;
                    break;

                case DateTime date:
                    cell.Value = date;
                    cell.Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                    break;

                case bool b:
                    cell.Value = b;
                    break;

                default:
                    cell.Value = value.ToString() ?? "";
                    break;
            }
        }

    }
}
