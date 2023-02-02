using AutoMapper;
using SuperDevices.Domain.Dtos;
using SuperDevices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevices.Domain.AMProfiles
{
    internal class DevicePofiles : Profile
    {
        public DevicePofiles() 
        {
            //Source, Dest
            CreateMap<Device, DeviceDto>()
                .ForMember(
                    dest => dest.CreateInfo,
                    opt => opt.MapFrom(src => $"{src.Creator} - {src.DateCreate.ToShortDateString()}"))
                .ForMember(
                    dest => dest.EditorInfo,
                    opt => opt.MapFrom(src => $"{src.Editor} - {src.DateEdit.ToShortDateString()}"))
                ;

            CreateMap<DeviceDto, Device>()
                .ForMember(
                    dest => dest.Version,
                    opt => opt.Ignore());
        }
    }
}
