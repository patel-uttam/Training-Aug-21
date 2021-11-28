using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15Assignment.API.Models;

namespace Day15Assignment.API.Repository
{
    public interface IAssignmentRepository
    {
        public IEnumerable<Assignment> GetAllAssignment(int id);

        public Assignment GetAssignment(int id , int id2);

        public Assignment UpdateAssignment(Assignment assignment);


    }
}
