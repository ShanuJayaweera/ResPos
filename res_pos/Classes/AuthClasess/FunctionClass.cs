using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Interfaces.AuthInterfaces;
using res_pos.Model;

namespace res_pos.Classes.AuthClasess
{
    class FunctionClass : IFunctions
    {
        PosDBEntities model;
        public List<auth_functions> getAllRecodes()
        {
            model = new PosDBEntities();
            return model.auth_functions.ToList();
        }

        public List<auth_functions> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.auth_functions.Where(l => l.Id == id).ToList();
            return result;
        }

        public string saveProcess(auth_functions af)
        {
            model = new PosDBEntities();
            if (model.auth_functions.Any(l => l.func_name == af.func_name))
            {
                return "exist";
            }
            else
            {
                try
                {
                    model.auth_functions.Add(af);
                    model.SaveChanges();
                    return "done";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }

            }
        }

        public string updateFunc(auth_functions af)
        {
            model = new PosDBEntities();

            if (model.auth_functions.Any(l => l.Id == af.Id))
            {
                if (model.auth_functions.Any(l => l.func_name == af.func_name))
                {
                    return "exist";
                }
                else
                {
                    var result = model.auth_functions.SingleOrDefault(l => l.Id == af.Id);
                    if (result != null)
                    {
                        result.func_name = af.func_name;
                        model.SaveChanges();
                        return "done";
                    }
                    else
                    {
                        return "not_exist";
                    }
                }

            }
            else
            {
                return "not_exist";
            }
        }
    }
}
