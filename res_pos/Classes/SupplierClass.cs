using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;
using res_pos.Interfaces;

namespace res_pos.Classes
{
    class SupplierClass : ISupplier
    {
        PosDBEntities model;

        public List<db_supplier> getAllRecodes()
        {
            model = new PosDBEntities();
            List<db_supplier> list = new List<db_supplier>();
            list =   model.db_supplier.ToList();
            return list;
        }

        public List<db_supplier> getRecodeById(int id)
        {
            model = new PosDBEntities();
            List<db_supplier> list = model.db_supplier.Where(l => l.Id == id).ToList();
            return list;
        }


        public string insertSupplier(db_supplier supplierEntity)
        {
            model = new PosDBEntities();
            model.db_supplier.Add(supplierEntity);
            model.SaveChanges();
            return "done";
        }

        public string updateSupplier(db_supplier sup)
        {
            model = new PosDBEntities();
            if (model.db_supplier.Any(l => l.Id == sup.Id))
            {
                var result = model.db_supplier.SingleOrDefault(b => b.Id == sup.Id);
                if (result != null)
                {
                    result.sup_name = sup.sup_name;
                    result.sup_mobile = sup.sup_mobile;
                    result.sup_email = sup.sup_email;
                    result.sup_address = sup.sup_address;
                    result.created_date = sup.created_date;
                    result.created_dy = sup.created_dy;
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
    }
}
