using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBilling.Interfaces
{
    interface IPrice
    {
        double getSellingPriceByProId(int proId);
    }
}
