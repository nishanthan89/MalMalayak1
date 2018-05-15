using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MalMaalayak.Models;
using PagedList;
using MalMaalayak.BL;

namespace MalMaalayak.Controllers
{
    public class HomeController : Controller
    {
        CoupleBL coupleBL = new CoupleBL();
        public IList<ClientDetailClassModel> coupleList = new List<ClientDetailClassModel>();
        public ActionResult Index(int? page = 1)
        {
            //return View(this.GetClientDetail(1));
            int pageSize = 10;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var allDetails = coupleBL.GetAllDetails().OrderBy
                                (m => m.StarName).ToPagedList(pageIndex, pageSize);

            return View(allDetails);
        }

        //[HttpPost]
        //public ActionResult Index(int currentPageIndex)
        //{
        //   // return View(this.GetClientDetail(currentPageIndex));
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}