//File: CustomerForm.cs
//Created by: Padma Priya Duvvuri
//Created on: 11-Nov-2011

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
        //creats the customerMangr private object
        Customer_Files.CustomerManager customerMngr ;

        public MainForm()
        {
            InitializeComponent();
            //Initialize customer manager object
            customerMngr = new Customer_Files.CustomerManager();
        }
        
        /// <summary>
        /// clears the listbox and updates it with the customer values of the 
        /// customerMngr arraylist
        /// </summary>
        private void UpdateCustomerList()
        {
            lstCustomerDetails.Items.Clear();
            for (int index = 0; index <= (customerMngr.Count - 1); index++)
            {
                lstCustomerDetails.Items.Add(customerMngr.GetCustomer(index).ToString());
            }
        }

        /// <summary>
        /// Event handler for the click event of the Exit menuitem of the File Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //call the closing event of the form
            this.Close();
        }

        /// <summary>
        /// Event handler for the click event of the Add menuítem of the Customer menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuCustomerAdd_Click(object sender, EventArgs e)
        {
            // create and show the new instance of the CustomerForm
            CustomerForm frmCustomer = new CustomerForm("Add New Customer");
            //if the user clicks OK on the customerform then call the UpdateCusomerList()
            //to update the listbox
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmCustomer.CustomerData);
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// Event handler for teh click event of Change menuitme of the Customer Menu.
        /// If list box is not empty then allow the user to change details of the customer
        /// at the selected index, else call showError() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuCustomerChange_Click(object sender, EventArgs e)
        {    
            //perform the update if the list box is not empty
            if (lstCustomerDetails.Items.Count != 0)
            {
                CustomerForm frmCustomer = new CustomerForm("Change Customer Details");

                int index = lstCustomerDetails.SelectedIndex;
                //if index is not selected then show error, otherwise continue
                if (index != -1)
                {
                    frmCustomer.CustomerData = new Customer(customerMngr.GetCustomer(index).ContactData);
                }
                else
                {
                    MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if the user clicks on the Ok button of the customerForm then continue with the updation
                if (frmCustomer.ShowDialog() == DialogResult.OK)
                {
                    customerMngr.ChangeCustomer(frmCustomer.CustomerData.ContactData, lstCustomerDetails.SelectedIndex);
                    UpdateCustomerList();
                }
            }
            else
            {
                //if list box is empty, show error
                ShowError();
                return;
            }

        }

        /// <summary>
        /// If list box is empty then user will not be able to update or delete any values.
        /// This method is called form click event of Delete and Change menuitems of Customer menu.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Event handler for click event of Delete menuitme of the Customer Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuCustomerDelete_Click(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (lstCustomerDetails.Items.Count != 0)
            {
                int index = lstCustomerDetails.SelectedIndex;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (index == -1)
                {
                    MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customerMngr.RemoveCustomer(index);
                UpdateCustomerList();
            }
            else
            {
                //show error if list box is empty
                ShowError();
                return;
            }
        }

        /// <summary>
        /// Event handler for the formClosing event of the MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //show message box to check whether user wants to close the form
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //close the form only if the user clicks on Yes button of the messagebox.
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

    }
}
