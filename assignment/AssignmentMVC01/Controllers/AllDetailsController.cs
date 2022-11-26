using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentMVC01.Models;
using AssignmentMVC01.ViewModel;

namespace AssignmentMVC01.Controllers
{
    public class AllDetailsController : Controller
    {
        // GET: AllDetails
        public ActionResult Index()
        {
            Supplier supplier = new Supplier()
            {
                SId = 01,
                SName = "Raj",
                SGender = "Male",
                SAddress = "Mumbai",
                SProducts= "Laptop " 

            };
            Customer customer = new Customer()
            {
                CId = 101,
                Name = "Tejasvi",
                Gender = "Female",
                City = "Pune"
            };
            ViewData["Header"] = "Supplier's Details";
            ViewData["Sinfo"] = supplier;
            ViewBag.Header1 = "Customer Details";
            ViewBag.Cinfo=customer;


            return View();
        }
        public ActionResult Details()
        {
            Customer customer = new Customer()
            {
                CId = 101,
                Name = "Tejasvi",
                Gender = "Female",
                City = "Pune",

            };

            Product product = new Product()
            {
                PId = 11,
                PName = "Laptop",
                Model = "Lenovo",
                Price = 80000,

            };

            Supplier supplier = new Supplier()
            {
                SId = 01,
                SName = "Raj",
                SGender = "Male",
                SAddress = "Mumbai",
                SProducts = "Laptop "
            };

           
         
            AllDetailsViewModel ViewModel = new AllDetailsViewModel()
            {
                Supplier = supplier,
                Customer= customer,
                Product=product,
                Headermessage = "Product,Supplier and Customer Details"

            };
            return View(ViewModel);
        }
    }
}