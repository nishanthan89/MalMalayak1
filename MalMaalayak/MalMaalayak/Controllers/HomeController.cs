using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MalMaalayak.Models;
using PagedList;

namespace MalMaalayak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(this.GetClientDetail(1));
        }

        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetClientDetail(currentPageIndex));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private ClientDetailClassModel GetClientDetail(int currentPage) {
            int maxRows = 16;
            ClientDetailClassModel clientObj = new ClientDetailClassModel();

            using (MalMalayakDbEntities2 dbEntity = new MalMalayakDbEntities2()) {
                //ClientDetailClassModel clientObj = new ClientDetailClassModel();
                clientObj.ClientList= (from clint in dbEntity.ClientDetails
                                       select clint)
                        .OrderBy(clint => clint.Id)
                        .Skip((currentPage - 1) * maxRows)
                        .Take(maxRows).ToList();

                //this is for paging
                double pageCount = (double)((decimal)dbEntity.ClientDetails.Count() / Convert.ToDecimal(maxRows));
                clientObj.PageCount = (int)Math.Ceiling(pageCount);

                clientObj.CurrentPageIndex = currentPage;
                return clientObj;

            }

        }
    }
}