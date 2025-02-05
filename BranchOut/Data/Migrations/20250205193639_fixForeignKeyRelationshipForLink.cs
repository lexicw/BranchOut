using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class fixForeignKeyRelationshipForLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_Profile_ProfileId",
                table: "Link");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "Link",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Profile_ProfileId",
                table: "Link",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_Profile_ProfileId",
                table: "Link");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "Link",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Profile_ProfileId",
                table: "Link",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id");
        }
    }
}
