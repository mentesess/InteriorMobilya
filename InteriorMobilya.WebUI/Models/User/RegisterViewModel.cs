using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InteriorMobilya.WebUI.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name="İsim")]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        [Display(Name="Soyisim")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name="E-posta Adresi")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [Display(Name="Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}