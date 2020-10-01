using res_pos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.VM;

namespace res_pos.Interfaces
{
    interface IInvoice
    {
        string saveDirectSellStock(db_inv_direct_sell_stock directSellStock);

        string saveRawStock(db_inv_raw_stock rawStockEntity);

        int saveStockInv(db_stk_invoice stockEntity);


        List<db_stk_invoice> getAllRecodes();

        List<db_stk_invoice> getRecodeByStockIdAndDate(int supId, string date);

        List<db_stk_invoice> getInvoiceById(int id);

        List<db_inv_raw_stock> getRawStockByInvId(int id);

        List<db_inv_direct_sell_stock> getDirectSellStockByInvId(int id);

        List<ViewStockVM> getStockGridFillDataByInvId(int invId);



    }
}
