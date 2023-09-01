using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEntityFramework.Models;

namespace WebAppEntityFramework.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEntityFramework.Models.Emp> Emp { get; set; } = default!;
    }
}
