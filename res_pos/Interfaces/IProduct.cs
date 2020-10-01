using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface IProduct
    {
        int insertProduct(db_product productEntity);

        string updateProduct(db_product productEntity);

        List<db_product> getAllRecodes();

        List<db_product> getRecodeById(int id);

        List<db_product> getRecodeByProCode(string code);
        List<db_product> searchRecodeByProCode(string code);

        string getProCodeById(int id);

        List<db_product> getProductByStockCat(int stockCat);



    }
}
