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
    
    public partial class Artikelgrupp
    {
        public Artikelgrupp()
        {
            this.Artikel = new HashSet<Artikel>();
        }
    
        public string C22Artikelgrupp { get; set; }
        public string ArtikelgruppsNamn { get; set; }
        public string C21Varugrupp { get; set; }
    
        public virtual ICollection<Artikel> Artikel { get; set; }
        public virtual Varugrupp Varugrupp { get; set; }
    }
}
