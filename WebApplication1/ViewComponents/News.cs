using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class News :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var list = NewsContext.List;
            return View(list);
        }
    }
}
