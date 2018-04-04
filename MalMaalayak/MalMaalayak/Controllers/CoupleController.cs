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
        public IList<ClientDetailClassModel> coupleList = new List<ClientDetailClassModel>();
        // GET: Couple
        public ActionResult GetCouple(int? page = 1)
        {
            //int ? page=1;
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var CoupleDetails =coupleBL.GetCouple().OrderBy
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


            var CoupleDetails = coupleBL.GetCoupleFemale().OrderBy
                                (m => m.StarName).ToPagedList(pageIndex, pageSize);
            return View("GetCouple", CoupleDetails);
        }
        [HttpGet]
        public ActionResult GetMoreDetails()
        {
            return View("GetMoreDetails");
        }

    }
}
