// File Name: MainForm.cs
// Created By: Padma Priya Duvvuri
// Created On: 24-Dec-2011

using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

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
        public MainForm()
        {
            InitializeComponent();
            customerMngr = new CustomerManager();
            transportMngr = new TransportationManager();
            reservationSaved = false;
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
                MessageBox.Show ("Exception: " + e.Message);
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
            Transportation frmTrain = new Transportation("Add New Train Info");
            if (frmTrain.ShowDialog() == DialogResult.OK)
            {
                //Add the details and call the UpdateTrain List() method to write the values in File
                transportMngr.AddTrain(frmTrain.TransportData);
                UpdateTrainList();
            }
            
        }

        private void bussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation frmBus = new Transportation("Add New Bus Info");
          
            if (frmBus.ShowDialog() == DialogResult.OK)
            {
                transportMngr.AddBus(frmBus.TransportData);
                UpdateBusList ();
            }
        }

        private void UpdateBusList()
            {
            StreamWriter twBus = null;

            FileStream fsBus = new FileStream("BusDetails.txt", FileMode.Append);

            try
            {

                twBus  = new StreamWriter(fsBus );
                int index1 = 0;
                index1 = (transportMngr.CountBusses  - 1);
                twBus.WriteLine(transportMngr.GetBus(index1).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twBus.Close();
            }
            }
            private void UpdateFlightList()
                {
            StreamWriter twFlight = null;

            FileStream fsFlight = new FileStream("FlightDetails.txt", FileMode.Append);

            try
            {

                twFlight  = new StreamWriter(fsFlight );
                int index3 = 0;
                index3 = (transportMngr.CountFlights  - 1);
                twFlight.WriteLine(transportMngr.GetFlight(index3).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twFlight.Close();
            }
                }


        private void UpdateTrainList()
        {
            StreamWriter twTrain = null;

            FileStream fsTrain = new FileStream("TrainDetails.txt", FileMode.Append);

            try
            {

                twTrain  = new StreamWriter(fsTrain );
                int index2 = 0;
                index2 = (transportMngr.CountTrains  - 1);
                twTrain.WriteLine(transportMngr.GetTrain(index2).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twTrain.Close();
            }
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation frmFlight = new Transportation("Add New Flight Info");
            

            if (frmFlight.ShowDialog() == DialogResult.OK)
            {
                transportMngr.AddFlight(frmFlight.TransportData);
                UpdateFlightList ();
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm  frmCustomer = new CustomerForm ("Add New Customer Info");
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmCustomer.CustomerData);
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

            ReadFiles();
        }

        private void ChangedCustomerList()
        {
            StreamWriter twCustomer = null;
            StreamWriter twCustomerNames = null;

            FileStream fsCustomer = new FileStream("CustomerDetails.txt", FileMode.Create);
            FileStream fsNames = new FileStream("CustomerNames.txt", FileMode.Create);

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

            ReadFiles();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (lstCustomers.Items.Count != 0)
                {
                    
                   // ReadFiles();
                    int index = lstCustomers.SelectedIndex;
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

        private void ShowError()
        {
            MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidInput())
            {
            SelectTime frmSelectTime = new SelectTime(cmbTranportation.SelectedIndex + 1, SelectTitle(), cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString());

            if (frmSelectTime.ListBoxDetails.Count == 0)
                {
                MessageBox.Show("No transport available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSelectTime.Close();
                }
            else
                {
                if(frmSelectTime.ShowDialog() == DialogResult.OK)
                    {
                    lblCustomerName.Text = cmbCustomer.SelectedItem.ToString();
                    string[] str = InputUtility.GetWords(lstCustomers.Items[cmbCustomer.SelectedIndex].ToString());
                    lblCustomerPhone.Text = str[2];
                    lblReservationUpto.Text = frmSelectTime.Detail;
                    string[] str1 = InputUtility.GetWords(frmSelectTime.Detail);
                    string price = str1[4];
                
                    lblPrice.Text = GetPrice(price).ToString("#.##");

                    AddReservations(lblCustomerName.Text, lblCustomerPhone.Text, lblReservationUpto.Text, lblPrice.Text);
                    }
                }

            InitializeGUI();
            }

        }

        private void AddReservations(string name, string phone, string fromto, string price)
        {
            reservation = string.Format("{0}- Phone:{1,10}- Transport Details:{2}- Total Price: {3} SEK", name, phone,fromto, price);
            lstReservations.Items.Add(reservation);
            
        }

        private void UpdateReservations()
        {
            StreamWriter twReservation = null;

            FileStream fsReservation = new FileStream("Reservations.txt", FileMode.Append);

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

        private decimal  GetPrice(string priceValue)
        {
            decimal adultPrice = decimal.Parse(priceValue);
            decimal childPrice = adultPrice/2;
            if (checkBoxLessThan2.Checked == true)
            {
                childPrice = childPrice * 0.15M;
            }
            decimal price;
            price = ((int)numericAdults.Value * adultPrice) + ((int)numericChildren.Value * childPrice);
            return price;
        }

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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                ChangedCustomerList();
            }
            else
            {
                //if listbox is empty show error
                ShowError();
                return;
            }
        }

        public bool ValidInput() 
        {
            if (cmbFrom.SelectedItem.ToString() == cmbTo.SelectedItem.ToString())
            {
                MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFrom.Text = "From*";
                lblTo.Text = "To*";
                return false;
            }
            if(cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblName.Text = "Customer Name*";
                return false;
            }

            if (numericAdults.Value == 0 && numericChildren.Value == 0)
            {
                MessageBox.Show("At least one passenger must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassengers.Text = "No.Of Passengers *";
                return false;
            }

            if(cmbTranportation.SelectedIndex == -1)
            {
                MessageBox.Show("Select Transportation Type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTransportType.Text = "Select the means of Transportaione*";
                return false;
            }
            return true;
        }


        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveResToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hover the mouse over the controls to see the help.", "Help", MessageBoxButtons.OK);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reservationSaved == false && lstReservations.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to Save reservations before closing the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //close the form only if the user clicks on Yes button of the messagebox.
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
                else
                {
                    this.Dispose();
                }

            }
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

       

       

      
    }
}
