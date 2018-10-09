using MalMaalayak.BL;
using MalMaalayak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

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
        public ActionResult SaveCoupleDetail(CoupleRegisterModel coupleRegisterModel , HttpPostedFileBase UploadLagna, HttpPostedFileBase UploadNawamsa)
        {
          coupleBL.CoupleRegister(coupleRegisterModel, UploadLagna, UploadNawamsa);
            ViewBag.Message = "Save successfully";
            return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult ViewAllClient(int? page = 1)
        {
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var data = coupleBL.ViewAllClientData().OrderBy
                                (m => m.FirstName).ToPagedList(pageIndex, pageSize);

          
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