using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BranchOut.Migrations
{
    /// <inheritdoc />
    public partial class alterSocialMediaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "Github",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "TikTok",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "YouTube",
                table: "SocialMedia");

            migrationBuilder.AddColumn<int>(
                name: "Platform",
                table: "SocialMedia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platform",
                table: "SocialMedia");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TikTok",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YouTube",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
