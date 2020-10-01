using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class TicketClass : ITicket
    {
        PosDBEntitiesBill model;

        public int createNewTicket(bill_ticket tkt)
        {
            model = new PosDBEntitiesBill();
            try
            {
                if (model.bill_ticket.Any(l => l.tbl_id == tkt.tbl_id && l.is_hold == 1))
                {
                    return -1;
                }
                else
                {
                    model.bill_ticket.Add(tkt);
                    model.SaveChanges();
                    return tkt.Id;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double getCurrentTotal(int ticketId)
        {
            model = new PosDBEntitiesBill();
            return double.Parse(model.bill_ticket.Where(l => l.Id == ticketId).FirstOrDefault().total.ToString());
        }

        public int getTicketIdByTable(string tableName)
        {
            int ticketId = 0;
            model = new PosDBEntitiesBill();
            var data = model.bill_ticket.Where(l => l.is_hold == 1 && l.my_tables.table_name == tableName).ToList();
            foreach (var item in data)
            {
                ticketId = item.Id;
            }
            return ticketId;
        }

        public List<bill_ticket> holdTicketData(int ticketId)
        {
            model = new PosDBEntitiesBill();
            var data = model.bill_ticket.Where(l => l.is_hold == 1 && l.Id == ticketId).ToList();
            return data;
        }

        public List<bill_ticket> holdTickets()
        {
            model = new PosDBEntitiesBill();
            var data = model.bill_ticket.Where(l => l.is_hold == 1).ToList();
            return data;
        }

        public bool isTicketHold(string tableName)
        {
            model = new PosDBEntitiesBill();
            bool respond = false;
            var data = model.bill_ticket.Where(l => l.my_tables.table_name == tableName).ToList();
            foreach (var item in data)
            {
                if (item.is_hold == 1)
                {
                    respond = true;
                    break;
                }
                
            }
            return respond;

        }

        public string updateCustomer(int cusId , int ticketId)
        {
            model = new PosDBEntitiesBill();
            try
            {
                var result = model.bill_ticket.SingleOrDefault(l => l.Id == ticketId);
                if (result != null)
                {
                    result.cus_id = cusId;
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

        public string updateSteward(int stewardId, int ticketId)
        {
            model = new PosDBEntitiesBill();

            try
            {
                var result = model.bill_ticket.SingleOrDefault(l => l.Id == ticketId);
                if (result != null)
                {
                    result.stewardId = stewardId;
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

        public string updateTotalWhenAddProduct(int proId , double qty, int ticketId)
        {
            model = new PosDBEntitiesBill();

            var priceData = model.db_price.Where(l => l.pro_id == proId).FirstOrDefault();

            double sellingPrice = double.Parse(priceData.selling_price.ToString());
            double proDiscount = double.Parse(priceData.discount.ToString());
            double reminder = (sellingPrice * qty) - ((sellingPrice * qty) * (proDiscount / 100)); // Reminder for rest items
            double oldTotal = getCurrentTotal(ticketId); // get current saved total
            double newTotal = oldTotal + reminder;

            // update total
            try
            {
                var result = model.bill_ticket.SingleOrDefault(b => b.Id == ticketId);
                if (result != null)
                {
                    result.total = newTotal;
                    model.SaveChanges();
                    return newTotal.ToString();

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
    }
}
