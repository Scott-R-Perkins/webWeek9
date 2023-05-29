using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations.InitialMigration
{
    /// <inheritdoc />
    public partial class updatedPotionImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 1,
                column: "imgURL",
                value: "BtFkFWn");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 2,
                column: "imgURL",
                value: "hQU0HQG");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 3,
                column: "imgURL",
                value: "hOL3mew");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 4,
                column: "imgURL",
                value: "OBV95Xr");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 5,
                column: "imgURL",
                value: "lajwEJd");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 6,
                column: "imgURL",
                value: "ZwNIHHE");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 7,
                column: "imgURL",
                value: "RCosYt9");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 8,
                column: "imgURL",
                value: "MEUkEX7");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 9,
                column: "imgURL",
                value: "5JKaqbG");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 10,
                column: "imgURL",
                value: "TC4TKiW");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 11,
                column: "imgURL",
                value: "teGVnVo");

            migrationBuilder.UpdateData(
                table: "Potion",
                keyColumn: "potionId",
                keyValue: 12,
                column: "imgURL",
                value: "Mu7z0Dq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
