using CS322_Projekat.Enums;
using CS322_Projekat.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Projekat.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<UserSale> UserSales { get; set; }
        public DbSet<UserSaleItem> UserSaleItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=root;database=cs322_pz;",
                new MySqlServerVersion(new Version(10, 5, 0))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Admin migration
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Name = "Admin",
                Email = "admin@vinylstore.com",
                Password = "admin123", 
                Role = RoleEnum.Admin
            });
        }
    }
}
