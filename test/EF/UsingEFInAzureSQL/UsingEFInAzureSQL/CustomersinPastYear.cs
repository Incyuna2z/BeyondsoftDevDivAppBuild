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
    
    public partial class CustomersinPastYear
    {
        public int COntactID { get; set; }
        public Nullable<int> PrimaryDesintation { get; set; }
        public int CustomerTypeID { get; set; }
        public Nullable<System.DateTime> InitialDate { get; set; }
        public Nullable<int> SecondaryDestination { get; set; }
        public Nullable<int> PrimaryActivity { get; set; }
        public Nullable<int> SecondaryActivity { get; set; }
        public string Notes { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public System.DateTime AddDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
