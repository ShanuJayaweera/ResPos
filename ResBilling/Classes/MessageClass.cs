using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBilling.Classes
{
    class MessageClass
    {
        public void requiredDataErr()
        {
            MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void recodeExistErr()
        {
            MessageBox.Show("Recode already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void recodeNotExistErr()
        {
            MessageBox.Show("Recode not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void recodeInsertSuccess()
        {
            MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void recodeUpdateSuccess()
        {
            MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Boolean requestToUpdate()
        {
            DialogResult res = MessageBox.Show("Are you sure to update this recode? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean requestToHoldTickt()
        {
            DialogResult res = MessageBox.Show("Are you sure to hold this ticket and continue another? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean requestToDelete()
        {
            DialogResult res = MessageBox.Show("Are you sure to delete this recode? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean requestToView()
        {
            DialogResult res = MessageBox.Show("Are you sure to view this recode? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean requestToAddNewTable()
        {
            DialogResult res = MessageBox.Show("Are you sure to add new table? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // select category
        public void selectCatErr()
        {
            MessageBox.Show("Please select category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // select supplier
        public void selectSupplierAndInvErr()
        {
            MessageBox.Show("Please select supplier and invoice no", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ExceptionErr(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Boolean requestToAddNewTicket()
        {
            DialogResult res = MessageBox.Show("Are you sure to add new ticket? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
