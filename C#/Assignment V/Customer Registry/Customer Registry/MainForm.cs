using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Customer_Registry
{
    public partial class MainForm : Form
    {
        Customer_Files.CustomerManager customerMngr = new Customer_Files.CustomerManager();
        public MainForm()
        {
            InitializeComponent();

            customerMngr.TestValues();

            UpdateCustomerList();
        }
        
        private void UpdateCustomerList()
        {
            lstCustomerDetails.Items.Add(customerMngr.GetCustomer(0).ToString());
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
