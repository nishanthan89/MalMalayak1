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
        public string Gender { get; set; }
        public string Star { get; set; }
        public string CCT { get; set; }
        public string Job { get; set; }

        public List<ClientDetail> ClientList { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }


    }
}