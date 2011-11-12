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
        private bool closeForm;
        private Customer m_customer;

        public CustomerForm(string title)
        {
            InitializeComponent();

            this.Text = title;
            closeForm = true;

            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;
        }

       
        public Customer CustomerData
        {
            get { return m_customer; }
            set 
            {
                if (value != null)
                    m_customer = value;

                UpdateGUI();
            }
        }

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

       
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
            {
                return;
            }
            if (m_customer == null)
            {
                m_customer = new Customer();
            }
            
            Countries selectedCountry = (Countries)Enum.Parse(typeof(Countries), (string)this.cmbCountry.SelectedItem);
                
            m_customer.ContactData.AddressData = new Address(txtStreet.Text, txtZip.Text, txtCity.Text, selectedCountry);
            m_customer.ContactData.EmailData = new Email(txtProfessionalEmail.Text, txtPersonalEmail.Text);


            m_customer.ContactData.PhoneData = new Phone(txtHomePhone.Text, txtCellPhone.Text);

            

                m_customer.ContactData.FirstName = txtFirstName.Text;
                m_customer.ContactData.LastName = txtLastName.Text;

                this.DialogResult = DialogResult.OK;
            
            
        }

        private bool ValidateInputFields()
        {
            if (!InputUtility.CheckString(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFirstName.Text = "First Name *";
                return false;
            }
            if (!InputUtility.CheckString(txtLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLastName.Text = "Last Name *";
                return false;
            }
            if (!ValidateAndFormatPhoneNumber(txtCellPhone.Text) || !ValidateAndFormatPhoneNumber(txtHomePhone.Text))
            {
                return false;
            }

            return true;
        }


        private bool ValidateAndFormatPhoneNumber(string phone)
        {
            long number;
            bool isValid = InputUtility.GetLong(phone, out number);
            if (isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Format","Info!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
