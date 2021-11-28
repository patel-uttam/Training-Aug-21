using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public class Instructor
    {
        public int InstructorId { set; get; }
        public string InstructorName { set; get; }
        public string Subject { set; get; }

        public ICollection<Student> student { set; get; }
    }
}
