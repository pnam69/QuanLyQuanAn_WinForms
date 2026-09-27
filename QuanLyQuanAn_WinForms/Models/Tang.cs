using System.ComponentModel.DataAnnotations;

namespace QuanLyQuanAn_WinForms.Models
{
    public class Tang
    {
        [Key]
        public int MaTang { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTang { get; set; } = "";

        public ICollection<Ban> Bans { get; set; } =
            new List<Ban>();
    }
}