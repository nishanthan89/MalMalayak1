using MalMaalayak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalMaalayak.Controllers
{
    public class ManagePersonController : Controller
    {
        ClientDetailClassModel personDbObject = new ClientDetailClassModel();
        // GET: ManagePerson
        public ActionResult PersonList()
        {
            return View(personDbObject.ClientList.ToList());
        }

        //  
        // GET: /CRUD/Details/5  

        //public ActionResult Details(string id = null)
        //{
        //    ClientDetail person = personDbObject.ClientList.Find();
        //    if (person == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(person);
        //}

        //  
        // GET: /CRUD/Create  

        public ActionResult Create()
        {
            return View();
        }

        //  
        // POST: /CRUD/Create  

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(ClientDetailClassModel personDbObjectCreate)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        personDbObject.ClientDetail.Add(employee);
        //        personDbObject.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(employee);
        //}

        //  
        // GET: /CRUD/Edit/5  

        //public ActionResult Edit(string id = null)
        //{
        //    ClientDetail employee = personDbObject.EMPLOYEEs.Find(id);
        //    if (employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employee);
        //}

        //  
        // POST: /CRUD/Edit/5  

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(ClientDetail employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        personDbObject.Entry(employee).State = EntityState.Modified;
        //        personDbObject.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //  
        // GET: /CRUD/Delete/5  

        //public ActionResult Delete(string id = null)
        //{
        //    ClientDetail employee = personDbObject.EMPLOYEEs.Find(id);
        //    if (employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employee);
        //}

        //  
        // POST: /CRUD/Delete/5  

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    ClientDetail employee = personDbObject.EMPLOYEEs.Find(id);
        //    personDbObject.EMPLOYEEs.Remove(employee);
        //    personDbObject.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    personDbObject.Dispose();
        //    base.Dispose(disposing);
        //}

    }
}