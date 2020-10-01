using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Model;

namespace ResBilling.Interfaces
{
    interface ITicket
    {
        Boolean isTicketHold(string tableName);

        int getTicketIdByTable(string tableName);

        string updateTotalWhenAddProduct(int proId, double qty, int ticketId);

        double getCurrentTotal(int ticketId);

        int createNewTicket(bill_ticket tkt);

        List<bill_ticket> holdTickets();

        List<bill_ticket> holdTicketData(int ticketId);

        string updateCustomer(int cusId, int ticketId);
        string updateSteward(int stewardId, int ticketId);
    }
}
