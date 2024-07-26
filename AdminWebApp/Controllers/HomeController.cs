using AdminWebApp.Models;
using AdminWebApp.Models.Login;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminUserService _adminUserBusinessService;

        public HomeController(ILogger<HomeController> logger, IAdminUserService adminUserBusinessService)
        {
            _logger = logger;
            _adminUserBusinessService = adminUserBusinessService;
        }

        public IActionResult Index()
        {
            return View();
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

        [Route("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                //var user = _adminUserBusinessService.GetByUserName(model.UserName);

                ////user = user.Where(s => s.username.Contains(model.username));
                //if (User.Count() != 0)
                //{
                //    if (User.First().password == model.password)
                //    {
                //        return RedirectToAction("Success");
                //    }
                //}
            }
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Fail()
        {
            return View();
        }
    }
}
