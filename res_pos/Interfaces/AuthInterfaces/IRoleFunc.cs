using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces.AuthInterfaces
{
    interface IRoleFunc
    {
        List<auth_role_func> getFuncByRoleId(int roleId);

        string addRoleFunc(int roleID, int funcId, int userId);

        string removeRoleFunc(int roleId, int funcId);
    }

}
