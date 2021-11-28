using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14Practice.API.Context;

namespace Day14Practice.API.Modals
{
    public class IEmployeeRepository_sqlserver : IEmployeeRepository
    {
        private EmployeeContext private_companyContext;
        public IEmployeeRepository_sqlserver(EmployeeContext companyContext)
        {
            private_companyContext = companyContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            private_companyContext.Employees.Add(employee);
            private_companyContext.SaveChanges();
            return employee;

        }

        public Employee DeleteEmployee(int id)
        {
            var delete_employee = private_companyContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            private_companyContext.Remove(delete_employee);
            private_companyContext.SaveChanges();
            return delete_employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return private_companyContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return private_companyContext.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee changedemployee)
        {
            var update_employee = private_companyContext.Employees.Attach(changedemployee);
            update_employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            private_companyContext.SaveChanges();
            return changedemployee;
        }
    }
}
