using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public interface IinstructorRepository
    {
        IEnumerable<Instructor> GetInstructorAll();

        Instructor GetInstructor(int id);

        Instructor AddInstructor(Instructor instructor);

        Instructor UpdateInstructor(Instructor instructor);

        Instructor DeleteInstructor(int id);

    }
}
