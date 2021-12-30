using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmTekno.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Şifreniz En Az 5 Karakter Olmalıdır...")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre Tekrar")]
        [Compare("NewPassword", ErrorMessage ="Şifreler Aynı Olmalıdır...")]
        public string ConNewPassword { get; set; }
    }
}