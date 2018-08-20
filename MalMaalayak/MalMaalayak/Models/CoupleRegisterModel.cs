using MalMaalayak.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MalMaalayak.Models
{
    public class CoupleRegisterModel
    {
        [Display(Name = "NIC No")]
        public string NIC { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
       // public string GenderType { get; set; }
        public ConstantDetail.Gender GenderType { get; set; }

        [Display(Name = "Religion")]
       // public string Religion { get; set; }
        public ConstantDetail.Religion Religion { get; set; }

        [Display(Name = "Job")]
        public string Job { get; set; }

        [Display(Name = "Height")]
        public string Height { get; set; }

        [Display(Name = "Star")]
        //public string StarName { get; set; }
        public ConstantDetail.Star StarName { get; set; }

        [Display(Name = "Caste")]
       // public string CasteName { get; set; }
        public ConstantDetail.Caste CasteName { get; set; }

        [Display(Name = "Lagna")]
        //public string Lagna { get; set; }
        public ConstantDetail.Lagna Lagna { get; set; }

        [Display(Name = "Qualification")]
        //public string Qualification { get; set; }
        public ConstantDetail.Qualification Qualification { get; set; }

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
        //public string Country { get; set; }
        public ConstantDetail.Country Country { get; set; }

        [Display(Name = "Phone Number(Home)")]
        public string HomePhone { get; set; }

        [Display(Name = "Phone Number(Mobile)")]
        public string MobileNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Expectation")]
        //public string Expectation { get; set; }
        public ConstantDetail.Expectation Expectation { get; set; }



        //public int GenderId { get; set; }
        //public int CastId { get; set; }
        //public int StarId { get; set; }

        //public enum Gender
        //{
        //    Male = 1,
        //    FeMale = 2,
        //    Alli = 3
        //}

       // public ConstantDetail.Gender GenderList { get; set; }
       // public ConstantDetail.Religion ReligionList { get; set; }
        //public ConstantDetail.Caste CasteList { get; set; }
        //public ConstantDetail.Star StarList { get; set; }
        //public ConstantDetail.Lagna LagnaList { get; set; }
        //public ConstantDetail.Qualification QualificationList { get; set; }
        //public ConstantDetail.Country CountryList { get; set; }
        //public ConstantDetail.Expectation ExpectationList { get; set; }




    }

}