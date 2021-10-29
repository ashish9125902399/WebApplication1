using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;
using WebApplication1.DBOperations;
using Newtonsoft.Json;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        GKHUBEntities en = new GKHUBEntities();
        UserRepo ur = new UserRepo();
        QuestionRepo qr = new QuestionRepo();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your can contact here.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register model, Login lmodel, RegisterModel rm)
        {
            if (rm.Checkbx == true)
            {
                using (var context = en)
                {
                    context.Registers.Add(model);
                    context.Logins.Add(lmodel);
                    context.SaveChanges();
                }
            }
            else
            {
                ViewBag.Message = "Please Accept the Terms and Conditions";
            }

            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            RegisterModel uname = new RegisterModel();
            QuestionRepo qr = new QuestionRepo();

            using (var context = en)
            {
                bool isValid = context.Logins.Any(x => x.Email == model.Email && x.Password == model.Password);
                if (isValid)
                {
                    if (uname.Checkbx == true)
                    {

                    }
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    string type = qr.GetUserType(model.Email);
                    if (type == "admin")
                    {
                        return RedirectToAction("AdminHome", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("UserHome", "User");
                    }

                }
                ModelState.AddModelError("", "Invalid Username or Password");
                ViewBag.Message = "";

                return View();
            }


        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult Download()
        {
            FormsAuthentication.SignOut();
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword(ChangePasswordModel model)
        {
            bool isSuccess = false;
            if (model.newpass == model.repass)
            {
                isSuccess = ur.UpdatePasswrod(model);
                if (isSuccess)
                {
                    return RedirectToAction("Login");
                }
            }
            else
            {
                ViewBag.Message = "Please enter the same password";
            }
            return View(ViewBag.Message);
        }
        public JsonResult GetID(ChangePasswordModel model)
        {
            var user = ur.GetUser(model.id);
            if (user!=null)
            { 
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Home");
        }
    }
}