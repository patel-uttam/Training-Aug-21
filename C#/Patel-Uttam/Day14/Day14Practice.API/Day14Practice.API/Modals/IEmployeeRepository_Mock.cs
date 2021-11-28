/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14Practice.API.Modals
{
    public class IEmployeeRepository_Mock : IEmployeeRepository
    {
        private List<Employee> employee_list;

        public IEmployeeRepository_Mock()
        {
            employee_list = new List<Employee>
            {
                new Employee(){EmployeeId = 6,EmployeeName = "User6",Gender = "male",CurrentAddress = "12,asdf",PermanentAddress = "12.asdf",DateOFBirth = "01/06/2000",City = "Faugi",Nationality = "asd",PINCode = "123456"},
                new Employee(){EmployeeId = 7,EmployeeName = "User7",Gender = "male",CurrentAddress = "12,sdfgh",PermanentAddress = "12.asdf",DateOFBirth = "01/06/2000",City = "Faugi",Nationality = "asd",PINCode = "123453"},
                new Employee(){EmployeeId = 8,EmployeeName = "User8",Gender = "male",CurrentAddress = "12,asdf",PermanentAddress = "12.asdf",DateOFBirth = "01/06/2000",City = "Faugi",Nationality = "zxcv",PINCode = "123456"},
                new Employee(){EmployeeId = 9,EmployeeName = "User9",Gender = "male",CurrentAddress = "12,dfgh",PermanentAddress = "12.asdf",DateOFBirth = "01/06/2000",City = "Faugi",Nationality = "asdf",PINCode = "123455"}

            };
        }

        public Employee AddEmployee(Employee employee)
        {
            Employee insert_employee = employee;
            employee_list.Add(employee);
            return insert_employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var delete_employee = employee_list.FirstOrDefault(e => e.EmployeeId == id);
            if(delete_employee != null)
            {
                employee_list.Remove(delete_employee);
                
            }
            return delete_employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employee_list.ToList();

        }

        public Employee GetEmployee(int id)
        {
            return employee_list.FirstOrDefault(e=>e.EmployeeId == id);
        }

        public Employee UpdateEmployee(Employee changedemployee)
        {
            var update_employee = employee_list.FirstOrDefault(e => e.EmployeeId == changedemployee.EmployeeId);
            if (update_employee != null)
            {
                update_employee.Gender = changedemployee.Gender;
                update_employee.PINCode = changedemployee.PINCode;
                *//*
                .
                .
                *//*
            }
            return update_employee;
        }
    }
}
*/