using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Day17Practice_Basic_Auth.API.Modals
{
    public class Instructor_Student_ContextDB : DbContext
    {
        public Instructor_Student_ContextDB(DbContextOptions dbContextOptions) :base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Instructor> instructors { set; get; }
        public DbSet<Student> students { set; get; }
    }
}
