using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResBilling.VM
{
    class BillingProDataVM
    {
        public int proId { get; set; }
        public string proCode { get; set; }
        public string proName { get; set; }
        public double sellingPrice { get; set; }
        public double qty { get; set; }
        public double discount { get; set; }
    }
}
