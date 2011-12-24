using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORS
{
    public partial class Transportation : Form
    {
        private Transport m_transport;
         //flag to handle the closing of the form
        private bool closeForm;
       // private string[] m_fullTransportDetails;

        //constructor with one parameter (title of the form)
        public Transportation(string title)
        {
            InitializeComponent();
            //Other initalizations
            this.Text = title;
            closeForm = true;
            UpdateGUI();

        }

        public Transport  TransportData
        {
            get { return m_transport; }
           
        }
      
       
         /// <summary>
        /// Event hadler for formclosing event event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transportation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
            decimal ticketPrice = 0.0M;
            if (!ValidateInputFields() && !ValidatePrice(out ticketPrice))
            {
                return;
            }
            //if no customer is present then create a new customer
            if (m_transport  == null)
            {
                m_transport = new Transport ();
            }

            m_transport.TransportationNumber = txtNumber.Text;
            Stations  fromStaion = (Stations)Enum.Parse(typeof(Stations ), (string)this.cmbFrom.SelectedItem);
            m_transport.FromStation = fromStaion;
            Stations toStation = (Stations)Enum.Parse(typeof(Stations), (string)this.cmbTo.SelectedItem);
            m_transport.FromStation = toStation;
            DateTime time = (DateTime)timeTransportation.Value;
            m_transport.Time = time;
            m_transport.PriceAdult = ticketPrice;
            UpdateGUI();
            this.DialogResult = DialogResult.OK;
        }

        private bool ValidatePrice(out decimal ticketPrice)
        {
            string str = txtPrice.Text;
            bool isValid = InputUtility.GetDecimal(str, out ticketPrice);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private bool ValidateInputFields()
        {//calls checkstring method of inpututility class
            if (!InputUtility.CheckString(txtNumber.Text))
            {
                MessageBox.Show("Number cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNumber.Text = "Number*";
                return false;
            }
            if(cmbFrom.SelectedItem.ToString() == cmbTo.SelectedItem.ToString())
            {
                MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFrom.Text = "From*";
                lblTo.Text = "To*";
                return false;
            }
            return true;
        }

        private void UpdateGUI()
        {
            txtNumber.Text = string.Empty;
            timeTransportation.Value = DateTime.Now;
            // clear and updated the cmbFrom with Station and select default value Stockholm.
            cmbFrom.Items.Clear();
            cmbFrom.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbFrom.SelectedIndex = (int)Stations.Stockholm;

            // clear and updated the cmbTo with Station and select default value Copenhagen.
            cmbTo.Items.Clear();
            cmbTo.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbTo.SelectedIndex = (int)Stations.Copenhagen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
