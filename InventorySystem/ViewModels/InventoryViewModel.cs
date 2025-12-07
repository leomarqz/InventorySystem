using InventorySystem.Models;

namespace InventorySystem.ViewModels
{
    public class InventoryViewModel
    {
        public List<Item>? Items { get; set; }
        public int TotalInStock { get; set; } // Total en Inventario (Activos)
        public int EntriesThisMonth { get; set; } // Ingresos Este Mes
        public int DisposedThisMonth { get; set; } // Salidas/Bajas Este Mes
        public int EntriesLastMonth { get; set; } // Ingresos Mes Pasado
    }
}
