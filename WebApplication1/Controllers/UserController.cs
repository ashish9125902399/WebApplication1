using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.DBOperations;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        GKHUBEntities en = new GKHUBEntities();
        UserRepo ur = new UserRepo();
        QuestionRepo qr = new QuestionRepo();
        // GET: User
        public ActionResult UserHome()
        {
            string id = User.Identity.Name;
            var details = ur.GetUser(id);
            ViewBag.Name = details.name;
            return View();
        }
        public ActionResult Details()
        {
            string id = User.Identity.Name;
            var details = ur.GetUser(id);
            ViewBag.Name = details.name;
            return View(details);
        }

        public ActionResult SelectSubject()
        {
            var list = new List<string>() { "History", "Physics","Chemistry","Biology", "Polity", "Geography", "Current Affairs", };
            ViewBag.List = list;
            return View();
        }

        [HttpPost]
        public ActionResult SelectSubject(SubjectModel model)
        {
            
            string sub = model.SubjectCat;
                        
            return RedirectToAction("Practice", new {sub=sub});
        }
        public ActionResult Practice(string sub)
        {
            ViewBag.Subject = sub;            
            return View();
        }            
        public JsonResult GetQuestion(PracticeModel model)
        {
            string sub = model.Subject;
            int id = model.QID;
            if (sub == "Physics")
            {
                var question = qr.GetPhyQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);

            }
            else if (sub == "Chemistry")
            {
                var question = qr.GetChemQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);
            }
            else if (sub == "Biology")
            {
                var question = qr.GetBioQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);
            }
            else if (sub == "History")
            {
                var question = qr.GetHisQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);
            }
            else if (sub == "Geography")
            {
                var question = qr.GetGeoQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);
            }
            else if (sub == "Polity")
            {
                var question = qr.GetPolityQ(id);
                var json = JsonConvert.SerializeObject(question);
                return Json(json, JsonRequestBehavior.AllowGet);
            }

            return Json("Empty", JsonRequestBehavior.AllowGet);
        }
               
        // GET: User/Edit/5
        public ActionResult EditProfile()
        {
            string id = User.Identity.Name;
            var user = ur.GetUser(id);

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult EditProfile(RegisterModel model)
        {
            bool isSuccess = ur.UpdateUser(model.email, model);
            if (isSuccess)
            {
                return RedirectToAction("Details");
            }
            return View();
        }

        // GET: User/Delete/5
        public ActionResult ChangePassword()
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            bool isSuccess = false;
            var user = ur.GetUser(User.Identity.Name);
            if(user.password==model.oldpass)
            {
                model.id = User.Identity.Name;
                isSuccess = ur.UpdatePasswrod(model);
                if (isSuccess)
                {
                    return RedirectToAction("UserHome");
                }
            }
            else
            {
                ViewBag.Message = "Wrong Password";
            }
            
            
            return View();
        }
    }
}
