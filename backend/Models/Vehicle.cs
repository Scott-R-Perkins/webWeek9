namespace backend.Models;

public class Vehicle{
    public int Id {get; set;}

    public string? Name {get; set;}

    public string? manufaturer {get; set;} = default!;
    public List<ManufacturerFood>? ManufacturerFoods {get; set;}
}