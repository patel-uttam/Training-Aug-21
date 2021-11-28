using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15Assignment.API.Models
{
    public class Employee_Assignment_DbContext:DbContext
    {
        public Employee_Assignment_DbContext(DbContextOptions<Employee_Assignment_DbContext> contextOptions):base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Assignment> Assignments { get; set; }
    }
}
