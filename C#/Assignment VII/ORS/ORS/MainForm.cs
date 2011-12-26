// File Name: MainForm.cs
// Created By: Padma Priya Duvvuri
// Created On: 24-Dec-2011

using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;


namespace ORS
{ 
    /// <summary>
    /// This is the mainForm class where the actual process happens
    /// </summary>
    public partial class MainForm : Form
    {
        //Instance variables
        CustomerManager customerMngr; //To manage customer details
        TransportationManager transportMngr; // To manage Transportion details
        ArrayList storedCustomers; // to store already store customers of the last instance
        ArrayList storeNames; //to store already store names of customers of the last instance
        string reservation; // to store the value of reservations
        bool reservationSaved; // to check wheter the reservations details are stored
        bool confirmCurrentReservation; // to confirm current reservation

        //forms that will be shown
        SelectTimeForm frmSelectTime; // to show the select time form
        CustomerForm frmCustomer; // to show customer form
        TransportationForm frmTransport; // toshow transport form

        public MainForm()
        {
            InitializeComponent();
            customerMngr = new CustomerManager();
            transportMngr = new TransportationManager();
            reservationSaved = false;
            EmptyReservationLabels();
            //My initalization
            InitializeGUI();
        }

        /// <summary>
        /// Other inializations that set default values for fields
        /// </summary>
        private void InitializeGUI()
        {
            dateOfJourney.MinDate = DateTime.Today;
            // clear and updated the cmbTransportaion with Trasportation type and select default value as Train.
            cmbTranportation.Items.Clear();
            cmbTranportation.Items.AddRange(Enum.GetNames(typeof(TransportationType)));
            cmbTranportation.SelectedIndex = (int)TransportationType.Train;

            // clear and updated the cmbFrom with Station and select default value Stockholm.
            cmbFrom.Items.Clear();
            cmbFrom.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbFrom.SelectedIndex = (int)Stations.Stockholm;

            // clear and updated the cmbTo with Station and select default value Copenhagen.
            cmbTo.Items.Clear();
            cmbTo.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbTo.SelectedIndex = (int)Stations.Copenhagen;

            numericAdults.Value = 0;
            numericChildren.Value = 0;
            checkBoxLessThan2.Checked = false;
            //read customer data from files
            ReadFiles();

        }

        /// <summary>
        /// Reads the customer data from the files if any customers are already added
        /// </summary>
        private void ReadFiles()
        {
            lstCustomers.Items.Clear();
            cmbCustomer.Items.Clear();
            
            string lineCustomer;
            string lineName;
            //StreamReader object to read the customer details
            StreamReader trCustomers = null;
            StreamReader trNames = null;
            try
            {
                //Read data from CustomerNames.txt
                trNames = new StreamReader("CustomerNames.txt");
                lineName = trNames.ReadLine();
                while (lineName != null)
                {
                    cmbCustomer.Items.Add(lineName);
                    lineName = trNames.ReadLine();
                }
                //store the customer names in combobox
                storeNames = new ArrayList(cmbCustomer.Items);

                //read data from CustomerDetails.txt
                trCustomers = new StreamReader("CustomerDetails.txt");
                lineCustomer = trCustomers.ReadLine();
                while (lineCustomer != null)
                {
                    lstCustomers.Items.Add(lineCustomer);
                    lineCustomer = trCustomers.ReadLine();
                }
                //store teh customer details in lstCustomers
                storedCustomers = new ArrayList(lstCustomers.Items);
                trCustomers.Close();
                trNames.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show ("Exception: " + e.Message);
                return;
            }
            
        }

        /// <summary>
        /// Event-handler for SelectedIndexChanged event of cmbTranportation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTranportation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change image in the image control according to the selection
            pictureBox.Image = this.imgList.Images[cmbTranportation.SelectedIndex];
        }

        /// <summary>
        /// Event-hanler for click event of about menu item in help menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the About form
            AboutBox about = new AboutBox();
            about.Show();
        }

        /// <summary>
        /// Event-hanler for click event of train menu item in Transport Menu.
        /// This is used to add new train info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show teh Transportation form
            frmTransport = new TransportationForm("Add New Train Info");
            if (frmTransport.ShowDialog() == DialogResult.OK)
            {
                //Add the details and call the UpdateTrain List() method to write the values in File
                transportMngr.AddTransport(frmTransport.TransportData);
                UpdateTransportList("TrainDetails.txt");
            }
            
        }

        /// <summary>
        /// Event-hanler for click event of train menu item in Transport Menu.
        /// This is used to add new train info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show the Transportation form
            frmTransport = new TransportationForm("Add New Bus Info");
          
            if (frmTransport.ShowDialog() == DialogResult.OK)
            {
                //Add the details and call the UpdateTrain List() method to write the values in File
                transportMngr.AddTransport(frmTransport.TransportData);
                UpdateTransportList("BusDetails.txt");
            }
        }

        /// <summary>
        /// Event-hanler for click event of train menu item in Transport Menu.
        /// This is used to add new train info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show teh Transportation form
            frmTransport = new TransportationForm("Add New Flight Info");

            if (frmTransport.ShowDialog() == DialogResult.OK)
            {
                //Add the details and call the UpdateTrain List() method to write the values in File
                transportMngr.AddTransport(frmTransport.TransportData);
                UpdateTransportList("FlightDetails.txt");
            }
        }
        

        /// <summary>
        /// Writes theTransportDetails to chosen file name (eg. bussdetails.txt for bus, train
        /// details for trains etc), if file already exits it will 
        /// append to it, otherwise creates new.
        /// </summary>
        private void UpdateTransportList(string fileName)
        {
            StreamWriter twTransport = null;
            FileStream fsTransport = new FileStream(fileName, FileMode.Append);
            //write data from transportMngr object to file
            try
            {

                twTransport = new StreamWriter(fsTransport);
                int index = 0;
                index = (transportMngr.CountTransport - 1);
                twTransport.WriteLine(transportMngr.GetTransport(index).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                twTransport.Close();
            }
        }




        /// <summary>
        /// event-hanlre for the add customer menu item of customer Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show customerform to enter the values
            frmCustomer = new CustomerForm ("Add New Customer Info");
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                //add new customer with help of customerMngr object
                customerMngr.AddCustomer(frmCustomer.CustomerData);
                //Update the customer list and updates the files
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// clears the listbox and updates it with the customer values of the 
        /// customerMngr arraylist
        /// </summary>
        private void UpdateCustomerList()
        {
            StreamWriter twCustomer = null;
            StreamWriter twCustomerNames = null;

            FileStream fsCustomer = new FileStream("CustomerDetails.txt", FileMode.Append);
            FileStream fsNames = new FileStream("CustomerNames.txt", FileMode.Append);
            //loop through and write the values to the files
            try
            {
                twCustomer = new StreamWriter(fsCustomer);
                twCustomerNames = new StreamWriter(fsNames);
                int index1 = 0;
                index1 = (customerMngr.CountCustomers - 1);
                twCustomer.WriteLine(customerMngr.GetCustomer(index1).ToString());
                twCustomerNames.WriteLine(customerMngr.GetName(index1).ToString());
            }
            catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
            finally {
                twCustomer.Close();
                twCustomerNames.Close();
            }
            //Read the files to get the updated list of customer and names
            ReadFiles();
        }

        /// <summary>
        /// Update the customer list if any value of customer is updated by clicking 
        /// update menu item of customer menu.
        /// </summary>
        private void ChangedCustomerList()
        {
            StreamWriter twCustomer = null;
            StreamWriter twCustomerNames = null;

            FileStream fsCustomer = new FileStream("CustomerDetails.txt", FileMode.Create);
            FileStream fsNames = new FileStream("CustomerNames.txt", FileMode.Create);
            //update the values and write them to files
            try
            {
                twCustomer = new StreamWriter(fsCustomer);
                twCustomerNames = new StreamWriter(fsNames);
                for (int i = 0; i < storedCustomers.Count; i++)
                    twCustomer.WriteLine(storedCustomers[i]);
                for (int i = 0; i < storeNames.Count; i++)
                   twCustomerNames.WriteLine(storeNames[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                twCustomer.Close();
                twCustomerNames.Close();
            }
            //Read files again to get the updates values
            ReadFiles();
        }

        /// <summary>
        /// Event-hanler for click event of update menu item of customer menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Perform updation only when some customers already present.
            if (lstCustomers.Items.Count != 0)
                {
                    int index = lstCustomers.SelectedIndex;
                    //if no index is selected show error
                    if (index == -1)
                    {
                        MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string str = lstCustomers.SelectedItem.ToString();
                    CustomerForm frmCustomer = new CustomerForm("Update Customer Info", InputUtility.GetWords(str));
                    customerMngr.Customers = storedCustomers;
                    customerMngr.Names = storeNames;
                    //if the customer clicks on OK button of the customer form then continue with the updation
                    if (frmCustomer.ShowDialog() == DialogResult.OK)
                    {
                        customerMngr.ChangeCustomer(frmCustomer.CustomerData, lstCustomers.SelectedIndex);
                        storedCustomers = customerMngr.Customers;
                        storeNames = customerMngr.Names;
                        //update the customer list
                        ChangedCustomerList();
                    }
                }
            else
                {
                        //if listbox is empty show error
                        ShowError();
                        return;
                }
        }

        /// <summary>
        /// Show error if the no customers are present to update or delete
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Event-handler for click event of submittt button. Here every calculation is performed and
        /// the result for one reservations will be showed in the labels and the all the reservations are stored
        /// in the Reservations tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if no customers are present prompt to add one
            if(cmbCustomer.Items.Count == 0)
            {
                MessageBox.Show("No Customers are registerd, add customers first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //to check whether the user has provided all the input or not, if provided continue
            if(ValidInput())
            {
            //Show the Select time form by passing the type of form selected by the user, title and from and to stations
            frmSelectTime = new SelectTimeForm(cmbTranportation.SelectedIndex + 1, SelectTitle(), cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString());
            //if no matching transport between selected locations are found show the message
            if (frmSelectTime.ListBoxDetails.Count == 0)
                {
                MessageBox.Show("No transport available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSelectTime.Close(); //do not show the selectTime form
                }
            else
                {
                //if some transports are available then continue
                if(frmSelectTime.ShowDialog() == DialogResult.OK)
                    {
                        //store the values of reservations in the labels
                        lblCustomerName.Text = cmbCustomer.SelectedItem.ToString();
                        string[] str = InputUtility.GetWords(lstCustomers.Items[cmbCustomer.SelectedIndex].ToString());
                        lblCustomerPhone.Text = str[2];
                        lblReservationUpto.Text = frmSelectTime.Detail;
                        string[] str1 = InputUtility.GetWords(frmSelectTime.Detail);
                        string price = str1[4];
                        //calculate the total Price
                        lblPrice.Text = GetPrice(price).ToString("#.##");
                        lblTotalTickets.Text = (numericInfants.Value + numericChildren.Value + numericAdults.Value).ToString();
                        //shwo the controls to confrim or cancel the reservations
                        btnSubmit.Enabled = false;
                        btnConfirm.Enabled = true;
                        btnCancel.Enabled = true;
                    }
                else
                    {
                        //to empty labels which save the reservation details
                        EmptyReservationLabels();
                    }
                }
            //re-initialize all fields
            InitializeGUI();
            }

        }

        private void EmptyReservationLabels()
        {
            lblCustomerName.Text = "No Reservations are made";
            lblCustomerPhone.Text = string.Empty;
            lblReservationUpto.Text = string.Empty;
            lblPrice.Text = string.Empty;
            lblTotalTickets.Text = string.Empty;
        }

        /// <summary>
        /// Add the reservation details in the listbox
        /// </summary>
        /// <param name="name">Customer Name parameter</param>
        /// <param name="phone">Customer phone number</param>
        /// <param name="fromto">transport details</param>
        /// <param name="price">Total price</param>
        private void AddReservations(string name, string phone, string fromto, string price,string tickets)
        {
            reservation = string.Format("{0}- Phone:{1}- Details:{2}- Price: {3} SEK- Tickets: {4}", name, phone, fromto, price,tickets);
            lstReservations.Items.Add(reservation); // add the reservations to the lstReservations
        }

        /// <summary>
        /// To save the reservations in the file ReservationDetails.txt, if file exits then append the
        /// values or create a new file
        /// </summary>
        private void UpdateReservations()
        {
            StreamWriter twReservation = null;
            FileStream fsReservation = new FileStream("Reservations.txt", FileMode.Append);
            //loop through the lstReservations and add the details to File
            try
            {
                twReservation = new StreamWriter(fsReservation);
                for (int i= 0; i <= lstReservations.Items.Count -1; i++)
                {
                twReservation.WriteLine(lstReservations.Items[i].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                twReservation.Close();
            }
        }

        /// <summary>
        /// Calcuate the total price to be paid by the customer
        /// </summary>
        /// <param name="priceValue">price per adult</param>
        /// <returns>Total price to be paid by customer</returns>
        private decimal  GetPrice(string priceValue)
        {
            decimal adultPrice = decimal.Parse(priceValue); //ticket price per adult
            decimal childPrice = adultPrice/2;
            decimal totalPrice;
            if (numericInfants.Value != 0)
            {
                numericChildren.Value = numericChildren.Value - numericInfants.Value;
            }
            totalPrice = ((int)numericAdults.Value * adultPrice) + ((int)numericChildren.Value * childPrice);
            return totalPrice;
        }

        /// <summary>
        /// Depending on the user chosen mode of transportion pass the title of the 
        /// SelectTime Form
        /// </summary>
        /// <returns>A string containing the title</returns>
        private string SelectTitle()
        {
            string str = string.Empty;
            if (cmbTranportation.SelectedIndex == 0)
                str = "Select Bus";
            else if(cmbTranportation.SelectedIndex == 1)
                str = "Select Train";
            else
             str = "Select Flight";

            return str;
        }

        /// <summary>
        /// Event hanlder for the click event of delete menu item of customer menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if no customer are present show error otherwise continue
            if (lstCustomers.Items.Count != 0)
            {
                int index = lstCustomers.SelectedIndex;
                customerMngr.Customers = storedCustomers;
                customerMngr.Names = storeNames;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (index == -1)
                {
                    MessageBox.Show("Please select an index from Customer list", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customerMngr.RemoveCustomer(index);
                storedCustomers = customerMngr.Customers;
                storeNames = customerMngr.Names;
                //update the customerlist
                ChangedCustomerList();
            }
            else
            {
                //if listbox is empty show error
                ShowError();
                return;
            }
        }

        /// <summary>
        /// To validate the user input in the main Form.
        /// </summary>
        /// <returns>true if all fields are entered otherwise false</returns>
        public bool ValidInput() 
        {
            //if from staiton and to station are same show error
            if (cmbFrom.SelectedItem.ToString() == cmbTo.SelectedItem.ToString())
            {
                MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFrom.Text = "From*";
                lblTo.Text = "To*";
                return false;
            }
            //if no customer is selected show error
            if(cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblName.Text = "Customer Name*";
                return false;
            }
            //If none of the passangers are selected then show error
            if (numericAdults.Value == 0 && numericChildren.Value == 0)
            {
                MessageBox.Show("At least one passenger must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassengers.Text = "No.Of Passengers *";
                return false;
            }
            //If none of transport mode are selected then show error
            if(cmbTranportation.SelectedIndex == -1)
            {
                MessageBox.Show("Select Transportation Type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTransportType.Text = "Select the means of Transportaione*";
                return false;
            }
            return true;
        }

        
        /// <summary>
        /// //show infant controls
        /// </summary>
        private void ShowInfantControls()
        {
            if (checkBoxLessThan2.Checked == true)
            {
                if (numericChildren.Value > 1)
                     {
                        //if the children are less than 2 years of age show the infant controls
                         lblInfants.Visible = true;
                         numericInfants.Visible = true;
                         numericInfants.Maximum = numericChildren.Value;
                         //if number of infants is selected are not 0 perform calulations 
                         if (numericInfants.Value == 0)
                            {
                             MessageBox.Show("Please select the no. of infants, otherwise uncheck the checkbox", "Info!", MessageBoxButtons.OK);
                            }
                    }
                else
                    numericInfants.Value = 1;
            }
            else
            {
                //if the children are less than 2 years of age show the infant controls
                lblInfants.Visible = false;
                numericInfants.Visible = false;
             }
        }

        /// <summary>
        /// Event-hanler for the click event of close menu item of File menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event-handler for the click event of Save Reservations menu item of File menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveResToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if the reservations are not saved before and list has some reservations then update the reservations
            //otherwise show the message
            if (reservationSaved == false && lstReservations.Items.Count != 0)
            {
                UpdateReservations();
                reservationSaved = true;
                MessageBox.Show("Reservations are saved","Info",MessageBoxButtons.OK);
            }
            else
            {
                reservationSaved = false;
                 MessageBox.Show("No reservations are made!","Info",MessageBoxButtons.OK);
            }
        }

        
        /// <summary>
        /// Event-handler for the click event of View help menu item of Help Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hover the mouse over the controls to see the help.", "Help", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Event handler for the formclosing event of Mainform. It checks with the user whether he wants to close the application
        /// or not. If he wants to close then asks them wheter to save the reservations or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the reservations are not saved and some reservations are present then show message
            if (reservationSaved == false && lstReservations.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to Save reservations before closing the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //If user wants to save info show message and close the form
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    UpdateReservations();
                    DialogResult showMessage = MessageBox.Show("Reservations are saved", "Info", MessageBoxButtons.OK);
                    if (showMessage == DialogResult.OK)
                    {
                        reservationSaved = true;
                       // e.Cancel = true;
                        this.Dispose();
                    }
               }
                    //if user don't want to save reservations then close the form
                else
                {
                    this.Dispose();
                }
            }
            //if there are no reservations are there to save then ask the user whether he wants to close the application or not
            else
            {
                DialogResult result = MessageBox.Show("Do you want to close the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        /// <summary>
        /// Event-handler for value changed event of number of children control(numericChildren)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericChildren_ValueChanged(object sender, EventArgs e)
        {
            checkBoxLessThan2.Checked = false;
            //if number of children are not 0 then show the controls 
            if (numericChildren.Value != 0)
            {
                checkBoxLessThan2.Visible = true;
            }
            else
            {
                checkBoxLessThan2.Visible = false;
            }
        }

        /// <summary>
        /// Event-handler for CheckedChaged event of checkbox to show teh controls are not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxLessThan2_CheckedChanged(object sender, EventArgs e)
        {
            ShowInfantControls();
        }

        /// <summary>
        /// Event-handlre for click event of Save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //save the current reservation
            //to save the reservations to reservations listbox
            AddReservations(lblCustomerName.Text, lblCustomerPhone.Text, lblReservationUpto.Text, lblPrice.Text, lblTotalTickets.Text);
            UpdateReservations();
            confirmCurrentReservation = true;
            DialogResult result= MessageBox.Show("Do you want to save the current reservation to a file?", "Info!", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SaveResult();
            }
            else
            {
                EmptyReservationLabels();
            }
            btnSubmit.Enabled = true;
            btnCancel.Enabled = false;
            btnConfirm.Enabled = false;
        }

       

        /// <summary>
        /// To save current reservation details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(confirmCurrentReservation == true)
            {
                SaveResult();
            }
            else
            {
                MessageBox.Show("Please confirm the reservation before saving","Info!",MessageBoxButtons.OK);
                return;
            }

        }

        /// <summary>
        /// To save the current reservation details in the a file
        /// provided by the user at user specified location
        /// </summary>
        private void SaveResult()
        { 
            //saveFileDialog1.ShowDialog();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                WriteToFile(name);
            }
        }


        /// <summary>
        /// Write current reservation details to specic file provided by the user
        /// </summary>
        private void WriteToFile(string name)
        {
            //Create a file stream using the file name
            name = name + ".txt";
            FileStream fs = new FileStream(name, FileMode.Create);

            //Create a writer that will write to the stream
            StreamWriter writer = new StreamWriter(fs);
            String[] str = new string[5];
            str[0] = "Name of Customer: " +lblCustomerName.Text;
            str[1] = "Phone Number: "+lblCustomerPhone.Text;
            str[2] = "Reservation details: "+lblReservationUpto.Text;
            str[3] = "Total Price: " + lblPrice.Text;
            str[4] = "Total no.of Tickets: "+lblTotalTickets.Text;
                
            foreach(string detail in str)
                {
                    writer.WriteLine(detail);
                }
            writer.Close();
        }

        /// <summary>
        /// Event-handler for MouseHover event of Submit button, this will show help for
        /// the button control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnSubmit, "To get available options and to continue with reservation. Press Confirm the button to save the reservation");
        }

        /// <summary>
        /// Event-handler for MouseHover event of Confirm button, this will show help for
        /// the button control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnConfirm, "Press this button to save the current reservation, otherwise the reservation won't be saved!");
        }

        /// <summary>
        /// Event-handler for Click event of Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Reinitialize form controls so no reservation is saved.
            InitializeGUI();
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;
            btnSubmit.Enabled = true;
            EmptyReservationLabels();
            reservationSaved = true;
        }

        /// <summary>
        /// Event-handler for MouseHover event of Confirm button, this will show help for
        /// the button control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnCancel, "Press this button to cancel the current reservation.");
        }

        
    }
}
