using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class EmployeeRepository
    {
        private ApplicationDbContext dbContext;

        public EmployeeRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public void addEmployee(Employee toAdd)
        {
            dbContext.Employees.Add(toAdd);
            dbContext.SaveChanges();
        }

        public Employee getEmployeeById(int id)
        {
            return dbContext.Employees.Find(id);
        }

        public void DeleteEmployee(Employee toDelete)
        {
            dbContext.Employees.Remove(toDelete);
            dbContext.SaveChanges();
        }

    }
}