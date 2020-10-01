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
    class StockClass : IStock
    {
        PosDBEntities model;
        public List<db_stock> getAllRecodes()
        {
            model = new PosDBEntities();
            var data = model.db_stock.ToList();
            return data;
            
        }

        public DataTable getItemById()
        {
            throw new NotImplementedException();
        }

        public string saveDirectSellStock(db_real_time_direct_sell_stock dss)
        {
            model = new PosDBEntities();
            if (model.db_real_time_direct_sell_stock.Any(l => l.pro_id == dss.pro_id))
            {
                // get current qty
                double qty = getCurrentProQty(dss.pro_id, "direct");
                // add current qty
                qty = double.Parse(dss.qty.ToString()) + qty;

                var result = model.db_real_time_direct_sell_stock.SingleOrDefault(b => b.pro_id == dss.pro_id);
                if (result != null)
                {
                    result.qty = float.Parse(qty.ToString());
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
                
                model.db_real_time_direct_sell_stock.Add(dss);
                model.SaveChanges();
                return "done";
            }
            
        }

        public string saveRawStock(db_real_time_raw_stock rs)
        {
            model = new PosDBEntities();
            if (model.db_real_time_raw_stock.Any(l => l.pro_id == rs.pro_id))
            {
                // get current qty
                double qty = getCurrentProQty(rs.pro_id, "raw");
                // add current qty
                qty = double.Parse(rs.qty.ToString()) + qty;

                var result = model.db_real_time_raw_stock.SingleOrDefault(b => b.pro_id == rs.pro_id);
                if (result != null)
                {
                    result.qty = float.Parse(qty.ToString());
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
                model.db_real_time_raw_stock.Add(rs);
                model.SaveChanges();
                return "done";
            }
            
        }

        public string tempDataSavingProcess()
        {
            throw new NotImplementedException();
        }

        public int saveStock(db_stock se)
        {
            model = new PosDBEntities();
            model.db_stock.Add(se);
            model.SaveChanges();
            return se.id;
        }

        public double getCurrentProQty(int? proId, string table)
        {
            model = new PosDBEntities();
            double quentity = 0.0;
            if (table.Equals("direct"))
            {
                var rQty = model.db_real_time_direct_sell_stock.Where(l => l.pro_id == proId).ToList();
                foreach (var item in rQty)
                {
                    quentity = double.Parse(item.qty.ToString());
                }
                return quentity;
            }
            else if (table.Equals("raw"))
            {
                var rQty = model.db_real_time_raw_stock.Where(l => l.pro_id == proId).ToList();
                foreach (var item in rQty)
                {
                    quentity = double.Parse(item.qty.ToString());
                }
                return quentity;
            }
            else
            {
                return 0.00;
            }
        }

        public List<db_stock> getRecodeBySupplier(int supId)
        {
            model = new PosDBEntities();
            var result = model.db_stock.Where(l => l.sup_id == supId).ToList();
            return result;
        }

        public List<db_stock> getRecodeByDate(string date)
        {
            model = new PosDBEntities();
            var result = model.db_stock.Where(l => l.created_date.Contains(date)).ToList();
            return result;
        }

        public List<db_stock> getRecodeByDateAndSupplier(int supId, string date)
        {
            model = new PosDBEntities();
            var result = model.db_stock.Where(l => l.created_date.Contains(date) || l.sup_id == supId).ToList();
            return result;
        }
    }
}
