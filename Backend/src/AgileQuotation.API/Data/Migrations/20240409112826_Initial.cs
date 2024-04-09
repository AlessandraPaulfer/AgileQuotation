using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileQuotation.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSupplier",
                columns: table => new
                {
                    ProductSupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SKU = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UnitBox = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weigth = table.Column<decimal>(type: "TEXT", nullable: false),
                    TypeUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    LastPurchase = table.Column<decimal>(type: "TEXT", nullable: false),
                    BoardingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastValidate = table.Column<decimal>(type: "TEXT", nullable: false),
                    LastMonthValidate = table.Column<string>(type: "TEXT", nullable: true),
                    LastSupplier = table.Column<string>(type: "TEXT", nullable: true),
                    Group = table.Column<string>(type: "TEXT", nullable: true),
                    SubGroup = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    SubBrand = table.Column<string>(type: "TEXT", nullable: true),
                    TypeSituation = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeSKUPositive = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeIndAtac = table.Column<int>(type: "INTEGER", nullable: false),
                    CountBySKU = table.Column<decimal>(type: "TEXT", nullable: false),
                    StatusProduct = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSupplier", x => x.ProductSupplierId);
                });

            migrationBuilder.CreateTable(
                name: "QuotationSupplier",
                columns: table => new
                {
                    QuotationSupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    StatusSupplier = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductSupplierId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationSupplier", x => x.QuotationSupplierId);
                    table.ForeignKey(
                        name: "FK_QuotationSupplier_ProductSupplier_ProductSupplierId",
                        column: x => x.ProductSupplierId,
                        principalTable: "ProductSupplier",
                        principalColumn: "ProductSupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuotationSupplier_ProductSupplierId",
                table: "QuotationSupplier",
                column: "ProductSupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotationSupplier");

            migrationBuilder.DropTable(
                name: "ProductSupplier");
        }
    }
}
