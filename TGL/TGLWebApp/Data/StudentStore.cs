using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGLWebApp.Models;

namespace TGLWebApp.Data
{
    public class StudentStore
    {
        //private List<Student> Students { get; set; } = new List<Student>();
        public TGLContext Context { get; set; }
        public StudentStore(TGLContext context)
        {
            Context = context;
            /*
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
            });*/
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudenById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Age = student.Age;
            currentStudent.Nit = student.Nit;
            Context.Student.Update(currentStudent);
            Context.SaveChanges();
        }

        internal Student GetStudenById(Guid id)
        {
            return Context.Student.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Context.Student.Add(student);
            Context.SaveChanges();
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Student.Remove(student);
            Context.SaveChanges();
        }

        public List<Student> GetStudents()
        {
            return Context.Student.ToList();
        }
    }
}
