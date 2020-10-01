using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;

namespace res_pos.Interfaces.AuthInterfaces
{
    interface IForm
    {
        
        List<sys_forms> getAllRecodes();
    }
}
