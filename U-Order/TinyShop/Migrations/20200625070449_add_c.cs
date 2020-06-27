using Microsoft.EntityFrameworkCore.Migrations;

namespace TinyShop.Migrations
{
    public partial class add_c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phonenumber",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jianjie",
                table: "Products",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Cart",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Total",
                table: "Cart",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Cart",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phonenumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Jianjie",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Cart");
        }
    }
}
