﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayOrganizer.Domain.Entities;

namespace DayOrganizer.Domain.Abstract
{
    public interface ITaskRepository
    {
        IEnumerable<Task>Tasks { get;}
    }
}
