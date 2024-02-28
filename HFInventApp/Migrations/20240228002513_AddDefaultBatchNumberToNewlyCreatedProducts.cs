using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFInventApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultBatchNumberToNewlyCreatedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("38a26830-187e-41b8-acf3-6d80f6b32ad1"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("b75719e4-58f4-4c91-8cc3-e0199623d100"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("4b594c25-3c9d-4e89-abc9-9c4f26de229b"));

            migrationBuilder.UpdateData(
                table: "Cylinders",
                keyColumn: "CylinderId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("750ba1d2-febd-41fd-8276-0c5751263b61"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "InventoryBatch",
                value: new Guid("4f42eb90-9c32-4809-9bf8-e80d3673cf6e"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "InventoryBatch",
                value: new Guid("d86eb489-8796-46f4-98ee-64d580256af8"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "InventoryBatch",
                value: new Guid("897739e6-36b6-4286-9c4c-8533bdaa221e"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "InventoryBatch",
                value: new Guid("4feb33e5-885f-4932-8231-d4eab5ef8cb2"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 5,
                column: "InventoryBatch",
                value: new Guid("fa3b86e7-6f67-404c-8137-5e2060d2f0a1"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 6,
                column: "InventoryBatch",
                value: new Guid("d3bd283e-ff5f-4411-90ba-740f122026de"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 7,
                column: "InventoryBatch",
                value: new Guid("fa18f481-e33f-4cf2-85d7-9f5e344d664b"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 8,
                column: "InventoryBatch",
                value: new Guid("c2f96ced-3475-4e4c-8653-1109d097d8c3"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 9,
                column: "InventoryBatch",
                value: new Guid("0329cf8e-f816-45f8-a4e8-750ae4fc0f72"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 10,
                column: "InventoryBatch",
                value: new Guid("460c5e14-782e-4693-a22e-3b350554f768"));

            migrationBuilder.UpdateData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 11,
                column: "InventoryBatch",
                value: new Guid("3cee8b59-48c5-4611-944e-b84674e69229"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("140b7943-f720-48fb-9d4d-9e45d71c979f"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("b5da6ce3-3669-4688-ae12-2745121e8ffa"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("9ce983a9-f90a-48e7-8aea-045474084595"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("a549be66-be2c-46a5-b64e-dd79e5d0117f"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "BatchNumber",
                value: new Guid("d595111a-4fc2-4e51-af21-a141aff7435e"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "BatchNumber",
                value: new Guid("a07e7756-57e6-4a09-9e69-343e47dd8e36"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "BatchNumber",
                value: new Guid("faa5da45-652f-4dd1-9763-2053cdecf55e"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "BatchNumber",
                value: new Guid("94ea533b-ea19-4a1f-ba3f-2fe46b9bd924"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "BatchNumber",
                value: new Guid("936b7567-4dac-4788-b317-654801488bae"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "BatchNumber",
                value: new Guid("f39c6821-0069-40e2-a3c0-035a82d216ef"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "BatchNumber",
                value: new Guid("9add0a6a-235d-4412-8f6e-ed7ad3fc84d6"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "BatchNumber",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
