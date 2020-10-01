using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class CustomerClass : ICustomer
    {
        PosDBEntitiesBill model;
        public List<db_customer> getAllRecodes()
        {
            model = new PosDBEntitiesBill();
            return model.db_customer.ToList();
        }
    }
}
