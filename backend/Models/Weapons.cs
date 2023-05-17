namespace backend.Models;

public class Weapon
{
    public int weaponId { get; set; }
    public string? name { get; set; }
    public int? attackValue { get; set; }
    public double? attackSpeed { get; set; }
    public double? dps { get; set; }
    public double? abilityDamageModifier { get; set; } //Percentage

    public Weapon(int weaponId, string name, int attackValue, double attackSpeed, double abilityDamageModifier){
        this.weaponId = weaponId;
        this.name = name;
        this.attackValue = attackValue;
        this.attackSpeed = attackSpeed;
        this.dps = attackSpeed * attackValue;
        this.abilityDamageModifier = abilityDamageModifier;
    }
}

//Will this need a constructor to set the dps, could look at calcing dps before creating the item?
