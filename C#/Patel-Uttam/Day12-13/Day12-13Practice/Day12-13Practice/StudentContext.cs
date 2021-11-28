using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Day12_13Practice
{
    class StudentContext : DbContext
    {
        public StudentContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=LAPTOP-3P2R1D3J\SQLEXPRESS;Database=Student_GradeDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        // Entity
        public DbSet<Student> Students { set; get; }
    }


    /* one to many
      
         class Student
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public string StudentAddress { set; get; }
        public DateTime DOB { set; get; }

        public int GradeId { set; get; }
        public Grade grade { set; get; }
    }

    class Grade
    {
        public int GradeId { set; get; }
        public string GradeName { set; get; }

        public IList<Student> students { set; get; }
    }
     */

    /*
     one to one 
        class Student
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public string StudentAddress { set; get; }
        public DateTime DOB { set; get; }

        public int GradeId { set; get; }
        public Grade grade { set; get; }
    }

    class Grade
    {
        public int GradeId { set; get; }
        public string GradeName { set; get; }

        public Student student { set; get; }
    }
     */
}
