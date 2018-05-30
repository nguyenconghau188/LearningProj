using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Create(Models.AdminModels user)
        {
            if (ModelState.IsValid)
            {
                var dao = new Models.AdminModels();
                var session = (UserLogin)Session[CommonConstants.USER_SESSION];
                user.Password = Encryptor.MD5Hash(user.Password);
                user.CreateBy = session.Username;
                long id = dao.AddAdmin(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Add user error!");
                }
            }
            return View("Index");
        }
    }
}