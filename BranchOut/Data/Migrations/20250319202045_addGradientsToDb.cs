using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class addGradientsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssGradientValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradient", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gradient");
        }
    }
}
