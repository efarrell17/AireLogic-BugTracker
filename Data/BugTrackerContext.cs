using BugTracker.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<User> Users { get; set; }

        public string DbPath { get; }

        public BugTrackerContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "BugTracker.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
