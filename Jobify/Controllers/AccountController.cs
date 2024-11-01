using Microsoft.AspNetCore.Mvc;

namespace Jobify.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult loginAccount()
        {
            return View();
        }


        [HttpGet]
        public IActionResult registerAccountUser()
        {
            return View();
        }

         [HttpGet]
        public IActionResult registerAccountEmployee()
        {
            return View();
        }


         [HttpGet]
        public IActionResult forgotAccount()
        {
            return View();
        }

    }
}
