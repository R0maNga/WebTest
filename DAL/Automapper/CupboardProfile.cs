using AutoMapper;
using DAL.Models.ForCupboards.Request;
using DAL.Models.ForCupboards.Response;

namespace DAL.Automapper;

public class CupboardProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GetCupboardById, CreateCupboard>();
            CreateMap<GetCupboardById, UpdateCupboard>();
            CreateMap<GetCupboardById, DeleteCupboard>();
        }
    }
}