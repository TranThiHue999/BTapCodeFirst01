using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTapCodeFirst01.Models
{
    public partial class BaiTapDBContext : DbContext
    {
        public BaiTapDBContext()
            : base("name=BaiTapDBContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.DeptName)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.Note)
                .IsFixedLength();
        }
    }
}
