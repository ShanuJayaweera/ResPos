using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Model;

namespace ResBilling.Interfaces
{
    interface ICustomer
    {
        List<db_customer> getAllRecodes();

    }
}
