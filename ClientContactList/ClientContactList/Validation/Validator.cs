using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientContactList.Validation
{
    public static class Validator
    {
        public static bool IsValidID(TextBox text)
        {
            int tempID;
            if(text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("ID is not valid!!");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool IsUniqueID(List<Customer> list, int id)
        {
            foreach(Customer c in list)
            {
                if (c.Id == id)
                {
                    MessageBox.Show("ID is not Unique");
                    return false;
                }
            }
            return true;
        }
    }
}
