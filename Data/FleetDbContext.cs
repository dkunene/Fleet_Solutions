
using Microsoft.EntityFrameworkCore;
using Fleet.Models;

namespace Fleet.Data
{
    public class FleetDbContext : DbContext
    {
        public FleetDbContext(DbContextOptions<FleetDbContext> options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Driver)
                .WithMany()
                .HasForeignKey(t => t.DriverId);

            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Vehicle)
                .WithMany()
                .HasForeignKey(t => t.VehicleId);
        }
    }
}
