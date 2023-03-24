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
            return View(new Customer());
        }
         [HttpPost]
         //Model Binding
        public IActionResult CreateWithForm(Customer customer)
        {

          //var firstName=  HttpContext.Request.Form["firstName"].ToString();
          //  var lastName = HttpContext.Request.Form["lastName"].ToString();
          //  var age = int.Parse(HttpContext.Request.Form["age"].ToString());
            Customer lastCustomer = null;
            if(CustomerContext.Customers.Count > 0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }
            
            customer.Id = lastCustomer == null ?  1 :  lastCustomer.Id + 1;

            
          
            CustomerContext.Customers.Add(customer);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());
            var removedCustomer = CustomerContext.Customers.Find(a=> a.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());
           var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a=> a.Id == id);
            return View(updatedCustomer);
        }
        [HttpPost]
        public IActionResult UpdateCustomer()
        {
            var id = int.Parse(HttpContext.Request.Form["id"].ToString());
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a=>a.Id == id);
            updatedCustomer.FirstName = HttpContext.Request.Form["firstName"].ToString();
            updatedCustomer.LastName = HttpContext.Request.Form["lastName"].ToString();
            updatedCustomer.Age = int.Parse(HttpContext.Request.Form["Age"].ToString());
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
