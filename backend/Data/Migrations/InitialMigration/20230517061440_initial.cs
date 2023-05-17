using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Data.Migrations.InitialMigration
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armour",
                columns: table => new
                {
                    armourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    physicalDefenceValue = table.Column<int>(type: "int", nullable: true),
                    magicalDefenceValue = table.Column<int>(type: "int", nullable: true),
                    flavourText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armour", x => x.armourId);
                });

            migrationBuilder.CreateTable(
                name: "Potion",
                columns: table => new
                {
                    potionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    potionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    potionPotencyValue = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potion", x => x.potionId);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    weaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attackValue = table.Column<int>(type: "int", nullable: true),
                    attackSpeed = table.Column<double>(type: "float", nullable: true),
                    dps = table.Column<double>(type: "float", nullable: true),
                    abilityDamageModifier = table.Column<double>(type: "float", nullable: true),
                    flavourText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.weaponId);
                });

            migrationBuilder.InsertData(
                table: "Armour",
                columns: new[] { "armourId", "flavourText", "magicalDefenceValue", "name", "physicalDefenceValue", "price" },
                values: new object[,]
                {
                    { 1, "Strong plate armour capable of withstanding strong physical blows.", 230, "Platemail of the Sturdy Soldier", 690, null },
                    { 2, "Robes imbued with magical wards to boost both magical offense and defense.", 550, "Robe of the Wizened Wizard", 190, null },
                    { 3, "Flexible armour allowing freedom of movement for quick strikes while providing a balanced defense.", 390, "Leather armour of the Dextrous Striker", 430, null }
                });

            migrationBuilder.InsertData(
                table: "Potion",
                columns: new[] { "potionId", "name", "potionDescription", "potionPotencyValue", "price" },
                values: new object[,]
                {
                    { 1, "Minor Health Potion", "Drink to restore a small amount of health, Heal potency: ", 75, 0 },
                    { 2, "Health Potion", "Drink to restore a medium amount of health, Heal potency: ", 150, 0 },
                    { 3, "Major Health Potion", "Drink to restore a large amount of health, Heal potency: ", 250, 0 },
                    { 4, "Minor Strength Potion", "Drink boost your strength a small amount, Boost potency: ", 75, 0 },
                    { 5, "Strength Potion", "Drink boost your strength a medium amount, Boost potency: ", 150, 0 },
                    { 6, "Major Strength Potion", "Drink boost your strength a large amount, Boost potency: ", 250, 0 },
                    { 7, "Minor Intellect Potion", "Drink boost your intelligence a small amount, Boost potency: ", 75, 0 },
                    { 8, "Intellect Potion", "Drink boost your intelligence a medium amount, Boost potency: ", 150, 0 },
                    { 9, "Major Intellect Potion", "Drink boost your intelligence a large amount, Boost potency: ", 250, 0 },
                    { 10, "Minor Dextrous Potion", "Drink boost your dexterity a small amount, Boost potency: ", 75, 0 },
                    { 11, "Dextrous Potion", "Drink boost your dexterity a medium amount, Boost potency: ", 150, 0 },
                    { 12, "Major Dextrous Potion", "Drink boost your dexterity a large amount, Boost potency: ", 250, 0 }
                });

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "weaponId", "abilityDamageModifier", "attackSpeed", "attackValue", "dps", "flavourText", "name", "price" },
                values: new object[,]
                {
                    { 1, 140.0, 1.6499999999999999, 170, null, "Sword forged in imitation of the sword of the late king and traitor, Augustus, VII", "Faux sword of the late kings deceit", 650 },
                    { 2, 170.0, 1.1000000000000001, 220, null, "A monstrous mace with the power to shatter shields and cave in skulls.", "Mace of sundering", 400 },
                    { 3, 160.0, 2.5, 75, null, "Twin curved daggers build for attacking quickly from the shadows.", "Daggers of the twin serpents", 250 },
                    { 4, 290.0, 0.75, 50, null, "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts", "Arcane apprentice staff", 700 },
                    { 5, 600.0, 0.5, 70, null, "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.", "Staff of destructive oblivion", 2900 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armour");

            migrationBuilder.DropTable(
                name: "Potion");

            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}
