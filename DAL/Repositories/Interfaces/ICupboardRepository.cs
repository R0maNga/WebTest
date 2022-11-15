using DAL.Models.ForCupboards.Request;
using DAL.Models.ForCupboards.Response;

namespace DAL.Repositories.Interfaces;

public interface ICupboardRepository
{
    public Task Create(CreateCupboard entity);
    public Task Delete(DeleteCupboard entity);
    public Task Update(UpdateCupboard entity);
    public Task<List<GetCupboard>> GetAsync();
    public Task<GetCupboardById?> GetByIdAsync(Guid id);
}