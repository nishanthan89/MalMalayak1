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
    
    public partial class JothidaDetail
    {
        public int Id { get; set; }
        public string NIC { get; set; }
        public string Lagna { get; set; }
        public string Star { get; set; }
        public string Paavam { get; set; }
        public byte[] LagnaChart { get; set; }
        public byte[] NavamsaChart { get; set; }
    
        public virtual ClientDetail ClientDetail { get; set; }
    }
}