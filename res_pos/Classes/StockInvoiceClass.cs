using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Model;
using res_pos.Classes;
using res_pos.VM;

namespace res_pos.Classes
{
    class StockInvoiceClass : IInvoice
    {
        PosDBEntities model;

        public List<db_stk_invoice> getAllRecodes()
        {
            model = new PosDBEntities();
            return model.db_stk_invoice.ToList();
        }

        public List<db_inv_direct_sell_stock> getDirectSellStockByInvId(int Invid)
        {
            model = new PosDBEntities();
            return model.db_inv_direct_sell_stock.Where(l => l.inv_id == Invid).ToList();
        }

        public List<db_stk_invoice> getInvoiceById(int id)
        {
            model = new PosDBEntities();
            return model.db_stk_invoice.Where(l => l.Id == id).ToList();
        }

        public List<db_inv_raw_stock> getRawStockByInvId(int invId)
        {
            model = new PosDBEntities();
            var data = model.db_inv_raw_stock.Where(l => l.inv_id == invId).ToList();
            return data;
        }



        public List<db_stk_invoice> getRecodeByStockIdAndDate(int supId, string date)
        {
            model = new PosDBEntities();
            var data = model.db_stk_invoice.Where(l => l.db_stock.sup_id == supId || l.db_stock.created_date.Contains(date)).ToList();

            return data;
        }

        public List<ViewStockVM> getStockGridFillDataByInvId(int invId)
        {
            List<db_inv_raw_stock> rd = getRawStockByInvId(invId);
            List<db_inv_direct_sell_stock> ds = getDirectSellStockByInvId(invId);
            List<ViewStockVM> list = new List<ViewStockVM>();
            ViewStockVM vsvm = new ViewStockVM();
            PriceClass pc = new PriceClass();

            if (rd.Count > 0)
            {
                foreach (var item in rd)
                {
                    vsvm.invId = int.Parse(item.inv_id.ToString());
                    vsvm.productName = item.db_product.pro_name;
                    vsvm.stkId = int.Parse(item.db_stk_invoice.stk_id.ToString());

                    foreach (var price in pc.getPriceByProId(int.Parse(item.pro_id.ToString())))
                    {
                        vsvm.sellingPrice = price.selling_price.ToString();
                        vsvm.buyingPrice = price.buying_price.ToString();
                        vsvm.discount = price.discount.ToString();
                    }
                    vsvm.qty = (item.qty.ToString() + item.unit.ToString());
                    list.Add(vsvm);
                }
            }

            if (ds.Count > 0)
            {
                foreach (var item in ds)
                {
                    vsvm.invId = int.Parse(item.inv_id.ToString());
                    vsvm.productName = item.db_product.pro_name;
                    vsvm.stkId = int.Parse(item.db_stk_invoice.stk_id.ToString());
                    foreach (var price in pc.getPriceByProId(int.Parse(item.pro_id.ToString())))
                    {
                        vsvm.sellingPrice = price.selling_price.ToString();
                        vsvm.buyingPrice = price.buying_price.ToString();
                        vsvm.discount = price.discount.ToString();
                    }
                    vsvm.qty = (item.qty.ToString());
                    list.Add(vsvm);
                }
            }
            return list;
        }

        public string saveDirectSellStock(db_inv_direct_sell_stock directSellStock)
        {
            try
            {
                model = new PosDBEntities();
                model.db_inv_direct_sell_stock.Add(directSellStock);
                model.SaveChanges();
                return "done";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string saveRawStock(db_inv_raw_stock rawStockEntity)
        {
            try
            {
                model = new PosDBEntities();
                model.db_inv_raw_stock.Add(rawStockEntity);
                model.SaveChanges();
                return "done";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public int saveStockInv(db_stk_invoice stockEntity)
        {
            try
            {
                model = new PosDBEntities();
                model.db_stk_invoice.Add(stockEntity);
                model.SaveChanges();
                return stockEntity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
