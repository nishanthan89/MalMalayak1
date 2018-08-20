using Mal.Utility.BL;
using MalMaalayak.BL;
using MalMaalayak.Controllers;
using System.Linq;
using System.Web.Mvc;

namespace MalMaalayak.Areas.Utility.Controllers
{
    public class UtilityController : CommonController
    {
       // private UtilityBL utilityBL = new UtilityBL();

        private void _SetDropdowns()
        {
            //ViewBag.LagnaList = utilityBL.GetLagnalist().Select(x => new SelectListItem()
            //{
            //    Value = x.LagnaId.ToString(),
            //    Text = x.LagnaType,
            //});

        }
    }
}