using System.Net.Http.Json;
using DAL.Models.ForClothes.Request;
using DAL.Models.ForClothes.Response;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace DAL.Repositories;

public class ClothesRepository : IClothesRepository
{
    private readonly string _baseUrl;
    private readonly HttpClient _http;
    private readonly NavigationManager _navigationManager;

    public ClothesRepository(HttpClient http, NavigationManager navigationManager)
    {
        _http = http;
        _baseUrl = "api/clothes";
        navigationManager = _navigationManager;
    }

    public async Task Create(CreateClothes model)
    {
        var result = await _http.PostAsJsonAsync(_baseUrl, model);
    }

    public async Task Delete(DeleteClothes model)
    {
        var result = await _http.DeleteAsync(_baseUrl + $"/{model.Id}");
    }

    public async Task<List<GetClothes>> GetAsync()
    {
        var result = await _http.GetFromJsonAsync<List<GetClothes>>(_baseUrl);
        return result ?? new List<GetClothes>();
    }

    public async Task<GetClothesById?> GetByIdAsync(Guid id)
    {
        var result = await _http.GetFromJsonAsync<GetClothesById>(_baseUrl + $"/{id}");
        if (result != null)
            return result;
        throw new Exception("Clothes not found");
    }

    public async Task Update(UpdateClothes model)
    {
        var result = await _http.PutAsJsonAsync(_baseUrl, model);
    }
}