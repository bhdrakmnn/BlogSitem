using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSitem.Models
{
    public class SifreDegistirme
    {
        [Required]
        [DisplayName("Mevcut Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Şifreniz en az 5 karakter olamlı...")]
        [DisplayName("Yeni Şifre")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("NewPassword",ErrorMessage ="Girilen şifreler birbiri ile uyuşmuyor...")]
        public string ConNewPassword { get; set; }
    }
}