using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Member.Controllers
{
    [Area("Member")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
