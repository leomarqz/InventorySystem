using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventorySystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Category", "CreatedAt", "DeleteAt", "Description", "Name", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Electronica", new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laptop Gamer X-Pro es un equipo especializado", "Laptop Gamer X-Pro", 15, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mobiliario", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silla Oficina Pro-Max es un equipo especializado", "Silla Oficina Pro-Max", 5, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Almacenamiento", new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disco Duro SSD 1TB, dispositivo de almacenamiento", "Disco Duro SSD 1TB", 20, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Redes", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Router Wi-Fi 6 de Doble Banda, dispositivo de red", "Router Wi-Fi 6 de Doble Banda", 25, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Conectividad", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cable HDMI Premium 2m, dispositivo de Conectividad", "Cable HDMI Premium 2m", 35, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Oficina", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Impresora Multifunción Láser, dispositivo de Oficina", "Impresora Multifunción Láser", 7, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
