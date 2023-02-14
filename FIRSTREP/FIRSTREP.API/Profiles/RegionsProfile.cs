using AutoMapper;

namespace FIRSTREP.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domains.Region, Models.DTO.Region>()
                .ReverseMap();

        }
    }
}
