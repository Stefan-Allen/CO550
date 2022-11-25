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
    public class DetailsModel : PageModel
    {
        private readonly Logbook_3_1_.Data.Logbook_3_1_Context _context;

        public DetailsModel(Logbook_3_1_.Data.Logbook_3_1_Context context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
