using MalMaalayak.BL;
using MalMaalayak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalMaalayak.Controllers
{
    public class CoupleRegisterController : Controller
    {
        CoupleBL coupleBL = new CoupleBL();
        CoupleRegisterModel CoupleRegisterModel = new CoupleRegisterModel();
        

        public ActionResult CoupleRegister(/*int? id*/)
        {
            //if (id != null && id > 0)
            //{
            //    CoupleRegisterModel = coupleBL.GetClientDetail((int)id);
            //}

            return View("CoupleRegister", CoupleRegisterModel);
           
        }

        public ActionResult CoupleEdit(int? id, string button)
        {
            if (id != null && id > 0)
            {
                CoupleRegisterModel = coupleBL.GetClientDetail((int)id);
            }

            return View("CoupleRegister", CoupleRegisterModel);

        }

        [HttpPost]
        public ActionResult SaveCoupleDetail(CoupleRegisterModel coupleRegisterModel)
        {
          coupleBL.CoupleRegister(coupleRegisterModel);
          return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult ViewAllClient()
        {

            var data=coupleBL.ViewAllClientData();
            return View(data);

        }

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteData(int ? id)
        {
            var data= coupleBL.DeleteClientDetail((int)id);

            //PersonalDetail personalDetail = db.PersonalDetails.Find(id);
            //db.PersonalDetails.Remove(personalDetail);
            //db.SaveChanges();
            return View("~/Views/Home/Contact.cshtml");
        }

    }
}