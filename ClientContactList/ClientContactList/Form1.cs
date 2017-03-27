using ClientContactList.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientContactList
{
    public partial class Form1 : Form
    {
        Customer c1;
        List<Customer> customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (Validator.IsValidID(textID) && Validator.IsUniqueID(customers, Convert.ToInt32(textID.Text))){
                c1 = new Customer(textFirstName.Text, textLastName.Text);
                string idStr = textID.Text;
                c1.setID(Convert.ToInt32(idStr));
                c1.PhoneNumber = maskedTextBoxPhone.Text;
                customers.Add(c1);
                ClearAll();
            }   
        }

        public void ClearAll()
        {
            textID.Clear();
            textFirstName.Clear();
            textLastName.Clear();
            maskedTextBoxPhone.Clear();
            textID.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Customer c1 in customers)
            {               
                ListViewItem customerForList = new ListViewItem(Convert.ToString(c1.Id));
                customerForList.SubItems.Add(c1.FirstName);
                customerForList.SubItems.Add(c1.LastName);
                customerForList.SubItems.Add(c1.PhoneNumber);
                listView1.Items.Add(customerForList);
            }        
        }
    }
}
