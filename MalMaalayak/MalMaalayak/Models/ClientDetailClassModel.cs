using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MalMaalayak.Models
{
    public class ClientDetailClassModel
    {

        public string NIC { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GenderId { get; set; }
        public string GenderType { get; set; }

        public int StarId { get; set; }
        public string StarName { get; set; }



        public int CastId { get; set; }
        public string CastName { get; set; }

        public string Job { get; set; }

        public List<ClientDetail> ClientList { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }


        public List<ClientDetail> CoupleList { get; set; }
        //public IEnumerable<ClientDetail> CoupleList { get; set; }



    }
}