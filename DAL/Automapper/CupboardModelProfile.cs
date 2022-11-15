using AutoMapper;
using DAL.Models.Additional;
using DAL.Models.ForCupboardModels.Response;

namespace DAL.Automapper;

public class CupboardModelProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GetCupboardModel, ModelAdditional>();
        }
    }
}