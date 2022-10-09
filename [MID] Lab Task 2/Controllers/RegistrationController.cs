using _MID__Lab_Task_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _MID__Lab_Task_2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", "Registration");
            }
            return View(user);
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}