using AdminWebApp.Models;
using AdminWebApp.Models.Login;
using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AdminWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminUserBusinessService _adminUserBusinessService;

        public HomeController(ILogger<HomeController> logger, IAdminUserBusinessService adminUserBusinessService)
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginDto model)
        {
            if (ModelState.IsValid)
            {

                //username ile e�le�en bir user nesnesi bulunur. 
                //first al�n�r
                //

                var user = _adminUserBusinessService.GetByUserName(model.UserName);

                //user = user.Where(s => s.username.Contains(model.username));
                if (User.Count() != 0)
                {
                    if (User.First().password == model.password)
                    {
                        return RedirectToAction("Success");
                    }
                }
            }
            return RedirectToAction("Fail");
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
