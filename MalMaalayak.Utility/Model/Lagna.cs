using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MalMaalayak.Utility.Model
{
    public class Lagna
    {
        public int LagnaId { get; set; }

        [Required(ErrorMessage = "Title field is required"), Display(Name = "LagnaType")]
        public string LagnaType { get; set; }
    }
}