using SuperDevices.Base.Entities;

namespace SuperDevices.Domain.Entities
{
    public class Device : BaseEntity
    {

        public string Name { get; set; } = string.Empty;

        public string SerialNumber { get; set; } = string.Empty;
    }
}
