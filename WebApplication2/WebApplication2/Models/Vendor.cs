//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            this.Products = new HashSet<Product>();
        }
    
        public decimal Vendor_Id { get; set; }
        public string Vendor_Name { get; set; }
        public string Vendor_Email { get; set; }
        public decimal Mobile_Number { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public int Vendor_Age { get; set; }
        public string Passowrd { get; set; }
        public Nullable<int> Hint_Id { get; set; }
        public string Hint_Answer { get; set; }
        public string Status { get; set; }
    
        public virtual Hint Hint { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
