//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MalMaalayak
{
    using System;
    using System.Collections.Generic;
    
    public partial class BirthDetail
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string BirthPlace { get; set; }
        public string BirthTime { get; set; }
        public string FartherPlace { get; set; }
        public string MotherPlace { get; set; }
        public Nullable<int> ClientId { get; set; }
    
        public virtual ClientDetail ClientDetail { get; set; }
    }
}
