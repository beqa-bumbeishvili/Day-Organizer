using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DayOrganizer.Domain.Entities;

namespace DayOrganizer.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
