namespace backend.Models;

public class ManufacturerFood{
    public int Id {get; set;}

    public int? FoodId {get; set;}

    public string? FoodName {get; set;}

    public int? ManucaturerId {get; set;}
    
    public string? ManufacturerName {get; set;}
}