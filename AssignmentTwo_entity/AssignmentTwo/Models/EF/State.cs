//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssignmentTwo.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int FirstZipCode { get; set; }
        public int LastZipCode { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
