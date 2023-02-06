using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperDevices.Domain.Entities;

namespace SuperDevices.DataAccess.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         
        public DbSet<Device> Devices => Set<Device>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Device>().HasData(
                new Device { Id = Guid.Parse("1aa64943-a2b8-4615-b1b4-623a2e6b1541"), Name = "Telewizor X", SerialNumber = "12345", Version = 1, Creator = "x@x.com", DateCreate = DateTime.Parse("2023-02-01"), Editor = "x@x.com", DateEdit = DateTime.Parse("2023-02-01") },
                new Device { Id = Guid.Parse("582258d3-6621-4b41-82e5-1e89f1c4fff1"), Name = "Radio Y", SerialNumber = "987654", Version = 1, Creator = "x@x.com", DateCreate = DateTime.Parse("2023-02-02"), Editor = "x@x.com", DateEdit = DateTime.Parse("2023-02-02") },
                new Device { Id = Guid.Parse("c7deaff3-6b2a-4727-966a-5f2b9a2ceb1a"), Name = "Pilot Z", SerialNumber = "123", Version = 1, Creator = "x@x.com", DateCreate = DateTime.Parse("2023-02-02"), Editor = "x@x.com", DateEdit = DateTime.Parse("2023-02-02") }
                );
        }
    }
}