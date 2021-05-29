using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce_Website.Migrations
{
    public partial class Soory_For_Top : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "top",
                table: "product_Variants");

            migrationBuilder.AddColumn<int>(
                name: "top",
                table: "specifications",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "top",
                table: "specifications");

            migrationBuilder.AddColumn<int>(
                name: "top",
                table: "product_Variants",
                nullable: false,
                defaultValue: 0);
        }
    }
}
