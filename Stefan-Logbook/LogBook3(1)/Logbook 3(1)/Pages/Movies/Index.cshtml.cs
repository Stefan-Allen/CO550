using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logbook_3_1_.Data;
using RazorPagesMovie.Models;

namespace Logbook_3_1_.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Logbook_3_1_.Data.Logbook_3_1_Context _context;

        public IndexModel(Logbook_3_1_.Data.Logbook_3_1_Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
