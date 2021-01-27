using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooKing.Migrations
{
    public partial class ContactForm3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateSent",
                table: "UserMessages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateSent",
                table: "UserMessages");
        }
    }
}
