using Microsoft.EntityFrameworkCore;
using SmartCity.Entities.Concrete;

namespace SmartCity.DataAccess.Concrete.EntityFramework
{
    public class SmartCityContext : DbContext
    {
        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarPark>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=SmartCityDB; Integrated Security=True;");
            }
        }
    }
}