using MalMaalayak.BL;
using MalMaalayak.Models;
using PagedList;
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
        CoupleRegisterModel CoupleRegisterModel = new CoupleRegisterModel();
        public IList<ClientDetailClassModel> coupleList = new List<ClientDetailClassModel>();
        // GET: Couple
        public ActionResult GetCouple(int? page = 1)
        {
            //int ? page=1;
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var CoupleDetails =coupleBL.GetMale().OrderBy
                                (m => m.StarName).ToPagedList(pageIndex, pageSize); 

            return View(CoupleDetails);
        }

        [HttpGet]
        public ActionResult GetCoupleFemale(int? page = 1)
        {
           // int? page = 1;
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;


            var CoupleDetails = coupleBL.GetFemale().OrderBy
                                (m => m.StarName).ToPagedList(pageIndex, pageSize);
            return View("GetCouple", CoupleDetails);
        }
        [HttpGet]
        public ActionResult GetMoreDetails(int? id, string button)
        {
            if (id != null && id > 0)
            {
                CoupleRegisterModel = coupleBL.GetClientDetail((int)id);
            }

            return View("GetMoreDetails", CoupleRegisterModel);
            //return View("GetMoreDetails");
        }
        [HttpGet]
        public ActionResult test()
        {
            return View("test");
        }

    }
}
