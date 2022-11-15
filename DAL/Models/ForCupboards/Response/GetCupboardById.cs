using DAL.Models.Additional;

namespace DAL.Models.ForCupboards.Response;

public class GetCupboardById
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? OwnerName { get; set; }
    public Guid ModelId { get; set; }

    public ModelAdditional? CupboardModel { get; set; }
    /*public CupboardModel CupboardModel { get; set; } = new CupboardModel();*/
}