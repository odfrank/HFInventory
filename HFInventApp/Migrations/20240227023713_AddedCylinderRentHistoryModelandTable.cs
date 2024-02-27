using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFInventApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedCylinderRentHistoryModelandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CylinderRentHistories",
                columns: table => new
                {
                    CylinderRentHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CylinderRentHistories", x => x.CylinderRentHistoryId);
                });

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("6c5f8e9b-8ac5-4bb1-88d8-aa1496b4dc25"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("dd698ae5-d69a-4614-9298-f0e8add9079e"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("63b1edfc-796e-4934-8080-0124f13bd28e"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("2c4db4d6-0d7e-429f-b846-45142858511d"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "InventoryBatch",
                value: new Guid("969203cb-aa59-48d0-ba65-bf075c89b80e"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "InventoryBatch",
                value: new Guid("677a4734-37ac-4d0e-bdad-0d733fb5c5a1"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "InventoryBatch",
                value: new Guid("7db69915-48e2-4c55-8221-f55aa1cd1c77"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "InventoryBatch",
                value: new Guid("00fbf402-a402-4eb1-baf5-05d291956f12"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 5,
                column: "InventoryBatch",
                value: new Guid("d4c0939c-acf5-416d-bd93-44c712f23652"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 6,
                column: "InventoryBatch",
                value: new Guid("925d1f8e-f772-4926-9b44-361b5d908a9f"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 7,
                column: "InventoryBatch",
                value: new Guid("44a18fc5-1573-4eb1-96c6-912496eb7e1d"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 8,
                column: "InventoryBatch",
                value: new Guid("06809f24-e5cd-43f1-8d89-56a3779e88de"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 9,
                column: "InventoryBatch",
                value: new Guid("78ac3742-924a-4b06-8e93-e33ee4693d4c"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 10,
                column: "InventoryBatch",
                value: new Guid("edf9dfd4-93b3-47ec-8f4e-2915651fabcc"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 11,
                column: "InventoryBatch",
                value: new Guid("04f96e71-e855-48e1-8299-39a5d6888bb6"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CylinderRentHistories");

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
    }
}
