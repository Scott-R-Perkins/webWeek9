using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations.InitialMigration
{
    /// <inheritdoc />
    public partial class hardCodedDps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 1,
                column: "dps",
                value: 280.5);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 2,
                column: "dps",
                value: 242.00000000000003);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 3,
                column: "dps",
                value: 187.5);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 4,
                column: "dps",
                value: 37.5);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 5,
                column: "dps",
                value: 35.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 1,
                column: "dps",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 2,
                column: "dps",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 3,
                column: "dps",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 4,
                column: "dps",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 5,
                column: "dps",
                value: null);
        }
    }
}
