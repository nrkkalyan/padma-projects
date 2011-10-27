// MainForm.cs
// Created By: Padma Priya Duvvuri
// Created On: 21-Oct-2011

using System;
using System.Windows.Forms;

namespace Assignment4CBS
{
    public partial class MainForm2b : Form
    {
        //Test variables - to test the application
        // Declare a constant for max number of rows and colums of seats in the cinema
        private const int m_numOfRows = 7;
        private const int m_numOfCols = 7;

        // declare a reference variable fo the SeatManager type
        private SeatManager m_seatMngr;


        //Consturctor is a special method that is automatically called
        // when an instance of the class is created by using the keyword new.
        //It is a good place for initializations and creation of
        // the objects that are used as fields, e.g m_seatMngr

        public MainForm2b()
        {
            //visual studio generated method
            InitializeComponent();

            //my initialization method
            m_seatMngr = new SeatManager(m_numOfRows,m_numOfCols);
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
           
            lstReservations.Items.Clear();
            txtName.Text = string.Empty;

            lblNumOfReserved.Text = string.Empty;
            lblNumOfSeats.Text = m_seatMngr.TotNumOfSeats().ToString();
            lblNumOfVacant.Text = string.Empty;

            cmboxChoice.Items.AddRange(Enum.GetNames(typeof(SeatManager.DisplayOptions)));
            cmboxChoice.SelectedIndex = (int)SeatManager.DisplayOptions.AllSeats;
            
            UpdateGUI();
        }


        /// <summary>
        /// Clear output controls if needed.
        /// Fill the listbox with info of each seat. Each row in the list box represents a seat.
        /// </summary>
        private void UpdateGUI()
        {

            lstReservations.Items.Clear(); // empty the list box;

            string[] strSeatInfoStrings = null;

            SeatManager.DisplayOptions  selected = (SeatManager.DisplayOptions)Enum.Parse(typeof(SeatManager.DisplayOptions), (string)this.cmboxChoice.SelectedItem);

            m_seatMngr.GetSeatInfoStrings(selected , out strSeatInfoStrings);

            foreach (String str in strSeatInfoStrings)
            {
                if (str != null)
                {
                    lstReservations.Items.Add(str);
                }
            }

            UpdateLabels(); // to update the labels


        }

        /// <summary>
        /// The user must highlight an item in the LisbBox before a reservation or
        /// cancellation can be performed. If an item in the listbox is not
        /// highlighted, give an error message to the user.
        /// </summary>
        /// <returns>true if user selects one row otherwise false</returns>
        private bool CheckSelectedIndex()
        {
            if (lstReservations.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a seat first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Parse the user input, validate and save the data for later use.
        /// This method calls other method to read and validate name
        /// </summary>
        /// <param name="customerName">The name of the customer</param>
        /// <returns>True if input is valid, False otherwise</returns>
        private bool ReadAndValidateInput(out string name)
        {
            bool nameValid = ReadAndValidateName(out name);

            if (nameValid)
            {
                return true;
            }
            else
            {
                if (!nameValid)
                {
                    MessageBox.Show("Invalid input in name field! Name cannot be empty, and must have atleast one character(not a blank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus(); // set focus to name textbox
                    txtName.SelectAll(); // to select all the text present
                }

                return false;
            }
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
            bool isInValid = InputUtility.CheckString(name);
            if (!isInValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Event-handler method for the Click-event of the button. When the user clicks the
        /// button, this method will be executed automatically.
        /// If teh Cancel Radiobutton is checked, no need to read customer name
        /// or seatPrice.
        /// Call the method ReserverOrCancelSeat to process the reservation/ cancellation
        /// of a seat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedIndex())
            {
                return;
            }
            ReserveOrCancelSeat();
        }

        
        /// <summary>
        /// 
        /// Reserve or cancel a seat
        /// 
        /// If reserve radiobutton is selected then
        ///      1. If seat is reserved check with user to update or not that seat
        ///      2. If seat is empty validate  name
        ///      3. Call the reserve method of m_seatManager to reserve or update
        ///      
        /// If cancel radiobutton is selected then
        ///      Call the cancel method of m_seatManager to canel 
        ///      
        /// call UpdateGUI
        /// </summary>
        private void ReserveOrCancelSeat()
        {
           string customerName = string.Empty;
             // if reserve radiobutton is checked perform reservation of update of the seat
                if (rbtnReserved.Checked)
                {
                    if (!ReadAndValidateInput(out customerName)) 
                    {
                        return;
                    }
                    if (m_seatMngr.GetSeatInfoAt(lstReservations.SelectedIndex) == "Vacant  ")
                            m_seatMngr.ReserveSeat(customerName, lstReservations.SelectedIndex);
                }
                else
                {
                    DialogResult result = MessageBox.Show("This seat is reserved, do you want to update it?", "Info!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        m_seatMngr.ReserveSeat(customerName,lstReservations.SelectedIndex);
                    }
                }
            // if cancel radio button is checked perform cancellation of reservation.
                if (rbtnCancel.Checked)
                {
                   m_seatMngr.CancelSeat(lstReservations.SelectedIndex);
                }
                UpdateGUI();
      }



        /// <summary>
        /// This method updates the labels of the output group with the values 
        /// after the button is clicked
        /// </summary>
        private void UpdateLabels()
        {

            lblNumOfSeats.Text = Convert.ToString(m_seatMngr.TotNumOfSeats()) ;
            lblNumOfReserved.Text = Convert.ToString(m_seatMngr.GetNumReserved());
            lblNumOfVacant.Text = Convert.ToString(m_seatMngr.GetNumVacant());
            if (rbtnReserved.Checked)
            {
                btnOK.Text = "Reseve";
            }
        }


        /// <summary>
        /// Event-handler method for the SelectedIndexChanged event of the Combobox.
        /// The method is automatically called when the user select an entry in the combobox.
        /// The user will be able to update or reserve the seat only when the allseats of the 
        /// combox is selected.
        /// </summary>
        /// <param name="sender">The object that fired the event (combobox)</param>
        /// <param name="e">An object containing useful information about the event.</param>
        private void cmboxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableOrDisable = true;
            SeatManager.DisplayOptions selected = (SeatManager.DisplayOptions)Enum.Parse(typeof(SeatManager.DisplayOptions), (string)this.cmboxChoice.SelectedItem);
            if (selected != SeatManager.DisplayOptions.AllSeats)
            {
                enableOrDisable = false;
            }
            txtName.Enabled = enableOrDisable;
            btnOK.Enabled = enableOrDisable;
   
            UpdateGUI(); // update teh listbox depending on the choice of combo box
        }

        /// <summary>
        /// Event-handler method for the CheckedChanged event of the Cancel radiobutton.
        /// </summary>
        /// <param name="sender">The object that fired the event (cancel radiobutton)</param>
        /// <param name="e"></param>
        private void rbtnCancel_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            btnOK.Text = "Cancel Reservation";
        }

        /// <summary>
        /// Event-handler method for the checkedchanged event of the Reserve radiobutton.
        /// </summary>
        /// <param name="sender">The object that fired the event (reserv radiobutton) </param>
        /// <param name="e"></param>
        private void rbtnReserved_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnCancel.Checked)
            {
                txtName.Enabled = false;
            }
            else {
                txtName.Enabled = true;
            }
            if (lstReservations.SelectedIndex >= 0)
            {
                btnOK.Text = "Update";
            }
            else
            {
                btnOK.Text = "Reserve";
            }
        }

        

        /// <summary>
        /// Event-handler method for the selectedIndexChanged event of the Listbox.
        /// </summary>
        /// <param name="sender">The object that fired the event(listbox)</param>
        /// <param name="e"></param>
        private void lstReservations_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rbtnReserved.Checked)
            {
                if (m_seatMngr.GetSeatInfoAt(lstReservations.SelectedIndex) == "Vacant  ")
                {
                    btnOK.Text = "Reserve";
                }
                else if (m_seatMngr.GetSeatInfoAt(lstReservations.SelectedIndex) == "Reserved")
                {
                    btnOK.Text = "Update";
                }
            }
            else
            {
                btnOK.Text = "Cancel Reservation";
            }
        }

         

        


    }
        

        
}
