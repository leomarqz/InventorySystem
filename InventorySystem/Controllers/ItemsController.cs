using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    [Route("/items")]
    public class ItemsController : Controller
    {
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("edit")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
