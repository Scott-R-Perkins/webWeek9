using Microsoft.EntityFrameworkCore;
using backend.Models;


namespace backend.Data;

public class Week9Lab7Context : DbContext
{
    public Week9Lab7Context(DbContextOptions options) : base(options)
    {

    }

    public object? Food { get; set; }

    public object? Vehicle { get; set; }

    public object? Manucaturer { get; set; }

    public object? ManufacturerFood { get; set; }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     var manufacturers = Seed.GetManufacturers(manufacturers);
    //     var food = Seed.GetFood(food);
    //     var vehicle = seed.GetVehicles(vehicle);
    //     var ManufacturerFood = Seed.ManufacturerFood(manufacturers, food);
    // }


}
