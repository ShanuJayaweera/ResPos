//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResBilling.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class db_supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public db_supplier()
        {
            this.db_stock = new HashSet<db_stock>();
        }
    
        public int Id { get; set; }
        public string sup_name { get; set; }
        public string sup_email { get; set; }
        public string sup_address { get; set; }
        public string sup_mobile { get; set; }
        public string sup_telephone { get; set; }
        public Nullable<int> created_dy { get; set; }
        public string created_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<db_stock> db_stock { get; set; }
    }
}