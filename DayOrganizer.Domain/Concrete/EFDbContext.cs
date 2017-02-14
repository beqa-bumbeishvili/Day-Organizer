using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DayOrganizer.Domain.Entities;

namespace DayOrganizer.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

    }
}
