using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}

