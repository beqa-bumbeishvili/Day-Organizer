using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayOrganizer.Web.Models;
using DayOrganizer.Web.Helpers;

namespace DayOrganizer.Web.Controllers
{
    public class TaskController : Controller
    {
        EFDbModel db = new EFDbModel();
        // GET: Task
        public ActionResult Index()
        {
            var SortedTasksByDate = Helper.SortTasks(db.Tasks);
            return View(SortedTasksByDate);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(DateTime eventStartDate, DateTime eventEndDate, string eventTitle, string eventDescription)
        {
            if (!String.IsNullOrWhiteSpace(eventTitle) && !String.IsNullOrWhiteSpace(eventDescription))
            {
                Task Task = new Task();
                Task.Title = eventTitle;
                Task.FullDescription = eventDescription;
                Task.StartDate = eventStartDate;
                Task.EndDate = eventEndDate;
                Task.CurrentStatus = Helper.GetCalculatedStatus(eventEndDate, eventEndDate);
                db.Tasks.Add(Task);
                db.SaveChanges();
            }
            var SortedTasksByDate = Helper.SortTasks(db.Tasks);
            return View(SortedTasksByDate);
        }

    }
}