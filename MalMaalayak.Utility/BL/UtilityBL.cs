using MalMaalayak.Utility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MalMaalayak.Utility.BL
{
    public class UtilityBL
    {
        MalMalayakDbEntities2 dbEntity = new MalMalayakDbEntities2();
        public List<Lagna> GetLagnalist()
        {
            return (from lagna in dbEntity.Lagnas
                    orderby lagna.LagnaId
                    select new Lagna()
                    {
                        LagnaId = lagna.LagnaId,
                        LagnaType = lagna.LagnaType,
                    }).OrderBy(x => x.LagnaId).ToList();
        }
    }
}