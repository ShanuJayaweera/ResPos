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
    
    public partial class db_real_time_direct_sell_stock
    {
        public int Id { get; set; }
        public Nullable<int> pro_id { get; set; }
        public Nullable<double> qty { get; set; }
    
        public virtual db_product db_product { get; set; }
    }
}
