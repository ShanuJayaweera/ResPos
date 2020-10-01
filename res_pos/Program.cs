using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.stock;
using res_pos.SystemModules.Authentication;
using res_pos.SystemModules.Employee;
using res_pos.SystemModules.Product;
using res_pos.SystemModules.Customer;
using res_pos.SystemModules.Stock;
using res_pos.SystemModules.Dashboard;
using res_pos.SystemModules.Supplier;

namespace res_pos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
