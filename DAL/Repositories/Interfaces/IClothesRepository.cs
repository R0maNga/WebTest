using DAL.Models.ForClothes.Request;
using DAL.Models.ForClothes.Response;

namespace DAL.Repositories.Interfaces;

public interface IClothesRepository
{
    public Task Create(CreateClothes model);
    public Task Delete(DeleteClothes model);
    public Task Update(UpdateClothes model);
    public Task<List<GetClothes>> GetAsync();
    public Task<GetClothesById?> GetByIdAsync(Guid id);
}