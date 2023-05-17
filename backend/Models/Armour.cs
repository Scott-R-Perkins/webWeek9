namespace backend.Models;

public class Armour
{
    public int armourId { get; set; }
    public string? name { get; set; }
    public int? physicalDefenceValue { get; set; }
    public int? magicalDefenceValue { get; set; }
    public string? flavourText { get; set; }
    public int? price { get; set; }
}