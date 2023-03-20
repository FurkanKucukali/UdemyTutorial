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
            new Customer {Id = 1, FirstName = "Yavuz", LastName = "Kahraman ", Age = 27 },
            new Customer {Id = 2, FirstName = "Oğuz", LastName = "Veli", Age = 23 }
        };
    }
}
