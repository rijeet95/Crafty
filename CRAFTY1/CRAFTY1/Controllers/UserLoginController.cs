using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRAFTY1.Models;

namespace CRAFTY1.Controllers
{
    public class UserLoginController : Controller
    {
        crafty1Entities db = new crafty1Entities();
        // GET: UserLogin
       

        [HttpPost]
        public ActionResult Login(UserLogin s)
        {
            if (ModelState.IsValid == true)
            {
                var credential = db.Customers.Where(model => model.Customer_Mail == s.mail && model.Customer_Password == s.password).FirstOrDefault();
                Console.WriteLine(credential);
                if (credential == null)
                {
                    ViewBag.ErrorMessage = "Login Failed";
                    return View();
                }
                else
                {
                    Session["usermail"] = s.mail;
                    return RedirectToAction("About", "Home");
                    // return RedirectToAction("Registration", "UserRegistration");
                }


            }

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }


        


        [HttpPost]
        public ActionResult Registration([Bind(Include = "customer_name,customer_address,password,customer_mail")] Customer user)
        {

            if (ModelState.IsValid)
            {


                //return View();

                var credential = (from c in db.Customers
                    where c.Customer_Mail.Equals(user.Customer_Mail)
                    select c).SingleOrDefault();
                if (credential != null)
                {
                    ViewBag.ErrorMessage = "This Email already registered";
                    return View();
                }
                else
                {
                    db.Customers.Add(user);

                    
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }
                    return RedirectToAction("Login", "UserLogin");

                }

            }
            return View();
        }




    }
}