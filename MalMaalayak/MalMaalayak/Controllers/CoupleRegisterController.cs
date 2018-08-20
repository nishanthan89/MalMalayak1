

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
        //private UtilityBL utilityBL = new UtilityBL();

        //private void _SetDropdowns()
        //{
        //    ViewBag.LagnaList = utilityBL.GetLagnalist().Select(x => new SelectListItem()
        //    {
        //        Value = x.LagnaId.ToString(),
        //        Text = x.LagnaType,
        //    });

        //}
        // GET: CoupleRegister
        public ActionResult CoupleRegister()
        {
           // _SetDropdowns();
            return View();
           
        }
        [HttpPost]
        public ActionResult SaveCoupleDetail(CoupleRegisterModel coupleRegisterModel)
        {
            var saveData = coupleBL.CoupleRegister(coupleRegisterModel);
            return View();
        }

    }
}