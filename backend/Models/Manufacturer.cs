namespace backend.Models;

public class Manufaturer{
    public int Id {get; set;}

    public string? ManucaturerName{get; set;}

    public List<ManufacturerFood>? ManufacturerFoods {get; set;}
}