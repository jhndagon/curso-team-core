using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGLWebApp.Models;

namespace TGLWebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Id= Guid.NewGuid(),
                Age = 24,
                Name = "John",
                LastName = "David",
                Nit = "12341234"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 24,
                Name = "Pedro",
                LastName = "Andres",
                Nit = "432134"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 24,
                Name = "Alguien",
                LastName = "En serio",
                Nit = "235423"
            });
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudenById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Age = student.Age;
            currentStudent.Nit = student.Nit;
        }

        internal Student GetStudenById(Guid id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
