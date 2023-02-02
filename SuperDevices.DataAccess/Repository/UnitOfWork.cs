using SuperDevices.DataAccess.Context;
using SuperDevices.Domain.Entities;
using SuperDevices.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevices.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Device = new GenericRepository<Device>(_context);
        }

        public IGenericRepository<Device> Device { get; private set;}

        //public IDeviceRepo DeviceRepo { get; private set; }



        public int Save()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
