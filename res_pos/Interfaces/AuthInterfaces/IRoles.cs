using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces.AuthInterfaces
{
    interface IRoles
    {
        List<auth_roles> getAllRecodes();

        List<auth_roles> getRecodeById(int id);

        string saveProcess(auth_roles rolesEntity);

        string updateRole(auth_roles rolesEntity);
    }
}
