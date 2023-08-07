using AutoMapper;
using Zbra.Application.Dto;
using Zbra.Domain.Contracts.Queries;

namespace Zbra.Application.AutoMapper
{
    public class DtoToModelMappingProfile : Profile
    {
        public DtoToModelMappingProfile()
        {
            CreateMap<GetValueAddressDto, GetValueAddressQuery>();
        }
    }
}
