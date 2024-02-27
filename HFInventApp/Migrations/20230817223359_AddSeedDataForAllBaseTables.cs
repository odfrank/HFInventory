using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFInventApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForAllBaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BinLookups",
                columns: new[] { "BinLookupId", "BinNumber", "Description", "Height", "Length", "Location", "Width" },
                values: new object[,]
                {
                    { 1, "T345", "Large bin", 10, 10, "Row 2, Slot 1", 50 },
                    { 2, "T5789", "Small bin", 5, 5, "Row 1, Slot 1", 25 },
                    { 3, "T9876", "Large bin", 10, 10, "Row 3, Slot 2", 50 },
                    { 4, "T098", "Medium bin", 7, 10, "Row 3, Slot 1", 30 },
                    { 5, "T349", "Small bin", 5, 5, "Row 1, Slot 2", 25 },
                    { 6, "T5789", "Large bin", 10, 10, "Row 4, Slot 5", 50 },
                    { 7, "T9875", "Large bin", 10, 10, "Row 2, Slot 2", 50 }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilityId", "FacilityName", "Location" },
                values: new object[,]
                {
                    { 1, "AbujaStore", "Abuja, Nigeria" },
                    { 2, "LagosStore", "Lagos, Nigeria" },
                    { 3, "TexasStore", "Texas, USA" },
                    { 4, "AccraStore", "Accra, Ghana" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "InventoryId", "BinLookupId", "FacilityId", "InventorySKU", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "SP7875", 1, 20 },
                    { 2, 2, 2, "TR87680", 2, 45 },
                    { 3, 2, 1, "MK676554", 1, 15 },
                    { 4, 3, 2, "YE98767", 2, 30 },
                    { 5, 4, 1, "XR23423", 1, 10 },
                    { 6, 1, 2, "PW98762", 2, 25 },
                    { 7, 3, 1, "BM87684", 1, 20 },
                    { 8, 2, 2, "BH67655", 2, 15 },
                    { 9, 1, 1, "WT98768", 1, 50 },
                    { 10, 4, 2, "TS3456", 2, 15 },
                    { 11, 1, 1, "WDG123", 1, 20 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, 30m, "Item 1", "Item 1" },
                    { 2, 40m, "Item 2", "Item 2" },
                    { 3, 5m, "Item 3", "Item 3" },
                    { 4, 15m, "Item 4", "Item 4" },
                    { 5, 26m, "Item 5", "Item 5" },
                    { 6, 50m, "Item 6", "Item 6" },
                    { 7, 10m, "Item 7", "Item 7" },
                    { 8, 3m, "Item 8", "Item 8" },
                    { 9, 14m, "Item 9", "Item 9" },
                    { 10, 60m, "Item 10", "Item 10" },
                    { 11, 8m, "Item 11", "Item 11" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactTitle", "Country", "CustomerName", "Email", "FacilityId", "FaxNumber", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "12 Beacon St", "Boston", "Adatum Corporation", "Manager", "USA", "Adrian King", "adrian@example.com", 1, "(123) 555-0124", "(123) 555-0134", "MA", "98765" },
                    { 2, "123 Main Street", "Seattle", "Adventure Works", "Sr. Buyer", "USA", "Aidyn Zhanbolat", "aidyn@example.com", 2, "(456) 555-0146", "(456) 555-0145", "WA", "87654" },
                    { 3, "321 Avenue A", "Portland", "Alpine Ski House", "Analyst", "USA", "Alex Krejci", "alex@example.com", 3, "(212) 555-0102", "(212) 555-0101", "OR", "76543" },
                    { 4, "89 Pacific Ave", "San Francisco", "Adventure Works", "Managing Partner", "USA", "Alix Gauthier", "alix@example.com", 4, "(786) 555-0151", "(786) 555-0150", "CA", "65432" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BinLookups",
                keyColumn: "BinLookupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 4);
        }
    }
}
