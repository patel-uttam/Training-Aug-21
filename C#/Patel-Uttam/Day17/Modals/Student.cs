using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public class Student
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public int InstructorId { set; get; } 
        public Instructor instructor { set; get; }
    }
}
