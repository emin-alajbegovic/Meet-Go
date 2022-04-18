using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetAndGo.Migrations
{
    public partial class AddedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "RentedOffice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "RentedOffice",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "RentedBuilding",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "RentedBuilding",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "RentedOffice");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "RentedOffice");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "RentedBuilding");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "RentedBuilding");
        }
    }
}
