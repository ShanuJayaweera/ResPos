using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface ISupplier
    {
        string insertSupplier(db_supplier supplierEntity);

        string updateSupplier(db_supplier supplierEntity);

        List<db_supplier> getAllRecodes();

        List<db_supplier> getRecodeById(int id);

    }
}
