using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample
{
    class SchoolContext : DbContext
    {

        public SchoolContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContexOptionsBuilder)
        {
            dbContexOptionsBuilder.UseSqlServer(@"Server =LAPTOP-3P2R1D3J\SQLEXPRESS; Database = SchoolDB; Trusted_Connection = True; ");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    class Student
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        public string StudentName
        {
            get;
            set;
        }
        public int CourseId
        {
            get;
            set;
        }
    }

    class Course
    {
        [Key]
        public int CourseId
        {
            get;
            set;
        }

        public string CourseName
        {
            get;
            set;
        }
    }

}
