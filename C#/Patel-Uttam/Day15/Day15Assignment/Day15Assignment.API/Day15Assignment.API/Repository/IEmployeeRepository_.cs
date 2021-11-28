/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15Assignment.API.Models;

namespace Day15Assignment.API.Repository
{
    public class IEmployeeRepository_ : IEmployeeRepository
    {
        private readonly Employee_Assignment_DbContext DbContext;

        public IEmployeeRepository_(Employee_Assignment_DbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return DbContext.Employees;
        }

        public IEnumerable<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
*/