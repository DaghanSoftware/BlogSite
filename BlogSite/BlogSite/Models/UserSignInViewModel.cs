using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="lÜTFEN KUllanıcı Adını Giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "lÜTFEN Şifrenizi Giriniz")]
        public string password { get; set; }
    }
}
