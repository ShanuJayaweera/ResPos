using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace res_pos.Interfaces
{
    interface ICustomUI
    {
        string action { get; set; }

        int userId { get; set; }

        void _action(string action);

        void clearAllInputs();

        void enableAllInputs();

        void disableAllInputs();

        List<KeyValuePair<string, string>> nullValidateData();

        void fillGridView();

        void setDataToFields(int id);

        void search();

    }
}
