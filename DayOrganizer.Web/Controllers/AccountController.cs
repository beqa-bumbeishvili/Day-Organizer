using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayOrganizer.Web.Models;

namespace DayOrganizer.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        EFDbModel db = new EFDbModel();
        [AllowAnonymous]
        public ActionResult Login()
        {
            var testVar = db.Users.ToList();
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(string username, string password, string email)
        {
            return View();
        }
    }
}