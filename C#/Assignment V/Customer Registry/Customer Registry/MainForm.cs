using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Customer_Registry.Customer_Files;
namespace Customer_Registry
{
    public partial class MainForm : Form
    {
        Customer_Files.CustomerManager customerMngr ;

        public MainForm()
        {
            InitializeComponent();
            customerMngr = new Customer_Files.CustomerManager();
        }
        
        private void UpdateCustomerList()
        {
            lstCustomerDetails.Items.Clear();
            for (int index = 0; index <= (customerMngr.Count - 1); index++)
            {
                lstCustomerDetails.Items.Add(customerMngr.GetCustomer(index).ToString());
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerForm frmCustomer = new CustomerForm("Add New Customer");

            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmCustomer.CustomerData);
                UpdateCustomerList();
            }
        }

        private void mnuCustomerChange_Click(object sender, EventArgs e)
        {
            CustomerForm frmCustomer = new CustomerForm("Change Customer Details");

            int index = lstCustomerDetails.SelectedIndex;
            if (index != -1)
            {
                frmCustomer.CustomerData = new Customer(customerMngr.GetCustomer(index).ContactData);
            }
            else {
                MessageBox.Show("Please select an index","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                customerMngr.ChangeCustomer(frmCustomer.CustomerData.ContactData ,lstCustomerDetails.SelectedIndex);
                UpdateCustomerList();
            }

        }

        private void mnuCustomerDelete_Click(object sender, EventArgs e)
        {
            int index = lstCustomerDetails.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customerMngr.RemoveCustomer(index);
            UpdateCustomerList();
        }

    }
}
