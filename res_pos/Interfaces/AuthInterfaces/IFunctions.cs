using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces.AuthInterfaces
{
    interface IFunctions
    {
        List<auth_functions> getAllRecodes();

        List<auth_functions> getRecodeById(int id);

        string saveProcess(auth_functions funcEntity);

        string updateFunc(auth_functions funcEntity);
    }
}
