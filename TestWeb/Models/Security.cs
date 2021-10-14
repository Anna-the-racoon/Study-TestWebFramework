using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestWeb.Models
{
    public class Security
    {
        [DisplayName("Login")]
        [Required(ErrorMessage ="Не указан логин")]
        public string Login { get; set; }
        
        [DisplayName("Password")]
        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(1000, MinimumLength =3, ErrorMessage = "Длина пароля не может быть меньше 3 символов")]
        public string Password { get; set; }
    }
}