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
        private EmployeeRepository suppository;

        public EmployeeService()
        {
            suppository = new EmployeeRepository();
        }

        public List<Employee> GetAllEmployees()
        {
            return suppository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return suppository.getEmployeeById(id);
        }

        public void AddEmployee(Employee toAdd)
        {
            suppository.addEmployee(toAdd);
        }

        public void DeleteEmployee(Employee toDelete)
        {
            suppository.DeleteEmployee(toDelete);
        }

        public List<Employee> GetEmployeeByWorkLength(int yearsWorked)
        {
            List<Employee> filteredList = GetAllEmployees();
            List<Employee> loyalWorkers = new List<Employee>();
            DateTime now = DateTime.Today;
            int currentYear = now.Year;
            foreach (Employee worker in filteredList) {
                if (currentYear - worker.hireDate.Year >= yearsWorked) {
                    loyalWorkers.Add(worker);
                }
            }
            return loyalWorkers;
        }
    }
}