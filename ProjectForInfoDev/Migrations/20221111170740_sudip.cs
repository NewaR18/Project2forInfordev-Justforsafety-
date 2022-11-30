using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectForInfoDev.Migrations
{
    public partial class sudip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bloods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apositive = table.Column<int>(type: "int", nullable: false),
                    Anegative = table.Column<int>(type: "int", nullable: false),
                    Bpositive = table.Column<int>(type: "int", nullable: false),
                    Bnegative = table.Column<int>(type: "int", nullable: false),
                    ABpositive = table.Column<int>(type: "int", nullable: false),
                    ABnegative = table.Column<int>(type: "int", nullable: false),
                    Opositive = table.Column<int>(type: "int", nullable: false),
                    Onegative = table.Column<int>(type: "int", nullable: false),
                    LastReviewed = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloods", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bloods");
        }
    }
}
