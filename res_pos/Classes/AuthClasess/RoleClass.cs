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
    class RoleClass : IRoles
    {
        PosDBEntities model;
        public List<auth_roles> getAllRecodes()
        {
            model = new PosDBEntities();
            return model.auth_roles.ToList();
        }

        public List<auth_roles> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.auth_roles.Where(l => l.Id == id).ToList();
            return result;
        }

        public string saveProcess(auth_roles ar)
        {
            model = new PosDBEntities();
            if (model.auth_roles.Any(l => l.role_name == ar.role_name))
            {
                return "exist";
            }
            else
            {
                try
                {
                    model.auth_roles.Add(ar);
                    model.SaveChanges();
                    return "done";
                }
                catch(Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public string updateRole(auth_roles ar)
        {
            model = new PosDBEntities();

            if (model.auth_roles.Any(l => l.Id == ar.Id))
            {
                if (model.auth_roles.Any(l => l.role_name == ar.role_name))
                {
                    return "exist";
                }
                else
                {
                    var result = model.auth_roles.SingleOrDefault(l => l.Id == ar.Id);
                    if (result != null)
                    {
                        result.role_name = ar.role_name;
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
