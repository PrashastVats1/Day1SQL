using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCoreAssignment.Models;

namespace WebAppCoreAssignment.Data
{
    public class TaskMgmtDbContext : DbContext
    {
        public TaskMgmtDbContext (DbContextOptions<TaskMgmtDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCoreAssignment.Models.TaskItem> TaskItem { get; set; } = default!;
    }
}
