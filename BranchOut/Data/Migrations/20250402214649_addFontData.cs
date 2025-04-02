using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class addFontData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Font",
                columns: new[] { "Id", "CssClass", "Name" },
                values: new object[,]
                {
                    { 1, "font-inter", "Inter" },
                    { 2, "font-sofia", "Sofia" },
                    { 3, "font-merriweather", "Merriweather" },
                    { 4, "font-miniver", "Miniver" },
                    { 5, "font-oswald", "Oswald" },
                    { 6, "font-raleway", "Raleway" },
                    { 7, "font-yomogi", "Yomogi" },
                    { 8, "font-silkscreen", "Silkscreen" },
                    { 9, "font-fresca", "Fresca" }
                });

            migrationBuilder.InsertData(
                table: "Gradient",
                columns: new[] { "Id", "CssClass", "Value" },
                values: new object[,]
                {
                    { 1, null, "None" },
                    { 2, "gradient-cherry-blossom", "Cherry Blossom" },
                    { 3, "gradient-tropical", "Tropical" },
                    { 4, "gradient-northern-lights", "Northern Lights" },
                    { 5, "gradient-vibrant", "Vibrant" },
                    { 6, "gradient-lime", "Lime" },
                    { 7, "gradient-ocean", "Ocean" },
                    { 8, "gradient-fire", "Fire" },
                    { 9, "gradient-space", "Solar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Font",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gradient",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
