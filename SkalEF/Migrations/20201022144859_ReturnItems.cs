using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkalEF.Migrations
{
    public partial class ReturnItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountHeadphonesReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountMobileReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountSlippersReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountSocksReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountTrousersReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountUnderwareReturned",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HeadphoneGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HeadphoneRetrunDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MobileGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MobileReturnDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SlippersGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SlippersRetrunDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SocksGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SocksRetrunDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TrouserGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TrouserReturnDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UnderwareGiveDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UnderwareReturnDate",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountHeadphonesReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountMobileReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountSlippersReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountSocksReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountTrousersReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AmountUnderwareReturned",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "HeadphoneGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "HeadphoneRetrunDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "MobileGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "MobileReturnDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SlippersGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SlippersRetrunDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SocksGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SocksRetrunDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TrouserGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TrouserReturnDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UnderwareGiveDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UnderwareReturnDate",
                table: "Clients");
        }
    }
}
