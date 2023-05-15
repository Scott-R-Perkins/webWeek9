namespace backend.Models;

public class Food{
    public int Id {get; set;}

    public string? Name {get; set;}

    public string? description {get; set;} = default!;
    public List<ManufacturerFood>? ManufacturerFoods {get; set;}
}