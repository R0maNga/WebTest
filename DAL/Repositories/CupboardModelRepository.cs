using System.Net.Http.Json;
using System.Text.Json;
using DAL.Models.Additional;
using DAL.Models.ForCupboardModels.Request;
using DAL.Models.ForCupboardModels.Response;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories;

public class CupboardModelRepository : ICupboardModelRepository
{
    private readonly string _baseUrl;
    private readonly HttpClient _http;

    public CupboardModelRepository(HttpClient http)
    {
        _http = http;
        _baseUrl = "api/cupboard-model";
    }


    public List<ModelAdditional> CupboardModel { get; set; } = new();

    public async Task Create(CreateCupboardModel model)
    {
        var result = await _http.PostAsJsonAsync(_baseUrl, model);
    }

    public async Task<List<GetCupboardModel>> GetAsync()
    {
        var result = await _http.GetFromJsonAsync<List<GetCupboardModel>>(_baseUrl);

        if (result != null)
            return result;
        throw new Exception("CupboardModel empty");
    }
}