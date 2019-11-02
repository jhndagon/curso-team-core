using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGLWebApp.Models;

namespace TGLWebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }

        public ComputerStore(TGLContext context)
        {
            Context = context;
        }

        internal List<Computer> GetComputers()
        {
            return Context.Computer.ToList();
        }

        internal void AddComputer(Computer computer)
        {
            Context.Computer.Add(computer);
            Context.SaveChanges();
        }
    }
}
