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
        //[Required(ErrorMessage = "Title field is required"), Display(Name = "Title")]


        public int Id { get; set; }

        [Required(ErrorMessage = "NIC is required"), Display(Name = "NIC No")]
        public string NIC { get; set; }

        [Required(ErrorMessage = "First Name field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Title field is required"), Display(Name = "Gender")]
       // public string GenderType { get; set; }
        public ConstantDetail.Gender GenderType { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Religion")]
       // public string Religion { get; set; }
        public ConstantDetail.Religion Religion { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Job")]
        public string Job { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Height")]
        public string Height { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Star")]
        //public string StarName { get; set; }
        public ConstantDetail.Star StarName { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Caste")]
       // public string CasteName { get; set; }
        public ConstantDetail.Caste CasteName { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Lagna")]
        //public string Lagna { get; set; }
        public ConstantDetail.Lagna Lagna { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Qualification")]
        //public string Qualification { get; set; }
        public ConstantDetail.Qualification Qualification { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Birth Of Date")]
        public DateTime BirthOfDate { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Birth Place")]
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

        [Required(ErrorMessage = "This field is required"), Display(Name = "Country")]
        //public string Country { get; set; }
        public ConstantDetail.Country Country { get; set; }

        [Display(Name = "Phone Number(Home)")]
        public int ? HomePhone { get; set; }

        [Required(ErrorMessage = "This field is required"), Display(Name = "Phone Number(Mobile)")]
        public int ? MobileNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Expectation")]
        //public string Expectation { get; set; }
        public ConstantDetail.Expectation Expectation { get; set; }

        public byte[] LagnaChart { get; set; }
        public byte[] NavamsaChart { get; set; }




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