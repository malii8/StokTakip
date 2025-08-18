using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_SalesReceipts_SalesReceiptId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Wholesalers_WholesalerId",
                table: "StockMovements");

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 14, 1, 43, 2, 931, DateTimeKind.Local).AddTicks(4979), "Adet olarak ölçü birimi", "Adet" },
                    { 2, new DateTime(2025, 8, 14, 1, 43, 2, 933, DateTimeKind.Local).AddTicks(403), "Kilogram olarak ölçü birimi", "Kg" },
                    { 3, new DateTime(2025, 8, 14, 1, 43, 2, 933, DateTimeKind.Local).AddTicks(416), "Litre olarak ölçü birimi", "Litre" },
                    { 4, new DateTime(2025, 8, 14, 1, 43, 2, 933, DateTimeKind.Local).AddTicks(417), "Metre olarak ölçü birimi", "Metre" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_Name",
                table: "Units",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_SalesReceipts_SalesReceiptId",
                table: "StockMovements",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Wholesalers_WholesalerId",
                table: "StockMovements",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_SalesReceipts_SalesReceiptId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Wholesalers_WholesalerId",
                table: "StockMovements");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_SalesReceipts_SalesReceiptId",
                table: "StockMovements",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Wholesalers_WholesalerId",
                table: "StockMovements",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
