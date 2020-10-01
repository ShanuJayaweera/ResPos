using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBilling.VM;
using ResBilling.Classes;
using ResBilling.Model;
using System.Security.AccessControl;

namespace ResBilling.SystemModules
{
    public partial class frmSplitBill : MetroFramework.Forms.MetroForm
    {
        public frmSplitBill(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;

        }

        public int ticketId { get; set; }

        TempBillClass tbc;


        private void getTempBillProducts()
        {
            tbc = new TempBillClass();
            List<BillingProDataVM> tempBill = tbc.getTempBillPro(this.ticketId);
            setTempBillToGrid(tempBill);
        }

        private void setTempBillToGrid(List<BillingProDataVM> list)
        {
            foreach (var item in list)
            {
                gridPurchased.Rows.Add(item.proId, item.proCode, item.proName, item.sellingPrice, item.qty, item.discount);
            }

        }

        private void setDataToFinalGrid(string id, string name, string qty, string dis, string total)
        {
            gridFinal.Rows.Add(id, name, qty, dis, total);
        }

        private void frmSplitBill_Load(object sender, EventArgs e)
        {
            getTempBillProducts();
        }

        private void reduseQtyFromSourceTable(int row_id, string newQty)
        {
            gridPurchased.Rows[row_id].Cells[4].Value = newQty;
        }

        private void gridPurchased_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridPurchased.Rows[index];
                string id = selected_row.Cells[0].Value.ToString();

                if (!e.ColumnIndex.Equals(0))
                {
                    using (frmProduct fh = new frmProduct(this.ticketId, int.Parse(id)))
                    {
                        if (fh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            // add data to final bill table
                            setDataToFinalGrid(fh.proId.ToString(), fh.name, fh.qty, fh.discount, fh.price);

                            string oldQty = gridPurchased.Rows[index].Cells[4].Value.ToString();

                            string newQty = (int.Parse(oldQty) - int.Parse(fh.qty)).ToString();

                            if (int.Parse(newQty) <= 0)
                            {
                                gridPurchased.Rows.RemoveAt(index);
                            }
                            else
                            {
                                //discrease qty and total from source table
                                reduseQtyFromSourceTable(index, newQty);
                            }
                        }
                    }
                }

            }
        }
    }
}
