namespace backend.Models;

public class Weapon
{
    public int weaponId { get; set; }
    public string? name { get; set; }
    public int? attackValue { get; set; }
    public double? attackSpeed { get; set; }
    public double? dps { get; set; }
    public double? abilityDamageModifier { get; set; }
    public string? flavourText { get; set; }
    public int? price { get; set; }

    public Weapon(){

    }

    public double getDps(int attackSpeed, int attackValue){
        return attackSpeed * attackValue;
    }
}
