using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class EmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            return null;
        }

        public Employee GetEmployeeById(int id)
        {
            return null;
        }

        public void AddEmployee(Employee toAdd)
        {
            
        }

        public void DeleteEmployee(Employee toDelete)
        {

        }

        public List<Employee> GetEmployeeByWorkLength(int yearsWorked)
        {
            List<Employee> filteredList = GetAllEmployees();
            //Filter list here
            return filteredList;
        }
    }
}