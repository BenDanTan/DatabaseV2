using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    
    public class StudentRepository
    {
        private ApplicationDbContext dbContext;

        public StudentRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public List<Student> GetAllStudents()
        {
            return dbContext.Students.ToList();
        }

        public void AddStudent(Student toAdd)
        {
            dbContext.Students.Add(toAdd);
            dbContext.SaveChanges();
        }
        public Student GetStudentById(int id)
        {
            return dbContext.Students.Find(id);
        }
        public void SaveEdits(Student toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteStudent(Student toDelete)
        {
            dbContext.Students.Remove(toDelete);
            dbContext.SaveChanges();
        }
    }
}