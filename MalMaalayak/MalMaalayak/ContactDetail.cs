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
    
    public partial class ContactDetail
    {
        public int Id { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Residence { get; set; }
        public Nullable<int> PhoneHome { get; set; }
        public Nullable<int> PhoneMobile { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    
        public virtual ClientDetail ClientDetail { get; set; }
    }
}