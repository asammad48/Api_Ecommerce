using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce_Website.Migrations
{
    public partial class Update_variants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Var_Discount",
                table: "variants",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Var_Price",
                table: "variants",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Var_Reviews",
                table: "variants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Var_Stock",
                table: "variants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Var_Discount",
                table: "variants");

            migrationBuilder.DropColumn(
                name: "Var_Price",
                table: "variants");

            migrationBuilder.DropColumn(
                name: "Var_Reviews",
                table: "variants");

            migrationBuilder.DropColumn(
                name: "Var_Stock",
                table: "variants");
        }
    }
}
