using Microsoft.EntityFrameworkCore.Migrations;

namespace ScraperApp.Migrations
{
    public partial class AddedYahooCredentialInputs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YahooEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YahooPassword",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YahooEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "YahooPassword",
                table: "AspNetUsers");
        }
    }
}
