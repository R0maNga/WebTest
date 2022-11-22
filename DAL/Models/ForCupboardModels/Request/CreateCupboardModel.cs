namespace DAL.Models.ForCupboardModels.Request;

public class CreateCupboardModel
{
    public string Name { get; set; } = string.Empty;
    public int? Year { get; set; }
}