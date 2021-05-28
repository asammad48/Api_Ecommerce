using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce_Website.Migrations
{
    public partial class Change_Product_Structure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryID",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "products",
                newName: "SubSubCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryID",
                table: "products",
                newName: "IX_products_SubSubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_subSubCategories_SubSubCategoryID",
                table: "products",
                column: "SubSubCategoryID",
                principalTable: "subSubCategories",
                principalColumn: "SubSubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_subSubCategories_SubSubCategoryID",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "SubSubCategoryID",
                table: "products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_products_SubSubCategoryID",
                table: "products",
                newName: "IX_products_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryID",
                table: "products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
