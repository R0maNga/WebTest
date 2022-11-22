namespace DAL.Models.ForClothes.Request;

public class UpdateClothes
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? DefaultQuantity { get; set; }
}