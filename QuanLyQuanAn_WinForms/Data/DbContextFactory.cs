using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;

namespace QuanLyQuanAn_WinForms.Data
{
    public static class DbContextFactory
    {
        public static AppDbContext Create()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(DbConfig.ConnectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}