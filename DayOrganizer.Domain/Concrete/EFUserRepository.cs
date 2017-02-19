using DayOrganizer.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOrganizer.Domain.Entities;
using DayOrganizer.Domain.Concrete;

namespace DayOrganizer.Domain.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private readonly EFDbContext db = new EFDbContext();
        public IEnumerable<User> Users
        {
            get
            {
                return db.Users;
            }
        }
    }
}
