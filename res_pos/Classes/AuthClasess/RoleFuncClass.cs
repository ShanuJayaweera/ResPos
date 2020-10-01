using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;
using res_pos.Interfaces.AuthInterfaces;

namespace res_pos.Classes.AuthClasess
{
    class RoleFuncClass : IRoleFunc
    {
        PosDBEntities model;

        public string addRoleFunc(int roleID, int funcId, int userId)
        {
            model = new PosDBEntities();
            auth_role_func ar = new auth_role_func();
            ar.role_id = roleID;
            ar.func_id = funcId;
            ar.createdBy = userId;
            ar.createdDate = DateTime.Now.ToString();

            try
            {
                if (model.auth_role_func.Any(l => l.func_id == funcId && l.role_id == roleID))
                {
                    return "Recode is exist";
                }
                else
                {
                    model.auth_role_func.Add(ar);
                    model.SaveChanges();
                    return "done";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public List<auth_role_func> getFuncByRoleId(int roleId)
        {
            model = new PosDBEntities();
            return model.auth_role_func.Where(l => l.role_id == roleId).ToList();
        }

        public string removeRoleFunc(int roleId, int funcId)
        {
            try
            {
                model = new PosDBEntities();
                var recode = (from r in model.auth_role_func where r.role_id == roleId && r.func_id == funcId select r).SingleOrDefault();
                model.auth_role_func.Remove(recode);
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
