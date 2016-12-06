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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Invoice_Address = new HashSet<Invoice_Address>();
            this.Line_Item = new HashSet<Line_Item>();
        }
    
        public int invoice_id { get; set; }
        public int user_id { get; set; }
        public int credit_card_id { get; set; }
        public System.DateTime invoice_date { get; set; }
        public Nullable<System.DateTime> ship_date { get; set; }
        public bool is_invoice_closed { get; set; }
    
        public virtual Credit_Card Credit_Card { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Address> Invoice_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Line_Item> Line_Item { get; set; }
        public virtual User User { get; set; }
    }
}
