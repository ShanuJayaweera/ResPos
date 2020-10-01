using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using res_pos.Model;
using res_pos.VM;

namespace res_pos.Interfaces
{
    interface IUsers
    {
        string saveProcess(auth_users au);

        string updateRole(auth_users au);

        List<auth_users> getAllRecodes();

        List<auth_users> getRecodeById(int id);

        LoggedUser login(string userName, string _password);

        string changePassword(string userName, string _password, string newPassword);

        string userNameById(int id);

    }
}
