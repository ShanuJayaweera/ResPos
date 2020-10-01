using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Model;

namespace res_pos.Classes
{
    internal class ProductCategoryClass : IProductCategory

    {
        PosDBEntities model;

        public string deleteRecode(int id)
        {
            model = new PosDBEntities();
            if (model.db_pro_category.Any(l => l.Id ==id))
            {
                var deleteRecode = (from proCat in model.db_pro_category where proCat.Id == id select proCat).First();
                model.db_pro_category.Remove(deleteRecode);
                model.SaveChanges();
                return "done";
            }
            else
            {
                return "not_exist";
            }

        }

        // get all recodes from category table
        public List<db_pro_category> getAllRecodes()
        {
            model = new PosDBEntities();
            var result = model.db_pro_category.ToList();
            return result;

        }


        public List<db_pro_category> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.db_pro_category.Where(l => l.Id == id).ToList();
            return result;
        }


        public string insertProductCategory(db_pro_category cat)
        {
            model = new PosDBEntities();

            if (model.db_pro_category.Any(l => l.cat_name == cat.cat_name))
            {
                return "exist";
            }
            else
            {
                model.db_pro_category.Add(cat);
                model.SaveChanges();
                return "done";
            }
        }

        public string updateProductCategory(db_pro_category cat)
        {
            model = new PosDBEntities();

            if (model.db_pro_category.Any(l => l.Id == cat.Id))
            {
                if (model.db_pro_category.Any(l => l.cat_name == cat.cat_name))
                {
                    return "exist";
                }
                else
                {
                    var result = model.db_pro_category.SingleOrDefault(l => l.Id == cat.Id);
                    if (result != null)
                    {
                        result.cat_name = cat.cat_name;
                        result.created_date = cat.created_date;
                        result.created_by = cat.created_by;
                        model.SaveChanges();
                        return "done";
                    }
                    else
                    {
                        return "not_exist";
                    }
                }
                
            }
            else
            {
                return "not_exist";
            }
        }

        
    }
}
