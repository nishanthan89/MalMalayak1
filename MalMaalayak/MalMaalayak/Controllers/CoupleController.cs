using MalMaalayak.BL;
using MalMaalayak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalMaalayak.Controllers
{
    public class CoupleController : Controller
    {
        CoupleBL coupleBL = new CoupleBL();
        public IList<ClientDetailClassModel> coupleList = new List<ClientDetailClassModel>();
        // GET: Couple
        public ActionResult GetCouple()
        {
            var CoupleDetails =coupleBL.GetCouple();

            return View(CoupleDetails);
        }

        [HttpGet]
        public ActionResult GetCoupleFemale()
        {
            var CoupleDetails = coupleBL.GetCoupleFemale();
            return View("GetCouple", CoupleDetails);
        }



        // GET: Couple/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Couple/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCouple()
        {
            return View();
        }




        // POST: Couple/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Couple/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Couple/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Couple/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Couple/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
