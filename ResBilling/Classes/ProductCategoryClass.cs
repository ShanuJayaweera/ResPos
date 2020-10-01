using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    internal class ProductCategoryClass : IProductCat 

    {
        PosDBEntitiesBill model;

        

        // get all recodes from category table
        public List<db_pro_category> getAllRecodes()
        {
            model = new PosDBEntitiesBill();
            var result = model.db_pro_category.ToList();
            return result;

        }

        public int getCatIdByName(string catName)
        {
            model = new PosDBEntitiesBill();
            var result = model.db_pro_category.Where(l => l.cat_name == catName).FirstOrDefault();
            return result.Id;
        }

        public List<db_pro_category> getRecodeById(int id)
        {
            model = new PosDBEntitiesBill();
            var result = model.db_pro_category.Where(l => l.Id == id).ToList();
            return result;
        }


        
    }
}
