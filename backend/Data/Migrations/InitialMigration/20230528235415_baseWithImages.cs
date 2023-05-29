using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations.InitialMigration
{
    /// <inheritdoc />
    public partial class baseWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "Weapon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Potion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "Potion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "Armour",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 1,
                column: "imgURL",
                value: "T3vSkoI");

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 2,
                column: "imgURL",
                value: "S6MLT0P");

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 3,
                column: "imgURL",
                value: "GDE6NHc");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 1,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 2,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 3,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 4,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 5,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 6,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 7,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 8,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 9,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 10,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 11,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 12,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 1,
                column: "imgURL",
                value: "HXe6HWw");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 2,
                column: "imgURL",
                value: "DJjnBts");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 3,
                columns: new[] { "imgURL", "name" },
                values: new object[] { "yHx2Lc5", "Dagger of the twin serpents" });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 4,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 5,
                column: "imgURL",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "Weapon");

            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "Potion");

            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "Armour");

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Potion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 3,
                column: "name",
                value: "Daggers of the twin serpents");
        }
    }
}
