using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MalMaalayak.ViewModel
{
    public class CoupleRegisterViewModel
    {
   
        public string NIC { get; set; }

    
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string GenderType { get; set; }


        public string Religion { get; set; }

        
        public string Job { get; set; }


        public string Height { get; set; }


        public string StarName { get; set; }

     
        public string CasteName { get; set; }

   
        public string Lagna { get; set; }

      
        public string Qualification { get; set; }


        public string BirthOfDate { get; set; }


        public string BirthPlace { get; set; }


        public string BirthTime { get; set; }


        public string Paavam { get; set; }


        public string FartherPlace { get; set; }


        public string MotherPlace { get; set; }


        public string Address { get; set; }


        public string Residence { get; set; }


        public string Country { get; set; }


        public string HomePhone { get; set; }

    
        public string MobileNo { get; set; }


        public string Email { get; set; }

        public string Expectation { get; set; }


        public int GenderId { get; set; }
        public int CastId { get; set; }
        public int StarId { get; set; }

        //public enum Gender
        //{
        //    Male = 1,
        //    FeMale = 2,
        //    Alli = 3
        //}

        //public ConstantDetail.Gender GenderList { get; set; }
        //public ConstantDetail.Religion ReligionList { get; set; }
        //public ConstantDetail.Caste CasteList { get; set; }
        //public ConstantDetail.Star StarList { get; set; }
        //public ConstantDetail.Lagna LagnaList { get; set; }
        //public ConstantDetail.Qualification QualificationList { get; set; }
        //public ConstantDetail.Country CountryList { get; set; }
        //public ConstantDetail.Expectation ExpectationList { get; set; }




    }
}