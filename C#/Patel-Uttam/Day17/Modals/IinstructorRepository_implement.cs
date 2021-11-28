/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public class IinstructorRepository_implement : IinstructorRepository
    {
        private readonly Instructor_Student_ContextDB contextDB;

        public IinstructorRepository_implement(Instructor_Student_ContextDB context)
        {
            contextDB = context;
        }
        public Instructor AddInstructor(Instructor instructor)
        {
            contextDB.instructors.Add(instructor);
            contextDB.SaveChanges();
            return instructor;
        }

        public Instructor DeleteInstructor(int id)
        {
            var instructor_in_student = contextDB.students.FirstOrDefault(i => i.InstructorId == id);

            var deleted_instructor = contextDB.instructors.FirstOrDefault(i => i.InstructorId == id);
            if (instructor_in_student == null)
            {
                
                contextDB.instructors.Remove(deleted_instructor);
                contextDB.SaveChanges();
            }
            return deleted_instructor;

        }

        public Instructor GetInstructor(int id)
        {
            var get_instructor = contextDB.instructors.FirstOrDefault(i=>i.InstructorId == id);
            return get_instructor;
        }

        public IEnumerable<Instructor> GetInstructorAll()
        {
            return contextDB.instructors;

        }

        public Instructor UpdateInstructor(Instructor instructor)
        {
            var updated_instructor = contextDB.instructors.Attach(instructor);
            updated_instructor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contextDB.SaveChanges();
            return instructor;
        }
    }
}
*/