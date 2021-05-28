using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce_Website.Migrations
{
    public partial class Spec_With_Variant_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VariantID",
                table: "specifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_specifications_VariantID",
                table: "specifications",
                column: "VariantID");

            migrationBuilder.AddForeignKey(
                name: "FK_specifications_variants_VariantID",
                table: "specifications",
                column: "VariantID",
                principalTable: "variants",
                principalColumn: "VariantID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_specifications_variants_VariantID",
                table: "specifications");

            migrationBuilder.DropIndex(
                name: "IX_specifications_VariantID",
                table: "specifications");

            migrationBuilder.DropColumn(
                name: "VariantID",
                table: "specifications");
        }
    }
}
