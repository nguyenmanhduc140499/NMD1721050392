using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NMD1721050392.Models
{
    public class NMD1721050392DBcontext : DbContext
    {
        public NMD1721050392DBcontext() : base("NMD1721050392DBcontext")
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
            modelBuilder.Entity<Student>()
            .Property(e => e.PersonName)
            .IsUnicode(false);
        }


    }
}