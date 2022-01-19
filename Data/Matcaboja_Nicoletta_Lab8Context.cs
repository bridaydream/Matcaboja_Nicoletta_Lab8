using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Matcaboja_Nicoletta_Lab8.Models;

namespace Matcaboja_Nicoletta_Lab8.Data
{
    public class Matcaboja_Nicoletta_Lab8Context : DbContext
    {
        public Matcaboja_Nicoletta_Lab8Context (DbContextOptions<Matcaboja_Nicoletta_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Matcaboja_Nicoletta_Lab8.Models.Book> Book { get; set; }

        public DbSet<Matcaboja_Nicoletta_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Matcaboja_Nicoletta_Lab8.Models.Category> Category { get; set; }
    }
}
