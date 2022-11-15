using AutoMapper;
using DAL.Models.ForCupboardClothes.Request;
using DAL.Models.ForCupboardClothes.Response;

namespace DAL.Automapper;

public class CupboardClothesProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GetCupboardClothes, CreateCupboardClothes>();
        }
    }
}