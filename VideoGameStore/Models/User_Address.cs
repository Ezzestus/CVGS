//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoGameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Address
    {
        public int user_id { get; set; }
        public int address_id { get; set; }
        public string address_name { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
    }
}
