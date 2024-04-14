using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileQuotation.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuotationProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
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
                    table.PrimaryKey("PK_QuotationProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuotationSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSuppliers",
                columns: table => new
                {
                    QuotationProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    QuotationSupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSuppliers", x => new { x.QuotationProductId, x.QuotationSupplierId });
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_QuotationProducts_QuotationProductId",
                        column: x => x.QuotationProductId,
                        principalTable: "QuotationProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_QuotationSuppliers_QuotationSupplierId",
                        column: x => x.QuotationSupplierId,
                        principalTable: "QuotationSuppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationProductQuotationSupplier",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SuppliersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationProductQuotationSupplier", x => new { x.ProductsId, x.SuppliersId });
                    table.ForeignKey(
                        name: "FK_QuotationProductQuotationSupplier_QuotationProducts_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "QuotationProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuotationProductQuotationSupplier_QuotationSuppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "QuotationSuppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSuppliers_QuotationSupplierId",
                table: "ProductSuppliers",
                column: "QuotationSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationProductQuotationSupplier_SuppliersId",
                table: "QuotationProductQuotationSupplier",
                column: "SuppliersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSuppliers");

            migrationBuilder.DropTable(
                name: "QuotationProductQuotationSupplier");

            migrationBuilder.DropTable(
                name: "QuotationProducts");

            migrationBuilder.DropTable(
                name: "QuotationSuppliers");
        }
    }
}
