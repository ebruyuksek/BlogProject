using Microsoft.AspNetCore.Mvc;

namespace AdminWebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
