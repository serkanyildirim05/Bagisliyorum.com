using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bagisla.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Elektronik posta adresi bilgisi gereklidir!")]
        //[RegularExpression(@"^([a-zA-Z0-9_-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([a-zA-Z0-9-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$", ErrorMessage = "Geçerli mail adresi girmeden geçiş yok!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gerekli!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gerekli!")]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }
        public bool Bagisci { get; set; }
        public bool Hasta { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }


    }

    public class LogOnModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gerekli!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre gerekli!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ChangePasswordModel
    {
        [Required]
        public string OldPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword", ErrorMessage = "Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }
    }
}