/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public class IstudentRepository_implement : IstudentRepository
    {
        private readonly Instructor_Student_ContextDB contextDB;

        public IstudentRepository_implement(Instructor_Student_ContextDB context)
        {
            contextDB = context;
        }
        public Student AddStudent(Student Student)
        {
            contextDB.students.Add(Student);
            contextDB.SaveChanges();
            return Student;
        }

        public Student DeleteStudent(int id)
        {
            var deleted_student = contextDB.students.FirstOrDefault(s => s.StudentId == id);
            contextDB.students.Remove(deleted_student);
            return deleted_student;
        }

        public Student GetStudent(int id)
        {
            var get_student = contextDB.students.FirstOrDefault(s=>s.StudentId == id);
            contextDB.SaveChanges();
            return get_student;
        }

        public IEnumerable<Student> GetStudentAll()
        {
             var all_student = contextDB.students;
            return all_student;
        }

        public Student UpdateStudent(Student Student)
        {
            var update_stuednt = contextDB.students.Attach(Student);
            update_stuednt.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return Student;

        }
    }
}
*/