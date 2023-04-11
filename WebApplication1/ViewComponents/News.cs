using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class News :ViewComponent
    {
        public IViewComponentResult Invoke(string color = "default")
        {
            var list = NewsContext.List;

            if (color == "default")
            {
                return View(list);
            }
            else if (color=="red") {
                return View("red",list);
            }
            else { return View("blue", list); };
            
        }
    }
}
