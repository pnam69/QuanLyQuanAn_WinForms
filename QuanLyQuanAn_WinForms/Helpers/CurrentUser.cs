using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyQuanAn_WinForms.Helpers
{
    public static class CurrentUser
    {
        public static int MaNV { get; set; }
        public static string HoTen { get; set; } = "";
        public static string TaiKhoan { get; set; } = "";
        public static string VaiTro { get; set; } = "";

        public static bool IsAdmin =>
            VaiTro == "Admin";

        public static bool IsEmployee =>
            VaiTro == "Employee";

        public static void Clear()
        {
            MaNV = 0;
            HoTen = "";
            TaiKhoan = "";
            VaiTro = "";
        }
    }
}