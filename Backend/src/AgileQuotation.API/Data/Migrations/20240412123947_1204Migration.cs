using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileQuotation.API.Data.Migrations
{
    public partial class _1204Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuotationProduct",
                columns: table => new
                {
                    QuotationProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SKU = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UnitBox = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weigth = table.Column<decimal>(type: "TEXT", nullable: false),
                    TypeUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    LastPurchase = table.Column<decimal>(type: "TEXT", nullable: false),
                    BoardingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastValidate = table.Column<decimal>(type: "TEXT", nullable: false),
                    LastMonthValidate = table.Column<string>(type: "TEXT", nullable: true),
                    LastSupplier = table.Column<string>(type: "TEXT", nullable: true),
                    TheGroup = table.Column<string>(type: "TEXT", nullable: true),
                    TheSubGroup = table.Column<string>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_QuotationProduct", x => x.QuotationProductId);
                });

            migrationBuilder.CreateTable(
                name: "QuotationSupplier",
                columns: table => new
                {
                    QuotationSupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationSupplier", x => x.QuotationSupplierId);
                });

            migrationBuilder.CreateTable(
                name: "QuotationProductQuotationSupplier",
                columns: table => new
                {
                    ProductsQuotationProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    SuppliersQuotationSupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationProductQuotationSupplier", x => new { x.ProductsQuotationProductId, x.SuppliersQuotationSupplierId });
                    table.ForeignKey(
                        name: "FK_QuotationProductQuotationSupplier_QuotationProduct_ProductsQuotationProductId",
                        column: x => x.ProductsQuotationProductId,
                        principalTable: "QuotationProduct",
                        principalColumn: "QuotationProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuotationProductQuotationSupplier_QuotationSupplier_SuppliersQuotationSupplierId",
                        column: x => x.SuppliersQuotationSupplierId,
                        principalTable: "QuotationSupplier",
                        principalColumn: "QuotationSupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuotationProductQuotationSupplier_SuppliersQuotationSupplierId",
                table: "QuotationProductQuotationSupplier",
                column: "SuppliersQuotationSupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotationProductQuotationSupplier");

            migrationBuilder.DropTable(
                name: "QuotationProduct");

            migrationBuilder.DropTable(
                name: "QuotationSupplier");
        }
    }
}
