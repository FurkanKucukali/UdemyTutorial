using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }
         [HttpPost]
        public IActionResult CreateWithForm()
        {

          var firstName=  HttpContext.Request.Form["firstName"].ToString();
            var lastName = HttpContext.Request.Form["lastName"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var lastCustomer = CustomerContext.Customers.Last();
            var id = lastCustomer.Id + 1;
            CustomerContext.Customers.Add(new Customer
            {
                Id = id,
                Age = age,
                FirstName = firstName,
                LastName = lastName,
                
            });
            
            return RedirectToAction("Index");
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
    }
}
