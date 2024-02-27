using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFInventApp.Migrations
{
    /// <inheritdoc />
    public partial class AddsCylinderModelWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cylinders",
                columns: table => new
                {
                    CylinderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CylinderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cylinders", x => x.CylinderId);
                    table.ForeignKey(
                        name: "FK_Cylinders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.InsertData(
                table: "Cylinders",
                columns: new[] { "CylinderId", "BatchNumber", "CustomerId", "CylinderName" },
                values: new object[,]
                {
                    { 1, new Guid("0cb3b36a-3ebe-47ae-9156-d7903f1e8304"), 1, "Cylinder1" },
                    { 2, new Guid("721af526-90d2-4dfe-a62e-2ad0c82fa452"), 2, "Cylinder2" },
                    { 3, new Guid("6b33d04c-04f6-443f-868b-65155be0eec8"), 3, "Cylinder3" },
                    { 4, new Guid("c51b2fec-c1e3-40fc-a40f-6afa435bb322"), null, "Cylinder4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cylinders_CustomerId",
                table: "Cylinders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cylinders");
        }
    }
}
