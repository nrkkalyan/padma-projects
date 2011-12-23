using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace ORS
{
    public partial class CustomerForm : Form
    {
        //customer object receiving input and/or sending output
        private CustomerContacts m_customer;
         //flag to handle the closing of the form
        private bool closeForm;
        private string[] m_fullConact;

        /// <summary>
        /// Property CustomerData to read customer values, with access to 
        /// read and write
        /// </summary>
        /// <value></value>
        /// 
        /// <returns>Customer object</returns>

        public CustomerContacts CustomerData
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
        

       /* public CustomerContacts CustomerData() { 
            return m_customer;
        }

        public string ContactString 
        {
            set
            {
                if (value != string.Empty)
                     m_fullConact  = value;
            } 
        }
        */
        /// <summary>
        /// update the controls of customerForm to the m_customer object values
        /// </summary>
        private void UpdateGUI()
        {
            txtCustomerEmail.Text = m_customer.Email;
            txtCustomerFirstName.Text = m_customer.FirstName;
            txtCustomerLastName.Text = m_customer.LastName;
            txtCustomerPhone.Text = m_customer.Phone;
        }

        //constructor with one parameter (title of the form)
        public CustomerForm(string title)
        {
            InitializeComponent();
            //Other initalizations
            this.Text = title;
            closeForm = true;

        }

        public string[] Details
        {
            set
            {
                if (value != null)
                    m_fullConact = value;
            }
        }
        public CustomerForm(string title, string[] details)
        {
            InitializeComponent();
            //Other initalizations
            this.Text = title;
            closeForm = true;
            m_customer = new CustomerContacts(details);
            UpdateGUI();


        }



         /// <summary>
        /// Event hadler for formclosing event event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //validate the user given values for Name fields and phone number
            if (!ValidateInputFields())
            {
                return;
            }
            //if no customer is present then create a new customer
            if (m_customer == null)
            {
                m_customer = new CustomerContacts();
            }

            m_customer.Email = txtCustomerEmail.Text;
            m_customer.Phone = txtCustomerPhone.Text ;
            m_customer.FirstName = txtCustomerFirstName.Text;
            m_customer.LastName = txtCustomerLastName.Text;
            UpdateGUI();
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
            if (!InputUtility.CheckString(txtCustomerFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFirstName.Text = "First Name*";
                return false;
            }
            if (!InputUtility.CheckString(txtCustomerLastName.Text))
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

            if (!ValidateEmail())
            {
                MessageBox.Show("Enter a valid E-mail address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLastName.Text = "Email*";
                return false;
            }    

            return true;
        }

        private bool ValidateEmail()
        {
            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
               @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
               @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            System.Text.RegularExpressions.Match match =
                Regex.Match(txtCustomerEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase);

            if (match.Success)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks whehter atleast one telepone number is provided or not.And validates the
        /// presented by the user
        /// </summary>
        /// <returns>true if atleast one phone number is given and validates the given
        /// user input</returns>
        private bool ValidationForPhoneNumbers()
        {
            if ( txtCustomerPhone.Text  == string.Empty)
            {
                MessageBox.Show("Telephone number should be provided", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPhone.Text = "Phone/Moble*";
                return false;
            }
            if (txtCustomerPhone.Text != string.Empty)
            {
                return ValidatePhoneNumber(txtCustomerPhone.Text);
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
                MessageBox.Show("Invalid Phone Format", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
