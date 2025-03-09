using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class AddTextColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextColor",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextColor",
                table: "Profile");
        }
    }
}
