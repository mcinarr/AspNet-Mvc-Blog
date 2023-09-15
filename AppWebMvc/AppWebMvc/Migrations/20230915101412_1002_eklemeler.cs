using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class _1002_eklemeler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNick",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "UserNickName",
                table: "User",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserPhoneNumber",
                table: "User",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNickName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserPhoneNumber",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "UserNick",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
