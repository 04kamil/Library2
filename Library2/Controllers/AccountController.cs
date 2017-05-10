using Library2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library2.Controllers
{
    public class AccountController : Controller
    {
        public UserRepository ur = new UserRepository();
        // GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Login(string Login, string Password)
        {
            string s = ur.CheckUser(Login, Password).ToString();
            Session["Logged"] = s;
            
            return View("../Home/Index");
        }

        public ActionResult Logout()
        {
            Session.Remove("Logged");
            return View("../Home/Index");
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}