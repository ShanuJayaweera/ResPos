using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class ProductClass : IProduct
    {
        PosDBEntitiesBill model;
        public List<db_product> getProductByCatId(int catId)
        {
            model = new PosDBEntitiesBill();
            var data = model.db_product.Where(l => l.pro_cat_id == catId).ToList();
            return data;
        }

        public List<db_product> getProductByCatIdAndName(string proName, int catId)
        {
            model = new PosDBEntitiesBill();
            var data = model.db_product.Where(l => l.pro_cat_id == catId && l.pro_name == proName).ToList();
            return data;
        }
    }
}
