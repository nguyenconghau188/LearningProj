using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required(ErrorMessage = "Mời nhập User name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mời nhập Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}