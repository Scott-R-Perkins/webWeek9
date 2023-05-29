namespace backend.Models;

public class Potion
{
    public int potionId { get; set; }
    public string? name { get; set; }
    public string? potionDescription { get; set; }
    public int? potionPotencyValue { get; set; }
    public int? price { get; set; }
    public string? imgURL { get; set; }
}