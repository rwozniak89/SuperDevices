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

        //public DbSet<Device> Devices => Set<Device>();


        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<Device>().HasData(
        //        new Device { Id = Guid.NewGuid(), Name = "Telewizor X", SerialNumber="12345", Version=1, Creator="admin@it.com", DateCreate= DateTime.Parse("2023-02-01") },
        //        new Device { Id = Guid.NewGuid(), Name = "Radio Y", SerialNumber = "987654", Version = 1, Creator = "admin@it.com", DateCreate = DateTime.Parse("2023-02-2") }
        //        );
        //}
    }
}