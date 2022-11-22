using System.ComponentModel.DataAnnotations;

namespace DAL.Models.ForCupboardClothes.Request;

public class CreateCupboardClothes
{
    [Required(ErrorMessage = "asdasd")] public Guid CupboardId { get; set; }

    [Required] public Guid ClothesId { get; set; }

    [Required] public int Quantity { get; set; }
}