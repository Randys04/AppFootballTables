using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppFootballTables.Models
{
    public class DatabaseContext : DbContext
    {
        private const string connectionString = @"Data Source=DESKTOP-EHI5R08\SQLEXPRESS; Initial Catalog=FootyTables; Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulider)
        {
            optionsBulider.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Con esto indicamos que la entidad BookAuthor tiene dos llaves primarias
            modelBuilder.Entity<RankingTableContent>().HasKey(xi => new {xi.TeamID, xi.RankingTableID});

        }
        public DbSet<User>? Users { get; set;}
        public DbSet<Team>? Teams { get; set;}
        public DbSet<RankingTable>? RankingTables { get; set;}
        public DbSet<RankingTableContent>? RankingTablesContent { get; set;}
    }
}