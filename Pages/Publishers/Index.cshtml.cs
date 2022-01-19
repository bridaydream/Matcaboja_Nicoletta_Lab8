using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Matcaboja_Nicoletta_Lab8.Data;
using Matcaboja_Nicoletta_Lab8.Models;

namespace Matcaboja_Nicoletta_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Matcaboja_Nicoletta_Lab8.Data.Matcaboja_Nicoletta_Lab8Context _context;

        public IndexModel(Matcaboja_Nicoletta_Lab8.Data.Matcaboja_Nicoletta_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
