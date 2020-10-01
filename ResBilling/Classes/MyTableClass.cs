using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResBilling.Interfaces;
using ResBilling.Model;

namespace ResBilling.Classes
{
    class MyTableClass : IMyTables
    {
        PosDBEntitiesBill model;

        public List<my_tables> getAllRecodes()
        {
            model = new PosDBEntitiesBill();
            return model.my_tables.ToList();
        }

        public string saveProcess(my_tables tbl)
        {
            model = new PosDBEntitiesBill();
            try
            {
                if (model.my_tables.Any(l => l.table_name == tbl.table_name))
                {
                    return "exist";
                }
                else
                {
                    model.my_tables.Add(tbl);
                    model.SaveChanges();
                    return "done";
                }
                
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public int tableIdByTableName(string tableName)
        {
            model = new PosDBEntitiesBill();
            var data = model.my_tables.Where(l => l.table_name == tableName).FirstOrDefault();
            return data.Id;
        }
    }
}
