using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWAPICO.Migrations
{
    public partial class AddtblPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPeople",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Mass = table.Column<string>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    SkinColor = table.Column<string>(nullable: true),
                    EyeColor = table.Column<string>(nullable: true),
                    BirthYear = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Homeworld = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPeople");
        }
    }
}
