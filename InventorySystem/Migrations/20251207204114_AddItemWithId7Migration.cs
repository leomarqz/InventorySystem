using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventorySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddItemWithId7Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Category", "CreatedAt", "DeleteAt", "Description", "Name", "Stock", "UpdatedAt" },
                values: new object[] { 7, "Limpieza", new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sprite Limpia Contacto para PC", "Sprite Limpia Contacto para PC", 0, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
