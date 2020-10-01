using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class EmployeeClass : IEmployee
    {
        PosDBEntitiesBill model;

        public List<db_employee> getStewardsList()
        {
            model = new PosDBEntitiesBill();
            return model.db_employee.Where(l => l.emp_type == 1).ToList();
        }

    }
}
