using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace QuanLyQuanAn_WinForms.Models
{
    [Index(nameof(SoBan), IsUnique = true)]
    public class Ban
    {
        [Key]
        public int MaBan { get; set; }

        [Required(ErrorMessage = "Số bàn không được để trống")]
        [StringLength(20, ErrorMessage = "Số bàn không được vượt quá 20 ký tự")]
        [Display(Name = "Số bàn")]
        public string SoBan { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "Số chỗ phải từ 1 đến 100")]
        [Display(Name = "Số chỗ")]
        public int SoCho { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        [StringLength(30)]
        [Display(Name = "Trạng thái")]
        public string TrangThai { get; set; } = "Trống";

        public int MaTang { get; set; }
        public Tang? Tang { get; set; }

        [Range(1, 12)]

        public int SoGhe { get; set; } = 4;

        public int ViTriX { get; set; } = 20;

        public int ViTriY { get; set; } = 20;

        public ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
    }
}