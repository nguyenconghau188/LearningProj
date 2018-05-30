using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class AdminModels
    {
        [Required(ErrorMessage = "Mời nhập User name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mời nhập Password")]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }


        public long AddAdmin(AdminModels models, long id = 0)
        {
            var dao = new Model.DAO.UserDao();
            Model.EF.User user = new Model.EF.User();
            user.UserName = models.Username;
            user.Password = models.Password;
            user.Phone = models.Phone;
            user.Email = models.Email;
            user.Address = user.Address;
            user.CreateDate = DateTime.Today;
            user.Status = true;
            user.CreateBy = models.CreateBy;
            id = dao.Insert(user);
            return id;
        }
    }
}