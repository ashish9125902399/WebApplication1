using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;
using WebApplication1.DBOperations;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class PracticeController : Controller
    {
        GKHUBEntities en = new GKHUBEntities();
        QuestionRepo qr = new QuestionRepo();
        // GET: Practice
        public ActionResult Index(string sub)
        {
            ViewBag.Subject = sub;
            if (sub == "Physics")
            {
                var pm = qr.GetPhysics();
                return View(pm);
            }
            else if (sub == "Chemistry")
            {
                var pm = qr.GetChemistry();
                return View(pm);
            }
            else if (sub == "Biology")
            {
                var pm = qr.GetBiology();
                return View(pm);
            }
            else if (sub == "History")
            {
                var pm = qr.GetHistory();
                return View(pm);
            }
            else if (sub == "Geography")
            {
                var pm = qr.GetGeography();
                return View(pm);
            }
            else if (sub == "Polity")
            {
                var pm = qr.GetPolity();
                return View(pm);
            }

            return View();
        }

        // GET: Practice/Create
        public ActionResult Create(string sub)
        {
            ViewBag.Subject = sub;
            return View();
        }

        // POST: Practice/Create
        [HttpPost]
        public ActionResult Create(PracticeModel pr, string sub)
        {
            try
            {
                int i = 0;
                if (ModelState.IsValid)
                {
                    if (sub == "Physics")
                    {
                        i = qr.AddPhysics(pr);
                    }
                    else if (sub == "Chemistry")
                    {
                        i = qr.AddChemistry(pr);
                    }
                    else if (sub == "Biology")
                    {
                        i = qr.AddBiology(pr);
                    }
                    else if (sub == "History")
                    {
                        i = qr.AddHistory(pr);
                    }
                    else if (sub == "Geography")
                    {
                        i = qr.AddGeography(pr);
                    }
                    else if (sub == "Polity")
                    {
                        i = qr.AddPolity(pr);
                    }
                    else if (sub == "Economic")
                    {
                        i = qr.AddEconomic(pr);
                    }
                    if (i > 0)
                    {
                        ModelState.Clear();
                        ViewBag.Status = "Data Added Successfully";
                        ViewBag.Subject = sub;
                    }
                }
                return RedirectToAction("Index", "Practice", new { sub = ViewBag.Subject  });
            }
            catch
            {
                return View();
            }
        }

        // GET: Practice/Edit/5
        public ActionResult Edit(int id, string sub)
        {
            ViewBag.Subject = sub;
            if (sub == "Physics")
            {
                var question = qr.GetPhyQ(id);
                return View(question);
            }
            else if (sub == "Chemistry")
            {
                var question = qr.GetChemQ(id);
                return View(question);
            }
            else if (sub == "Biology")
            {
                var question = qr.GetBioQ(id);
                return View(question);
            }
            else if (sub == "History")
            {
                var question = qr.GetHisQ(id);
                return View(question);
            }
            else if (sub == "Geography")
            {
                var question = qr.GetGeoQ(id);
                return View(question);
            }
            else if (sub == "Polity")
            {
                var question = qr.GetPolityQ(id);
                return View(question);
            }
                      
            return View(sub);
        }

        // POST: Practice/Edit/5
        [HttpPost]
        public ActionResult Edit(PracticeModel pr, string sub)
        {
            bool isSuccess = false;
            if (sub == "Physics")
            {
                isSuccess = qr.UpdatePhyQ(pr.QID, pr);
            }
            else if (sub == "Chemistry")
            {
                isSuccess = qr.UpdateChemQ(pr.QID, pr); ;
            }
            else if (sub == "Biology")
            {
                isSuccess = qr.UpdateBioQ(pr.QID, pr);
            }
            else if (sub == "History")
            {
                isSuccess = qr.UpdateHisQ(pr.QID, pr);
            }
            else if (sub == "Geography")
            {
                isSuccess = qr.UpdateGeoQ(pr.QID, pr);
            }
            else if (sub == "Polity")
            {
                isSuccess = qr.UpdatePolityQ(pr.QID, pr);
            }
           
            if (isSuccess)
            {
                return RedirectToAction("Index","Practice", new { sub = sub });
            }
            return View();
        }

        // GET: Practice/Delete/5
        public ActionResult Delete(int id, string sub)
        {
            bool isDeleted = qr.DeletePhyQ(id);

            if(isDeleted)
            {
                return RedirectToAction("Index", new { sub = sub });
            }
            return ViewBag.Status = "Error in Deletion";
        }
               
    }
}
