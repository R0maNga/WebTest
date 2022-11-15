namespace DAL.Models.ForCupboardModels.Response;

public class GetCupboardModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? Year { get; set; }

    /*public IEnumerable<Cupboard> Cupboards { get; set; } = new List<Cupboard>();*/
}