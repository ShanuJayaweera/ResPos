using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using res_pos.Classes;

namespace res_pos.SystemModules.Stock
{
    public partial class frmSetSupplierAndDate : MetroFramework.Forms.MetroForm
    {
        public frmSetSupplierAndDate(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        SupplierClass sc;
        StockInvoiceClass sic;
        MessageClass msg;

        public int userId { get; set; }

        private void setSupplierCombo()
        {
            sc = new SupplierClass();
            comboSuppliers.DataSource = sc.getAllRecodes();
        }

        private void fillInvoiceGrid(int supId, string setDate)
        {
            sic = new StockInvoiceClass();
            var data = sic.getRecodeByStockIdAndDate(supId, setDate);
            gridInvoice.Rows.Clear();
            foreach (var item in data)
            {
                gridInvoice.Rows.Add(item.Id, item.invoice_no, item.db_stock.db_supplier.sup_name, item.db_stock.created_date);
            }
        }

        private void search()
        {
            int supId = int.Parse(comboSuppliers.SelectedValue.ToString());
            string setDate = dtDate.Value.ToString("m/dd/yyyy");
            fillInvoiceGrid(supId, setDate);
        }


        private void frmSetSupplierAndDate_Load(object sender, EventArgs e)
        {
            // set supplier combo
            setSupplierCombo();
        }

        private void comboSuppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            search();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void gridInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = gridInvoice.Rows[index];
                string id = selected_row.Cells[0].Value.ToString(); // this is inv id

                msg = new MessageClass();
                if (!e.ColumnIndex.Equals(0))
                {
                    frmViewStock f = new frmViewStock(this.userId, int.Parse(id));
                    f.Show();
                    this.Hide();
                }

            }
        }
    }
}
