using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class changeButtonShapeToRoundness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ButtonShape",
                table: "Profile",
                newName: "ButtonRoundness");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ButtonRoundness",
                table: "Profile",
                newName: "ButtonShape");
        }
    }
}
