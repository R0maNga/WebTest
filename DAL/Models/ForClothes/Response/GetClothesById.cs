namespace DAL.Models.ForClothes.Response;

public class GetClothesById
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? DefaultQuantity { get; set; }
}