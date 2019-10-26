using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGLWebApp.Models
{
    public class Student
    {

        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Required]
        public string Nit { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

    }
}
