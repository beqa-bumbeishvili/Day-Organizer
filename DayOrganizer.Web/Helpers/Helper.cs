using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DayOrganizer.Web.Models;

namespace DayOrganizer.Web.Helpers
{
    public static class Helper
    {
       public static string GetCalculatedStatus(DateTime start, DateTime end)
        {
            if (DateTime.Now < start)
                return "inactive";
            else if (DateTime.Now > end)
                return "failed";
            return "active";
        }
        public static IEnumerable<Task> SortTasks(IEnumerable<Task> tasks)
        {
            tasks = tasks.Where(t => t.StartDate.Day == DateTime.Now.Day).OrderBy(t => t.StartDate);
            return tasks;
        }
    }
}

