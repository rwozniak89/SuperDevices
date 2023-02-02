using System.ComponentModel.DataAnnotations;

namespace SuperDevices.Domain.Dtos
{
    public class DeviceDto
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string SerialNumber { get; set; } = string.Empty;

        public string CreateInfo { get; set; } = string.Empty;
        public string EditorInfo { get; set; } = string.Empty;

        public int Version { get; set; }



    }
}
