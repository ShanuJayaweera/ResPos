using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;
using ResBilling.VM;

namespace ResBilling.Classes
{
    class TempBillClass : ITempBill
    {
        PosDBEntitiesBill model;

        public double getCurrentQTY(int proId, int ticketId)
        {
            var dt = model.bill_temp_bill.Where(x => x.proId == proId && x.ticketId == ticketId).Single();
            double qty = double.Parse(dt.qty.ToString());
            return qty;
        }

        public List<BillingProDataVM> getTempBillPro(int ticketId)
        {
            model = new PosDBEntitiesBill();
            BillingProDataVM bvm;
            List<BillingProDataVM> list = new List<BillingProDataVM>();

            var data = model.bill_temp_bill.Where(l => l.ticketId == ticketId).ToList();
            foreach (var item in data)
            {
                bvm = new BillingProDataVM();
                bvm.proId = int.Parse(item.proId.ToString());
                bvm.proCode = item.db_product.pro_code;
                bvm.proName = item.db_product.pro_name;
                bvm.qty = double.Parse(item.qty.ToString());

                // get product selling price
                var price = model.db_price.Where(l => l.pro_id == item.proId).FirstOrDefault();
                bvm.sellingPrice = double.Parse(price.selling_price.ToString());
                bvm.discount = double.Parse(price.discount.ToString());
                list.Add(bvm);
            }
            return list;

        }

        public bool recodeExist(int? proId, int? ticketId)
        {
            model = new PosDBEntitiesBill();
            if (model.bill_temp_bill.Any(l => l.ticketId == ticketId && l.proId == proId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string saveTempBillProcess(bill_temp_bill temp)
        {
            model = new PosDBEntitiesBill();
            try
            {
                if (recodeExist(temp.proId, temp.ticketId))
                {
                    string respond = updateQTY(temp.proId, temp.ticketId,  temp.qty);
                    return respond;

                }
                else
                {
                    model.bill_temp_bill.Add(temp);
                    model.SaveChanges();
                    return "done";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        public List<bill_temp_bill> tempDataByTicketId(int ticketId)
        {
            model = new PosDBEntitiesBill();
            var data = model.bill_temp_bill.Where(l => l.ticketId == ticketId).ToList();
            return data;
        }

        public string updateQTY(int? proId, int? ticketId, double? qty)
        {
            model = new PosDBEntitiesBill();
            try
            {
                var result = model.bill_temp_bill.SingleOrDefault(x => x.proId == proId && x.ticketId == ticketId);

                if (result != null)
                {
                    result.qty = qty;
                    model.SaveChanges();
                    return "done";
                }
                else
                {
                    return "not_exist";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        public BillingProDataVM getItemByTempTicket(int proId, int ticketId)
        {
            model = new PosDBEntitiesBill();
            try
            {
                BillingProDataVM bvm = new BillingProDataVM();
                var data = model.bill_temp_bill.Where(l => l.ticketId == ticketId && l.proId == proId).ToList();

                foreach (var item in data)
                {
                    bvm.proId = int.Parse(item.proId.ToString());
                    bvm.proCode = item.db_product.pro_code;
                    bvm.proName = item.db_product.pro_name;
                    bvm.qty = double.Parse(item.qty.ToString());

                    // get product selling price
                    var price = model.db_price.Where(l => l.pro_id == item.proId).FirstOrDefault();
                    bvm.sellingPrice = double.Parse(price.selling_price.ToString());
                    bvm.discount = double.Parse(price.discount.ToString());
                }
                return bvm;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
