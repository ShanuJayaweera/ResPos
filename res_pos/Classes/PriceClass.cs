using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;
using res_pos.Interfaces;

namespace res_pos.Classes
{
    class PriceClass : IPrice
    {
        PosDBEntities model;

        public List<db_price> getAllRecodes()
        {
            model = new PosDBEntities();
            var data = model.db_price.ToList();
            return data;
        }

        public List<db_price> getPriceByProId(int proId)
        {
            model = new PosDBEntities();
            List<db_price> list = model.db_price.Where(l => l.pro_id == proId).ToList();
            return list;
        }

        public List<db_price> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var data = model.db_price.Where(l => l.Id == id).ToList();
            return data;
        }


        // this method is containing insert and update process
        public string saveProcess(db_price priceEntity)
        {
            model = new PosDBEntities();
            if (model.db_product.Any(l => l.Id== priceEntity.pro_id))
            {
                if (model.db_price.Any(l => l.pro_id == priceEntity.pro_id))
                {
                    // update process
                    var result = model.db_price.SingleOrDefault(l => l.pro_id == priceEntity.pro_id);
                    if (result != null)
                    {
                        result.buying_price = priceEntity.buying_price;
                        result.selling_price = priceEntity.selling_price;
                        model.SaveChanges();
                        return "done";
                    }
                    else
                    {
                        return "not_exist";
                    }
                }
                else
                {
                    // insert process
                    model.db_price.Add(priceEntity);
                    model.SaveChanges();
                    return "done";
                }
            }
            else
            {
                return "not_exist";
            }
        }
    }
}
