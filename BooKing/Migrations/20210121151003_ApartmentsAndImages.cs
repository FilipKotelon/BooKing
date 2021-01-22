using Microsoft.EntityFrameworkCore.Migrations;

namespace BooKing.Migrations
{
    public partial class ApartmentsAndImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageIds",
                table: "Apartments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sleeps",
                table: "Apartments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageIds",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Sleeps",
                table: "Apartments");
        }
    }
}
