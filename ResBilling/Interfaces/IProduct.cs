using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Model;

namespace ResBilling.Interfaces
{
    interface IProduct
    {

        List<db_product> getProductByCatId(int catId);

        List<db_product> getProductByCatIdAndName(string proName, int catId);
    }
}
