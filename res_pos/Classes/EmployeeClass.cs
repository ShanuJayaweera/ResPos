using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Model;
using res_pos.Classes.AuthClasess;

namespace res_pos.Classes
{
    class EmployeeClass : IEmployee
    {
        PosDBEntities model;

        public string empSaveProcess(db_employee emp)
        {
            model = new PosDBEntities();
            
            if (model.db_employee.Any(l => l.nic == emp.nic))
            {
                return "exist";
            }
            else
            {
                try
                {
                    model.db_employee.Add(emp);
                    model.SaveChanges();

                    return emp.Id.ToString();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public string empUpdateProcess(db_employee emp)
        {
            model = new PosDBEntities();

            if (model.db_employee.Any(l => l.nic == emp.nic))
            {
                var result = model.db_employee.SingleOrDefault(l => l.Id == emp.Id);
                if (result != null)
                {
                    result.name = emp.name;
                    result.address = emp.address;
                    result.telephone = emp.telephone;
                    result.mobile = emp.mobile;
                    result.emp_type = emp.emp_type;
                    result.created_by = emp.created_by;
                    result.created_date = emp.created_date;
                    result.created_by = emp.created_by;
                    result.email = emp.email;
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

        public List<db_employee> getAllEmployeeRecodes()
        {
            model = new PosDBEntities();
            var list = model.db_employee.ToList();
            return list;
        }

        public List<db_emp_type> getAllEmployeeTypeRecodes()
        {
            model = new PosDBEntities();
            var list = model.db_emp_type.ToList();
            return list;
        }

        public List<db_employee> getEmployeeRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.db_employee.Where(l => l.Id == id).ToList();
            return result;
        }

        public List<db_employee> searchByEmpType(int emptype)
        {
            model = new PosDBEntities();
            var result = model.db_employee.Where(l => l.emp_type == emptype).ToList();
            return result;
        }

        public List<db_employee> searchByNic(string nic)
        {
            model = new PosDBEntities();
            var result = model.db_employee.Where(l => l.nic.Contains(nic)).ToList();
            return result;
        }

        public List<db_employee> searchByNicAndEmpType(int emptype, string nic)
        {
            model = new PosDBEntities();
            var result = model.db_employee.Where(l => l.nic.Contains(nic) && l.emp_type == emptype).ToList();
            return result;
        }
    }
}
