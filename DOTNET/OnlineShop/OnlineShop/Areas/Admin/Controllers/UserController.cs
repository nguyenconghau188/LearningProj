﻿using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult AddUser()
        {
            List<SelectListItem> Level = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Normal User", Value = "1" },
                new SelectListItem { Text = "Admin", Value = "2" },
                new SelectListItem { Text = "System Admin", Value = "3" }
            };
            ViewBag.Level = Level;
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserModel user)
        {
            if (ModelState.IsValid)
            {
                string error = user.CheckExist();
                if (error == "")
                {
                    
                    if (user.Password == user.ConfirmPassword)
                    {
                        user.Password = Encryptor.MD5Hash(user.Password);
                        var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                        user.CreateBy = session.UserName;
                        long userID = user.AddNewUser();
                        if (userID > 0)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Add error!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password and confirm password are not same!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", error);
                }

            }
            else
            {
                ModelState.AddModelError("", "Error input!");
            }
            return View("AddUser");
        }

        public ActionResult ListUser()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }
    }
}