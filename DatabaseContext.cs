using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppFootballTables.Models;

namespace AppFootballTables
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Con esto indicamos que la entidad BookAuthor tiene dos llaves primarias
            modelBuilder.Entity<RankingTableContent>().HasKey(xi => new {xi.TeamID, xi.RankingTableID});

        }
        public DbSet<User>? User { get; set;}
        public DbSet<Team>? Team { get; set;}
        public DbSet<RankingTable>? RankingTable { get; set;}
        public DbSet<RankingTableContent>? RankingTableContent { get; set;}
    }
}