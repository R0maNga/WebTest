namespace DAL.Models.ForCupboardClothes.Response;

public class GetCupboardClothes
{
    public Guid Id { get; set; }
    public Guid CupboardId { get; set; }
    public Guid ClothesId { get; set; }
    public int Quantity { get; set; }
}