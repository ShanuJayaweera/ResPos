using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface IPrice
    {

        string saveProcess(db_price priceEntity);

        List<db_price> getAllRecodes();

        List<db_price> getRecodeById(int id);

        List<db_price> getPriceByProId(int proId);

    }
}
