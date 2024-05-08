//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Hint_Questions = new HashSet<Hint_Questions>();
            this.Orders = new HashSet<Order>();
        }
    
        public decimal Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Email { get; set; }
        public System.DateTime Date_Of_Birth { get; set; }
        public string Address { get; set; }
        public Nullable<double> Balance { get; set; }
        public Nullable<decimal> Mobile_Number { get; set; }
        public string Status { get; set; }
        public string Hint_Question { get; set; }
        public string Hint_Answer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hint_Questions> Hint_Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}