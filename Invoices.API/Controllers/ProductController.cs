using Microsoft.AspNetCore.Mvc;

namespace Invoices.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
