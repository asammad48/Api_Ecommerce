using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce_Website.Migrations
{
    public partial class guyuhjhjk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_subCategories_SubCategoryID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SubCategoryID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SubCategoryID",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "Category_subCategory",
                columns: table => new
                {
                    SubCategory_SubSubcategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    SubCategoryID = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_subCategory", x => x.SubCategory_SubSubcategoryID);
                    table.ForeignKey(
                        name: "FK_Category_subCategory_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_subCategory_subCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "subCategories",
                        principalColumn: "SubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory_SubSubcategory",
                columns: table => new
                {
                    SubCategory_SubSubcategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubSubCategoryID = table.Column<int>(nullable: false),
                    SubCategoryID = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory_SubSubcategory", x => x.SubCategory_SubSubcategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategory_SubSubcategory_subCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "subCategories",
                        principalColumn: "SubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCategory_SubSubcategory_subSubCategories_SubSubCategoryID",
                        column: x => x.SubSubCategoryID,
                        principalTable: "subSubCategories",
                        principalColumn: "SubSubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_subCategory_CategoryID",
                table: "Category_subCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_subCategory_SubCategoryID",
                table: "Category_subCategory",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_SubSubcategory_SubCategoryID",
                table: "SubCategory_SubSubcategory",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_SubSubcategory_SubSubCategoryID",
                table: "SubCategory_SubSubcategory",
                column: "SubSubCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category_subCategory");

            migrationBuilder.DropTable(
                name: "SubCategory_SubSubcategory");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryID",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubCategoryID",
                table: "Categories",
                column: "SubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_subCategories_SubCategoryID",
                table: "Categories",
                column: "SubCategoryID",
                principalTable: "subCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
