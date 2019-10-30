using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ContextContext: DbContext
    {
        public List<Student> Students { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VIFOA8M\SQLEXPRESS; Database=WWW_Student;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, Name = "Azra", Surname = "Yerli", Age = 15,  SchoolNumber = 222 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, Name = "Hazal", Surname = "Yerli", Age = 23, SchoolNumber = 333 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, Name = "Parla", Surname = "Yerli", Age = 26, SchoolNumber = 444 });
        }
    }
}
