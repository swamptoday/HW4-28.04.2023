using Microsoft.AspNetCore.Mvc;
using Developer_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Developer_form.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Welcome(string fname, string lname, string email)
        {
            var model = new Welcome() { first_name = fname, last_name = lname, w_email = email };
            return View(model);
        }
    }
}
