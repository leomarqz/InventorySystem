using System.Diagnostics;
using System.Threading.Tasks;
using InventorySystem.Models;
using InventorySystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly InventorySystemDbContext context;

        public HomeController(InventorySystemDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Obtenemos la fecha actual
            var now = DateTime.Now;
            var currentMonth = now.Month;
            var currentYear = now.Year;

            // Calculamos las fechas del mes pasado
            var lastMonth = now.AddMonths(-1).Month;
            var lastMonthYear = now.AddMonths(-1).Year;

            //total de items
            List<Item>? items = await this.context.Items.ToListAsync();

            int totalStock = items
                .Where(i => i.DeleteAt == null && i.Stock > 0)
                .Sum(i => i.Stock);

            int entriesThisMonth = items
                .Where(i => i.CreatedAt.Month == currentMonth && i.CreatedAt.Year == currentYear)
                .Sum(i => i.Stock);

            int disposedThisMonth = items.Where(i=>i.DeleteAt != null)
                .Sum(i => i.Stock);

            int entriesLastMonth = items
                .Where(i => i.CreatedAt.Month == lastMonth && i.CreatedAt.Year == lastMonthYear)
                .Sum(i => i.Stock);

            return View(new InventoryViewModel
            {
                TotalInStock = totalStock,
                EntriesThisMonth = entriesThisMonth,
                EntriesLastMonth = entriesLastMonth,
                DisposedThisMonth = disposedThisMonth,
                Items = items
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
