using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIEx.Models;

namespace WebAPIEx.Data
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext (DbContextOptions<TasksDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIEx.Models.Task> Task { get; set; } = default!;
    }
}
