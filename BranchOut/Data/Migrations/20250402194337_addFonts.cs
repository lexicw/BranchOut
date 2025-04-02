using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class addFonts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Font",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Font", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Font");

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
    }
}
