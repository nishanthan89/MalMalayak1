using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MalMaalayak.Models.ViewModel
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string NIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public string GenderType { get; set; }
        public string Religion { get; set; }
        public string Job { get; set; }
        public string Height { get; set; }
        public int CastId { get; set; }
        public string CastName { get; set; }
        public string Qualification { get; set; }
        public string Expectation { get; set; }
    }
}