//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace res_pos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class db_stk_invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public db_stk_invoice()
        {
            this.db_inv_direct_sell_stock = new HashSet<db_inv_direct_sell_stock>();
            this.db_inv_raw_stock = new HashSet<db_inv_raw_stock>();
        }
    
        public int Id { get; set; }
        public string invoice_no { get; set; }
        public Nullable<int> stk_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<db_inv_direct_sell_stock> db_inv_direct_sell_stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<db_inv_raw_stock> db_inv_raw_stock { get; set; }
        public virtual db_stock db_stock { get; set; }
    }
}
