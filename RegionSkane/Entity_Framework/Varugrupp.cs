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
    
    public partial class Varugrupp
    {
        public Varugrupp()
        {
            this.Artikelgrupp = new HashSet<Artikelgrupp>();
        }
    
        public string C20Huvudgrupp { get; set; }
        public string C21Varugrupp { get; set; }
        public string namn { get; set; }
    
        public virtual ICollection<Artikelgrupp> Artikelgrupp { get; set; }
        public virtual Huvudgrupp Huvudgrupp { get; set; }
    }
}
