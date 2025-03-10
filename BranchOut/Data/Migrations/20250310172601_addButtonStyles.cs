using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class addButtonStyles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ButtonStyle",
                table: "Profile",
                newName: "ButtonTextColor");

            migrationBuilder.AddColumn<string>(
                name: "ButtonBorder",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ButtonColor",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ButtonShape",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonBorder",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ButtonColor",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ButtonShape",
                table: "Profile");

            migrationBuilder.RenameColumn(
                name: "ButtonTextColor",
                table: "Profile",
                newName: "ButtonStyle");
        }
    }
}
