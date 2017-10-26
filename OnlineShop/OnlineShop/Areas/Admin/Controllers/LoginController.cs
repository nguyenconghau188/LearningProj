using Model.DAO;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModels model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                if (result == DefinedParam.LOGIN_SUCCESS)
                {
                    var user = dao.GetByUsername(model.Username);
                    var userSession = new UserLogin();
                    userSession.Username = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == DefinedParam.LOGIN_NULL)
                {
                    ModelState.AddModelError("", "Username can't found!");
                }
                else if (result == DefinedParam.LOGIN_FALSE_PASSWORD)
                {
                    ModelState.AddModelError("", "Wrong password!");
                }
                else if (result == DefinedParam.LOGIN_FALSE)
                {
                    ModelState.AddModelError("", "Username in ban list!");
                }
            }
            return View("Login");        
        }
    }
}