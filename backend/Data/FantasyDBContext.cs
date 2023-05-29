using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Models;

    public class FantasyDBContext : DbContext
    {
        public FantasyDBContext (DbContextOptions<FantasyDBContext> options)
            : base(options)
        {
        }

        public DbSet<backend.Models.Weapon> Weapon { get; set; } = default!;

        public DbSet<backend.Models.Armour> Armour { get; set; } = default!;

        public DbSet<backend.Models.Potion> Potion { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Weapon>().HasData(
            new Weapon(){
                weaponId = 1,
                name = "Faux sword of the late kings deceit",
                attackValue = 170,
                attackSpeed = 1.65,
                dps = 170 * 1.65,
                abilityDamageModifier = 140,
                flavourText = "Sword forged in imitation of the sword of the late king and traitor, Augustus, VII",
                price = 650,
                imgURL = "HXe6HWw.png"
            },
            new Weapon(){
                weaponId = 2,
                name = "Mace of sundering",
                attackValue = 220,
                attackSpeed = 1.10,
                dps = 220 * 1.10,
                abilityDamageModifier = 170,
                flavourText = "A monstrous mace with the power to shatter shields and cave in skulls.",
                price = 400,
                imgURL = "DJjnBts.png"
            },
            new Weapon(){
                weaponId = 3,
                name = "Dagger of the twin serpents",
                attackValue = 75,
                attackSpeed = 2.5,
                dps = 75 * 2.5,
                abilityDamageModifier = 160,
                flavourText = "Twin curved daggers build for attacking quickly from the shadows.",
                price = 250,
                imgURL = "yHx2Lc5.png"
            },
            new Weapon(){
                weaponId = 4,
                name = "Arcane apprentice staff",
                attackValue = 50,
                attackSpeed = 0.75,
                dps = 50 * 0.75,
                abilityDamageModifier = 290,
                flavourText = "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts",
                price = 700,
                imgURL = ""
            },
            new Weapon(){
                weaponId = 5,
                name = "Staff of destructive oblivion",
                attackValue = 70,
                attackSpeed = 0.50,
                dps = 70 * 0.50,
                abilityDamageModifier = 600,
                flavourText = "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.",
                price = 2900,
                imgURL = ""
            }
        );
        builder.Entity<Armour>().HasData(
            new Armour(){
                armourId = 1,
                name = "Platemail of the Sturdy Soldier", 
                physicalDefenceValue = 690,
                magicalDefenceValue = 230,
                flavourText = "Strong plate armour capable of withstanding strong physical blows.",
                price = 680,
                imgURL = "T3vSkoI.png"
            },
            new Armour(){
                armourId = 2,
                name = "Robe of the Wizened Wizard", 
                physicalDefenceValue = 190,
                magicalDefenceValue = 550,
                flavourText = "Robes imbued with magical wards to boost both magical offense and defense.",
                price = 700,
                imgURL = "S6MLT0P.png"
            },
            new Armour(){
                armourId = 3,
                name = "Leather armour of the Dextrous Striker", 
                physicalDefenceValue = 430,
                magicalDefenceValue = 390,
                flavourText = "Flexible armour allowing freedom of movement for quick strikes while providing a balanced defense.",
                price = 650,
                imgURL = "GDE6NHc.png"
            }
        );
        builder.Entity<Potion>().HasData(
            new Potion(){
                potionId = 1,
                name = "Minor Health Potion",
                potionDescription = "Drink to restore a small amount of health, Heal potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = ""
            },
            new Potion(){
                potionId = 2,
                name = "Health Potion",
                potionDescription = "Drink to restore a medium amount of health, Heal potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = ""
            },
            new Potion(){
                potionId = 3,
                name = "Major Health Potion",
                potionDescription = "Drink to restore a large amount of health, Heal potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = ""
            },
            new Potion(){
                potionId = 4,
                name = "Minor Strength Potion",
                potionDescription = "Drink boost your strength a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = ""
            },
            new Potion(){
                potionId = 5,
                name = "Strength Potion",
                potionDescription = "Drink boost your strength a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = ""
            },
            new Potion(){
                potionId = 6,
                name = "Major Strength Potion",
                potionDescription = "Drink boost your strength a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = ""
            },
            new Potion(){
                potionId = 7,
                name = "Minor Intellect Potion",
                potionDescription = "Drink boost your intelligence a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = ""
            },
            new Potion(){
                potionId = 8,
                name = "Intellect Potion",
                potionDescription = "Drink boost your intelligence a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = ""
            },
            new Potion(){
                potionId = 9,
                name = "Major Intellect Potion",
                potionDescription = "Drink boost your intelligence a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = ""
            },
            new Potion(){
                potionId = 10,
                name = "Minor Dextrous Potion",
                potionDescription = "Drink boost your dexterity a small amount, Boost potency: ",
                potionPotencyValue = 75,
                price = 20,
                imgURL = ""
            },
            new Potion(){
                potionId = 11,
                name = "Dextrous Potion",
                potionDescription = "Drink boost your dexterity a medium amount, Boost potency: ",
                potionPotencyValue = 150,
                price = 70,
                imgURL = ""
            },
            new Potion(){
                potionId = 12,
                name = "Major Dextrous Potion",
                potionDescription = "Drink boost your dexterity a large amount, Boost potency: ",
                potionPotencyValue = 250,
                price = 200,
                imgURL = ""
            }
        );
    }
    }
