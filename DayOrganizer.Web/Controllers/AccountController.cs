﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DayOrganizer.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
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