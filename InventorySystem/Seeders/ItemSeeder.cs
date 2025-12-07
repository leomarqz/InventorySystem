using InventorySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Seeders
{
    public static class ItemSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var laptopGamerXPro = new Item
            {
                Id = 1,
                Name = "Laptop Gamer X-Pro",
                Description = "Laptop Gamer X-Pro es un equipo especializado",
                Category = "Electronica",
                Stock = 15,
                CreatedAt = new DateTime(2020, 3, 24),
                UpdatedAt = new DateTime(2020, 3, 25),
            };

            var sillaOficinaProMax = new Item
            {
                Id = 2,
                Name = "Silla Oficina Pro-Max",
                Description = "Silla Oficina Pro-Max es un equipo especializado",
                Category = "Mobiliario",
                Stock = 5,
                CreatedAt = new DateTime(2020, 5, 10),
                UpdatedAt = new DateTime(2020, 6, 15),
            };

            var discoSSD1TB = new Item
            {
                Id = 3,
                Name = "Disco Duro SSD 1TB",
                Description = "Disco Duro SSD 1TB, dispositivo de almacenamiento",
                Category = "Almacenamiento",
                Stock = 20,
                CreatedAt = new DateTime(2021, 1, 10),
                UpdatedAt = new DateTime(2021, 2, 2),
                DeleteAt = new DateTime(2022, 2, 3)
            };

            var routerWifi6 = new Item
            {
                Id = 4,
                Name = "Router Wi-Fi 6 de Doble Banda",
                Description = "Router Wi-Fi 6 de Doble Banda, dispositivo de red",
                Category = "Redes",
                Stock = 25,
                CreatedAt = new DateTime(2025, 11, 10),
                UpdatedAt = new DateTime(2025, 11, 11),
            };

            var cableHDMIPremium = new Item
            {
                Id = 5,
                Name = "Cable HDMI Premium 2m",
                Description = "Cable HDMI Premium 2m, dispositivo de Conectividad",
                Category = "Conectividad",
                Stock = 35,
                CreatedAt = new DateTime(2025, 11, 10),
                UpdatedAt = new DateTime(2025, 12, 5),
            };

            var impresora = new Item
            {
                Id = 6,
                Name = "Impresora Multifunción Láser",
                Description = "Impresora Multifunción Láser, dispositivo de Oficina",
                Category = "Oficina",
                Stock = 7,
                CreatedAt = new DateTime(2025, 11, 10),
                UpdatedAt = new DateTime(2025, 12, 5), 
            };

            var limpiaContactoParaPC = new Item
            {
                Id = 7,
                Name = "Sprite Limpia Contacto para PC",
                Description = "Sprite Limpia Contacto para PC",
                Category = "Limpieza",
                Stock = 0,
                CreatedAt = new DateTime(2025, 12, 7),
                UpdatedAt = new DateTime(2025, 12, 7),
            };

            builder.Entity<Item>().HasData(laptopGamerXPro);
            builder.Entity<Item>().HasData(sillaOficinaProMax);
            builder.Entity<Item>().HasData(discoSSD1TB);
            builder.Entity<Item>().HasData(routerWifi6);
            builder.Entity<Item>().HasData(cableHDMIPremium);
            builder.Entity<Item>().HasData(impresora);
            builder.Entity<Item>().HasData(limpiaContactoParaPC);

        }
    }
}
