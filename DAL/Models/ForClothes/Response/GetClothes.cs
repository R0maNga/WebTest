namespace DAL.Models.ForClothes.Response;

public class GetClothes
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? DefaultQuantity { get; set; }
}