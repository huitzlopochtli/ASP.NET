using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HireAVehicle.Entity;
using HireAVehicle.Models;
using Microsoft.ApplicationInsights.Web;

namespace HireAVehicle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to GoGo";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegistrationCustomer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegistrationCustomer(AccountCustomer accountCustomer)
        {
            accountCustomer.Account.AccountType = AccountType.Customer;
            Account regAccount = accountCustomer.Account;
            Customer regCustomer = accountCustomer.Customer;
            return View();
        }

        [HttpGet]
        public ActionResult RegistrationDriver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationCustomer(Account account, Driver driver)
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}