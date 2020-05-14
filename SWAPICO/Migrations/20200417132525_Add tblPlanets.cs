using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWAPICO.Migrations
{
    public partial class AddtblPlanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPlanets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RotationPeriod = table.Column<string>(nullable: true),
                    OrbitalPeriod = table.Column<string>(nullable: true),
                    Diameter = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    Gravity = table.Column<string>(nullable: true),
                    Terrain = table.Column<string>(nullable: true),
                    SurfaceWater = table.Column<string>(nullable: true),
                    Population = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlanets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPlanets");
        }
    }
}
