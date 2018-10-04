using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MalMaalayak.Models.ViewModel
{
    public class UpdateModel
    {

        public List<ClientViewModel> ClientDataList { get; set; }
        public List<BirthDetailViewModel> BirthDataList { get; set; }
        public List<ContactViewModel> ContactDataList { get; set; }
        public List<JothidaViewModel> JothidaDataList { get; set; }


    }
}