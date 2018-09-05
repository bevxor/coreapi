using AutoMapper;

namespace CoreApi.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Application.Model.Customer, Entity.Model.Customer>()
                .ReverseMap();
        }
    }
}