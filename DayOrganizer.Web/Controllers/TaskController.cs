using DayOrganizer.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DayOrganizer.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository Repository;

        public TaskController(ITaskRepository repo)
        {
            Repository = repo;
        }
        // GET: Task
        public ActionResult Index()
        {
            var x = Repository.Tasks;
            return View(Repository.Tasks);
        }
    }
}