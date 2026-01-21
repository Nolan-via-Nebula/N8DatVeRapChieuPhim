using System.ComponentModel.DataAnnotations;

namespace N8DatVeRapChieuPhim.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; 
    }
}
