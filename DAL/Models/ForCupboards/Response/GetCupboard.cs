using System.Text.Json.Serialization;
using DAL.Models.Additional;

namespace DAL.Models.ForCupboards.Response;

public class GetCupboard
{
    public Guid Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

    [JsonPropertyName("ownerName")] public string? OwnerName { get; set; }

    [JsonPropertyName("modelId")] public Guid ModelId { get; set; }

    public ModelAdditional? CupboardModel { get; set; }
}