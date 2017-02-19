using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayOrganizer.Domain.Concrete;

namespace DayOrganizer.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private EFDbContext db = new EFDbContext();
        [AllowAnonymous]
        public ActionResult Login()
        {
            var testVar = db.Tasks.ToList();
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