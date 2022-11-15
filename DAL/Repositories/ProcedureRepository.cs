using DAL.Repositories.Interfaces;

namespace DAL.Repositories;

public class ProcedureRepository : IProcedureRepository
{
    private readonly string _baseUrl;
    private readonly HttpClient _http;

    public ProcedureRepository(HttpClient http)
    {
        _http = http;
        _baseUrl = "api/procedure";
    }


    public async Task CallProcedure()
    {
        await _http.GetAsync(_baseUrl);
    }
}