//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegionSkane.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Handläggare
    {
        public Handläggare()
        {
            this.Avtal = new HashSet<Avtal>();
        }
    
        public string Id { get; set; }
        public string Namn { get; set; }
        public string TelefonNr { get; set; }
        public string Mail { get; set; }
    
        public virtual ICollection<Avtal> Avtal { get; set; }
    }
}
