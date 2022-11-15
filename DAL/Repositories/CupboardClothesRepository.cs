using DAL.Models.ForCupboardClothes.Request;
using DAL.Models.ForCupboardClothes.Response;
using DAL.Repositories.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Repositories
{
    public class CupboardClothesRepository : ICupboardClothesRepository
    {
        private readonly string _baseUrl;
        private readonly HttpClient _http;
        public CupboardClothesRepository(HttpClient http)
        {
            _http = http;
            _baseUrl = "api/cupboard-clothes";
        }

        public async Task Create(CreateCupboardClothes model)
        {

            var result = await _http.PostAsJsonAsync(_baseUrl, model);

        }

        

        public async Task<List<GetCupboardClothes>> GetAsync()
        {
            var result = await _http.GetFromJsonAsync<List<GetCupboardClothes>>(_baseUrl);

            if (result != null)
                return result;
            throw new Exception("CupboardClothes empty");
        }
    }
}
