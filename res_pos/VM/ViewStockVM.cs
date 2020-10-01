using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace res_pos.VM
{
    class ViewStockVM
    {
        public int invId { get; set; }
        public int stkId { get; set; }
        public string productName { get; set; }
        public string qty { get; set; }
        public string buyingPrice { get; set; }
        public string sellingPrice { get; set; }
        public string discount { get; set; }
    }
}
