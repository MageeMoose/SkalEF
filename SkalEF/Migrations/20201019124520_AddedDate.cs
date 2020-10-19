using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkalEF.Migrations
{
    public partial class AddedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Room",
                table: "Clients",
                type: "nvarchar(8)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Dossnr",
                table: "Clients",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AmountHeadphones",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountMobile",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountSlippers",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountSocks",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountTrousers",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountUnderware",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CaseOfficer",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountHeadphones",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountMobile",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountSlippers",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountSocks",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountTrousers",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountUnderware",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CaseOfficer",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "Room",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)");

            migrationBuilder.AlterColumn<int>(
                name: "Dossnr",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rooms = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });
        }
    }
}
