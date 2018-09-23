using Model.Dao;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                var dao = new UserDao();
                var result = dao.Login(cookie["UserName"], cookie["Password"]);
                if (result)
                {
                    var user = dao.GetByUsername(cookie["UserName"]);
                    var userSession = new UserLogin();
                    userSession.UserId = user.ID;
                    userSession.UserName = user.UserName;
                    Session.Add(CommonConstant.USER_SESSION, userSession);
                }
                
            }
            else
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                if (session == null)
                {
                    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
                        new { controller = "Login", action = "Login", Area = "Admin" }));
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}