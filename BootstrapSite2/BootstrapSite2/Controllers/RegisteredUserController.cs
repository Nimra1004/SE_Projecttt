using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapSite2.ViewModels;
using System.Data.Entity;
using BootstrapSite2.Models;

namespace BootstrapSite2.Controllers
{
    public class RegisteredUserController : Controller
    {
        // GET: RegisteredUser
        [HttpGet]
        public ActionResult Register()
        {
            RegisteredUserM user = new RegisteredUserM();
            return View(user);
        }
        [HttpPost]
        public ActionResult Register(RegisteredUserM R)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }
            else
            {
                try
                {
                    using (DonorsDataDbEntities model = new DonorsDataDbEntities())
                    {
                        RegisteredUser obj = new RegisteredUser();
                        {
                            obj.R_Name = R.R_Name;
                            obj.R_Email = R.R_Email;
                            obj.R_Gender = R.R_Gender;
                            obj.R_BloodGroup = R.R_BloodGroup;
                            obj.R_Contact = R.R_Contact;
                            obj.R_City = R.R_City;
                            obj.R_Address = R.R_Address;
                            obj.R_Dateofbirth = R.R_Dateofbirth;
                            obj.R_Password = R.R_Password;
                            obj.R_AddedOn = System.DateTime.Now;
                        };
                        if (model.RegisteredUsers.Any(x => x.R_Email == obj.R_Email))
                        {
                            ViewBag.DuplicateMessage = "UserName already exist!";
                            return View("Register", R);
                        }
                        if (model.RegisteredUsers.Any(x => x.R_Contact == obj.R_Contact))
                        {
                            ViewBag.DuplicateMessage = "Contact Number already exist!";
                            return View("Register", R);
                        }
                        if (model.RegisteredUsers.Any(x => x.R_Password == obj.R_Password))
                        {
                            ViewBag.DuplicateMessage = "Use Any other Password";
                            return View("Register", R);
                        }
                        model.RegisteredUsers.Add(obj);
                        model.SaveChanges();
                    }
                    ModelState.Clear();
                    ViewBag.SuccessMessage = "Congratulations! You are registered";
                    return View();

                }
                catch (Exception ex)
                {
                    ViewBag.DuplicateMessage = "Sorry fields are required";
                    return View();
                }

            }    
        }
    }
}