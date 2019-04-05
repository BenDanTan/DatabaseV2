using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class StudentService
    {
        private StudentRepository suppository;

        public StudentService()
        {
            suppository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return suppository.GetAllStudents();
        }

        public void AddStudent(Student toAdd)
        {
            suppository.AddStudent(toAdd);
        }

        public Student GetStudentById(int id)
        {
            return suppository.GetStudentById(id);
        }

        public void SaveEdits(Student toSave)
        {
            suppository.SaveEdits(toSave);
        }

        public void DeleteStudent(Student toDelete)
        {
            suppository.DeleteStudent(toDelete);
        }

        public List<Student> GetOldStudents(int minAge)
        {
            List<Student> all = suppository.GetAllStudents();
            List<Student> old = new List<Student>();
            foreach (Student n in all)
            {
                if (n.age > minAge)
                {
                    old.Add(n);
                }
            }
            return old;
        }

        public List<Student> GetShortNameStudents(int length)
        {
            List<Student> all = suppository.GetAllStudents();
            List<Student> shortNames = new List<Student>();
            foreach (Student n in all)
            {
                if (n.name.Length < length)
                {
                    shortNames.Add(n);
                }
            }
            return shortNames;
        }
    }
}