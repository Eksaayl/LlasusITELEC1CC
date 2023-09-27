using System;
using Microsoft.EntityFrameworkCore;
using LlasusITELEC1CC.Models;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace LlasusITELEC1CC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                 new Student()
                 {
                     Id = 1,
                     FirstName = "Don",
                     LastName = "Flaming",
                     Course = Course.BSIT,
                     AdmissionDate = DateTime.Parse("2022-08-26"),
                     GPA = 1.5,
                     Email = "faxe1@gmail.com"
                 },
                new Student()
                {
                    Id = 2,
                    FirstName = "Beate",
                    LastName = "Ronas",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "z235yx@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Fetz",
                    LastName = "Dogs",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "agerkiel@gmail.com"
                });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instructor>().HasData(

             new Instructor()
             {
                 Id = 1,
                 FirstName = "Krap",
                 LastName = "Doroteo",
                 IsTenured = IsTenured.Yes,
                 DateHired = DateTime.Now,
                 Rank = Rank.Instructor,
                 Email = "trail@gmail.com",
                 Mobile = "0000-232-12"
             },
            new Instructor()
            {
                Id = 2,
                FirstName = "Leomord",
                LastName = "Polska",
                IsTenured = IsTenured.Yes,
                DateHired = DateTime.Now,
                Rank = Rank.AssistProf,
                Email = "trail1@gmail.com",
                Mobile = "2352-232-12"

            },
            new Instructor()
            {
                Id = 3,
                FirstName = "Yamato",
                LastName = "Kaido",
                IsTenured = IsTenured.No,
                DateHired = DateTime.Now,
                Rank = Rank.AssociateProf,
                Email = "trail2@gmail.com",
                Mobile = "2552-232-12"

            },
            new Instructor()
            {
                Id = 4,
                FirstName = "Jor",
                LastName = "Noel",
                IsTenured = IsTenured.No,
                DateHired = DateTime.Now,
                Rank = Rank.Prof,
                Email = "trail3@gmail.com",
                Mobile = "2563-232-12"
            });








        }
    }
}
