using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static MalMaalayak.Constants.ConstantDetail;

namespace MalMaalayak.Models
{
    public class ClientDetailClassModel
    {
        public int Id { get; set; }
        [Display(Name = "NIC No")]
        public string NIC { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int GenderId { get; set; }

        [Display(Name = "Gender")]
        public Gender GenderType { get; set; }

        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Display(Name = "Job")]
        public string Job { get; set; }

        [Display(Name = "Height")]
        public string Height { get; set; }

        public Star StarId { get; set; }
        public Star Star { get; set; }

        [Display(Name = "Star")]
        public Star StarName { get; set; }



        public int CastId { get; set; }
        [Display(Name = "Cast")]
        public Caste CastName { get; set; }

        [Display(Name = "Lagna")]
        public Lagna Lagna { get; set; }

        [Display(Name = "Qualification")]
        public Qualification Qualification { get; set; }

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
        public Country Country { get; set; }

        [Display(Name = "Phone Number(Home)")]
        public string HomePhone { get; set; }
        [Display(Name = "Phone Number(Mobile)")]
        public string MobileNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Expectation")]
        public Expectation Expectation { get; set; }





        public List<ClientDetail> ClientList { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }


        public List<ClientDetail> CoupleList { get; set; }
        //public IEnumerable<ClientDetail> CoupleList { get; set; }



        public string PhotoType { get; set; }
       // public string HomePhone { get; set; }


    }
}