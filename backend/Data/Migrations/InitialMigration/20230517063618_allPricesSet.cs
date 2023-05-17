using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations.InitialMigration
{
    /// <inheritdoc />
    public partial class allPricesSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 1,
                column: "price",
                value: 680);

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 2,
                column: "price",
                value: 700);

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 3,
                column: "price",
                value: 650);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 1,
                column: "price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 2,
                column: "price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 3,
                column: "price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 4,
                column: "price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 5,
                column: "price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 6,
                column: "price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 7,
                column: "price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 8,
                column: "price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 9,
                column: "price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 10,
                column: "price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 11,
                column: "price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 12,
                column: "price",
                value: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 1,
                column: "price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 2,
                column: "price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Armour",
                keyColumn: "armourId",
                keyValue: 3,
                column: "price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 1,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 2,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 3,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 4,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 5,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 6,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 7,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 8,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 9,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 10,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 11,
                column: "price",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 12,
                column: "price",
                value: 0);
        }
    }
}
