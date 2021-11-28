using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15Assignment.API.Models;

namespace Day15Assignment.API.Repository
{
    public class IAssignmentRepository_ : IAssignmentRepository
    {
        private readonly Employee_Assignment_DbContext DbContext;

        public IAssignmentRepository_(Employee_Assignment_DbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public IEnumerable<Assignment> GetAllAssignment(int emp_id)
        {

            return DbContext.Assignments.Where(e=>e.EmployeeId == emp_id).ToList();
            
        }

        public Assignment GetAssignment(int Emp_id , int ass_id)
        {
            var Searched_Assignment = DbContext.Assignments.Where(e=>e.EmployeeId == Emp_id).FirstOrDefault(e => e.AssignmentId == ass_id);
            return Searched_Assignment;
        }

        public Assignment UpdateAssignment( Assignment assignment)
        {
            var Updated_Assignment = DbContext.Assignments.Attach(assignment);
            Updated_Assignment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DbContext.SaveChanges();
            return assignment;
        }
    }
}
