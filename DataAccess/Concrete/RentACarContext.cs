using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5DJ9FN4\SQLEXPRESS;Database=RentACar;Trusted_Connection=true;TrustServerCertificate=true;");
            optionsBuilder.UseSqlServer("Data Source=WIN-47H6MAU8L06;User ID=sa;Password=Rentacar43;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        public DbSet<Car> Cars  { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MaintenanceDescription> MaintenanceDescriptions { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GearType> GearTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
