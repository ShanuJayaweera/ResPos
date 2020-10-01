using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Model;

namespace ResBilling.Interfaces
{
    interface IMyTables
    {
        string saveProcess(my_tables tbl);

        List<my_tables> getAllRecodes();

        int tableIdByTableName(string tableName);
    }
}
