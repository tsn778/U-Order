using Microsoft.EntityFrameworkCore.Migrations;

namespace TinyShop.Migrations
{
    public partial class add_Line : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Line",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Total = table.Column<double>(maxLength: 100, nullable: false),
                    Adress = table.Column<string>(maxLength: 300, nullable: true),
                    UserName = table.Column<string>(maxLength: 100, nullable: true),
                    Zhuangtai = table.Column<string>(maxLength: 100, nullable: true),
                    Time = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Line");
        }
    }
}
