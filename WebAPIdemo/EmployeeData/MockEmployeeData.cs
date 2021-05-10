using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdemo.Models;

namespace WebAPIdemo.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Emp1"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Emp2"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
