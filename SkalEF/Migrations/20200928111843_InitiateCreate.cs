using Microsoft.EntityFrameworkCore.Migrations;

namespace SkalEF.Migrations
{
    public partial class InitiateCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room = table.Column<int>(nullable: false),
                    FirNamn = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    LasName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Lang = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Dossnr = table.Column<int>(nullable: false),
                    Socks = table.Column<bool>(nullable: false),
                    Slippers = table.Column<bool>(nullable: false),
                    Underware = table.Column<bool>(nullable: false),
                    Mobil = table.Column<bool>(nullable: false),
                    Headphones = table.Column<bool>(nullable: false),
                    Trouser = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
