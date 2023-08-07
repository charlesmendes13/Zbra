using AutoMapper;
using Zbra.Application.AutoMapper;
using Zbra.Application.Dto;
using Zbra.Domain.Contracts.Queries;

namespace Zbra.Unit.Tests.Application.AutoMapper
{
    public class DtoToModelMappingProfileTest
    {
        [Fact]
        public void DtoToModelMappingProfile()
        {
            var mapper = new DtoToModelMappingProfile();

            mapper.Should().NotBeNull();
        }

        [Fact]
        public void GetValueAddressDto()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoToModelMappingProfile>();
            });

            var mapper = new Mapper(mapperConfig);
            var dto = new GetValueAddressDto()
            {
                Path = "commands.txt"
            };

            var query = mapper.Map<GetValueAddressQuery>(dto);

            query.Path.Should().Be("commands.txt");
        }
    }
}
