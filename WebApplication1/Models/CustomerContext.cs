using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
            new Customer { FirstName = "Yavuz", LastName = "Kahraman ", Age = 27 },
            new Customer { FirstName = "Oğuz", LastName = "Veli", Age = 23 }
        };
    }
}
