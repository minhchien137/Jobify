using Microsoft.AspNetCore.Mvc;

namespace Jobify.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
