using System.ComponentModel.DataAnnotations;

namespace InteriorMobilya.WebUI.Models.User
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(300)]
        [Display(Name = "E-posta Adresi")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla ?")]
        public bool RememberMe { get; set; }
    }
}