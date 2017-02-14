using DayOrganizer.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOrganizer.Domain.Entities;

namespace DayOrganizer.Domain.Concrete
{
    public class EFTaskRepository : ITaskRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Entities.Task> Tasks
        {
            get
            {
                return context.Tasks;
            }
        }
    }
}
