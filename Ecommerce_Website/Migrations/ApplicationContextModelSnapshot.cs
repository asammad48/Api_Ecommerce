﻿// <auto-generated />
using System;
using Ecommerce_Website.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce_Website.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce_Website.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<int>("Status");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Category_subCategory", b =>
                {
                    b.Property<int>("SubCategory_SubSubcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<int>("SubCategoryID");

                    b.Property<int>("status");

                    b.HasKey("SubCategory_SubSubcategoryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Category_subCategory");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("ProductName");

                    b.Property<int>("Status");

                    b.Property<int>("SubSubCategoryID");

                    b.HasKey("ProductID");

                    b.HasIndex("SubSubCategoryID");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product_Images", b =>
                {
                    b.Property<int>("p_img_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Images");

                    b.Property<int>("ProductID");

                    b.HasKey("p_img_id");

                    b.HasIndex("ProductID");

                    b.ToTable("images");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product_Variants", b =>
                {
                    b.Property<int>("product_variant_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID");

                    b.Property<decimal>("Var_Discount");

                    b.Property<decimal>("Var_Price");

                    b.Property<int>("Var_Reviews");

                    b.Property<int>("Var_Stock");

                    b.Property<int>("VariantID");

                    b.Property<int>("status");

                    b.HasKey("product_variant_ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("VariantID");

                    b.ToTable("product_Variants");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Specification", b =>
                {
                    b.Property<int>("SpecID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID");

                    b.Property<string>("SpecName");

                    b.Property<string>("SpecValue");

                    b.Property<int>("VariantID");

                    b.Property<int>("top");

                    b.HasKey("SpecID");

                    b.HasIndex("ProductID");

                    b.HasIndex("VariantID");

                    b.ToTable("specifications");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status");

                    b.Property<string>("SubCategoryName");

                    b.HasKey("SubCategoryID");

                    b.ToTable("subCategories");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.SubCategory_SubSubcategory", b =>
                {
                    b.Property<int>("SubCategory_SubSubcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubCategoryID");

                    b.Property<int>("SubSubCategoryID");

                    b.Property<int>("status");

                    b.HasKey("SubCategory_SubSubcategoryID");

                    b.HasIndex("SubCategoryID");

                    b.HasIndex("SubSubCategoryID");

                    b.ToTable("SubCategory_SubSubcategory");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.SubSubCategory", b =>
                {
                    b.Property<int>("SubSubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status");

                    b.Property<string>("SubsUBCategoryName");

                    b.HasKey("SubSubCategoryID");

                    b.ToTable("subSubCategories");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Variants", b =>
                {
                    b.Property<int>("VariantID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VariantName");

                    b.Property<int>("status");

                    b.HasKey("VariantID");

                    b.ToTable("variants");
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Category_subCategory", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_Website.Models.SubCategory", "SubCategories")
                        .WithMany()
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.SubSubCategory", "Product_Category")
                        .WithMany()
                        .HasForeignKey("SubSubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product_Images", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Product_Variants", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_Website.Models.Variants", "Variants")
                        .WithMany()
                        .HasForeignKey("VariantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_Website.Models.Specification", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_Website.Models.Variants", "Variants")
                        .WithMany()
                        .HasForeignKey("VariantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_Website.Models.SubCategory_SubSubcategory", b =>
                {
                    b.HasOne("Ecommerce_Website.Models.SubCategory", "SubCategories")
                        .WithMany()
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_Website.Models.SubSubCategory", "SubSubCategories")
                        .WithMany()
                        .HasForeignKey("SubSubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
