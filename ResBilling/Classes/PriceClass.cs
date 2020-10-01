using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class PriceClass : IPrice
    {
        PosDBEntitiesBill model;

        public double getSellingPriceByProId(int proId)
        {
            model = new PosDBEntitiesBill();
            return double.Parse(model.db_price.Where(l => l.pro_id == proId).FirstOrDefault().selling_price.ToString());
        }
    }
}
