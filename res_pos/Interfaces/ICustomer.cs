using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface ICustomer
    {
        List<db_cus_type> getAllCustomerTypeRecodes();

        List<db_customer> getAllCustomerRecodes();

        List<db_customer> getCustomerRecodeById(int id);

        string cusUpdateProcess(db_customer cus);
        string cusSaveProcess(db_customer cus);
    }
}
