using System.Collections.Generic;
using DayOrganizer.Domain.Entities;

namespace DayOrganizer.Domain.Abstract
{
    public interface ITaskRepository
    {
        IEnumerable<User> Users { get; }
    }
}
