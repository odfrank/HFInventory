using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFInventApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangedProductInventorySKUToBatchNumberWithDefaultGUID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InventoryBatch",
                table: "ProductInventories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("17cb1a2b-2983-4f23-a3cc-354526f9c370"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("43dd46b3-1680-4b90-9ebc-db9b8e43572b"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("f75ba0d4-9db0-4ad4-b2e4-9394e90c2f1c"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("8819ce05-f610-427c-80ba-f8e24db4ffac"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "InventoryBatch",
                value: new Guid("0880d52d-a7e0-49db-95da-1efde05f20bb"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "InventoryBatch",
                value: new Guid("0c8a223f-f5e9-4764-97ce-d1020058fbf5"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "InventoryBatch",
                value: new Guid("d09a1360-ce2c-4e7e-9005-df95e7839958"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "InventoryBatch",
                value: new Guid("27aa5a7b-05b5-46df-9a8e-12dfcb08e335"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 5,
                column: "InventoryBatch",
                value: new Guid("07af1cb9-b6d6-4fc2-8392-6923c7ee906a"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 6,
                column: "InventoryBatch",
                value: new Guid("9aa26c5d-58a2-4e7c-b89f-91aa802a2657"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 7,
                column: "InventoryBatch",
                value: new Guid("e3fe3659-6783-4f91-950d-dd303c1e7dad"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 8,
                column: "InventoryBatch",
                value: new Guid("5619e92b-694c-4d5d-a48d-2ff31a58a5a4"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 9,
                column: "InventoryBatch",
                value: new Guid("9eaa58f6-eefd-4101-bcdd-10faab20be1d"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 10,
                column: "InventoryBatch",
                value: new Guid("8e4a583b-04eb-407c-9f3e-f70fadf116ab"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 11,
                column: "InventoryBatch",
                value: new Guid("5a3fc60d-baf9-4a87-b0e5-4f290eb11642"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryBatch",
                table: "ProductInventories");

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("0cb3b36a-3ebe-47ae-9156-d7903f1e8304"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("721af526-90d2-4dfe-a62e-2ad0c82fa452"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("6b33d04c-04f6-443f-868b-65155be0eec8"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("c51b2fec-c1e3-40fc-a40f-6afa435bb322"));
        }
    }
}
