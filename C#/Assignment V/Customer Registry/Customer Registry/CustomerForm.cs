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
    public partial class CustomerForm : Form
    {
        //customer object receiving input and/or sending output
        private Customer m_customer;
        //flag to handle the closing of the form
        private bool closeForm;

        //constructor with one parameter (title of the form)
        public CustomerForm(string title)
        {
            InitializeComponent();
            //Other initialization
            this.Text = title;
            closeForm = true;
            //populate the combo box and select the default country as Sverige
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;
        }

       
        /// <summary>
        /// Property CustomerData to read customer values, with access to 
        /// read and write
        /// </summary>
        /// <value></value>
        /// <returns>Customer object</returns>
        public Customer CustomerData
        {
            get { return m_customer; }
            set 
            {
                if (value != null)
                    m_customer = value;
                //update input controls
                UpdateGUI();
            }
        }

        /// <summary>
        /// update the controls of customerForm to the m_customer object values
        /// </summary>
        private void UpdateGUI()
        {
            txtCellPhone.Text = m_customer.ContactData.PhoneData.Cell;
            txtHomePhone.Text = m_customer.ContactData.PhoneData.Home;
            txtFirstName.Text = m_customer.ContactData.FirstName;
            txtLastName.Text = m_customer.ContactData.LastName;
            txtCity.Text = m_customer.ContactData.AddressData.City;
            txtStreet.Text = m_customer.ContactData.AddressData.Street;
            txtZip.Text = m_customer.ContactData.AddressData.ZipCode;
            txtPersonalEmail.Text = m_customer.ContactData.EmailData.Personal;
            txtProfessionalEmail.Text = m_customer.ContactData.EmailData.Work;
            cmbCountry.SelectedIndex = (int)m_customer.ContactData.AddressData.Country;
        }

        /// <summary>
        /// Event hadler for formclosing event event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Event handler for click event of the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //validate the user given values for Name fields and phone number
            if (!ValidateInputFields())
            {
                return;
            }
            //if no customer is present then create a new customer
            if (m_customer == null)
            {
                m_customer = new Customer();
            }
            // passing the values given by the user to the fields
            //get selected coutry
            Countries selectedCountry = (Countries)Enum.Parse(typeof(Countries), (string)this.cmbCountry.SelectedItem);
            m_customer.ContactData.AddressData = new Address(txtStreet.Text, txtZip.Text, txtCity.Text, selectedCountry);
            m_customer.ContactData.EmailData = new Email(txtProfessionalEmail.Text, txtPersonalEmail.Text);
            m_customer.ContactData.PhoneData = new Phone(txtHomePhone.Text, txtCellPhone.Text);
            m_customer.ContactData.FirstName = txtFirstName.Text;
            m_customer.ContactData.LastName = txtLastName.Text;
            //return the dialog result value as OK so as to perform next calculations
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Validates the firstname, lastname and telephone numbers.
        /// </summary>
        /// <returns>returns true if all the three fields are validated, false
        /// otherwise</returns>
        private bool ValidateInputFields()
        {
            //calls checkstring method of inpututility class
            if (!InputUtility.CheckString(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFirstName.Text = "First Name*";
                return false;
            }
            if (!InputUtility.CheckString(txtLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLastName.Text = "Last Name*";
                return false;
            }
            //validation for phone numbers
            if (!ValidationForPhoneNumbers())
            {
                return false;
            }
           
            return true;
        }

        /// <summary>
        /// checks whehter atleast one telepone number is provided or not.And validates the
        /// presented by the user
        /// </summary>
        /// <returns>true if atleast one phone number is given and validates the given
        /// user input</returns>
        private bool ValidationForPhoneNumbers()
        {
            if (txtCellPhone.Text == string.Empty && txtHomePhone.Text == string.Empty)
            {
                MessageBox.Show("Atleast one telephone number should be provided", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCellPhone.Text != string.Empty)
            {
                return ValidatePhoneNumber(txtCellPhone.Text);
            }
            if (txtHomePhone.Text != string.Empty)
            {
                return ValidatePhoneNumber(txtHomePhone.Text);
            }
                
            return true;
        }

        /// <summary>
        /// If atleast one phone number is provided, converts the value to long
        /// by calling GetLong method of InputUtility
        /// </summary>
        /// <param name="phone">string value of the user input for phone number</param>
        /// <returns>true if conversion is successful</returns>
        private bool ValidatePhoneNumber(string phone)
        {
            long number;
            bool isValid = InputUtility.GetLong(phone, out number);
            if (isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Phone Format","Info!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// event handler for the click event of cancel button. It closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
