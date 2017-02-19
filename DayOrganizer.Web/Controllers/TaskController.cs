using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayOrganizer.Web.Models;

namespace DayOrganizer.Web.Controllers
{
    public class TaskController : Controller
    {
        EFDbModel db = new EFDbModel();
        // GET: Task
        public ActionResult Index()
        {
            var x = db.Tasks;
            return View(x);
        }
    }
}