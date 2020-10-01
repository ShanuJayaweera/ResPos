using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Classes
{
    class StockCategoryClass
    {
        PosDBEntities model;
        public List<db_stock_cat> getAllRecodes()
        {
            model = new PosDBEntities();
            var list = model.db_stock_cat.ToList();
            return list;
        }
    }
}
