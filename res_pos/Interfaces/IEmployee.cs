using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces
{
    interface IEmployee
    {

        List<db_emp_type> getAllEmployeeTypeRecodes();

        List<db_employee> getAllEmployeeRecodes();

        List<db_employee> getEmployeeRecodeById(int id);
        string empSaveProcess(db_employee emp);

        string empUpdateProcess(db_employee emp);

        List<db_employee> searchByNic(string nic);

        List<db_employee> searchByEmpType(int emptype);

        List<db_employee> searchByNicAndEmpType(int emptype, string nic);

    }
}
