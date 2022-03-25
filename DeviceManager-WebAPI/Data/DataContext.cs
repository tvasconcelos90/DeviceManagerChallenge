using DeviceManager_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManager_WebAPI.Data 
{   
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Device>()
                .HasData(new List<Device>(){
                    new Device(1, "Personal Phone", "Available", "smartphone", "Personal smartphone", 28),
                    new Device(2, "Work Tablet", "Offline", "tablet", "Samsung Tablet", 33),
                    new Device(3, "Work Computer", "Available", "computer", "Company's Computer", 48)
                });
        }
    }
}