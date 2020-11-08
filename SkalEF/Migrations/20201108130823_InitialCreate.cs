using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkalEF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Lang = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    FoodChoice = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DossNr = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ClientItem",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    ItemCount = table.Column<int>(nullable: false),
                    ItemOutDate = table.Column<DateTime>(nullable: false),
                    ItemInDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientItem", x => new { x.ClientId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_ClientItem_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientItem_ItemId",
                table: "ClientItem",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientItem");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
