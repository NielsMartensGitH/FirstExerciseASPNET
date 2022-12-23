using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstExerciseASPNET.Models;
using FirstExerciseASPNET.ViewModels;

namespace FirstExerciseASPNET.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Niels Martens"},
                new Customer { Name = "Nore Martens"}
            };

            CustomerViewModel viewModel = new CustomerViewModel { Customers = customers };

            return View(viewModel);
        }
    }
}