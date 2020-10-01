using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;
using res_pos.Classes.AuthClasess;

namespace res_pos
{
    class common_moduls
    {
        public Boolean check_null_data(List<KeyValuePair<string, string>> list)
        {
            Boolean return_val = false;

            foreach (KeyValuePair<string, string> entry in list)
            {
                if (string.IsNullOrEmpty(entry.Value) || string.IsNullOrWhiteSpace(entry.Value))
                {
                    return_val = true;
                }
            }
            return return_val;
        }

        public Boolean validateRequiredData(List<KeyValuePair<string, string>> list)
        {
            Boolean returnValue = false;

            foreach (KeyValuePair<string, string> entry in list)
            {
                if (string.IsNullOrEmpty(entry.Value) || string.IsNullOrWhiteSpace(entry.Value))
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        public int return_branch_id()
        {
            int branch_id = 0;

            //var dt = db.meta_data.ToList();
            //foreach (var item in dt)
            //{
            //    branch_id = int.Parse(item.branch_id.ToString());
            //}

            return branch_id;
        }

        public Boolean permissionCheck(int funcId, int roleId)
        {
            PosDBEntities model = new PosDBEntities();
            auth_role_func arf = new auth_role_func();
            if (model.auth_role_func.Any(l => l.func_id == funcId && l.role_id == roleId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string returnUserName(int id)
        {
            UserClass uc = new UserClass();
            return uc.userNameById(id);
        }

    }
}
