using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace Logbook_3_1_.Data
{
    public class Logbook_3_1_Context : DbContext
    {
        public Logbook_3_1_Context (DbContextOptions<Logbook_3_1_Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
