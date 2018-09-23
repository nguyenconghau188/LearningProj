using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public int? Level { get; set; }

        public long AddNewUser()
        {
            Model.EF.User user = new Model.EF.User();
            user.UserName = Username;
            user.Password = Password;
            user.Name = Name;
            user.Address = Address;
            user.Email = Email;
            user.Phone = Phone;
            user.Status = Status;
            user.Level = Level;
            var dao = new Model.Dao.UserDao();
            long userID = dao.Insert(user);
            if (userID > 0)
            {
                return userID;
            }
            return 0;
        }
        public string CheckExist()
        {
            var dao = new Model.Dao.UserDao();
            return dao.CheckExist(Username, Email);
        }
    }
}