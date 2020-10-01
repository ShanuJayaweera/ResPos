using ResBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.VM;

namespace ResBilling.Interfaces
{
    interface ITempBill
    {
        Boolean recodeExist(int? proId ,int? ticketId);

        double getCurrentQTY(int proId, int ticketId);

        string updateQTY(int? proId, int? ticketId,  double? qty);

        List<BillingProDataVM> getTempBillPro(int ticketId);

        string saveTempBillProcess(bill_temp_bill temp);

        List<bill_temp_bill> tempDataByTicketId(int ticketId);

        BillingProDataVM getItemByTempTicket(int proId, int ticketId);



    }
}
