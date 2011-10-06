using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment3CBS
{
    public partial class MainForm : Form
    {
        //Test variables - to test the application
        private double revenue = 0.0; // accumulate everytime a new
        private const int totalNumOfSeats = 240;
        private int numOfReservedSeats = 0; //increase as a reservation is made

        public MainForm()
        {
            //visual studio generated method
            InitializeComponent();

            //my initialization method
            InitializeGUI();
        }

        /// <summary>
        /// Clear the input and output controls (if needed)
        /// Do other initializations, for example select one of the radiobuttons as default.
        /// </summary>
        /// <remarks>This is to be called from the constructor, AFTER the call
        /// to InitializeComponent.</remarks>

        private void InitializeGUI()
        {
            rbtnReserved.Checked = true;
            lstReservations.Items.Clear();
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            lblNumOfReserved.Text = string.Empty;
            lblNumOfSeats.Text = string.Empty;
            lblNumOfVacant.Text = string.Empty;
            lblTotalRevenue.Text = string.Empty;
            txtName.Focus(); // focus is set to the name field
        }


        /// <summary>
        /// Event-handler method for the Click-event of the button,when the user 
        /// clicks the button, this method will be executed automatically.
        /// Call the ReadAndValidateInput method, save its return value in a Boolean variable.
        /// If the return value is true, tehn call the UpdateGUI method to display the results.
        /// </summary>
        /// <param name="sender">Reference to the object that has fired teh Click event (the button)</param>
        /// <param name="e">Contains information about the event</param>
        /// <remarks>Send and e are part of event delegate hadling</remarks>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // declaring variable to store user input
            string customerName = string.Empty;
            double seatPrice = 0.0;

            //to validate user input
            bool inputOk = ReadAndValidateInput(out customerName, out seatPrice);

            if (inputOk)
            {
                numOfReservedSeats++;
                revenue += seatPrice;
                UpdateGUI(customerName, seatPrice); // perform the calculations and update GUI
            }

        }

        /// <summary>
        /// This updates the GUI to show the updated values, by performing necessary calculations if needed.
        /// </summary>
        /// <param name="customerName">Receives the customer name after perfoming the validations</param>
        /// <param name="seatPrice">Recives the price after validation</param>
        /// <remarks>It adds the name and price to the listbox for display</remarks>
        private void UpdateGUI(string customerName, double seatPrice)
        {
            lblNumOfSeats.Text = Convert.ToString(totalNumOfSeats);
            lblNumOfReserved.Text = Convert.ToString(numOfReservedSeats);
            lblNumOfVacant.Text = Convert.ToString(totalNumOfSeats - numOfReservedSeats);
            lblTotalRevenue.Text = Convert.ToString(revenue);

            string str = string.Format("{0,15} {1,10} {2,20}\t{3} ", "0", "Reserved", seatPrice , customerName);
   
            lstReservations.Items.Add(str);


        }

        
        /// <summary>
        /// Parse the user input, validate and save the data for later use.
        /// In this version, all input is saved in local variables and therefore the values are passed
        /// as parameters in method calls
        /// This method calls two other methods to read and validate name and price repsectively
        /// </summary>
        /// <param name="customerName">The name of the customer</param>
        /// <param name="seatPrice">The price to be paid by the customer</param>
        /// <returns>True if input is valid, False otherwise</returns>
        private bool ReadAndValidateInput(out string name, out double price)
        {
            bool nameValid = ReadAndValidateName(out name);
            bool priceValid = ReadAndValidatePrice(out price);

            if (nameValid && priceValid)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check so the user has entered a text in the TextBox for name
        /// </summary>
        /// <param name="name">A string variable passing customer name inputted by the user</param>
        /// <returns>True Validation (name must have atleast one char other than 
        /// a blank space) is OK, false otherwise</returns>
        /// <remarks></remarks>
        private bool ReadAndValidateName(out string name)
        {
            name = txtName.Text;

            // calling CheckString method of InputUtility to validate name
            bool isValid = InputUtility.CheckString(name);
            if (!isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input in name field! Name cannot be empty, and must have atleast one character(not a blank)", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtName.Focus(); // set focus to name textbox
                txtName.SelectAll(); // to select all the text present
                return false;
            }

        }


        /// <summary>
        /// Call GetDouble method of the InputUtility to convert the text given by the user
        /// in the price TextBox. Validate and then the converted value to a value >= 0 and less than or equal to a 
        /// max ticket price (3500.00)
        /// </summary>
        /// <param name="price">Variable receiving the converted value</param>
        /// <returns>True if the convertion is successful and validation is OK, False otherwise</returns>
        private bool ReadAndValidatePrice(out double price)
        {
            string str = txtPrice.Text;

            double min = 0.0;
            const double max = 3500.00; // delcaring a constant for max value

            bool isValid = InputUtility.GetDouble( str, out price, min, max);
            if (isValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input in price field!", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPrice.Focus(); // set focus to price textbox
                txtPrice.SelectAll(); // to select all text
                return false;

            }

        }
    }
}
