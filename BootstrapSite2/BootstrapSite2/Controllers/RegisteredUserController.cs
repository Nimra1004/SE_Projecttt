using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapSite2.Models;
using System.Runtime.Serialization;

namespace BootstrapSite2.Controllers
{
    public class RegisteredUserController : Controller
    {
        // GET: RegisteredUser
        [HttpGet]
        public ActionResult Register()
        {
            RegisteredUser user = new RegisteredUser();
            return View(user);
        }
        [HttpPost]
        public ActionResult Register(RegisteredUser R)
        {
            using (DonorsDataDbEntities model = new DonorsDataDbEntities())
            {
                if (model.RegisteredUsers.Any(x => x.R_Email == R.R_Email))
                {
                    ViewBag.DuplicateMessage = "UserName already exist!";
                    return View("Register", R);
                }
                if (model.RegisteredUsers.Any(x => x.R_Contact == R.R_Contact))
                {
                    ViewBag.DuplicateMessage = "UserName already exist!";
                    return View("Register", R);
                }
                if (model.RegisteredUsers.Any(x => x.R_Password == R.R_Password))
                {
                    ViewBag.DuplicateMessage = "UserName already exist!";
                    return View("Register", R);
                }
                R.R_AddedOn = DateTime.Now;
                model.RegisteredUsers.Add(R);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Congratulations! You are registered";
            return View();


        }
    }
}