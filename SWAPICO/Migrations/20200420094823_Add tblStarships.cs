using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWAPICO.Migrations
{
    public partial class AddtblStarships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblStarships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    CostInCredits = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    MaxAtmospheringSpeed = table.Column<string>(nullable: true),
                    Crew = table.Column<string>(nullable: true),
                    Passengers = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStarships", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblStarships");
        }
    }
}
