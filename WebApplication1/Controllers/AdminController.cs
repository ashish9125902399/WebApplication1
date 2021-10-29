using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;
using WebApplication1.DBOperations;

namespace WebApplication1.Controllers
{
   [Authorize]
    public class AdminController : Controller
    {
        GKHUBEntities en = new GKHUBEntities();
        QuestionRepo qr = new QuestionRepo();
        // GET: Admin
        public ActionResult AdminHome()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Subject()
        {           
            var list = new List<string>() { "History","Physics","Chemistry","Biology","Polity","Geography","Current Affairs",};
            ViewBag.List = list;
            return View();
        }
        
        [HttpPost]
        public ActionResult Subject(SubjectModel sub)
        {
            string subject = sub.SubjectCat;
            return RedirectToAction("Index","Practice", new {  sub=subject });
        }
        
        // GET: Admin/Delete/5
        public ActionResult DeleteQuestion()
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult DeleteQuestion(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
