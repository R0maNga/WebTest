using System.Net.Http.Json;
using DAL.Models.ForCupboards.Request;
using DAL.Models.ForCupboards.Response;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace DAL.Repositories;

public class CupboardRepository : ICupboardRepository
{
    private readonly string _baseUrl;
    private readonly HttpClient _http;
    private readonly NavigationManager _navigationManager;

    public CupboardRepository(HttpClient http, NavigationManager navigationManager)
    {
        _http = http;
        _baseUrl = "api/cupboard";
        _navigationManager = navigationManager;
    }

    public List<UpdateCupboard> Cup { get; set; } = new();

    public async Task Create(CreateCupboard entity)
    {
        var result = await _http.PostAsJsonAsync(_baseUrl, entity);
        _navigationManager.NavigateTo("/cupboard");
    }

    public async Task Delete(DeleteCupboard entity)
    {
        var result = await _http.DeleteAsync(_baseUrl + $"/{entity.Id}");
        _navigationManager.NavigateTo("/cupboard");
    }

    public async Task<List<GetCupboard>> GetAsync()
    {
        var result = await _http.GetFromJsonAsync<List<GetCupboard>>(_baseUrl);

        return result ?? new List<GetCupboard>();
    }

    public async Task<GetCupboardById?> GetByIdAsync(Guid id)
    {
        var result = await _http.GetFromJsonAsync<GetCupboardById>(_baseUrl + $"/{id}");
        if (result != null)
            return result;
        throw new Exception("Cupboard not found");
    }

    public async Task Update(UpdateCupboard entity)
    {
        await _http.PutAsJsonAsync(_baseUrl, entity);
        _navigationManager.NavigateTo("/cupboard");
    }
}