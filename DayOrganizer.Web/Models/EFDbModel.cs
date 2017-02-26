namespace DayOrganizer.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDbModel : DbContext
    {
        public EFDbModel()
            : base("name=EFDbModel")
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
