using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.EF.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<PaymentEntry> PaymentEntrys { get; set; }
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // configures one-to-many relationship
        //    //modelBuilder.Entity<Student>()
        //    //.HasRequired<Grade>(s => s.CurrentGrade)
        //    //.WithMany(g => g.Students)
        //    //.HasForeignKey<int>(s => s.CurrentGradeId);
        //}
    }
}

