using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class EmployeeService
    {
        private EmployeeRepository repository;

        public EmployeeService()
        {
            repository = new EmployeeRepository();
        }

        public List<Employee> GetAllEmployees()
        {
            return repository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return repository.GetEmployeeById(id);
        }

        public void AddEmployee(Employee toAdd)
        {
            repository.AddEmployee(toAdd);
        }

        public void DeleteEmployee(Employee toDelete)
        {
            repository.DeleteEmployee(toDelete);
        }

        public List<Employee> GetEmployeeByWorkLength(int yearsWorked)
        {
            List<Employee> fullList = GetAllEmployees();
            List<Employee> filteredList = new List<Employee>();
            DateTime minDate = DateTime.Now.AddYears(-1 * yearsWorked).ToUniversalTime();

            for (int i = 0; i < fullList.Count; i++)
            {
                Employee temp = fullList.ElementAt(i);
                DateTime tempDate = temp.hireDate.ToUniversalTime();

                if(tempDate.CompareTo(minDate) < 0)
                {
                    filteredList.Add(temp);
                }
            }

            return filteredList;
        }
    }
}