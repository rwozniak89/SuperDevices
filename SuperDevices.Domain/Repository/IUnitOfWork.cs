using SuperDevices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevices.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Device> Device { get; }
        //IDeviceRepo DeviceRepo { get; }

        int Save();

        Task<int> SaveAsync();

    }
}
