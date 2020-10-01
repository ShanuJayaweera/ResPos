using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;


namespace res_pos.Interfaces
{
    interface IStock
    {
        string saveDirectSellStock(db_real_time_direct_sell_stock directSellStock);

        string saveRawStock(db_real_time_raw_stock rawStockEntity);

        int saveStock(db_stock stockEntity);

        string tempDataSavingProcess();

        List<db_stock> getAllRecodes();

        DataTable getItemById();

        double getCurrentProQty(int? proId, string table);

        List<db_stock> getRecodeBySupplier(int supId);

        List<db_stock> getRecodeByDate(string date);

        List<db_stock> getRecodeByDateAndSupplier(int supId, string date);
    }
}
