using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddQuickSaleButtonConfigAndFixRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDebtMovements_Customers_CustomerId",
                table: "CustomerDebtMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_WholesalerDebtMovements_Wholesalers_WholesalerId",
                table: "WholesalerDebtMovements");

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "SalesReceiptId",
                table: "WholesalerDebtMovements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QuickSaleButtonConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ButtonIndex = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarcodeNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuickSaleButtonConfigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuickSaleButtonConfigs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Filtreler" });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Motor Yağları" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "ProductGroupId", "PurchasePrice", "SalePrice", "StockCode" },
                values: new object[] { "1234567890123", 100m, 10m, "Hava Filtresi", 1, 50.00m, 75.00m, "HF-100" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "PurchasePrice", "SalePrice", "StockCode", "VatRate" },
                values: new object[] { "9876543210987", 50m, 5m, "Yağ Filtresi", 30.00m, 45.00m, "YF-200", 18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "ProductGroupId", "PurchasePrice", "SalePrice", "StockCode", "VatRate" },
                values: new object[] { "1122334455667", 30m, 3m, "Motor Yağı 5W-30", 2, 120.00m, 180.00m, "MY-5W30", 18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BarcodeNo", "Name", "ProductGroupId", "PurchasePrice", "StockCode" },
                values: new object[] { "000001", "MANN C24003", 1, 40.00m, "MANN-C24003" });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Koli" });

            migrationBuilder.CreateIndex(
                name: "IX_WholesalerDebtMovements_SalesReceiptId",
                table: "WholesalerDebtMovements",
                column: "SalesReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_QuickSaleButtonConfigs_ProductId",
                table: "QuickSaleButtonConfigs",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDebtMovements_Customers_CustomerId",
                table: "CustomerDebtMovements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WholesalerDebtMovements_SalesReceipts_SalesReceiptId",
                table: "WholesalerDebtMovements",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_WholesalerDebtMovements_Wholesalers_WholesalerId",
                table: "WholesalerDebtMovements",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDebtMovements_Customers_CustomerId",
                table: "CustomerDebtMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_WholesalerDebtMovements_SalesReceipts_SalesReceiptId",
                table: "WholesalerDebtMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_WholesalerDebtMovements_Wholesalers_WholesalerId",
                table: "WholesalerDebtMovements");

            migrationBuilder.DropTable(
                name: "QuickSaleButtonConfigs");

            migrationBuilder.DropIndex(
                name: "IX_WholesalerDebtMovements_SalesReceiptId",
                table: "WholesalerDebtMovements");

            migrationBuilder.DropColumn(
                name: "SalesReceiptId",
                table: "WholesalerDebtMovements");

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Bisküvi ürünleri", "BİSKÜVİ" });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filtre ürünleri", "FİLTRE" });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salça ürünleri", "SALÇA" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yağ ürünleri", "YAĞ" },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deterjan ürünleri", "DETERJAN" },
                    { 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Süt ürünleri", "SÜT ÜRÜNLERİ" },
                    { 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçecek ürünleri", "İÇECEK" },
                    { 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krema ürünleri", "KREMA" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "ProductGroupId", "PurchasePrice", "SalePrice", "StockCode" },
                values: new object[] { "8690511010128", 12m, 2m, "ABC ÇAMAŞIR SUYU 4000 ML", 5, 70.00m, 90.00m, "ABC-4000" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "PurchasePrice", "SalePrice", "StockCode", "VatRate" },
                values: new object[] { "8690504034506", 4m, 4m, "ÜLKER ALBENİ 35 GR", 7.00m, 10.00m, "ULK-ALB", 8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BarcodeNo", "CurrentStock", "MinimumStock", "Name", "ProductGroupId", "PurchasePrice", "SalePrice", "StockCode", "VatRate" },
                values: new object[] { "8690876010016", 3m, 1m, "YUDUM 1 LT SIVI YAĞ", 4, 55.00m, 75.00m, "YUD-1LT", 8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BarcodeNo", "Name", "ProductGroupId", "PurchasePrice", "StockCode" },
                values: new object[] { "8690575012519", "TAMEK DOMATES SALÇASI 830 GR", 3, 45.00m, "TAM-830" });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Adet olarak ölçü birimi");

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kilogram olarak ölçü birimi", "Kg" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Litre olarak ölçü birimi", "Litre" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metre olarak ölçü birimi", "Metre" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDebtMovements_Customers_CustomerId",
                table: "CustomerDebtMovements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WholesalerDebtMovements_Wholesalers_WholesalerId",
                table: "WholesalerDebtMovements",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
