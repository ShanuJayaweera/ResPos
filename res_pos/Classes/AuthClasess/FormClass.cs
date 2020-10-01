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
    class FormClass : IForm
    {
        PosDBEntities model;

        public List<sys_forms> getAllRecodes()
        {
            model = new PosDBEntities();
            return model.sys_forms.ToList();
        }
    }
}
