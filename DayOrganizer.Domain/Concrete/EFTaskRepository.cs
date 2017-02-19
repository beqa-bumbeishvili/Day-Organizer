﻿using DayOrganizer.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOrganizer.Domain.Entities;
using DayOrganizer.Domain.Concrete;

namespace DayOrganizer.Domain.Concrete
{
    public class EFTaskRepository : ITaskRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Task> Tasks
        {
            get
            {
                return context.Tasks;
            }
        }

        public IEnumerable<User> Users
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
