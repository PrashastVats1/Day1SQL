using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIAssignment.Models;

namespace WebAPIAssignment.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIAssignment.Models.Movie> Movie { get; set; } = default!;
    }
}
