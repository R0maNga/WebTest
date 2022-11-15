using AutoMapper;
using DAL.Models.ForClothes.Request;
using DAL.Models.ForClothes.Response;

namespace DAL.Automapper;

public class ClothesProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GetClothesById, CreateClothes>();
            CreateMap<GetClothesById, UpdateClothes>();
            CreateMap<GetClothesById, DeleteClothes>();
        }
    }
}