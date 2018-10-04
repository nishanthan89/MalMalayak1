using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MalMaalayak.Models
{
    public class ClientDetailClassModel
    {
        [Display(Name = "NIC No")]
        public string NIC { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int GenderId { get; set; }

        [Display(Name = "Gender")]
        public string GenderType { get; set; }

        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Display(Name = "Job")]
        public string Job { get; set; }

        [Display(Name = "Height")]
        public string Height { get; set; }

        public int StarId { get; set; }
        public string Star { get; set; }

        [Display(Name = "Star")]
        public string StarName { get; set; }



        public int CastId { get; set; }
        [Display(Name = "Cast")]
        public string CastName { get; set; }

        [Display(Name = "Lagna")]
        public string Lagna { get; set; }

        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Display(Name = "Birth Of Date")]
        public string BirthOfDate { get; set; }

        [Display(Name = "Birth Place")]
        public string BirthPlace { get; set; }

        [Display(Name = "Birth Time")]
        public string BirthTime { get; set; }
        [Display(Name = "Kiraka Paavam")]
        public string Paavam { get; set; }

        [Display(Name = "Father's Place")]
        public string FartherPlace { get; set; }

        [Display(Name = "Mother's Place")]
        public string MotherPlace { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Residence")]
        public string Residence { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Phone Number(Home)")]
        public string HomePhone { get; set; }
        [Display(Name = "Phone Number(Mobile)")]
        public string MobileNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Expectation")]
        public string Expectation { get; set; }





        public List<ClientDetail> ClientList { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }


        public List<ClientDetail> CoupleList { get; set; }
        //public IEnumerable<ClientDetail> CoupleList { get; set; }



    }
}