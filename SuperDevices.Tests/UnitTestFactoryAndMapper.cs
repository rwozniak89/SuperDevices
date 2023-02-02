using SuperDevices.Domain.Entities;
using SuperDevices.Domain.Dtos;
using SuperDevices.Domain.AMProfiles;
using AutoMapper;

namespace SuperDevices.Tests
{
    public class UnitTestFactoryAndMapper
    {


        private static IMapper _mapper;

        public UnitTestFactoryAndMapper()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new DevicePofiles());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public void MapShouldHaveValidConfig()
        {

            // Assert
            Assert.NotNull( _mapper );
            Assert.IsAssignableFrom<IMapper>(_mapper);
        }

        [Fact]
        public void FactoryShouldCreateDtoFromModelAccordingToTheRules()
        {

            // Arrange
            string email = "email@email.pl";
            var date = DateTime.Now;
            string creatorInfo = email + " - " + date.ToShortDateString();


            var device = new Device()
            {
                Id = Guid.NewGuid(),
                Name = "Name1",
                SerialNumber = "123",
                Creator = email,
                DateCreate = date,
                Editor = email,
                DateEdit = date
            };


            // Act
            var deviceDto = DeviceDtoFactory.CreateDtofromModel(_mapper, device);
            // Assert
            Assert.IsType<DeviceDto>(deviceDto);
           
            Assert.Equal(device.Id, deviceDto.Id);

            Assert.Equal(deviceDto.CreateInfo, creatorInfo);

        }


        [Fact]
        public void FactoryShouldCreateModelFromDtoAccordingToTheRules()
        {

            // Arrange
            var deviceDto = new DeviceDto()
            {
                Id = Guid.NewGuid(),
                Name = "Name1",
                SerialNumber = "123",
            };


            // Act
            var device = DeviceDtoFactory.CreateModelfromDto(_mapper, deviceDto);
            // Assert
            Assert.IsType<Device>(device);

            Assert.Equal(device.Id, deviceDto.Id);

        }

    }
}