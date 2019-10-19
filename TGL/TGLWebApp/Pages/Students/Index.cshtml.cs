using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGLWebApp.Data;
using TGLWebApp.Models;

namespace TGLWebApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public List<Student> Students { get; set; }
        public IndexModel(StudentStore studentStore)
        {
            StudentStore = studentStore;
            Students = StudentStore.GetStudents();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            StudentStore.DeleteStudent(id);

            return RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}
