using System.ComponentModel.DataAnnotations;

namespace N8DatVeRapChieuPhim.Models
{
    public class Phim
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã phim không được để trống")]
        [StringLength(10)]
        [Display(Name = "Mã Phim")]
        public string MaPhim { get; set; }

        [Required(ErrorMessage = "Tên phim không được để trống")]
        [StringLength(200)]
        [Display(Name = "Tên Phim")]
        public string TenPhim { get; set; }

        [Required(ErrorMessage = "Thể loại không được để trống")]
        [StringLength(100)]
        [Display(Name = "Thể Loại")]
        public string TheLoai { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Thời lượng phải lớn hơn 0")]
        [Display(Name = "Thời Lượng (phút)")]
        public int ThoiLuong { get; set; }

        [Required(ErrorMessage = "Đạo diễn không được để trống")]
        [StringLength(100)]
        [Display(Name = "Đạo Diễn")]
        public string DaoDien { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(1500)]
        [Display(Name = "Mô Tả")]
        public string MoTa { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [StringLength(200)]
        [Display(Name = "Hình Ảnh")]
        public string HinhAnh { get; set; }
    }
}
