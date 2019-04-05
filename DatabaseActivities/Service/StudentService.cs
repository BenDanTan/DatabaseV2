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
        private StudentRepository repository;

        public StudentService()
        {
            repository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return repository.GetAllStudents();
        }

        public List<Student> GetAllStudentsOver(int age)
        {
            List<Student> students = repository.GetAllStudents();
            List<Student> studentsOver = new List<Student>();

            for(int i = 0; i < students.Count; i++)
            {
                if(students.ElementAt(i).age > age)
                {
                    studentsOver.Add(students.ElementAt(i));
                }
            }

            return studentsOver;
        }

        public void AddStudent(Student toAdd)
        {
            repository.AddStudent(toAdd);
        }

        public Student GetStudentById(int id)
        {
            return repository.GetStudentById(id);
        }

        public void SaveEdits(Student toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteStudent(Student toDelete)
        {
            repository.DeleteStudent(toDelete);
        }
    }
}