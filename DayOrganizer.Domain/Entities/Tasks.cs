using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOrganizer.Domain.Entities
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CurrentStatus { get; set; }
    }
}
