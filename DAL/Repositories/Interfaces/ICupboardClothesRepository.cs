using DAL.Models.ForCupboardClothes.Request;
using DAL.Models.ForCupboardClothes.Response;

namespace DAL.Repositories.Interfaces;

public interface ICupboardClothesRepository
{
    public Task Create(CreateCupboardClothes entity);
    public Task<List<GetCupboardClothes>> GetAsync();
}