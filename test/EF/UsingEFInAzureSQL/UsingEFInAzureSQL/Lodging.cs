//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsingEFInAzureSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lodging
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lodging()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int LodgingID { get; set; }
        public string LodgingName { get; set; }
        public int ContactID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public bool Resort { get; set; }
        public string ResortChainOwner { get; set; }
        public bool LuxuryResort { get; set; }
    
        public virtual Contact Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
        public virtual Location Location { get; set; }
    }
}
