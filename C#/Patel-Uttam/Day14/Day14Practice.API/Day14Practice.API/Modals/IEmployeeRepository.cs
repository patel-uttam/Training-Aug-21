using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice.API.Modals
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee changedemployee);
        Employee DeleteEmployee(int id);
    }
}
