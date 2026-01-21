using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace N8DatVeRapChieuPhim.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Tài khoản")]
        public string UserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
