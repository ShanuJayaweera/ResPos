using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using res_pos.Interfaces;
using res_pos.Model;
using res_pos.VM;

namespace res_pos.Classes.AuthClasess
{
    class UserClass : IUsers
    {
        PosDBEntities model;

        public string changePassword(string userName, string _password, string newPassword)
        {
            model = new PosDBEntities();

            var result = model.auth_users.SingleOrDefault(l => l.user_password == _password && l.user_name == userName);
            if (result != null)
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(_password);
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                
                result.user_password = sb.ToString();

                model.SaveChanges();
                return "done";
            }
            else
            {
                return "not_exist";
            }
        }

        public List<auth_users> getAllRecodes()
        {
            model = new PosDBEntities();
            return model.auth_users.ToList();
        }

        public List<auth_users> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var result = model.auth_users.Where(l => l.Id == id).ToList();
            return result;
        }

        public LoggedUser login(string userName, string _password)
        {
            model = new PosDBEntities();
            LoggedUser lu = new LoggedUser();

            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(_password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            _password = sb.ToString();


            if (model.auth_users.Any(l => l.user_name == userName && l.user_password == _password))
            {
                var list = model.auth_users.Where(l => l.user_name == userName && l.user_password == _password).FirstOrDefault();
                lu.roleId = list.role_id;
                lu.userId = list.emp_id;
                return lu;
            }
            else
            {
                lu.roleId = null;
                lu.userId = null;
                return lu;
            }
        }

        public string saveProcess(auth_users au)
        {
            model = new PosDBEntities();
            if (model.auth_users.Any(l => l.user_name == au.user_name))
            {
                return "exist";
            }
            else
            {
                try
                {
                    model.auth_users.Add(au);
                    model.SaveChanges();
                    return "done";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public string updateRole(auth_users au)
        {
            model = new PosDBEntities();

            if (model.auth_users.Any(l => l.Id == au.Id))
            {
                if (model.auth_users.Any(l => l.user_name == au.user_name))
                {
                    return "exist";
                }
                else
                {
                    var result = model.auth_users.SingleOrDefault(l => l.Id == au.Id);
                    if (result != null)
                    {
                        result.role_id = au.role_id;
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

        public string userNameById(int id)
        {
            model = new PosDBEntities();
            string userName = "Something went wrong";
            var dt = model.auth_users.Where(l => l.Id == id).ToList();
            foreach (var item in dt)
            {
                userName = item.user_name;
            }
            return userName;
        }
    }
}
