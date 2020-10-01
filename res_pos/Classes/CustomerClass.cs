using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Model;

namespace res_pos.Classes
{
    class CustomerClass : ICustomer
    {
        PosDBEntities model;

        public List<db_cus_type> getAllCustomerTypeRecodes()
        {
            model = new PosDBEntities();
            var data = model.db_cus_type.ToList();
            return data;
        }

        public List<db_customer> getAllCustomerRecodes()
        {
            model = new PosDBEntities();
            var data = model.db_customer.ToList();
            return data;
        }

        public List<db_customer> getCustomerRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.db_customer.Where(l => l.Id == id).ToList();
            return result;
        }

        public string cusUpdateProcess(db_customer cus)
        {
            model = new PosDBEntities();

            if (model.db_customer.Any(l => l.nic == cus.nic))
            {
                var result = model.db_customer.SingleOrDefault(l => l.Id == cus.Id);
                if (result != null)
                {
                    result.name = cus.name;
                    result.address = cus.address;
                    result.telephone = cus.telephone;
                    result.mobile = cus.mobile;
                    result.cusType = cus.cusType;
                    result.createdBy = cus.createdBy;
                    result.createdDate = cus.createdDate;
                    
                    result.email = cus.email;
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
                return "not_exist";
            }
        }

        public string cusSaveProcess(db_customer cus)
        {
            model = new PosDBEntities();
            if (model.db_customer.Any(l => l.nic == cus.nic))
            {
                return "exist";
            }
            else
            {
                try
                {
                    model.db_customer.Add(cus);
                    model.SaveChanges();
                    return "done";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }
    }
}
