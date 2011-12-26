// File Name: TransportaionForm.cs
// Created By: Padma Priya Duvvuri
// Created On: 25-Dec-2011

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
    /// <summary>
    /// This form is used to add new info of transportation (buss, train or flight)
    /// </summary>
    public partial class TransportationForm : Form
    {
        private Transport m_transport;
         //flag to handle the closing of the form
        private bool closeForm;

        //constructor with one parameter (title of the form)
        public TransportationForm(string title)
        {
            InitializeComponent();
            //Other initalizations
            this.Text = title;
            closeForm = true;
            UpdateGUI();

        }

        /// <summary>
        /// Read only property for m_transport
        /// </summary>
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

        /// <summary>
        /// Event-handler for click event of Transporation button. This will create a new tranport object and 
        /// calls the transport constructor to add new details fo transport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransportation_Click(object sender, EventArgs e)
        {
            int ticketPrice = 0;
            //if all fields are validated continue with adding new transportaion info
            if (ValidateInputFields() == true && ValidatePrice(out ticketPrice) == true)
            {
                m_transport = new Transport(ticketPrice);
                //assign the values
                m_transport.TransportationNumber = txtNumber.Text;
                Stations fromStaion = (Stations)Enum.Parse(typeof(Stations), (string)cmbFrom.SelectedItem);
                m_transport.FromStation = fromStaion;
                Stations toStation = (Stations)Enum.Parse(typeof(Stations), (string)cmbTo.SelectedItem);
                m_transport.ToStation = toStation;
                DateTime time = (DateTime)timeTransportation.Value;
                m_transport.Time = time;
                m_transport.PriceAdult = ticketPrice;
                UpdateGUI();
                this.DialogResult = DialogResult.OK;
            }
           
        }

        /// <summary>
        /// validation for price field
        /// </summary>
        /// <param name="ticketPrice"></param>
        /// <returns>a integer having ticket price</returns>
        private bool ValidatePrice(out int ticketPrice)
        {
            string str = txtPrice.Text;
            bool isValid = InputUtility.GetInteger(str, out ticketPrice);
            if (isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter valid price", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        /// <summary>
        /// validate all input fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputFields()
        {
            //calls checkstring method of inpututility class
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

        /// <summary>
        /// Update the controls of the form
        /// </summary>
        private void UpdateGUI()
        {
            txtNumber.Text = string.Empty;
            timeTransportation.Value = DateTime.Now;
            // clear and updated the cmbFrom with Station and select default value Stockholm.
            cmbFrom.Items.Clear();
            cmbFrom.Items.AddRange(Enum.GetNames(typeof(Stations)));
            
            // clear and updated the cmbTo with Station and select default value Copenhagen.
            cmbTo.Items.Clear();
            cmbTo.Items.AddRange(Enum.GetNames(typeof(Stations)));
        }

        /// <summary>
        /// Event hanlder for Click event of cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //to close the form.
            this.Close();
        }
    }
}
