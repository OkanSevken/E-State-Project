using System.ComponentModel.DataAnnotations;

namespace Estate.UI.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Boş gecilemez")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Boş gecilemez")]
        [DataType(DataType.Password,ErrorMessage ="Şifre tipinde değil")]
        public string Password { get; set; }
    }
}
