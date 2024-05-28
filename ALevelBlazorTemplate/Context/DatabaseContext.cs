using ALevelBlazorTemplate.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ALevelBlazorTemplate.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        private IWebHostEnvironment _environment;

        public DbSet<Habit> Habits { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IWebHostEnvironment environment) : base(options)
        {
            _environment = environment;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Path.Combine(_environment.WebRootPath, "database");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            optionbuilder.UseSqlite($"Data Source={folder}/habit.db");
        }
    }
}