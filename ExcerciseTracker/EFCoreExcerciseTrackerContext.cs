using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ExcerciseTracker
{
    internal class EFCoreExcerciseTrackerContext : DbContext
    {
        public DbSet<ExcerciseSession> ExcerciseSessions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ExcerciseTrackerAppDatabase;Trusted_Connection=True;");
        }
    }
}
