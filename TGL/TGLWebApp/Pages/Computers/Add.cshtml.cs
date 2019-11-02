using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGLWebApp.Data;
using TGLWebApp.Models;

namespace TGLWebApp.Pages.Computers
{
    public class AddModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        [BindProperty]
        public Computer Computer { get; set; }
        [BindProperty]
        public Guid StudentId { get; set; }
        public AddModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
        }
        public void OnGet(Guid id)
        {
            StudentId = id;
        }

        public ActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Computer.StudenId = StudentId;
            ComputerStore.AddComputer(Computer);
            return RedirectToPage("../Students/Index");
        }
    }
}