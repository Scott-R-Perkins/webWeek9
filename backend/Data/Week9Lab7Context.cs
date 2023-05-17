using Microsoft.EntityFrameworkCore;
using backend.Models;


namespace backend.Data;

public class Week9Lab7Context : DbContext
{
    public Week9Lab7Context(DbContextOptions options) : base(options)
    {

    }

    public object? Weapon { get; set; }

    public object? Armour { get; set; }

    public object? Potion { get; set; }

   protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Weapon>().HasData(
            new Weapon(1,"Sword of the Kings Deceit", 170, 1.65, 140),
            new Weapon(2, "Mace of Sundering", 220, 1.10,170),
            new Weapon(3, "Daggers of the Twin Snakes", 75, 2.5, 160)
        );
        builder.Entity<Armour>().HasData(
            new Armour(){
                armourId = 1,
                name = "Platemail of the Sturdy Soldier", 
                physicalDefenceValue = 690,
                magicalDefenceValue = 230
            },
            new Armour(){
                armourId = 2,
                name = "Robe of the Wizened Wizard", 
                physicalDefenceValue = 190,
                magicalDefenceValue = 550
            },
            new Armour(){
                armourId = 3,
                name = "Leather armour of the Dextrous Striker", 
                physicalDefenceValue = 430,
                magicalDefenceValue = 390
            }
        );
        builder.Entity<Potion>().HasData(
            new Potion(){
                potionId = 1,
                name = "Minor Health Potion",
                potionDescription = "",
                potionPotencyValue = 75
            },
            new Potion(){
                potionId = 1,
                name = "Health Potion",
                potionDescription = "",
                potionPotencyValue = 150
            },
            new Potion(){
                potionId = 1,
                name = "Major Health Potion",
                potionDescription = "",
                potionPotencyValue = 250
            },
            new Potion(){
                potionId = 1,
                name = "Minor Strength Potion",
                potionDescription = "",
                potionPotencyValue = 75
            },
            new Potion(){
                potionId = 1,
                name = "Strength Potion",
                potionDescription = "",
                potionPotencyValue = 150
            },
            new Potion(){
                potionId = 1,
                name = "Major Strength Potion",
                potionDescription = "",
                potionPotencyValue = 250
            },
            new Potion(){
                potionId = 1,
                name = "Minor Intellect Potion",
                potionDescription = "",
                potionPotencyValue = 75
            },
            new Potion(){
                potionId = 1,
                name = "Intellect Potion",
                potionDescription = "",
                potionPotencyValue = 150
            },
            new Potion(){
                potionId = 1,
                name = "Major Intellect Potion",
                potionDescription = "",
                potionPotencyValue = 250
            },
            new Potion(){
                potionId = 1,
                name = "Minor Dextrous Potion",
                potionDescription = "",
                potionPotencyValue = 75
            },
            new Potion(){
                potionId = 1,
                name = "Dextrous Potion",
                potionDescription = "",
                potionPotencyValue = 150
            },
            new Potion(){
                potionId = 1,
                name = "Major Dextrous Potion",
                potionDescription = "",
                potionPotencyValue = 250
            }
        );
    }
}
