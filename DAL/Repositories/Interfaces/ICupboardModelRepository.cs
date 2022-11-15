using DAL.Models.Additional;
using DAL.Models.ForCupboardModels.Request;
using DAL.Models.ForCupboardModels.Response;

namespace DAL.Repositories.Interfaces;

public interface ICupboardModelRepository
{
    public List<ModelAdditional> CupboardModel { get; set; }
    public Task Create(CreateCupboardModel model);
    public Task<List<GetCupboardModel>> GetAsync();
}