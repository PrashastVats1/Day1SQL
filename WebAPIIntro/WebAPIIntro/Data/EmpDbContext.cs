using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIIntro.Models;

namespace WebAPIIntro.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIIntro.Models.Employee> Employee { get; set; } = default!;
    }
}
