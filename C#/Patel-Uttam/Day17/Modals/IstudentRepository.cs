using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Practice_Basic_Auth.API.Modals
{
    public interface IstudentRepository
    {
        IEnumerable<Student> GetStudentAll();

        Student GetStudent(int id);

        Student AddStudent(Student Student);

        Student UpdateStudent(Student Student);

        Student DeleteStudent(int id);
    }
}
