using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Interfaces;
using res_pos.Model;

namespace res_pos.Classes
{
    class ProductClass : IProduct
    {
        PosDBEntities model;

        public List<db_product> getAllRecodes()
        {
            model = new PosDBEntities();
            List<db_product> list = model.db_product.ToList();
            return list;
        }

        public string getProCodeById(int id)
        {
            model = new PosDBEntities();
            var data = model.db_product.Where(l => l.Id == id).Select(l => l.pro_code).Single();
            return data;
        }

        public List<db_product> getProductByStockCat(int stockCat)
        {
            model = new PosDBEntities();
            List<db_product> list = new List<db_product>();
            list = model.db_product.Where(l => l.stock_cat_id == stockCat).ToList();
            return list;
        }

        public List<db_product> getRecodeById(int id)
        {
            model = new PosDBEntities();
            var data = model.db_product.Where(l => l.Id == id).ToList();
            return data;

        }

        public List<db_product> getRecodeByProCode(string code)
        {
            model = new PosDBEntities();
            var data = model.db_product.Where(l => l.pro_code == code).ToList();
            return data;
        }

        public int insertProduct(db_product pro)
        {
            model = new PosDBEntities();

            if(model.db_product.Any(l => l.pro_code == pro.pro_code) || model.db_product.Any(x => x.pro_barcode == pro.pro_barcode))
            {
                return -1;
            }
            else
            {
                model.db_product.Add(pro);
                model.SaveChanges();
                return pro.Id;
            }
        }

        public string saveProcess(db_product pro, db_price price)
        {
            model = new PosDBEntities();
            PriceClass pc = new PriceClass();
            int proId = insertProduct(pro);
            if (proId != -1)
            {
                // save price
                price.pro_id = proId;
                string respond = pc.saveProcess(price);
                return respond;
            }
            else
            {
                return "exist";
            }
            
        }

        public List<db_product> searchRecodeByProCode(string code)
        {
            model = new PosDBEntities();
            var data = model.db_product.Where(l => l.pro_code.Contains(code)).ToList();
            return data;
        }

        public string updateProduct(db_product pro)
        {
            model = new PosDBEntities();
                 var result = model.db_product.SingleOrDefault(l => l.Id == pro.Id);
                if (result != null)
                {
                    result.pro_name = pro.pro_name;
                    result.stock_cat_id = pro.stock_cat_id;
                    result.pro_cat_id = pro.pro_cat_id;

                    result.created_date = pro.created_date;
                    result.created_by = pro.created_by;
                    model.SaveChanges();
                    return "done";
                }
                else
                {
                    return "not_exist";
                }
            }
            
        }
    }

