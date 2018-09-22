using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            var session = (UserLogin)Session[CommonConstant.USER_SESSION];
            ViewData["user"] = session.UserName;
            return View();
        }
    }
}