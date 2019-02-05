using Microsoft.EntityFrameworkCore;
using movienotes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Data
{
    public class TestContext : DbContext
    {
        public DbSet<Award> Awards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBUilder)
        {
            string path = System.IO.Path.Combine(
                System.Environment.CurrentDirectory, "Data", "mnotes.db");
       
            optionsBUilder.UseSqlite($"Filename = mnotes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieAward>()
                .HasKey(ma => new { ma.AwardID, ma.MovieID });
        }
    }
}
