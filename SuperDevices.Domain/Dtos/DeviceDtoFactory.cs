using AutoMapper;
using SuperDevices.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SuperDevices.Domain.Dtos
{
    public static class DeviceDtoFactory
    {


        public static DeviceDto CreateDtofromModel(IMapper _mapper, Device device)
        {
            var deviceDto = _mapper.Map<DeviceDto>(device);

            return deviceDto;
        }

        public static IEnumerable<DeviceDto> CreateCollectionDtofromModelCollection(IMapper _mapper, IEnumerable<Device> devices)
        {
            var deviceDtos = _mapper.Map<IEnumerable<DeviceDto>>(devices);

            return deviceDtos;
        }

        public static Device CreateModelfromDto(IMapper _mapper, DeviceDto deviceDto)
        {
            var device = _mapper.Map<Device>(deviceDto);

            return device;
        }



        public static void UpdateModelfromDto(IMapper _mapper, Device device, DeviceDto deviceDto)
        {
            _mapper.Map<DeviceDto, Device>(deviceDto, device);
        }

    }
}
