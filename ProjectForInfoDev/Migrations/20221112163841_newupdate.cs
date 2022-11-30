using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectForInfoDev.Migrations
{
    public partial class newupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Queries",
                columns: table => new
                {
                    SpecialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpecialEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpecialAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpecialMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queries", x => x.SpecialId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Queries");
        }
    }
}
