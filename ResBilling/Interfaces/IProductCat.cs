using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Model;

namespace ResBilling.Interfaces
{
    interface IProductCat
    {
        List<db_pro_category> getAllRecodes();
        List<db_pro_category> getRecodeById(int catId);

        int getCatIdByName(string catName);

    }
}
