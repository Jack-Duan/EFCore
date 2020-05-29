using EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCore.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Province> Procinces { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreDemo;Trusted_Connection=true;");
        }

    }
}
