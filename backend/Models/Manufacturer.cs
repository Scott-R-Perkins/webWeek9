namespace backend.Models;

public class Manufaturer{
    public int Id {get; set;}

    public string? ManucaturerName{get; set;}
    
    public string? Location {get; set;}

    public List<ManufacturerFood>? ManufacturerFoods {get; set;}
}