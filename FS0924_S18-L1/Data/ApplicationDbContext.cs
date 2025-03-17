using FS0924_S18_L1.Models;
using Microsoft.EntityFrameworkCore;

namespace FS0924_S18_L1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Student>()
        //        .HasData(
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Marco",
        //                Surname = "Rossi",
        //                BirthdayDate = DateTime.Parse("2000-05-12"),
        //                Email = "marco.rossi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Luca",
        //                Surname = "Bianchi",
        //                BirthdayDate = DateTime.Parse("1999-08-23"),
        //                Email = "luca.bianchi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Giulia",
        //                Surname = "Verdi",
        //                BirthdayDate = DateTime.Parse("2001-02-14"),
        //                Email = "giulia.verdi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Francesca",
        //                Surname = "Neri",
        //                BirthdayDate = DateTime.Parse("1998-11-30"),
        //                Email = "francesca.neri@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Alessandro",
        //                Surname = "Ferrari",
        //                BirthdayDate = DateTime.Parse("2002-07-19"),
        //                Email = "alessandro.ferrari@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Sara",
        //                Surname = "Galli",
        //                BirthdayDate = DateTime.Parse("2000-09-08"),
        //                Email = "sara.galli@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Matteo",
        //                Surname = "Conti",
        //                BirthdayDate = DateTime.Parse("1997-12-05"),
        //                Email = "matteo.conti@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Elena",
        //                Surname = "Marini",
        //                BirthdayDate = DateTime.Parse("1999-06-17"),
        //                Email = "elena.marini@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Davide",
        //                Surname = "Moretti",
        //                BirthdayDate = DateTime.Parse("2003-03-29"),
        //                Email = "davide.moretti@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Chiara",
        //                Surname = "Barbieri",
        //                BirthdayDate = DateTime.Parse("2001-01-21"),
        //                Email = "chiara.barbieri@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Stefano",
        //                Surname = "Romano",
        //                BirthdayDate = DateTime.Parse("1996-10-10"),
        //                Email = "stefano.romano@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Martina",
        //                Surname = "Fabbri",
        //                BirthdayDate = DateTime.Parse("2000-04-25"),
        //                Email = "martina.fabbri@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Andrea",
        //                Surname = "Rinaldi",
        //                BirthdayDate = DateTime.Parse("1999-07-30"),
        //                Email = "andrea.rinaldi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Laura",
        //                Surname = "De Luca",
        //                BirthdayDate = DateTime.Parse("2002-05-13"),
        //                Email = "laura.deluca@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Simone",
        //                Surname = "Costa",
        //                BirthdayDate = DateTime.Parse("1998-09-15"),
        //                Email = "simone.costa@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Beatrice",
        //                Surname = "Rizzi",
        //                BirthdayDate = DateTime.Parse("2001-11-27"),
        //                Email = "beatrice.rizzi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Federico",
        //                Surname = "Lombardi",
        //                BirthdayDate = DateTime.Parse("1997-08-22"),
        //                Email = "federico.lombardi@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Alice",
        //                Surname = "Serra",
        //                BirthdayDate = DateTime.Parse("2003-02-18"),
        //                Email = "alice.serra@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Roberto",
        //                Surname = "Pellegrini",
        //                BirthdayDate = DateTime.Parse("2000-06-12"),
        //                Email = "roberto.pellegrini@example.com",
        //            },
        //            new Student()
        //            {
        //                Id = Guid.NewGuid(),
        //                Name = "Valentina",
        //                Surname = "Caruso",
        //                BirthdayDate = DateTime.Parse("1999-03-05"),
        //                Email = "valentina.caruso@example.com",
        //            }
        //        );
        //}
    }
}
