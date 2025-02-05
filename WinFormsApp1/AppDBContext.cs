using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AppDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(LocalDB)\\MSSQLLocalDB; Initial Catalog = School; TrustServerCertificate = True; Encrypt = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(

                      new Teacher()
                      {
                          Id = 1,
                          NationalCode = "1",
                          PersonalCode = "1",
                      }

            );
            modelBuilder.Entity<Student>().HasData(

                     new Student()
                     {
                         Id = 1,
                         RowNumber = 1,
                         Fname = "ali",
                         Lname = "gholipour",
                         IsPersent = true,

                     },
                     new Student()
                     {
                         Id = 2,
                         RowNumber = 2,
                         Fname = "ali",
                         Lname = "rezaee",
                         IsPersent = true,

                     },
                     new Student()
                     {
                         Id = 3,
                         RowNumber = 3,
                         Fname = "ali",
                         Lname = "mhmmadi",
                         IsPersent = true,

                     },
                     new Student()
                     {
                         Id = 4,
                         RowNumber = 4,
                         Fname = "ali",
                         Lname = "gholizade",
                         IsPersent = true,

                     }

           );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}



