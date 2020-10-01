using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface IProductCategory
    {
        string insertProductCategory(db_pro_category categoryEntity);

        string updateProductCategory(db_pro_category categoryEntity);

        List<db_pro_category> getAllRecodes();

        List<db_pro_category> getRecodeById(int id);

        string deleteRecode(int id);
    }
}
