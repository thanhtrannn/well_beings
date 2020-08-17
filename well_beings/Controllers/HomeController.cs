using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using well_beings.Models;

namespace well_beings.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Generates random decimal to set price for test data
        /// </summary>
        /// <returns>Rounded decimal</returns>
       public Decimal GetPrice()
        {
            double min = .50;
            double max = 20;
            Random randomDecimal = new Random();
            Double price = randomDecimal.NextDouble() * (max - min) + min ;
            return (Decimal)Math.Round(price, 2);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            // create data from model
            List<Product> products = new List<Product>()
            {
                new Product { Id=1, Name="Chickasaw", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=2, DisplayImage="https://loremflickr.com/320/240/berries?random=1"  },
                new Product { Id=2, Name="Kiowa", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=0, DisplayImage="https://loremflickr.com/320/240/berries?random=2"  },
                new Product { Id=3, Name="Shawnee", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=1, DisplayImage="https://loremflickr.com/320/240/berries?random=3"  },
                new Product { Id=4, Name="Apache", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=5, DisplayImage="https://loremflickr.com/320/240/berries?random=4"  },
                new Product { Id=5, Name="Arapaho", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=10, DisplayImage="https://loremflickr.com/320/240/berries?random=5"  },
                new Product { Id=6, Name="Natchez", Price=GetPrice(),Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Quantity=2, DisplayImage="https://loremflickr.com/320/240/berries?random=6" },

            };
            return View(products);
        }

        public IActionResult Retailers()
        {
            List<Retailer> retailers = new List<Retailer>()
            {
                new Retailer { Id=1, Name="Gary's Shop", Country="Canada", ProvinceState="Ontario", City="Hamilton", PostalCode="L0S2S9", Telephone="(905) 923-2423"  },
                new Retailer { Id=2, Name="Jenny's Farm", Country="Canada", ProvinceState="Ontario", City="Hamilton", PostalCode="L9S9E9", Telephone="(905) 923-2222"  },
                new Retailer { Id=3, Name="Farmers Market", Country="Canada", ProvinceState="Ontario", City="Hamilton", PostalCode="L9S2E2", Telephone="(905) 923-4234"  },
                new Retailer { Id=4, Name="Jamey", Country="Canada", ProvinceState="Ontario", City="Hamilton", PostalCode="L8L6E3", Telephone="(905) 923-7777"  }
            };
            return View(retailers);
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {   
            // post to db or php email function goes here
            HttpContext.Session.SetString("MessageSent", "True");
            return View();
        }

    }
}
