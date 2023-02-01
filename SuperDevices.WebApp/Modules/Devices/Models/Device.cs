using SuperDevices.WebApp.Modules.Base;

namespace SuperDevices.WebApp.Modules.Devices.Models
{
    public class Device : BaseEntity
    {

        public string Name { get; set; } = string.Empty;

        public string SerialNumber { get; set; } = string.Empty;
    }
}
